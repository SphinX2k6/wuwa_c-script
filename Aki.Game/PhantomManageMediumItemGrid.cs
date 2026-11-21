using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014AF RID: 5295
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageMediumItemGrid : LoopScrollMediumItemGrid<PhantomItemData>, IStaticVariableResetter
{
	// Token: 0x0600D40C RID: 54284 RVA: 0x003F094C File Offset: 0x003EEB4C
	static PhantomManageMediumItemGrid()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageMediumItemGrid.CreateStaticDefaultValue), new Action(PhantomManageMediumItemGrid.ResetStaticDefaultValue));
	}

	// Token: 0x0600D40D RID: 54285 RVA: 0x003F096B File Offset: 0x003EEB6B
	public override void CreateThenShowByActor(AActor actor)
	{
	}

	// Token: 0x0600D40E RID: 54286 RVA: 0x003F0970 File Offset: 0x003EEB70
	public override UniTask CreateThenShowByActorAsync(AActor actor)
	{
		PhantomManageMediumItemGrid.<CreateThenShowByActorAsync>d__2 <CreateThenShowByActorAsync>d__;
		<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateThenShowByActorAsync>d__.<>1__state = -1;
		<CreateThenShowByActorAsync>d__.<>t__builder.Start<PhantomManageMediumItemGrid.<CreateThenShowByActorAsync>d__2>(ref <CreateThenShowByActorAsync>d__);
		return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D40F RID: 54287 RVA: 0x003F09AC File Offset: 0x003EEBAC
	public override UniTask CreateByActorAsync(AActor actor)
	{
		PhantomManageMediumItemGrid.<CreateByActorAsync>d__3 <CreateByActorAsync>d__;
		<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByActorAsync>d__.<>1__state = -1;
		<CreateByActorAsync>d__.<>t__builder.Start<PhantomManageMediumItemGrid.<CreateByActorAsync>d__3>(ref <CreateByActorAsync>d__);
		return <CreateByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D410 RID: 54288 RVA: 0x003F09E7 File Offset: 0x003EEBE7
	public static void CreateStaticDefaultValue()
	{
		PhantomManageMediumItemGrid.CallbackCheckSelect = null;
		PhantomManageMediumItemGrid.CallbackCheckTips = null;
		PhantomManageMediumItemGrid.CallbackListenerFocus = null;
	}

	// Token: 0x0600D411 RID: 54289 RVA: 0x003F09FB File Offset: 0x003EEBFB
	public static void ResetStaticDefaultValue()
	{
		PhantomManageMediumItemGrid.CallbackCheckSelect = null;
		PhantomManageMediumItemGrid.CallbackCheckTips = null;
		PhantomManageMediumItemGrid.CallbackListenerFocus = null;
	}

	// Token: 0x0600D412 RID: 54290 RVA: 0x003F0A0F File Offset: 0x003EEC0F
	protected override void OnStart()
	{
		base.OnStart();
		this.GetItemGridExtendToggle().FocusListenerDelegate.Bind(new Action(this.OnListenerFocus));
	}

	// Token: 0x0600D413 RID: 54291 RVA: 0x003F0A33 File Offset: 0x003EEC33
	private void OnListenerFocus()
	{
		if (this.Data != null && PhantomManageMediumItemGrid.CallbackListenerFocus != null)
		{
			PhantomManageMediumItemGrid.CallbackListenerFocus(this.Data as PhantomItemData);
		}
	}

	// Token: 0x0600D414 RID: 54292 RVA: 0x003F0A59 File Offset: 0x003EEC59
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.GetItemGridExtendToggle().FocusListenerDelegate.Unbind();
	}

	// Token: 0x0600D415 RID: 54293 RVA: 0x003F0A71 File Offset: 0x003EEC71
	protected override void OnRefresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshPrivate(data);
	}

	// Token: 0x0600D416 RID: 54294 RVA: 0x003F0A84 File Offset: 0x003EEC84
	private void RefreshPrivate(PhantomItemData data)
	{
		PhantomItem value = data.GetConfig().As<PhantomItem>().Value;
		int uniqueId = data.GetUniqueId();
		int qualityId = value.QualityId;
		InventoryModel instance = InventoryModel.Instance;
		bool selectState = this.GetSelectState(data);
		bool tipsState = this.GetTipsState(data);
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetConfigId()),
			StarLevel = new int?(qualityId),
			IsNewVisible = new bool?(instance.IsNewAttributeItem(uniqueId)),
			IsLockVisible = new bool?(data.GetIsLock()),
			IsDeprecate = new bool?(data.GetIsDeprecated()),
			IsRedDotVisible = new bool?(instance.IsAttributeItemHasRedDot(uniqueId)),
			IsGreenSelected = new bool?(selectState)
		};
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
		List<VisionSlotData> currentSlotData = phantomBattleData.GetCurrentSlotData();
		propMediumItemGrid.Level = new int?(phantomBattleData.GetCost());
		propMediumItemGrid.IsLevelTextUseChangeColor = new bool?(true);
		propMediumItemGrid.BottomText = "+" + phantomBattleData.GetPhantomLevel().ToString();
		propMediumItemGrid.IsOmitBottomText = new bool?(true);
		propMediumItemGrid.StackDisplayInfo = new PhantomStackDisplay
		{
			StackCount = data.GetStackCount(),
			SelectedCount = 0,
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
			switch (qualityId)
			{
			case 3:
				propMediumItemGrid.VisionSlotStateList = new int[]
				{
					(int)valueOrDefault
				};
				break;
			case 4:
				propMediumItemGrid.VisionSlotStateList = new int[]
				{
					(int)valueOrDefault,
					(int)valueOrDefault2
				};
				break;
			case 5:
				propMediumItemGrid.VisionSlotStateList = new int[]
				{
					(int)valueOrDefault,
					(int)valueOrDefault2,
					(int)valueOrDefault3
				};
				break;
			}
		}
		if (!selectState && PhantomBattleController.Instance.CheckIsEquip(uniqueId))
		{
			int uniqueId2 = phantomBattleData.GetUniqueId();
			int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId2);
			bool value2 = PhantomBattleModel.Instance.CheckPhantomIsMain(uniqueId2);
			propMediumItemGrid.VisionRoleHeadInfo = new VisionRoleHeadInfo
			{
				RoleConfigId = equipRole,
				VisionUniqueId = new int?(uniqueId2)
			};
			propMediumItemGrid.IsMainVisionVisible = new bool?(value2);
		}
		propMediumItemGrid.VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
		base.SetCheckTickPerformance(new bool?(selectState), "bf5c5c", new float?(0.9f), "663738");
		this.SetSelected(tipsState, true);
	}

	// Token: 0x0600D417 RID: 54295 RVA: 0x003F0DBE File Offset: 0x003EEFBE
	public void RefreshByView(PhantomItemData data)
	{
		this.RefreshPrivate(data);
	}

	// Token: 0x0600D418 RID: 54296 RVA: 0x003F0DC7 File Offset: 0x003EEFC7
	private bool GetTipsState(PhantomItemData data)
	{
		return PhantomManageMediumItemGrid.CallbackCheckTips != null && PhantomManageMediumItemGrid.CallbackCheckTips(data);
	}

	// Token: 0x0600D419 RID: 54297 RVA: 0x003F0DDD File Offset: 0x003EEFDD
	private bool GetSelectState(PhantomItemData data)
	{
		return PhantomManageMediumItemGrid.CallbackCheckSelect != null && PhantomManageMediumItemGrid.CallbackCheckSelect(data);
	}

	// Token: 0x0600D41A RID: 54298 RVA: 0x003F0DF3 File Offset: 0x003EEFF3
	public override object GetKey(PhantomItemData data, int gridIndex)
	{
		return data.GetUniqueId();
	}

	// Token: 0x04007731 RID: 30513
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Func<PhantomItemData, bool> CallbackCheckSelect;

	// Token: 0x04007732 RID: 30514
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Func<PhantomItemData, bool> CallbackCheckTips;

	// Token: 0x04007733 RID: 30515
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Action<PhantomItemData> CallbackListenerFocus;

	// Token: 0x04007734 RID: 30516
	private const string RED_TICK_HEX = "bf5c5c";

	// Token: 0x04007735 RID: 30517
	private const string TICK_COLOR_HEX = "663738";

	// Token: 0x04007736 RID: 30518
	private const float RED_TICK_ALPHA = 0.9f;
}
