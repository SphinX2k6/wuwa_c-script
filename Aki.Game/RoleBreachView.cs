using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D24 RID: 7460
[NullableContext(1)]
[Nullable(0)]
public class RoleBreachView : UiViewBase
{
	// Token: 0x060127AE RID: 75694 RVA: 0x00575935 File Offset: 0x00573B35
	public RoleBreachView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060127AF RID: 75695 RVA: 0x00575940 File Offset: 0x00573B40
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060127B0 RID: 75696 RVA: 0x00575A94 File Offset: 0x00573C94
	protected override UniTask OnBeforeStartAsync()
	{
		RoleBreachView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBreachView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060127B1 RID: 75697 RVA: 0x00575AD8 File Offset: 0x00573CD8
	private void RefreshCostItemButton()
	{
		if (this.RoleBreachState.GetValueOrDefault() == ERoleBreachState.CanBreach)
		{
			this.CostItemGridComponent.SetButtonItemLocalText("RoleBreakup");
			this.CostItemGridComponent.SetButtonItemInteractive(true);
			return;
		}
		ERoleBreachState? roleBreachState = this.RoleBreachState;
		ERoleBreachState eroleBreachState = ERoleBreachState.NoEnoughMaterial;
		if ((roleBreachState.GetValueOrDefault() == eroleBreachState & roleBreachState != null) || this.RoleBreachState.GetValueOrDefault() == ERoleBreachState.NoEnoughMoney)
		{
			bool flag = ComposePopupModel.Instance.CheckOpenResult(this.GetSelectedDataList());
			if (flag)
			{
				this.CostItemGridComponent.SetButtonItemLocalTextNew("AutoSynthesis_MaterialReplenishBtn_Text");
			}
			else
			{
				this.CostItemGridComponent.SetButtonItemLocalTextNew("AutoSynthesis_MaterialMissingBtn_Text");
			}
			this.CostItemGridComponent.SetButtonItemInteractive(flag);
		}
	}

	// Token: 0x060127B2 RID: 75698 RVA: 0x00575B7D File Offset: 0x00573D7D
	protected override void OnBeforeShow()
	{
		this.UpdateView();
	}

	// Token: 0x060127B3 RID: 75699 RVA: 0x00575B88 File Offset: 0x00573D88
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleBreachView.<OnPlayingStartSequenceAsync>d__14 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleBreachView.<OnPlayingStartSequenceAsync>d__14>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060127B4 RID: 75700 RVA: 0x00575BCC File Offset: 0x00573DCC
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleBreachView.<OnPlayingCloseSequenceAsync>d__15 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleBreachView.<OnPlayingCloseSequenceAsync>d__15>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060127B5 RID: 75701 RVA: 0x00575C0F File Offset: 0x00573E0F
	protected override void OnHandleLoadScene()
	{
		this.ViewModel.HandleLoadScene(delegate
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
		});
	}

	// Token: 0x060127B6 RID: 75702 RVA: 0x00575C3B File Offset: 0x00573E3B
	protected override void OnHandleReleaseScene()
	{
		this.ViewModel.HandleReleaseScene();
	}

