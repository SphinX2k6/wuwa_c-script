using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001442 RID: 5186
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressNewVersionMainView : UiViewBase
{
	// Token: 0x06009273 RID: 37491 RVA: 0x001F5F60 File Offset: 0x001F4160
	public ActivityRegressNewVersionMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06009274 RID: 37492 RVA: 0x001F5F80 File Offset: 0x001F4180
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06009275 RID: 37493 RVA: 0x001F6008 File Offset: 0x001F4208
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressNewVersionMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009276 RID: 37494 RVA: 0x001F604B File Offset: 0x001F424B
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06009277 RID: 37495 RVA: 0x001F605C File Offset: 0x001F425C
	private UniTask CreateTabs()
	{
		ActivityRegressNewVersionMainView.<CreateTabs>d__11 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<CreateTabs>d__11>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x06009278 RID: 37496 RVA: 0x001F60A0 File Offset: 0x001F42A0
	private UniTask RefreshTabs()
	{
		ActivityRegressNewVersionMainView.<RefreshTabs>d__12 <RefreshTabs>d__;
		<RefreshTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabs>d__.<>4__this = this;
		<RefreshTabs>d__.<>1__state = -1;
		<RefreshTabs>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<RefreshTabs>d__12>(ref <RefreshTabs>d__);
		return <RefreshTabs>d__.<>t__builder.Task;
	}

	// Token: 0x06009279 RID: 37497 RVA: 0x001F60E3 File Offset: 0x001F42E3
	private ActivityRegressTabItemPanel ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabItemPanel();
	}

	// Token: 0x0600927A RID: 37498 RVA: 0x001F60EA File Offset: 0x001F42EA
	private void OnTabSelected(int index)
	{
		this.LastClickTime = Time.Instance.Now;
		this.ChangeSubUi(this.TabTypeList[index], 0);
	}

	// Token: 0x0600927B RID: 37499 RVA: 0x001F6110 File Offset: 0x001F4310
	private UniTask ChangeSubUi(EActivityNewVersionSubViewType subViewType, int subTabIndex = 0)
	{
		ActivityRegressNewVersionMainView.<ChangeSubUi>d__15 <ChangeSubUi>d__;
		<ChangeSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeSubUi>d__.<>4__this = this;
		<ChangeSubUi>d__.subViewType = subViewType;
		<ChangeSubUi>d__.subTabIndex = subTabIndex;
		<ChangeSubUi>d__.<>1__state = -1;
		<ChangeSubUi>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<ChangeSubUi>d__15>(ref <ChangeSubUi>d__);
		return <ChangeSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x0600927C RID: 37500 RVA: 0x001F6164 File Offset: 0x001F4364
	private void UpdateTitle()
	{
		if (this.CurrentSubViewType == null)
		{
			return;
		}
		string textId = this.GetTypeTitle(this.CurrentSubViewType.Value) ?? "";
		string text = this.GetTypeTitleIconPath(this.CurrentSubViewType.Value) ?? "";
		string iconPath = (text != null && text != "") ? UiResourceConfig.Instance.GetResourcePath(text) : "";
		this.CaptionTabComponent.UpdateTitle(iconPath, new CommonTabTitleData(textId, Array.Empty<object>()));
	}

	// Token: 0x0600927D RID: 37501 RVA: 0x001F61F0 File Offset: 0x001F43F0
	private UniTask OpenSubUi(EActivityNewVersionSubViewType viewType, int subTabIndex)
	{
		ActivityRegressNewVersionMainView.<OpenSubUi>d__17 <OpenSubUi>d__;
		<OpenSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSubUi>d__.<>4__this = this;
		<OpenSubUi>d__.viewType = viewType;
		<OpenSubUi>d__.<>1__state = -1;
		<OpenSubUi>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<OpenSubUi>d__17>(ref <OpenSubUi>d__);
		return <OpenSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x0600927E RID: 37502 RVA: 0x001F623C File Offset: 0x001F443C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<UiPanelBase> CreateSubUi(EActivityNewVersionSubViewType viewType)
	{
		ActivityRegressNewVersionMainView.<CreateSubUi>d__18 <CreateSubUi>d__;
		<CreateSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPanelBase>.Create();
		<CreateSubUi>d__.<>4__this = this;
		<CreateSubUi>d__.viewType = viewType;
		<CreateSubUi>d__.<>1__state = -1;
		<CreateSubUi>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<CreateSubUi>d__18>(ref <CreateSubUi>d__);
		return <CreateSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x0600927F RID: 37503 RVA: 0x001F6288 File Offset: 0x001F4488
	private UniTask HideSubUi(EActivityNewVersionSubViewType viewType)
	{
		ActivityRegressNewVersionMainView.<HideSubUi>d__19 <HideSubUi>d__;
		<HideSubUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideSubUi>d__.<>4__this = this;
		<HideSubUi>d__.viewType = viewType;
		<HideSubUi>d__.<>1__state = -1;
		<HideSubUi>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<HideSubUi>d__19>(ref <HideSubUi>d__);
		return <HideSubUi>d__.<>t__builder.Task;
	}

	// Token: 0x06009280 RID: 37504 RVA: 0x001F62D4 File Offset: 0x001F44D4
	private CommonTabData GetCommonData(int index)
	{
		EActivityNewVersionSubViewType type = this.TabTypeList[index];
		string textId = this.GetTypeTitle(type) ?? "";
		string typeTitleIconPath = this.GetTypeTitleIconPath(type);
		return new CommonTabData((typeTitleIconPath != null && typeTitleIconPath != "") ? UiResourceConfig.Instance.GetResourcePath(typeTitleIconPath) : "", new CommonTabTitleData(textId, Array.Empty<object>()), null);
	}

	// Token: 0x06009281 RID: 37505 RVA: 0x001F633A File Offset: 0x001F453A
	[NullableContext(2)]
	private string GetTypeTitle(EActivityNewVersionSubViewType type)
	{
		if (type == EActivityNewVersionSubViewType.RoleGachaPool)
		{
			return "Regress_NewVersion_Role_Title";
		}
		if (type != EActivityNewVersionSubViewType.MainLine)
		{
			return null;
		}
		return "Regress_NewVersion_MainLine_Title";
	}

	// Token: 0x06009282 RID: 37506 RVA: 0x001F6352 File Offset: 0x001F4552
	[NullableContext(2)]
	private string GetTypeTitleIconPath(EActivityNewVersionSubViewType type)
	{
		if (type == EActivityNewVersionSubViewType.RoleGachaPool)
		{
			return "SP_IconComDrawcard";
		}
		if (type != EActivityNewVersionSubViewType.MainLine)
		{
			return null;
		}
		return "SP_FuncIconRenwu";
	}

	// Token: 0x06009283 RID: 37507 RVA: 0x001F636C File Offset: 0x001F456C
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int num = 600;
		return this.LastClickTime == 0.0 || Time.Instance.Now - this.LastClickTime >= (double)num;
	}

	// Token: 0x040040E3 RID: 16611
	private const int TAB_CD = 600;

	// Token: 0x040040E4 RID: 16612
	private readonly Dictionary<EActivityNewVersionSubViewType, UiPanelBase> SubViewMap = new Dictionary<EActivityNewVersionSubViewType, UiPanelBase>();

	// Token: 0x040040E5 RID: 16613
	private EActivityNewVersionSubViewType? CurrentSubViewType;

	// Token: 0x040040E6 RID: 16614
	private readonly List<EActivityNewVersionSubViewType> TabTypeList = new List<EActivityNewVersionSubViewType>();

	// Token: 0x040040E7 RID: 16615
	[Nullable(2)]
	private ActivityRegressMainCaptionListPanel CaptionTabComponent;

	// Token: 0x040040E8 RID: 16616
	private double LastClickTime;

	// Token: 0x02007A70 RID: 31344
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028498 RID: 165016
		public const int CaptionNameList = 0;

		// Token: 0x04028499 RID: 165017
		public const int Bg = 1;

		// Token: 0x0402849A RID: 165018
		public const int SubViewRoot = 2;

		// Token: 0x0402849B RID: 165019
		public const int Bg2 = 3;

		// Token: 0x0402849C RID: 165020
		public const int TitleItem = 4;
	}
}
