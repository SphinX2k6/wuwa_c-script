using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FDC RID: 8156
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageMediumItemGrid : LoopScrollMediumItemGrid<PhantomItemData>, IStaticVariableResetter
{
	// Token: 0x0600FFA4 RID: 65444 RVA: 0x003E434C File Offset: 0x003E254C
	static PhantomManageMediumItemGrid()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageMediumItemGrid.CreateStaticDefaultValue), new Action(PhantomManageMediumItemGrid.ResetStaticDefaultValue));
	}

	// Token: 0x0600FFA5 RID: 65445 RVA: 0x003E436B File Offset: 0x003E256B
	public override void CreateThenShowByActor(AActor actor)
	{
	}

	// Token: 0x0600FFA6 RID: 65446 RVA: 0x003E4370 File Offset: 0x003E2570
	public override UniTask CreateThenShowByActorAsync(AActor actor)
	{
		PhantomManageMediumItemGrid.<CreateThenShowByActorAsync>d__2 <CreateThenShowByActorAsync>d__;
		<CreateThenShowByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateThenShowByActorAsync>d__.<>1__state = -1;
		<CreateThenShowByActorAsync>d__.<>t__builder.Start<PhantomManageMediumItemGrid.<CreateThenShowByActorAsync>d__2>(ref <CreateThenShowByActorAsync>d__);
		return <CreateThenShowByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FFA7 RID: 65447 RVA: 0x003E43AC File Offset: 0x003E25AC
	public override UniTask CreateByActorAsync(AActor actor)
	{
		PhantomManageMediumItemGrid.<CreateByActorAsync>d__3 <CreateByActorAsync>d__;
		<CreateByActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByActorAsync>d__.<>1__state = -1;
		<CreateByActorAsync>d__.<>t__builder.Start<PhantomManageMediumItemGrid.<CreateByActorAsync>d__3>(ref <CreateByActorAsync>d__);
		return <CreateByActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FFA8 RID: 65448 RVA: 0x003E43E7 File Offset: 0x003E25E7
	public static void CreateStaticDefaultValue()
	{
		PhantomManageMediumItemGrid.CallbackCheckSelect = null;
		PhantomManageMediumItemGrid.CallbackCheckTips = null;
		PhantomManageMediumItemGrid.CallbackListenerFocus = null;
	}

	// Token: 0x0600FFA9 RID: 65449 RVA: 0x003E43FB File Offset: 0x003E25FB
	public static void ResetStaticDefaultValue()
	{
		PhantomManageMediumItemGrid.CallbackCheckSelect = null;
		PhantomManageMediumItemGrid.CallbackCheckTips = null;
		PhantomManageMediumItemGrid.CallbackListenerFocus = null;
	}

	// Token: 0x0600FFAA RID: 65450 RVA: 0x003E440F File Offset: 0x003E260F
	protected override void OnStart()
	{
		base.OnStart();
		this.GetItemGridExtendToggle().FocusListenerDelegate.Bind(new Action(this.OnListenerFocus));
	}

	// Token: 0x0600FFAB RID: 65451 RVA: 0x003E4433 File Offset: 0x003E2633
	private void OnListenerFocus()
	{
		if (this.Data != null && PhantomManageMediumItemGrid.CallbackListenerFocus != null)
		{
			PhantomManageMediumItemGrid.CallbackListenerFocus(this.Data as PhantomItemData);
		}
	}

	// Token: 0x0600FFAC RID: 65452 RVA: 0x003E4459 File Offset: 0x003E2659
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.GetItemGridExtendToggle().FocusListenerDelegate.Unbind();
	}

	// Token: 0x0600FFAD RID: 65453 RVA: 0x003E4471 File Offset: 0x003E2671
	protected override void OnRefresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshPrivate(data);
	}

	// Token: 0x0600FFAE RID: 65454 RVA: 0x003E4484 File Offset: 0x003E2684
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

	// Token: 0x0600FFAF RID: 65455 RVA: 0x003E47BE File Offset: 0x003E29BE
	public void RefreshByView(PhantomItemData data)
	{
		this.RefreshPrivate(data);
	}

	// Token: 0x0600FFB0 RID: 65456 RVA: 0x003E47C7 File Offset: 0x003E29C7
	private bool GetTipsState(PhantomItemData data)
	{
		return PhantomManageMediumItemGrid.CallbackCheckTips != null && PhantomManageMediumItemGrid.CallbackCheckTips(data);
	}

	// Token: 0x0600FFB1 RID: 65457 RVA: 0x003E47DD File Offset: 0x003E29DD
	private bool GetSelectState(PhantomItemData data)
	{
		return PhantomManageMediumItemGrid.CallbackCheckSelect != null && PhantomManageMediumItemGrid.CallbackCheckSelect(data);
	}

	// Token: 0x0600FFB2 RID: 65458 RVA: 0x003E47F3 File Offset: 0x003E29F3
	public override object GetKey(PhantomItemData data, int gridIndex)
	{
		return data.GetUniqueId();
	}

	// Token: 0x04007648 RID: 30280
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Func<PhantomItemData, bool> CallbackCheckSelect;

	// Token: 0x04007649 RID: 30281
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Func<PhantomItemData, bool> CallbackCheckTips;

	// Token: 0x0400764A RID: 30282
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Action<PhantomItemData> CallbackListenerFocus;

	// Token: 0x0400764B RID: 30283
	private const string RED_TICK_HEX = "bf5c5c";

	// Token: 0x0400764C RID: 30284
	private const string TICK_COLOR_HEX = "663738";

	// Token: 0x0400764D RID: 30285
	private const float RED_TICK_ALPHA = 0.9f;
}
