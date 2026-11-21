using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020011DA RID: 4570
[NullableContext(2)]
[Nullable(0)]
public class SpringManorMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001241 RID: 4673
	// (get) Token: 0x0600B55D RID: 46429 RVA: 0x00359474 File Offset: 0x00357674
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return null;
		}
	}

	// Token: 0x0600B55E RID: 46430 RVA: 0x0035948C File Offset: 0x0035768C
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorMainViewProxy.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorMainViewProxy.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B55F RID: 46431 RVA: 0x003594D0 File Offset: 0x003576D0
	private UniTask CreateMainHudPanel()
	{
		SpringManorMainViewProxy.<CreateMainHudPanel>d__6 <CreateMainHudPanel>d__;
		<CreateMainHudPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMainHudPanel>d__.<>4__this = this;
		<CreateMainHudPanel>d__.<>1__state = -1;
		<CreateMainHudPanel>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateMainHudPanel>d__6>(ref <CreateMainHudPanel>d__);
		return <CreateMainHudPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B560 RID: 46432 RVA: 0x00359514 File Offset: 0x00357714
	private UniTask CreateMobileBtnPanel()
	{
		SpringManorMainViewProxy.<CreateMobileBtnPanel>d__7 <CreateMobileBtnPanel>d__;
		<CreateMobileBtnPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileBtnPanel>d__.<>4__this = this;
		<CreateMobileBtnPanel>d__.<>1__state = -1;
		<CreateMobileBtnPanel>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateMobileBtnPanel>d__7>(ref <CreateMobileBtnPanel>d__);
		return <CreateMobileBtnPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B561 RID: 46433 RVA: 0x00359558 File Offset: 0x00357758
	private UniTask CreateDesktopBtnPanel()
	{
		SpringManorMainViewProxy.<CreateDesktopBtnPanel>d__8 <CreateDesktopBtnPanel>d__;
		<CreateDesktopBtnPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopBtnPanel>d__.<>4__this = this;
		<CreateDesktopBtnPanel>d__.<>1__state = -1;
		<CreateDesktopBtnPanel>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateDesktopBtnPanel>d__8>(ref <CreateDesktopBtnPanel>d__);
		return <CreateDesktopBtnPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B562 RID: 46434 RVA: 0x0035959C File Offset: 0x0035779C
	private UniTask CreateMobileSkillPanelInner()
	{
		SpringManorMainViewProxy.<CreateMobileSkillPanelInner>d__9 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateMobileSkillPanelInner>d__9>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B563 RID: 46435 RVA: 0x003595E0 File Offset: 0x003577E0
	private UniTask CreateDesktopSkillPanelInner()
	{
		SpringManorMainViewProxy.<CreateDesktopSkillPanelInner>d__10 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<SpringManorMainViewProxy.<CreateDesktopSkillPanelInner>d__10>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x040068E0 RID: 26848
	[Nullable(1)]
	public SpringManorMainHudPanel MainHudPanel;

	// Token: 0x040068E1 RID: 26849
	public SpringManorSkillPanel MobileSkillPanel;

	// Token: 0x040068E2 RID: 26850
	public SpringManorSkillPanel DesktopSkillPanel;
}
