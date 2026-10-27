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

// Token: 0x02002D49 RID: 11593
public class WeeklyRogueActivityView : UiViewBase
{
	// Token: 0x060185C8 RID: 99784 RVA: 0x00633EA6 File Offset: 0x006320A6
	[NullableContext(1)]
	public WeeklyRogueActivityView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060185C9 RID: 99785 RVA: 0x00633EB0 File Offset: 0x006320B0
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

	// Token: 0x060185CA RID: 99786 RVA: 0x00633F64 File Offset: 0x00632164
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueActivityView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueActivityView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060185CB RID: 99787 RVA: 0x00633FA8 File Offset: 0x006321A8
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

	// Token: 0x060185CC RID: 99788 RVA: 0x0063401B File Offset: 0x0063221B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x060185CD RID: 99789 RVA: 0x00634039 File Offset: 0x00632239
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x060185CE RID: 99790 RVA: 0x00634058 File Offset: 0x00632258
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

	// Token: 0x060185CF RID: 99791 RVA: 0x006340A3 File Offset: 0x006322A3
	protected override void OnBeforeShow()
	{
		if (this.CycleId != this.ActivityBaseData.CycleId)
		{
			this.OnCycleRefresh();
		}
		this.RefreshButton();
	}

	// Token: 0x060185D0 RID: 99792 RVA: 0x006340C4 File Offset: 0x006322C4
	private void RefreshButton()
	{
		if (WeeklyRogueModel.Instance.HasLastInfo())
		{
			this.ConfirmButton.SetLocalTextNew("WeRougeHomePageButtonTextContinue", Array.Empty<object>());
			return;
		}
		this.ConfirmButton.SetLocalTextNew("WeRougeHomePageButtonTextStart", Array.Empty<object>());
	}

	// Token: 0x060185D1 RID: 99793 RVA: 0x00634100 File Offset: 0x00632300
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

	// Token: 0x060185D2 RID: 99794 RVA: 0x006341F0 File Offset: 0x006323F0
	private void OnBtnHelpBtn()
	{
		RogueWeeklyCycle? cycleConfig = this.ActivityBaseData.GetCycleConfig();
		HelpController.Instance.OpenHelpById(cycleConfig.Value.HelpId);
	}

	// Token: 0x0400B4CF RID: 46287
	[Nullable(1)]
	protected WeeklyRogueData ActivityBaseData;

	// Token: 0x0400B4D0 RID: 46288
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B4D1 RID: 46289
	[Nullable(2)]
	private ButtonItem ConfirmButton;

	// Token: 0x0400B4D2 RID: 46290
	private int CycleId;

	// Token: 0x020092DA RID: 37594
	private enum EWeeklyRogueActivityViewDefine
	{
		// Token: 0x0402F778 RID: 194424
		CaptionItem,
		// Token: 0x0402F779 RID: 194425
		TxtTitle,
		// Token: 0x0402F77A RID: 194426
		TxtSubTitle,
		// Token: 0x0402F77B RID: 194427
		TxtBuffDescription,
		// Token: 0x0402F77C RID: 194428
		BtnConfirm,
		// Token: 0x0402F77D RID: 194429
		TextureBg,
		// Token: 0x0402F77E RID: 194430
		TxtDesc
	}
}