	// Token: 0x060127B7 RID: 75703 RVA: 0x00575C48 File Offset: 0x00573E48
	protected void CloseClick()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleBreach);
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
		base.CloseMe(null);
	}

	// Token: 0x060127B8 RID: 75704 RVA: 0x00575C68 File Offset: 0x00573E68
	protected void LevelUpClick(int _)
	{
		Action action = delegate()
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
			RoleController.Instance.SendPbOverRoleRequest(roleInstanceById.GetRoleId());
		};
		ERoleBreachState? roleBreachState = this.RoleBreachState;
		ERoleBreachState eroleBreachState = ERoleBreachState.NoEnoughMaterial;
		if ((roleBreachState.GetValueOrDefault() == eroleBreachState & roleBreachState != null) || this.RoleBreachState.GetValueOrDefault() == ERoleBreachState.NoEnoughMoney)
		{
			List<ISelectedData> selectedDataList = this.GetSelectedDataList();
			IComposePopupViewData param = new ComposePopupViewData
			{
				SelectedItemList = selectedDataList,
				ClickConfirm = action,
				BelongView = new EUiViewName?(EUiViewName.RoleBreachView)
			};
			UiManager.Instance.OpenView(EUiViewName.SynthesisTipsInfoView, param, delegate(bool isSuccess, int viewId)
			{
				if (isSuccess)
				{
					base.AddChildViewById(viewId);
				}
			});
			return;
		}
		action();
	}

	// Token: 0x060127B9 RID: 75705 RVA: 0x00575CFD File Offset: 0x00573EFD
	private List<ISelectedData> GetSelectedDataList()
	{
		return this.CachedConsumeList ?? new List<ISelectedData>();
	}

	// Token: 0x060127BA RID: 75706 RVA: 0x00575D10 File Offset: 0x00573F10
	protected void LevelUpLockTipClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleBreakUpTip);
		int curQuestId = QuestNewModel.Instance.GetCurWorldLevelBreakQuest();
		if (curQuestId < 0)
		{
			confirmBoxDataNew.InteractionMap[1] = false;
		}
		else
		{
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, curQuestId, null);
			};
			confirmBoxDataNew.InteractionMap[1] = true;
		}
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060127BB RID: 75707 RVA: 0x00575D87 File Offset: 0x00573F87
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.RoleBreakUp));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060127BC RID: 75708 RVA: 0x00575DC1 File Offset: 0x00573FC1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleBreakUp, new Action<int, int>(this.RoleBreakUp));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060127BD RID: 75709 RVA: 0x00575DFC File Offset: 0x00573FFC
	private void UpdateView()
	{
		RoleLevelData levelData = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetLevelData();
		int breachLevel = levelData.GetBreachLevel();
		LguiUtil.Instance.SetLocalText(base.GetText(4), "RoleBreakUpLevel", new <>z__ReadOnlySingleElementList<object>(breachLevel + 1));
		RoleBreach value = levelData.GetBreachConfig(breachLevel + 1).Value;
		base.GetText(0).SetText(value.MaxLevel.ToString(), true);
		int num = 0;
		List<ISelectedData> list = new List<ISelectedData>();
		Dictionary<int, int> dictionary = value.BreachConsume();
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				int value2 = keyValuePair.Value;
				if (key == 2)
				{
					num = value2;
				}
				else
				{
					SelectedData item = new SelectedData
					{
						ItemId = key,
						IncId = 0,
						SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(key, 0),
						Count = value2
					};
					list.Add(item);
				}
			}
		}
		this.CachedConsumeList = new List<ISelectedData>();
		foreach (ISelectedData selectedData in list)
		{
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = selectedData.ItemId,
				IncId = selectedData.IncId,
				Count = selectedData.Count,
				SelectedCount = selectedData.SelectedCount,
				OnlyTextFlag = selectedData.OnlyTextFlag
			});
		}
		if (num > 0)
		{
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = 2,
				IncId = 0,
				Count = num,
				SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(2, 0)
			});
		}
		this.RoleBreachState = new ERoleBreachState?(RoleModel.Instance.GetRoleBreachState(this.RoleId));
		if (this.RoleBreachState.GetValueOrDefault() == ERoleBreachState.NoEnoughCondition)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(value.ConditionId);
			this.CostItemGridComponent.SetButtonItemActive(false);
			this.CostItemGridComponent.SetLockItemActive(true);
			this.CostItemGridComponent.SetLockLocalText(conditionGroupHintText, Array.Empty<object>());
		}
		else
		{
			this.CostItemGridComponent.SetButtonItemActive(true);
			this.CostItemGridComponent.SetLockItemActive(false);
		}
		this.CostItemGridComponent.Update(list, 2, num);
		this.UpdateStar(breachLevel, levelData.GetMaxBreachLevel());
		this.UpdateAttribute();
		this.RefreshCostItemButton();
	}

	// Token: 0x060127BE RID: 75710 RVA: 0x00576098 File Offset: 0x00574298
	private void UpdateAttribute()
	{
		IEnumerable<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay3");
		RoleLevelData levelData = RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetLevelData();
		int level = levelData.GetLevel();
		int breachLevel = levelData.GetBreachLevel();
		int maxBreachLevel = levelData.GetMaxBreachLevel();
		List<CSharpScript.Game.Module.Common.AttributeData> list = new List<CSharpScript.Game.Module.Common.AttributeData>();
		foreach (int num in intArrayConfig)
		{
			float num2 = (float)RoleModel.Instance.GetAttributeByLevel(this.RoleId, (EAttributeType)num, level, breachLevel);
			int num3 = 0;
			if (breachLevel < maxBreachLevel)
			{
				int addAttrLevelUp = RoleModel.Instance.GetAddAttrLevelUp(this.RoleId, level, breachLevel, level, breachLevel + 1, num);
				if (addAttrLevelUp > 0)
				{
					num3 = (int)(num2 + (float)addAttrLevelUp);
				}
			}
			CSharpScript.Game.Module.Common.AttributeData item = new CSharpScript.Game.Module.Common.AttributeData
			{
				Id = num,
				IsRatio = false,
				CurValue = num2,
				BgActive = new bool?(false),
				ShowNext = new bool?((float)num3 > num2),
				NextValue = new float?((float)num3),
				UseAnotherName = new bool?(true)
			};
			list.Add(item);
		}
		this.AttributeLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060127BF RID: 75711 RVA: 0x005761D0 File Offset: 0x005743D0
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x060127C0 RID: 75712 RVA: 0x005761D8 File Offset: 0x005743D8
	private void UpdateStar(int breachLevel, int maxLevel)
	{
		List<IStarItemData> list = new List<IStarItemData>(maxLevel);
		for (int i = 0; i < maxLevel; i++)
		{
			StarItemData item = new StarItemData
			{
				StarOnActive = (i < breachLevel),
				StarOffActive = (i > breachLevel),
				StarNextActive = (i == breachLevel),
				StarLoopActive = (i == breachLevel),
				PlayLoopSequence = (i == breachLevel),
				PlayActivateSequence = false
			};
			list.Add(item);
		}
		this.StarLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060127C1 RID: 75713 RVA: 0x0057624C File Offset: 0x0057444C
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x060127C2 RID: 75714 RVA: 0x00576254 File Offset: 0x00574454
	private void BreakUpSuccess()
	{
		RoleBreachSuccessViewData param = new RoleBreachSuccessViewData(this.RoleId, new Action(this.OnBreachSuccessViewMaskClick));
		UiManager.Instance.OpenView(EUiViewName.RoleBreachSuccessView, param, null);
	}

	// Token: 0x060127C3 RID: 75715 RVA: 0x0057628C File Offset: 0x0057448C
	private void OnBreachSuccessViewMaskClick()
	{
		if (!RoleModel.Instance.GetRoleInstanceById(this.RoleId).GetLevelData().GetRoleIsMaxLevel())
		{
			RoleViewViewModel viewModel = new RoleViewViewModel(this.RoleId, false, ERoleViewSource.Normal)
			{
				FadeInCurveId = this.ViewModel.FadeInCurveId,
				NeedHideOnViewPlayingCloseSequence = this.ViewModel.NeedHideOnViewPlayingCloseSequence
			};
			this.ViewModel.NeedHideOnViewPlayingCloseSequence = false;
			base.CloseMe(null);
			RoleController.Instance.CloseAndOpenRoleViewByViewModel(EUiViewName.RoleBreachSuccessView, EUiViewName.RoleLevelUpView, viewModel);
			return;
		}
		base.CloseMe(null);
		UiManager.Instance.CloseView(EUiViewName.RoleBreachSuccessView, null);
	}

	// Token: 0x060127C4 RID: 75716 RVA: 0x00576328 File Offset: 0x00574528
	private void RoleBreakUp(int roleId, int level)
	{
		base.GetItem(3).SetUIActive(false);
		this.CostItemGridComponent.GetRootItem().SetUIActive(false);
		this.CaptionItem.GetRootItem().SetUIActive(false);
		UiRoleUtils.PlayRoleBreachFinishEffect(this.ViewModel.TsUiSceneRoleActor);
		int? roleBreachSuccessDelayTime = RoleConfig.Instance.GetRoleBreachSuccessDelayTime();
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
			this.BreakUpSuccess();
		}, (float)roleBreachSuccessDelayTime.Value, null, null, true, 1f);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		int? num = (roleDataById != null) ? new int?(roleDataById.GetRoleSkinId()) : null;
		if (num == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[Game.RoleBreachView] 没有皮肤ID";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		RoleSkinAudio? roleConfig = AudioConfig.Instance.GetRoleConfig(num.Value);
		if (roleConfig != null && level < roleConfig.Value.BreakUpEventListLength)
		{
			string text = roleConfig.Value.BreakUpEventList(level);
			if (!string.IsNullOrEmpty(text))
			{
				AudioSystem.Instance.PostEvent(text);
			}
		}
	}

	// Token: 0x060127C5 RID: 75717 RVA: 0x0057645A File Offset: 0x0057465A
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.UpdateView();
	}

	// Token: 0x0400A0CB RID: 41163
	private int RoleId;

	// Token: 0x0400A0CC RID: 41164
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x0400A0CD RID: 41165
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400A0CE RID: 41166
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A0CF RID: 41167
	[Nullable(2)]
	private CostItemGridComponent CostItemGridComponent;

	// Token: 0x0400A0D0 RID: 41168
	private ERoleBreachState? RoleBreachState;

	// Token: 0x0400A0D1 RID: 41169
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x0400A0D2 RID: 41170
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> CachedConsumeList;

	// Token: 0x0200806D RID: 32877
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040298ED RID: 170221
		NewLevelLimitText,
		// Token: 0x040298EE RID: 170222
		SkillRewardPanel,
		// Token: 0x040298EF RID: 170223
		NewSkillIconTexture,
		// Token: 0x040298F0 RID: 170224
		BreachPanel,
		// Token: 0x040298F1 RID: 170225
		DescText,
		// Token: 0x040298F2 RID: 170226
		StarHorizontalLayout,
		// Token: 0x040298F3 RID: 170227
		AttributeLayout,
		// Token: 0x040298F4 RID: 170228
		CaptionItem,
		// Token: 0x040298F5 RID: 170229
		ConsumeItem
	}
}
