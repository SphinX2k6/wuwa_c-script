using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020008F6 RID: 2294
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressNewVersionMainView : UiViewBase
{
	// Token: 0x06006608 RID: 26120 RVA: 0x001FEA9C File Offset: 0x001FCC9C
	public ActivityRegressNewVersionMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006609 RID: 26121 RVA: 0x001FEABC File Offset: 0x001FCCBC
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

	// Token: 0x0600660A RID: 26122 RVA: 0x001FEB44 File Offset: 0x001FCD44
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressNewVersionMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600660B RID: 26123 RVA: 0x001FEB87 File Offset: 0x001FCD87
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x0600660C RID: 26124 RVA: 0x001FEB98 File Offset: 0x001FCD98
	private UniTask CreateTabs()
	{
		ActivityRegressNewVersionMainView.<CreateTabs>d__11 <CreateTabs>d__;
		<CreateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTabs>d__.<>4__this = this;
		<CreateTabs>d__.<>1__state = -1;
		<CreateTabs>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<CreateTabs>d__11>(ref <CreateTabs>d__);
		return <CreateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600660D RID: 26125 RVA: 0x001FEBDC File Offset: 0x001FCDDC
	private UniTask RefreshTabs()
	{
		ActivityRegressNewVersionMainView.<RefreshTabs>d__12 <RefreshTabs>d__;
		<RefreshTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabs>d__.<>4__this = this;
		<RefreshTabs>d__.<>1__state = -1;
		<RefreshTabs>d__.<>t__builder.Start<ActivityRegressNewVersionMainView.<RefreshTabs>d__12>(ref <RefreshTabs>d__);
		return <RefreshTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600660E RID: 26126 RVA: 0x001FEC1F File Offset: 0x001FCE1F
	private ActivityRegressTabItemPanel ProxyCreateTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabItemPanel();
	}

	// Token: 0x0600660F RID: 26127 RVA: 0x001FEC26 File Offset: 0x001FCE26
	private void OnTabSelected(int index)
	{
		this.LastClickTime = Time.Instance.Now;
		this.ChangeSubUi(this.TabTypeList[index], 0);
	}

	// Token: 0x06006610 RID: 26128 RVA: 0x001FEC4C File Offset: 0x001FCE4C
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

	// Token: 0x06006611 RID: 26129 RVA: 0x001FECA0 File Offset: 0x001FCEA0
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

	// Token: 0x06006612 RID: 26130 RVA: 0x001FED2C File Offset: 0x001FCF2C
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

	// Token: 0x06006613 RID: 26131 RVA: 0x001FED78 File Offset: 0x001FCF78
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

	// Token: 0x06006614 RID: 26132 RVA: 0x001FEDC4 File Offset: 0x001FCFC4
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

	// Token: 0x06006615 RID: 26133 RVA: 0x001FEE10 File Offset: 0x001FD010
	private CommonTabData GetCommonData(int index)
	{
		EActivityNewVersionSubViewType type = this.TabTypeList[index];
		string textId = this.GetTypeTitle(type) ?? "";
		string typeTitleIconPath = this.GetTypeTitleIconPath(type);
		return new CommonTabData((typeTitleIconPath != null && typeTitleIconPath != "") ? UiResourceConfig.Instance.GetResourcePath(typeTitleIconPath) : "", new CommonTabTitleData(textId, Array.Empty<object>()), null);
	}

	// Token: 0x06006616 RID: 26134 RVA: 0x001FEE76 File Offset: 0x001FD076
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

	// Token: 0x06006617 RID: 26135 RVA: 0x001FEE8E File Offset: 0x001FD08E
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

	// Token: 0x06006618 RID: 26136 RVA: 0x001FEEA8 File Offset: 0x001FD0A8
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int num = 600;
		return this.LastClickTime == 0.0 || Time.Instance.Now - this.LastClickTime >= (double)num;
	}

	// Token: 0x0400417B RID: 16763
	private const int TAB_CD = 600;

	// Token: 0x0400417C RID: 16764
	private readonly Dictionary<EActivityNewVersionSubViewType, UiPanelBase> SubViewMap = new Dictionary<EActivityNewVersionSubViewType, UiPanelBase>();

	// Token: 0x0400417D RID: 16765
	private EActivityNewVersionSubViewType? CurrentSubViewType;

	// Token: 0x0400417E RID: 16766
	private readonly List<EActivityNewVersionSubViewType> TabTypeList = new List<EActivityNewVersionSubViewType>();

	// Token: 0x0400417F RID: 16767
	[Nullable(2)]
	private ActivityRegressMainCaptionListPanel CaptionTabComponent;

	// Token: 0x04004180 RID: 16768
	private double LastClickTime;

	// Token: 0x02006BF4 RID: 27636
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040237B2 RID: 145330
		public const int CaptionNameList = 0;

		// Token: 0x040237B3 RID: 145331
		public const int Bg = 1;

		// Token: 0x040237B4 RID: 145332
		public const int SubViewRoot = 2;

		// Token: 0x040237B5 RID: 145333
		public const int Bg2 = 3;

		// Token: 0x040237B6 RID: 145334
		public const int TitleItem = 4;
	}
}
