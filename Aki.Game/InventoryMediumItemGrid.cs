using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200149D RID: 5277
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InventoryMediumItemGrid : LoopScrollMediumItemGrid<global::ItemViewData>
{
	// Token: 0x0600D2FF RID: 54015 RVA: 0x003E98A5 File Offset: 0x003E7AA5
	public override void CreateThenShowByActor(AActor actor)
	{
	}

	// Token: 0x0600D300 RID: 54016 RVA: 0x003E98A8 File Offset: 0x003E7AA8
	public override UniTask CreateThenShowByActorAsync(AActor actor)
	{
		InventoryMediumItemGrid.<CreateThenShowByActorAsync>d__1 <CreateThenShowByActorAsync>d__;
		<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateThenShowByActorAsync>d__.<>1__state = -1;
		<CreateThenShowByActorAsync>d__.<>t__builder.Start<InventoryMediumItemGrid.<CreateThenShowByActorAsync>d__1>(ref <CreateThenShowByActorAsync>d__);
		return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D301 RID: 54017 RVA: 0x003E98E4 File Offset: 0x003E7AE4
	public override UniTask CreateByActorAsync(AActor actor)
	{
		InventoryMediumItemGrid.<CreateByActorAsync>d__2 <CreateByActorAsync>d__;
		<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByActorAsync>d__.<>1__state = -1;
		<CreateByActorAsync>d__.<>t__builder.Start<InventoryMediumItemGrid.<CreateByActorAsync>d__2>(ref <CreateByActorAsync>d__);
		return <CreateByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D302 RID: 54018 RVA: 0x003E991F File Offset: 0x003E7B1F
	protected override void OnStart()
	{
		base.SetUseFixedAsync(true);
	}

	// Token: 0x0600D303 RID: 54019 RVA: 0x003E9928 File Offset: 0x003E7B28
	protected override void OnRefresh(global::ItemViewData data, bool isSelected, int gridIndex)
	{
		this.ItemViewData = data;
		InventoryDefine.IItemViewDataInfo itemViewInfo = data.GetItemViewInfo();
		InventoryDefine.EItemDataType itemDataType = itemViewInfo.ItemDataType;
		int qualityId = itemViewInfo.QualityId;
		bool flag = data.GetItemOperationType() == ItemViewDefine.EItemOperationMode.Destruction;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetConfigId()),
			StarLevel = new int?(qualityId),
			IsNewVisible = new bool?(itemViewInfo.IsNewItem),
			IsLockVisible = new bool?(itemViewInfo.IsLock),
			IsDeprecate = new bool?(itemViewInfo.IsDeprecate),
			CoolDown = new float?(this.GetRemainingCoolDownTime()),
			TotalCoolDown = new float?(this.GetTotalCoolDownTime()),
			IsRedDotVisible = new bool?(itemViewInfo.HasRedDot),
			IsDisable = new bool?(flag && !data.IsItemCanDestroy()),
			IsCheckTick = new bool?(itemViewInfo.IsSelectOn)
		};
		switch (itemDataType)
		{
		case InventoryDefine.EItemDataType.CommonItem:
			this.ApplyCommonItemView(propMediumItemGrid, data, itemViewInfo);
			goto IL_131;
		case InventoryDefine.EItemDataType.WeaponItem:
			this.ApplyWeaponItemView(propMediumItemGrid);
			goto IL_131;
		case InventoryDefine.EItemDataType.PhantomItem:
			this.ApplyPhantomItemView(propMediumItemGrid, qualityId);
			goto IL_131;
		}
		propMediumItemGrid.BottomText = data.GetCount().ToString();
		IL_131:
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
		base.SetCheckTickPerformance(new bool?(itemViewInfo.IsSelectOn), "bf5c5c", new float?(0.9f), "663738");
		this.SetSelected(isSelected, false);
	}

	// Token: 0x0600D304 RID: 54020 RVA: 0x003E9A9C File Offset: 0x003E7C9C
	private void ApplyCommonItemView(PropMediumItemGrid propMediumItemGrid, global::ItemViewData data, InventoryDefine.IItemViewDataInfo itemViewInfo)
	{
		CommonItemData commonItemData = (CommonItemData)this.ItemViewData.GetItemDataBase();
		if (itemViewInfo.SelectOnNum != 0)
		{
			string bottomText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ItemRecycleChosen_text", null), new string[]
			{
				itemViewInfo.SelectOnNum.ToString(),
				data.GetCount().ToString()
			});
			propMediumItemGrid.BottomText = bottomText;
		}
		else
		{
			propMediumItemGrid.BottomText = data.GetCount().ToString();
		}
		propMediumItemGrid.IsTimeFlagVisible = new bool?(commonItemData.IsLimitTimeItem());
		propMediumItemGrid.BuffIconType = new EMediumItemGridBuffType?((EMediumItemGridBuffType)commonItemData.GetConfig().As<ItemInfo>().Value.ItemBuffType);
		propMediumItemGrid.IsOmitBottomText = new bool?(false);
		RoleDevelopModel instance = RoleDevelopModel.Instance;
		if (instance.DevTargetRoleId == 0)
		{
			return;
		}
		int configId = data.GetConfigId();
		InventoryModel instance2 = InventoryModel.Instance;
		bool flag = instance2.GetCurrentMainTypeId().GetValueOrDefault() == InventoryDefine.EItemMainTypeId.Weapon && commonItemData.GetShowTypeList().Contains(12);
		if ((!instance2.IsResourceOrMaterialTab() && !flag) || !instance.IsDevelopRoleNeedItem(configId))
		{
			return;
		}
		int devTargetRoleId = instance.DevTargetRoleId;
		string roleIconPath = "";
		if (RoleDevelopUtil.IsAnyProspectRole(devTargetRoleId))
		{
			roleIconPath = instance.GetRoleDevelopData(devTargetRoleId).GetDevelopRoleData().GetRoleSmallIconPath();
		}
		else if (RoleModel.Instance.GetRoleDataById(devTargetRoleId, true) == null)
		{
			roleIconPath = RoleConfig.Instance.GetRoleHeadIcon(devTargetRoleId, false);
		}
		propMediumItemGrid.RoleHeadInfo = new RoleHeadInfo
		{
			RoleConfigId = new int?(devTargetRoleId),
			RoleIconPath = roleIconPath
		};
	}

	// Token: 0x0600D305 RID: 54021 RVA: 0x003E9C24 File Offset: 0x003E7E24
	private void ApplyWeaponItemView(PropMediumItemGrid propMediumItemGrid)
	{
		int uniqueId = (this.ItemViewData.GetItemDataBase() as WeaponItemData).GetUniqueId();
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(uniqueId);
		propMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
		propMediumItemGrid.BottomTextParameter = new object[]
		{
			weaponDataByIncId.GetLevel()
		};
		propMediumItemGrid.Level = new int?(weaponDataByIncId.GetResonanceLevel());
		propMediumItemGrid.RoleHeadInfo = new RoleHeadInfo
		{
			RoleConfigId = new int?(weaponDataByIncId.GetRoleId())
		};
	}

	// Token: 0x0600D306 RID: 54022 RVA: 0x003E9CA8 File Offset: 0x003E7EA8
	private void ApplyPhantomItemView(PropMediumItemGrid propMediumItemGrid, int qualityId)
	{
		PhantomItemData phantomItemData = this.ItemViewData.GetItemDataBase() as PhantomItemData;
		int uniqueId = phantomItemData.GetUniqueId();
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
		List<VisionSlotData> currentSlotData = phantomBattleData.GetCurrentSlotData();
		propMediumItemGrid.ItemConfigId = new int?(phantomBattleData.GetConfigId(true));
		propMediumItemGrid.QualityId = new int?(qualityId);
		propMediumItemGrid.Level = new int?(phantomBattleData.GetCost());
		propMediumItemGrid.IsLevelTextUseChangeColor = new bool?(true);
		propMediumItemGrid.BottomText = "+" + phantomBattleData.GetPhantomLevel().ToString();
		propMediumItemGrid.IsOmitBottomText = new bool?(true);
		int selectedCount = this.ItemViewData.GetSelectOn() ? this.ItemViewData.GetSelectNum() : 0;
		propMediumItemGrid.StackDisplayInfo = new PhantomStackDisplay
		{
			StackCount = phantomItemData.GetStackCount(),
			SelectedCount = selectedCount,
			CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData)
		};
		if (currentSlotData.Count > 0)
		{
			EVisionSlotState? evisionSlotState;
			if (currentSlotData.Count <= 0)
			{
				evisionSlotState = null;
			}
			else
			{
				VisionSlotData visionSlotData = currentSlotData[0];
				evisionSlotState = ((visionSlotData != null) ? new EVisionSlotState?(visionSlotData.SlotState) : null);
			}
			EVisionSlotState? evisionSlotState2 = evisionSlotState;
			EVisionSlotState? evisionSlotState3;
			if (currentSlotData.Count <= 1)
			{
				evisionSlotState3 = null;
			}
			else
			{
				VisionSlotData visionSlotData2 = currentSlotData[1];
				evisionSlotState3 = ((visionSlotData2 != null) ? new EVisionSlotState?(visionSlotData2.SlotState) : null);
			}
			EVisionSlotState? evisionSlotState4 = evisionSlotState3;
			EVisionSlotState? evisionSlotState5;
			if (currentSlotData.Count <= 2)
			{
				evisionSlotState5 = null;
			}
			else
			{
				VisionSlotData visionSlotData3 = currentSlotData[2];
				evisionSlotState5 = ((visionSlotData3 != null) ? new EVisionSlotState?(visionSlotData3.SlotState) : null);
			}
			EVisionSlotState? evisionSlotState6 = evisionSlotState5;
			EVisionSlotState valueOrDefault = evisionSlotState2.GetValueOrDefault();
			EVisionSlotState valueOrDefault2 = evisionSlotState4.GetValueOrDefault();
			EVisionSlotState valueOrDefault3 = evisionSlotState6.GetValueOrDefault();
			propMediumItemGrid.VisionSlotStateList = this.BuildVisionSlotStateList((InventoryDefine.EQuality)qualityId, valueOrDefault, valueOrDefault2, valueOrDefault3);
		}
		if (PhantomBattleController.Instance.CheckIsEquip(uniqueId))
		{
			int uniqueId2 = phantomBattleData.GetUniqueId();
			int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId2);
			bool value = PhantomBattleModel.Instance.CheckPhantomIsMain(uniqueId2);
			propMediumItemGrid.VisionRoleHeadInfo = new VisionRoleHeadInfo
			{
				RoleConfigId = equipRole,
				VisionUniqueId = new int?(uniqueId2)
			};
			propMediumItemGrid.IsMainVisionVisible = new bool?(value);
		}
		propMediumItemGrid.VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
	}

	// Token: 0x0600D307 RID: 54023 RVA: 0x003E9EE0 File Offset: 0x003E80E0
	[NullableContext(2)]
	private int[] BuildVisionSlotStateList(InventoryDefine.EQuality qualityId, EVisionSlotState visionSlotState1, EVisionSlotState visionSlotState2, EVisionSlotState visionSlotState3)
	{
		switch (qualityId)
		{
		case InventoryDefine.EQuality.Blue:
			return new int[]
			{
				(int)visionSlotState1
			};
		case InventoryDefine.EQuality.Purple:
			return new int[]
			{
				(int)visionSlotState1,
				(int)visionSlotState2
			};
		case InventoryDefine.EQuality.Orange:
			return new int[]
			{
				(int)visionSlotState1,
				(int)visionSlotState2,
				(int)visionSlotState3
			};
		default:
			return null;
		}
	}

	// Token: 0x0600D308 RID: 54024 RVA: 0x003E9F32 File Offset: 0x003E8132
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x0600D309 RID: 54025 RVA: 0x003E9F3C File Offset: 0x003E813C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0600D30A RID: 54026 RVA: 0x003E9F48 File Offset: 0x003E8148
	public float GetRemainingCoolDownTime()
	{
		int configId = this.ItemViewData.GetConfigId();
		return (float)BuffItemModel.Instance.GetBuffItemRemainCdTime(configId);
	}

	// Token: 0x0600D30B RID: 54027 RVA: 0x003E9F70 File Offset: 0x003E8170
	public float GetTotalCoolDownTime()
	{
		int configId = this.ItemViewData.GetConfigId();
		return (float)BuffItemModel.Instance.GetBuffItemTotalCdTime(configId);
	}

	// Token: 0x0600D30C RID: 54028 RVA: 0x003E9F98 File Offset: 0x003E8198
	public void RefreshCoolDown()
	{
		float remainingCoolDownTime = this.GetRemainingCoolDownTime();
		float totalCoolDownTime = this.GetTotalCoolDownTime();
		base.SetCoolDown(new float?(remainingCoolDownTime), new float?(totalCoolDownTime));
	}

	// Token: 0x0600D30D RID: 54029 RVA: 0x003E9FC5 File Offset: 0x003E81C5
	public void BindOnItemButtonClickedCallback(Action<global::ItemViewData> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x0600D30E RID: 54030 RVA: 0x003E9FCE File Offset: 0x003E81CE
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			this.OnItemButtonClickedCallback(this.ItemViewData);
		}
	}

	// Token: 0x040076B9 RID: 30393
	[Nullable(2)]
	private global::ItemViewData ItemViewData;

	// Token: 0x040076BA RID: 30394
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<global::ItemViewData> OnItemButtonClickedCallback;

	// Token: 0x040076BB RID: 30395
	private const string RED_TICK_HEX = "bf5c5c";

	// Token: 0x040076BC RID: 30396
	private const string TICK_COLOR_HEX = "663738";

	// Token: 0x040076BD RID: 30397
	private const float RED_TICK_ALPHA = 0.9f;
}
