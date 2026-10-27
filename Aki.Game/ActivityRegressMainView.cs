using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200146D RID: 5229
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressMainView : UiViewBase
{
	// Token: 0x06009391 RID: 37777 RVA: 0x001FB70D File Offset: 0x001F990D
	public ActivityRegressMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009392 RID: 37778 RVA: 0x001FB738 File Offset: 0x001F9938
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

	// Token: 0x06009393 RID: 37779 RVA: 0x001FB7D4 File Offset: 0x001F99D4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009394 RID: 37780 RVA: 0x001FB818 File Offset: 0x001F9A18
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

	// Token: 0x06009395 RID: 37781 RVA: 0x001FB8C0 File Offset: 0x001F9AC0
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

	// Token: 0x06009396 RID: 37782 RVA: 0x001FB916 File Offset: 0x001F9B16
	private void OnTimerRefresh(float _)
	{
		this.RefreshTime();
	}

	// Token: 0x06009397 RID: 37783 RVA: 0x001FB91E File Offset: 0x001F9B1E
	private void ClearTimer()
	{
		if (this.RefreshTimer != null && TimerSystem.Instance.Has(this.RefreshTimer))
		{
			TimerSystem.Instance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x06009398 RID: 37784 RVA: 0x001FB954 File Offset: 0x001F9B54
	protected override void OnAfterHide()
	{
		this.ClearTimer();
		ActivityRegressMainSubViewBase activityRegressMainSubViewBase;
		if (this.CurrentSubViewType != null && this.SubViewMap.TryGetValue(this.CurrentSubViewType.Value, out activityRegressMainSubViewBase))
		{
			activityRegressMainSubViewBase.SetActive(false);
		}
	}

	// Token: 0x06009399 RID: 37785 RVA: 0x001FB998 File Offset: 0x001F9B98
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

	// Token: 0x0600939A RID: 37786 RVA: 0x001FBA18 File Offset: 0x001F9C18
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x0600939B RID: 37787 RVA: 0x001FBA36 File Offset: 0x001F9C36
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x0600939C RID: 37788 RVA: 0x001FBA54 File Offset: 0x001F9C54
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

	// Token: 0x0600939D RID: 37789 RVA: 0x001FBAA8 File Offset: 0x001F9CA8
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

	// Token: 0x0600939E RID: 37790 RVA: 0x001FBAF4 File Offset: 0x001F9CF4
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

	// Token: 0x0600939F RID: 37791 RVA: 0x001FBB64 File Offset: 0x001F9D64
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

	// Token: 0x060093A0 RID: 37792 RVA: 0x001FBBB0 File Offset: 0x001F9DB0
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

	// Token: 0x060093A1 RID: 37793 RVA: 0x001FBC04 File Offset: 0x001F9E04
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

	// Token: 0x060093A2 RID: 37794 RVA: 0x001FBC7C File Offset: 0x001F9E7C
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

	// Token: 0x060093A3 RID: 37795 RVA: 0x001FBCD8 File Offset: 0x001F9ED8
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

	// Token: 0x060093A4 RID: 37796 RVA: 0x001FBD34 File Offset: 0x001F9F34
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

	// Token: 0x060093A5 RID: 37797 RVA: 0x001FBDA8 File Offset: 0x001F9FA8
	private void OnActivityUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x060093A6 RID: 37798 RVA: 0x001FBDB0 File Offset: 0x001F9FB0
	private void RefreshView()
	{
		ActivityRegressMainSubViewBase activityRegressMainSubViewBase;
		if (this.CurrentSubViewType != null && this.SubViewMap.TryGetValue(this.CurrentSubViewType.Value, out activityRegressMainSubViewBase))
		{
			activityRegressMainSubViewBase.Update(0);
		}
	}

	// Token: 0x060093A7 RID: 37799 RVA: 0x001FBDEC File Offset: 0x001F9FEC
	private UniTask CreateTabs()
	{
		ActivityRegressMainView.<CreateTabs>d__33 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<ActivityRegressMainView.<CreateTabs>d__33>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x060093A8 RID: 37800 RVA: 0x001FBE30 File Offset: 0x001FA030
	private UniTask RefreshTabs()
	{
		ActivityRegressMainView.<RefreshTabs>d__34 <RefreshTabs>d__;
		<RefreshTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabs>d__.<>4__this = this;
		<RefreshTabs>d__.<>1__state = -1;
		<RefreshTabs>d__.<>t__builder.Start<ActivityRegressMainView.<RefreshTabs>d__34>(ref <RefreshTabs>d__);
		return <RefreshTabs>d__.<>t__builder.Task;
	}

	// Token: 0x060093A9 RID: 37801 RVA: 0x001FBE73 File Offset: 0x001FA073
	private ActivityRegressTabItemPanel ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabItemPanel();
	}

	// Token: 0x060093AA RID: 37802 RVA: 0x001FBE7A File Offset: 0x001FA07A
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

	// Token: 0x060093AB RID: 37803 RVA: 0x001FBEB4 File Offset: 0x001FA0B4
	private CommonTabData GetCommonData(int index)
	{
		EActivityMainSubViewNewType type = this.TabTypeList[index];
		string textId = this.GetTypeTitle(type) ?? "";
		string typeTitleIconPath = this.GetTypeTitleIconPath(type);
		return new CommonTabData((typeTitleIconPath != null) ? UiResourceConfig.Instance.GetResourcePath(typeTitleIconPath) : "", new CommonTabTitleData(textId, Array.Empty<object>()), null);
	}

	// Token: 0x060093AC RID: 37804 RVA: 0x001FBF10 File Offset: 0x001FA110
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int num = 600;
		return this.LastClickTime == 0.0 || Time.Instance.Now - this.LastClickTime >= (double)num;
	}

	// Token: 0x04004189 RID: 16777
	private const int TAB_CD = 600;

	// Token: 0x0400418A RID: 16778
	[Nullable(2)]
	private ActivityBaseData ActivityData;

	// Token: 0x0400418B RID: 16779
	private EActivityRegressMainViewOpenDataType OpenType;

	// Token: 0x0400418C RID: 16780
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x0400418D RID: 16781
	private readonly Dictionary<EActivityMainSubViewNewType, ActivityRegressMainSubViewBase> SubViewMap = new Dictionary<EActivityMainSubViewNewType, ActivityRegressMainSubViewBase>();

	// Token: 0x0400418E RID: 16782
	private EActivityMainSubViewNewType? CurrentSubViewType;

	// Token: 0x0400418F RID: 16783
	[Nullable(2)]
	private ActivityRegressMainCaptionListPanel CaptionTabComponent;

	// Token: 0x04004190 RID: 16784
	private List<EActivityMainSubViewNewType> TabTypeList = new List<EActivityMainSubViewNewType>();

	// Token: 0x04004191 RID: 16785
	private bool IgnoreFireEvent;

	// Token: 0x04004192 RID: 16786
	private string RemainTimeText = "";

	// Token: 0x04004193 RID: 16787
	private double LastClickTime;

	// Token: 0x02007A91 RID: 31377
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402853B RID: 165179
		public const int CaptionNameList = 0;

		// Token: 0x0402853C RID: 165180
		public const int Bg = 1;

		// Token: 0x0402853D RID: 165181
		public const int SubViewRoot = 2;

		// Token: 0x0402853E RID: 165182
		public const int Bg2 = 3;

		// Token: 0x0402853F RID: 165183
		public const int TimeItem = 4;

		// Token: 0x04028540 RID: 165184
		public const int TimeText = 5;
	}
}
