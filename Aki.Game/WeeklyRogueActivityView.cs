using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A3 RID: 8867
public class WeeklyRogueActivityView : UiViewBase
{
	// Token: 0x06015E6A RID: 89706 RVA: 0x00659EB6 File Offset: 0x006580B6
	[NullableContext(1)]
	public WeeklyRogueActivityView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015E6B RID: 89707 RVA: 0x00659EC0 File Offset: 0x006580C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
	}

	// Token: 0x06015E6C RID: 89708 RVA: 0x00659F74 File Offset: 0x00658174
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueActivityView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueActivityView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015E6D RID: 89709 RVA: 0x00659FB8 File Offset: 0x006581B8
	protected override void OnStart()
	{
		WeeklyRogueModel instance = WeeklyRogueModel.Instance;
		object openParam = this.OpenParam;
		bool isOpenedViewByWorld;
		if (openParam is EWeeklyRogueOpenWay)
		{
			EWeeklyRogueOpenWay eweeklyRogueOpenWay = (EWeeklyRogueOpenWay)openParam;
			isOpenedViewByWorld = (eweeklyRogueOpenWay == EWeeklyRogueOpenWay.World);
		}
		else
		{
			isOpenedViewByWorld = false;
		}
		instance.IsOpenedViewByWorld = isOpenedViewByWorld;
		RogueWeeklyCycle value = this.ActivityBaseData.GetCycleConfig().Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.BuffDesc, value.BuffDescParam());
		this.ActivityBaseData.SaveFirstCheckRedDotState();
	}

	// Token: 0x06015E6E RID: 89710 RVA: 0x0065A02B File Offset: 0x0065822B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x06015E6F RID: 89711 RVA: 0x0065A049 File Offset: 0x00658249
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x06015E70 RID: 89712 RVA: 0x0065A068 File Offset: 0x00658268
	private void OnCycleRefresh()
	{
		Action value = delegate()
		{
			base.CloseMe(null);
		};
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeeklyRogueCycleRefresh);
		confirmBoxDataNew.FunctionMap.Add(1, value);
		confirmBoxDataNew.FunctionMap.Add(0, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06015E71 RID: 89713 RVA: 0x0065A0B3 File Offset: 0x006582B3
	protected override void OnBeforeShow()
	{
		if (this.CycleId != this.ActivityBaseData.CycleId)
		{
			this.OnCycleRefresh();
		}
		this.RefreshButton();
	}

	// Token: 0x06015E72 RID: 89714 RVA: 0x0065A0D4 File Offset: 0x006582D4
	private void RefreshButton()
	{
		if (WeeklyRogueModel.Instance.HasLastInfo())
		{
			this.ConfirmButton.SetLocalTextNew("WeRougeHomePageButtonTextContinue", Array.Empty<object>());
			return;
		}
		this.ConfirmButton.SetLocalTextNew("WeRougeHomePageButtonTextStart", Array.Empty<object>());
	}

	// Token: 0x06015E73 RID: 89715 RVA: 0x0065A110 File Offset: 0x00658310
	private void OnBtnConfirmClick(int _)
	{
		if (WeeklyRogueModel.Instance.HasLastInfo())
		{
			RogueWeeklyLastInfo lastInstInfo = this.ActivityBaseData.LastInstInfo;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoguelikeEnter);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				lastInstInfo.CurLayer.ToString(),
				lastInstInfo.MaxLayer.ToString()
			});
			Action value = delegate()
			{
				if (RoleController.Instance.IsInRoleTrial())
				{
					GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
					return;
				}
				WeeklyRogueController.Instance.RogueWeeklyStartRequest(new List<int>());
			};
			Action value2 = delegate()
			{
				WeeklyRogueController.Instance.InstanceSettleRequest(delegate(bool success)
				{
					if (success)
					{
						this.RefreshButton();
					}
				});
			};
			confirmBoxDataNew.FunctionMap.Add(1, value2);
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueRoleSelectView, null, delegate(bool success, int viewId)
		{
			if (success && UiManager.Instance.IsViewShow(EUiViewName.WeeklyRogueActivityView))
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.WeeklyRogueActivityView);
				if (viewByName == null)
				{
					return;
				}
				viewByName.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06015E74 RID: 89716 RVA: 0x0065A200 File Offset: 0x00658400
	private void OnBtnHelpBtn()
	{
		RogueWeeklyCycle? cycleConfig = this.ActivityBaseData.GetCycleConfig();
		HelpController.Instance.OpenHelpById(cycleConfig.Value.HelpId);
	}

	// Token: 0x0400B844 RID: 47172
	[Nullable(1)]
	protected WeeklyRogueData ActivityBaseData;

	// Token: 0x0400B845 RID: 47173
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B846 RID: 47174
	[Nullable(2)]
	private ButtonItem ConfirmButton;

	// Token: 0x0400B847 RID: 47175
	private int CycleId;

	// Token: 0x02008501 RID: 34049
	private enum EWeeklyRogueActivityViewDefine
	{
		// Token: 0x0402AE00 RID: 175616
		CaptionItem,
		// Token: 0x0402AE01 RID: 175617
		TxtTitle,
		// Token: 0x0402AE02 RID: 175618
		TxtSubTitle,
		// Token: 0x0402AE03 RID: 175619
		TxtBuffDescription,
		// Token: 0x0402AE04 RID: 175620
		BtnConfirm,
		// Token: 0x0402AE05 RID: 175621
		TextureBg,
		// Token: 0x0402AE06 RID: 175622
		TxtDesc
	}
}
