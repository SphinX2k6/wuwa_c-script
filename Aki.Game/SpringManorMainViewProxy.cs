using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001D18 RID: 7448
[NullableContext(2)]
[Nullable(0)]
public class SpringManorMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001217 RID: 4631
	// (get) Token: 0x0600E140 RID: 57664 RVA: 0x0034DA44 File Offset: 0x0034BC44
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return null;
		}
	}

	// Token: 0x0600E141 RID: 57665 RVA: 0x0034DA5C File Offset: 0x0034BC5C
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorMainViewProxy.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorMainViewProxy.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E142 RID: 57666 RVA: 0x0034DAA0 File Offset: 0x0034BCA0
	private UniTask CreateMainHudPanel()
	{
		SpringManorMainViewProxy.<CreateMainHudPanel>d__6 <CreateMainHudPanel>d__;
		<CreateMainHudPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMainHudPanel>d__.<>4__this = this;
		<CreateMainHudPanel>d__.<>1__state = -1;
		<CreateMainHudPanel>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateMainHudPanel>d__6>(ref <CreateMainHudPanel>d__);
		return <CreateMainHudPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E143 RID: 57667 RVA: 0x0034DAE4 File Offset: 0x0034BCE4
	private UniTask CreateMobileBtnPanel()
	{
		SpringManorMainViewProxy.<CreateMobileBtnPanel>d__7 <CreateMobileBtnPanel>d__;
		<CreateMobileBtnPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileBtnPanel>d__.<>4__this = this;
		<CreateMobileBtnPanel>d__.<>1__state = -1;
		<CreateMobileBtnPanel>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateMobileBtnPanel>d__7>(ref <CreateMobileBtnPanel>d__);
		return <CreateMobileBtnPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E144 RID: 57668 RVA: 0x0034DB28 File Offset: 0x0034BD28
	private UniTask CreateDesktopBtnPanel()
	{
		SpringManorMainViewProxy.<CreateDesktopBtnPanel>d__8 <CreateDesktopBtnPanel>d__;
		<CreateDesktopBtnPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopBtnPanel>d__.<>4__this = this;
		<CreateDesktopBtnPanel>d__.<>1__state = -1;
		<CreateDesktopBtnPanel>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateDesktopBtnPanel>d__8>(ref <CreateDesktopBtnPanel>d__);
		return <CreateDesktopBtnPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E145 RID: 57669 RVA: 0x0034DB6C File Offset: 0x0034BD6C
	private UniTask CreateMobileSkillPanelInner()
	{
		SpringManorMainViewProxy.<CreateMobileSkillPanelInner>d__9 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateMobileSkillPanelInner>d__9>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E146 RID: 57670 RVA: 0x0034DBB0 File Offset: 0x0034BDB0
	private UniTask CreateDesktopSkillPanelInner()
	{
		SpringManorMainViewProxy.<CreateDesktopSkillPanelInner>d__10 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateDesktopSkillPanelInner>d__10>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x04006801 RID: 26625
	[Nullable(1)]
	public SpringManorMainHudPanel MainHudPanel;

	// Token: 0x04006802 RID: 26626
	public SpringManorSkillPanel MobileSkillPanel;

	// Token: 0x04006803 RID: 26627
	public SpringManorSkillPanel DesktopSkillPanel;
}
