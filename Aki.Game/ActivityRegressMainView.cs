using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000921 RID: 2337
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressMainView : UiViewBase
{
	// Token: 0x06006726 RID: 26406 RVA: 0x00204515 File Offset: 0x00202715
	public ActivityRegressMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006727 RID: 26407 RVA: 0x00204540 File Offset: 0x00202740
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06006728 RID: 26408 RVA: 0x002045DC File Offset: 0x002027DC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006729 RID: 26409 RVA: 0x00204620 File Offset: 0x00202820
	protected override void OnBeforeShow()
	{
		ActivityRegressMainSubViewBase activityRegressMainSubViewBase;
		if (this.CurrentSubViewType != null && this.SubViewMap.TryGetValue(this.CurrentSubViewType.Value, out activityRegressMainSubViewBase))
		{
			bool isShowOrShowing = activityRegressMainSubViewBase.IsShowOrShowing;
			activityRegressMainSubViewBase.SetActive(true);
			if (!isShowOrShowing)
			{
				this.UiViewSequence.StopSequenceByKey("Switch", true, true);
				base.PlaySequenceAsync("Switch", true, false, null);
				activityRegressMainSubViewBase.OnParentShow();
			}
		}
		this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		this.RefreshTime();
	}

	// Token: 0x0600672A RID: 26410 RVA: 0x002046C8 File Offset: 0x002028C8
	private void RefreshTime()
	{
		ActivityBaseData activityData = this.ActivityData;
		if (activityData == null || !activityData.CheckIfInShowTime())
		{
			base.CloseMe(null);
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, this.RemainTimeText);
		base.GetText(5).SetText(remainTimeText, true);
	}

	// Token: 0x0600672B RID: 26411 RVA: 0x0020471E File Offset: 0x0020291E
	private void OnTimerRefresh(float _)
	{
		this.RefreshTime();
	}

	// Token: 0x0600672C RID: 26412 RVA: 0x00204726 File Offset: 0x00202926
	private void ClearTimer()
	{
		if (this.RefreshTimer != null && TimerSystem.Instance.Has(this.RefreshTimer))
		{
			TimerSystem.Instance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x0600672D RID: 26413 RVA: 0x0020475C File Offset: 0x0020295C
	protected override void OnAfterHide()
	{
		this.ClearTimer();
		ActivityRegressMainSubViewBase activityRegressMainSubViewBase;
		if (this.CurrentSubViewType != null && this.SubViewMap.TryGetValue(this.CurrentSubViewType.Value, out activityRegressMainSubViewBase))
		{
			activityRegressMainSubViewBase.SetActive(false);
		}
	}

	// Token: 0x0600672E RID: 26414 RVA: 0x002047A0 File Offset: 0x002029A0
	protected override void OnBeforeDestroy()
	{
		this.CloseAllSubUi();
		if (this.CaptionTabComponent != null)
		{
			foreach (KeyValuePair<int, ActivityRegressTabItemPanel> keyValuePair in this.CaptionTabComponent.GetTabItemMap())
			{
				keyValuePair.Value.Clear();
			}
			this.CaptionTabComponent.Destroy(null);
			this.CaptionTabComponent = null;
		}
	}

	// Token: 0x0600672F RID: 26415 RVA: 0x00204820 File Offset: 0x00202A20
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06006730 RID: 26416 RVA: 0x0020483E File Offset: 0x00202A3E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06006731 RID: 26417 RVA: 0x0020485C File Offset: 0x00202A5C
	private UniTask OpenSubUi(EActivityMainSubViewNewType viewType, int subTabIndex)
	{
		ActivityRegressMainView.<OpenSubUi>d__22 <OpenSubUi>d__;
		<OpenSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSubUi>d__.<>4__this = this;
		<OpenSubUi>d__.viewType = viewType;
		<OpenSubUi>d__.subTabIndex = subTabIndex;
		<OpenSubUi>d__.<>1__state = -1;
		<OpenSubUi>d__.<>t__builder.Start<ActivityRegressMainView.<OpenSubUi>d__22>(ref <OpenSubUi>d__);
		return <OpenSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x06006732 RID: 26418 RVA: 0x002048B0 File Offset: 0x00202AB0
	private UniTask HideSubUi(EActivityMainSubViewNewType viewType)
	{
		ActivityRegressMainView.<HideSubUi>d__23 <HideSubUi>d__;
		<HideSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideSubUi>d__.<>4__this = this;
		<HideSubUi>d__.viewType = viewType;
		<HideSubUi>d__.<>1__state = -1;
		<HideSubUi>d__.<>t__builder.Start<ActivityRegressMainView.<HideSubUi>d__23>(ref <HideSubUi>d__);
		return <HideSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x06006733 RID: 26419 RVA: 0x002048FC File Offset: 0x00202AFC
	private void CloseAllSubUi()
	{
		foreach (KeyValuePair<EActivityMainSubViewNewType, ActivityRegressMainSubViewBase> keyValuePair in this.SubViewMap)
		{
			ActivityRegressMainSubViewBase value = keyValuePair.Value;
			value.UnBindPassRecallBaseCallBack();
			value.CloseMeAsync().Forget<bool>();
		}
		this.SubViewMap.Clear();
	}

	// Token: 0x06006734 RID: 26420 RVA: 0x0020496C File Offset: 0x00202B6C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ActivityRegressMainSubViewBase> CreateSubUi(EActivityMainSubViewNewType viewType)
	{
		ActivityRegressMainView.<CreateSubUi>d__25 <CreateSubUi>d__;
		<CreateSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder<ActivityRegressMainSubViewBase>.Create();
		<CreateSubUi>d__.<>4__this = this;
		<CreateSubUi>d__.viewType = viewType;
		<CreateSubUi>d__.<>1__state = -1;
		<CreateSubUi>d__.<>t__builder.Start<ActivityRegressMainView.<CreateSubUi>d__25>(ref <CreateSubUi>d__);
		return <CreateSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x06006735 RID: 26421 RVA: 0x002049B8 File Offset: 0x00202BB8
	private UniTask ChangeSubUi(EActivityMainSubViewNewType subViewType, int subTabIndex = 0)
	{
		ActivityRegressMainView.<ChangeSubUi>d__26 <ChangeSubUi>d__;
		<ChangeSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeSubUi>d__.<>4__this = this;
		<ChangeSubUi>d__.subViewType = subViewType;
		<ChangeSubUi>d__.subTabIndex = subTabIndex;
		<ChangeSubUi>d__.<>1__state = -1;
		<ChangeSubUi>d__.<>t__builder.Start<ActivityRegressMainView.<ChangeSubUi>d__26>(ref <ChangeSubUi>d__);
		return <ChangeSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x06006736 RID: 26422 RVA: 0x00204A0C File Offset: 0x00202C0C
	private void UpdateTitle()
	{
		string text = null;
		if (this.CurrentSubViewType.GetValueOrDefault() == EActivityMainSubViewNewType.Sign)
		{
			text = "RecallActivity_Sign_Title";
		}
		string titleIconPath = this.GetTitleIconPath();
		string iconPath = (titleIconPath != null) ? UiResourceConfig.Instance.GetResourcePath(titleIconPath) : "";
		if (text != null)
		{
			this.CaptionTabComponent.UpdateTitle(iconPath, new CommonTabTitleData(text, Array.Empty<object>()));
		}
		base.GetItem(4).SetUIActive(this.CurrentSubViewType.GetValueOrDefault() != EActivityMainSubViewNewType.Sign);
	}

	// Token: 0x06006737 RID: 26423 RVA: 0x00204A84 File Offset: 0x00202C84
	[NullableContext(2)]
	private string GetTypeTitleIconPath(EActivityMainSubViewNewType type)
	{
		switch (type)
		{
		case EActivityMainSubViewNewType.BattlePass:
			return "SP_IconCircumfluence1";
		case EActivityMainSubViewNewType.Recommend:
			return "SP_IconTab01";
		case EActivityMainSubViewNewType.DoubleDrop:
			return "SP_IconCircumfluence3";
		case EActivityMainSubViewNewType.Adventure:
			return "SP_IconBeginnerDev";
		case EActivityMainSubViewNewType.RoleGachaPool:
			return "SP_IconComDrawcard";
		case EActivityMainSubViewNewType.MainLine:
			return "SP_FuncIconRenwu";
		case EActivityMainSubViewNewType.Sign:
			return "SP_IconCircumfluence1";
		default:
			return null;
		}
	}

	// Token: 0x06006738 RID: 26424 RVA: 0x00204AE0 File Offset: 0x00202CE0
	[NullableContext(2)]
	private string GetTypeTitle(EActivityMainSubViewNewType type)
	{
		switch (type)
		{
		case EActivityMainSubViewNewType.BattlePass:
			return "Regress_BattlePass_Title";
		case EActivityMainSubViewNewType.Recommend:
			return "Regress_Recommend_Title";
		case EActivityMainSubViewNewType.DoubleDrop:
			return "Regress_DoubleDrop_Title";
		case EActivityMainSubViewNewType.Adventure:
			return "Regress_Adventure_Title";
		case EActivityMainSubViewNewType.RoleGachaPool:
			return "Regress_NewVersion_Role_Title";
		case EActivityMainSubViewNewType.MainLine:
			return "Regress_NewVersion_MainLine_Title";
		case EActivityMainSubViewNewType.Sign:
			return "Regress_Sign_Title";
		default:
			return null;
		}
	}

	// Token: 0x06006739 RID: 26425 RVA: 0x00204B3C File Offset: 0x00202D3C
	[NullableContext(2)]
	private string GetTitleIconPath()
	{
		EActivityMainSubViewNewType? currentSubViewType = this.CurrentSubViewType;
		if (currentSubViewType != null)
		{
			switch (currentSubViewType.GetValueOrDefault())
			{
			case EActivityMainSubViewNewType.BattlePass:
				return "SP_IconCircumfluence1";
			case EActivityMainSubViewNewType.Recommend:
				return "SP_IconTab01";
			case EActivityMainSubViewNewType.DoubleDrop:
				return "SP_IconCircumfluence3";
			case EActivityMainSubViewNewType.Adventure:
				return "SP_IconBeginnerDev";
			case EActivityMainSubViewNewType.RoleGachaPool:
				return "SP_IconComDrawcard";
			case EActivityMainSubViewNewType.MainLine:
				return "SP_FuncIconRenwu";
			case EActivityMainSubViewNewType.Sign:
				return "SP_IconCircumfluence1";
			}
		}
		return null;
	}

	// Token: 0x0600673A RID: 26426 RVA: 0x00204BB0 File Offset: 0x00202DB0
	private void OnActivityUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x0600673B RID: 26427 RVA: 0x00204BB8 File Offset: 0x00202DB8
	private void RefreshView()
	{
		ActivityRegressMainSubViewBase activityRegressMainSubViewBase;
		if (this.CurrentSubViewType != null && this.SubViewMap.TryGetValue(this.CurrentSubViewType.Value, out activityRegressMainSubViewBase))
		{
			activityRegressMainSubViewBase.Update(0);
		}
	}

	// Token: 0x0600673C RID: 26428 RVA: 0x00204BF4 File Offset: 0x00202DF4
	private UniTask CreateTabs()
	{
		ActivityRegressMainView.<CreateTabs>d__33 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<ActivityRegressMainView.<CreateTabs>d__33>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600673D RID: 26429 RVA: 0x00204C38 File Offset: 0x00202E38
	private UniTask RefreshTabs()
	{
		ActivityRegressMainView.<RefreshTabs>d__34 <RefreshTabs>d__;
		<RefreshTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabs>d__.<>4__this = this;
		<RefreshTabs>d__.<>1__state = -1;
		<RefreshTabs>d__.<>t__builder.Start<ActivityRegressMainView.<RefreshTabs>d__34>(ref <RefreshTabs>d__);
		return <RefreshTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600673E RID: 26430 RVA: 0x00204C7B File Offset: 0x00202E7B
	private ActivityRegressTabItemPanel ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabItemPanel();
	}

	// Token: 0x0600673F RID: 26431 RVA: 0x00204C82 File Offset: 0x00202E82
	private void OnTabSelected(int index)
	{
		if (this.IgnoreFireEvent)
		{
			this.IgnoreFireEvent = false;
			return;
		}
		this.LastClickTime = Time.Instance.Now;
		this.ChangeSubUi(this.TabTypeList[index], 0).Forget();
	}

	// Token: 0x06006740 RID: 26432 RVA: 0x00204CBC File Offset: 0x00202EBC
	private CommonTabData GetCommonData(int index)
	{
		EActivityMainSubViewNewType type = this.TabTypeList[index];
		string textId = this.GetTypeTitle(type) ?? "";
		string typeTitleIconPath = this.GetTypeTitleIconPath(type);
		return new CommonTabData((typeTitleIconPath != null) ? UiResourceConfig.Instance.GetResourcePath(typeTitleIconPath) : "", new CommonTabTitleData(textId, Array.Empty<object>()), null);
	}

	// Token: 0x06006741 RID: 26433 RVA: 0x00204D18 File Offset: 0x00202F18
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int num = 600;
		return this.LastClickTime == 0.0 || Time.Instance.Now - this.LastClickTime >= (double)num;
	}

	// Token: 0x04004221 RID: 16929
	private const int TAB_CD = 600;

	// Token: 0x04004222 RID: 16930
	[Nullable(2)]
	private ActivityBaseData ActivityData;

	// Token: 0x04004223 RID: 16931
	private EActivityRegressMainViewOpenDataType OpenType;

	// Token: 0x04004224 RID: 16932
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04004225 RID: 16933
	private readonly Dictionary<EActivityMainSubViewNewType, ActivityRegressMainSubViewBase> SubViewMap = new Dictionary<EActivityMainSubViewNewType, ActivityRegressMainSubViewBase>();

	// Token: 0x04004226 RID: 16934
	private EActivityMainSubViewNewType? CurrentSubViewType;

	// Token: 0x04004227 RID: 16935
	[Nullable(2)]
	private ActivityRegressMainCaptionListPanel CaptionTabComponent;

	// Token: 0x04004228 RID: 16936
	private List<EActivityMainSubViewNewType> TabTypeList = new List<EActivityMainSubViewNewType>();

	// Token: 0x04004229 RID: 16937
	private bool IgnoreFireEvent;

	// Token: 0x0400422A RID: 16938
	private string RemainTimeText = "";

	// Token: 0x0400422B RID: 16939
	private double LastClickTime;

	// Token: 0x02006C15 RID: 27669
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023855 RID: 145493
		public const int CaptionNameList = 0;

		// Token: 0x04023856 RID: 145494
		public const int Bg = 1;

		// Token: 0x04023857 RID: 145495
		public const int SubViewRoot = 2;

		// Token: 0x04023858 RID: 145496
		public const int Bg2 = 3;

		// Token: 0x04023859 RID: 145497
		public const int TimeItem = 4;

		// Token: 0x0402385A RID: 145498
		public const int TimeText = 5;
	}
}
