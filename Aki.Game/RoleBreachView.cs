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

// Token: 0x020027A9 RID: 10153
[NullableContext(1)]
[Nullable(0)]
public class RoleBreachView : UiViewBase
{
	// Token: 0x06014DB4 RID: 85428 RVA: 0x0054ADAD File Offset: 0x00548FAD
	public RoleBreachView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014DB5 RID: 85429 RVA: 0x0054ADB8 File Offset: 0x00548FB8
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

	// Token: 0x06014DB6 RID: 85430 RVA: 0x0054AF0C File Offset: 0x0054910C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleBreachView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleBreachView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DB7 RID: 85431 RVA: 0x0054AF50 File Offset: 0x00549150
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

	// Token: 0x06014DB8 RID: 85432 RVA: 0x0054AFF5 File Offset: 0x005491F5
	protected override void OnBeforeShow()
	{
		this.UpdateView();
	}

	// Token: 0x06014DB9 RID: 85433 RVA: 0x0054B000 File Offset: 0x00549200
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleBreachView.<OnPlayingStartSequenceAsync>d__14 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleBreachView.<OnPlayingStartSequenceAsync>d__14>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DBA RID: 85434 RVA: 0x0054B044 File Offset: 0x00549244
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleBreachView.<OnPlayingCloseSequenceAsync>d__15 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleBreachView.<OnPlayingCloseSequenceAsync>d__15>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014DBB RID: 85435 RVA: 0x0054B087 File Offset: 0x00549287
	protected override void OnHandleLoadScene()
	{
		this.ViewModel.HandleLoadScene(delegate
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
		});
	}

	// Token: 0x06014DBC RID: 85436 RVA: 0x0054B0B3 File Offset: 0x005492B3
	protected override void OnHandleReleaseScene()
	{
		this.ViewModel.HandleReleaseScene();
	}

	// Token: 0x06014DBD RID: 85437 RVA: 0x0054B0C0 File Offset: 0x005492C0
	protected void CloseClick()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleBreach);
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
		base.CloseMe(null);
	}

	// Token: 0x06014DBE RID: 85438 RVA: 0x0054B0E0 File Offset: 0x005492E0
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

	// Token: 0x06014DBF RID: 85439 RVA: 0x0054B175 File Offset: 0x00549375
	private List<ISelectedData> GetSelectedDataList()
	{
		return this.CachedConsumeList ?? new List<ISelectedData>();
	}

	// Token: 0x06014DC0 RID: 85440 RVA: 0x0054B188 File Offset: 0x00549388
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

	// Token: 0x06014DC1 RID: 85441 RVA: 0x0054B1FF File Offset: 0x005493FF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.RoleBreakUp));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06014DC2 RID: 85442 RVA: 0x0054B239 File Offset: 0x00549439
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleBreakUp, new Action<int, int>(this.RoleBreakUp));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06014DC3 RID: 85443 RVA: 0x0054B274 File Offset: 0x00549474
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

	// Token: 0x06014DC4 RID: 85444 RVA: 0x0054B510 File Offset: 0x00549710
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

	// Token: 0x06014DC5 RID: 85445 RVA: 0x0054B648 File Offset: 0x00549848
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06014DC6 RID: 85446 RVA: 0x0054B650 File Offset: 0x00549850
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

	// Token: 0x06014DC7 RID: 85447 RVA: 0x0054B6C4 File Offset: 0x005498C4
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x06014DC8 RID: 85448 RVA: 0x0054B6CC File Offset: 0x005498CC
	private void BreakUpSuccess()
	{
		RoleBreachSuccessViewData param = new RoleBreachSuccessViewData(this.RoleId, new Action(this.OnBreachSuccessViewMaskClick));
		UiManager.Instance.OpenView(EUiViewName.RoleBreachSuccessView, param, null);
	}

	// Token: 0x06014DC9 RID: 85449 RVA: 0x0054B704 File Offset: 0x00549904
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

	// Token: 0x06014DCA RID: 85450 RVA: 0x0054B7A0 File Offset: 0x005499A0
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

	// Token: 0x06014DCB RID: 85451 RVA: 0x0054B8D2 File Offset: 0x00549AD2
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.UpdateView();
	}

	// Token: 0x04009CE8 RID: 40168
	private int RoleId;

	// Token: 0x04009CE9 RID: 40169
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x04009CEA RID: 40170
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x04009CEB RID: 40171
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009CEC RID: 40172
	[Nullable(2)]
	private CostItemGridComponent CostItemGridComponent;

	// Token: 0x04009CED RID: 40173
	private ERoleBreachState? RoleBreachState;

	// Token: 0x04009CEE RID: 40174
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x04009CEF RID: 40175
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> CachedConsumeList;

	// Token: 0x02008E24 RID: 36388
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E1F1 RID: 188913
		NewLevelLimitText,
		// Token: 0x0402E1F2 RID: 188914
		SkillRewardPanel,
		// Token: 0x0402E1F3 RID: 188915
		NewSkillIconTexture,
		// Token: 0x0402E1F4 RID: 188916
		BreachPanel,
		// Token: 0x0402E1F5 RID: 188917
		DescText,
		// Token: 0x0402E1F6 RID: 188918
		StarHorizontalLayout,
		// Token: 0x0402E1F7 RID: 188919
		AttributeLayout,
		// Token: 0x0402E1F8 RID: 188920
		CaptionItem,
		// Token: 0x0402E1F9 RID: 188921
		ConsumeItem
	}
}
