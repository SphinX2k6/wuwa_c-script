using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011A1 RID: 4513
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001233 RID: 4659
	// (get) Token: 0x0600B41A RID: 46106 RVA: 0x0035323D File Offset: 0x0035143D
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.MotorcycleArrowBattle);
		}
	}

	// Token: 0x0600B41B RID: 46107 RVA: 0x00353248 File Offset: 0x00351448
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowMainViewProxy.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B41C RID: 46108 RVA: 0x0035328B File Offset: 0x0035148B
	protected override void OnBeforeDestroy()
	{
		this.RemoveScreenEffectFightRoot();
	}

	// Token: 0x0600B41D RID: 46109 RVA: 0x00353294 File Offset: 0x00351494
	private UniTask CreateFightInfoPanel()
	{
		MotorcycleArrowMainViewProxy.<CreateFightInfoPanel>d__8 <CreateFightInfoPanel>d__;
		<CreateFightInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFightInfoPanel>d__.<>4__this = this;
		<CreateFightInfoPanel>d__.<>1__state = -1;
		<CreateFightInfoPanel>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateFightInfoPanel>d__8>(ref <CreateFightInfoPanel>d__);
		return <CreateFightInfoPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B41E RID: 46110 RVA: 0x003532D8 File Offset: 0x003514D8
	private UniTask CreateDesktopSkillPanel()
	{
		MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanel>d__9 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanel>d__9>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B41F RID: 46111 RVA: 0x0035331C File Offset: 0x0035151C
	private UniTask CreateMobileSkillPanel()
	{
		MotorcycleArrowMainViewProxy.<CreateMobileSkillPanel>d__10 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateMobileSkillPanel>d__10>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B420 RID: 46112 RVA: 0x00353360 File Offset: 0x00351560
	private UniTask CreateMobileSkillPanelInner()
	{
		MotorcycleArrowMainViewProxy.<CreateMobileSkillPanelInner>d__11 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateMobileSkillPanelInner>d__11>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B421 RID: 46113 RVA: 0x003533A4 File Offset: 0x003515A4
	private UniTask CreateDesktopSkillPanelInner()
	{
		MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanelInner>d__12 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanelInner>d__12>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B422 RID: 46114 RVA: 0x003533E8 File Offset: 0x003515E8
	protected override void OnAfterShow()
	{
		this.FightInfoPanel.Show(null);
		MotorcycleArrowSkillPanel mobileSkillPanel = this.MobileSkillPanel;
		if (mobileSkillPanel != null)
		{
			mobileSkillPanel.Show(null);
		}
		MotorcycleArrowSkillPanel desktopSkillPanel = this.DesktopSkillPanel;
		if (desktopSkillPanel != null)
		{
			desktopSkillPanel.Show(null);
		}
		BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.MotorcycleMobileSkillButton, false, true, 0);
	}

	// Token: 0x0600B423 RID: 46115 RVA: 0x0035343C File Offset: 0x0035163C
	protected override void OnAfterHide()
	{
		this.FightInfoPanel.Hide(null);
		MotorcycleArrowSkillPanel mobileSkillPanel = this.MobileSkillPanel;
		if (mobileSkillPanel != null)
		{
			mobileSkillPanel.Hide(null);
		}
		MotorcycleArrowSkillPanel desktopSkillPanel = this.DesktopSkillPanel;
		if (desktopSkillPanel != null)
		{
			desktopSkillPanel.Hide(null);
		}
		BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.MotorcycleMobileSkillButton, true, true, 0);
	}

	// Token: 0x0600B424 RID: 46116 RVA: 0x00353490 File Offset: 0x00351690
	private void AddScreenEffectFightRoot()
	{
		BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
		if (!instance.IsValid())
		{
			return;
		}
		AUIContainerActor screenEffectFightRoot = null;
		instance.GetScreenEffectFightRoot(ref screenEffectFightRoot);
		this.ScreenEffectFightRoot = screenEffectFightRoot;
		AUIContainerActor screenEffectFightRoot2 = this.ScreenEffectFightRoot;
		if (screenEffectFightRoot2 != null)
		{
			screenEffectFightRoot2.K2_AttachRootComponentTo(this.View.GetContentPanel(), default(FName), EAttachLocation.KeepRelativeOffset, true);
		}
		ScreenEffectModel.Instance.SetFightRootInited(true);
	}

	// Token: 0x0600B425 RID: 46117 RVA: 0x003534EF File Offset: 0x003516EF
	private void RemoveScreenEffectFightRoot()
	{
		AUIContainerActor screenEffectFightRoot = this.ScreenEffectFightRoot;
		if (screenEffectFightRoot != null && screenEffectFightRoot.IsValid())
		{
			this.ScreenEffectFightRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		this.ScreenEffectFightRoot = null;
		ScreenEffectModel instance = ScreenEffectModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SetFightRootInited(false);
	}

	// Token: 0x0600B426 RID: 46118 RVA: 0x0035352C File Offset: 0x0035172C
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "sword_skill"))
		{
			return null;
		}
		if (Info.Instance.IsInTouch())
		{
			MotorcycleArrowSkillPanel mobileSkillPanel = this.MobileSkillPanel;
			if (mobileSkillPanel == null)
			{
				return null;
			}
			return mobileSkillPanel.GetSkillGuideItem();
		}
		else
		{
			MotorcycleArrowSkillPanel desktopSkillPanel = this.DesktopSkillPanel;
			if (desktopSkillPanel == null)
			{
				return null;
			}
			return desktopSkillPanel.GetSkillGuideItem();
		}
	}

	// Token: 0x040067F8 RID: 26616
	[Nullable(1)]
	public MotorcycleArrowBattleMain FightInfoPanel;

	// Token: 0x040067F9 RID: 26617
	public MotorcycleArrowSkillPanel MobileSkillPanel;

	// Token: 0x040067FA RID: 26618
	public MotorcycleArrowSkillPanel DesktopSkillPanel;

	// Token: 0x040067FB RID: 26619
	private AUIContainerActor ScreenEffectFightRoot;
}
