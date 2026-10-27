using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CDF RID: 7391
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowMainViewProxy : GameMainViewProxy
{
	// Token: 0x17001209 RID: 4617
	// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x00347815 File Offset: 0x00345A15
	protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
	{
		get
		{
			return new EBattleUiCommonChildVisibleReason?(EBattleUiCommonChildVisibleReason.MotorcycleArrowBattle);
		}
	}

	// Token: 0x0600DFFE RID: 57342 RVA: 0x00347820 File Offset: 0x00345A20
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowMainViewProxy.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFFF RID: 57343 RVA: 0x00347863 File Offset: 0x00345A63
	protected override void OnBeforeDestroy()
	{
		this.RemoveScreenEffectFightRoot();
	}

	// Token: 0x0600E000 RID: 57344 RVA: 0x0034786C File Offset: 0x00345A6C
	private UniTask CreateFightInfoPanel()
	{
		MotorcycleArrowMainViewProxy.<CreateFightInfoPanel>d__8 <CreateFightInfoPanel>d__;
		<CreateFightInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFightInfoPanel>d__.<>4__this = this;
		<CreateFightInfoPanel>d__.<>1__state = -1;
		<CreateFightInfoPanel>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateFightInfoPanel>d__8>(ref <CreateFightInfoPanel>d__);
		return <CreateFightInfoPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E001 RID: 57345 RVA: 0x003478B0 File Offset: 0x00345AB0
	private UniTask CreateDesktopSkillPanel()
	{
		MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanel>d__9 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanel>d__9>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E002 RID: 57346 RVA: 0x003478F4 File Offset: 0x00345AF4
	private UniTask CreateMobileSkillPanel()
	{
		MotorcycleArrowMainViewProxy.<CreateMobileSkillPanel>d__10 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateMobileSkillPanel>d__10>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600E003 RID: 57347 RVA: 0x00347938 File Offset: 0x00345B38
	private UniTask CreateMobileSkillPanelInner()
	{
		MotorcycleArrowMainViewProxy.<CreateMobileSkillPanelInner>d__11 <CreateMobileSkillPanelInner>d__;
		<CreateMobileSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanelInner>d__.<>4__this = this;
		<CreateMobileSkillPanelInner>d__.<>1__state = -1;
		<CreateMobileSkillPanelInner>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateMobileSkillPanelInner>d__11>(ref <CreateMobileSkillPanelInner>d__);
		return <CreateMobileSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E004 RID: 57348 RVA: 0x0034797C File Offset: 0x00345B7C
	private UniTask CreateDesktopSkillPanelInner()
	{
		MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanelInner>d__12 <CreateDesktopSkillPanelInner>d__;
		<CreateDesktopSkillPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanelInner>d__.<>4__this = this;
		<CreateDesktopSkillPanelInner>d__.<>1__state = -1;
		<CreateDesktopSkillPanelInner>d__.<>t__builder.Start<MotorcycleArrowMainViewProxy.<CreateDesktopSkillPanelInner>d__12>(ref <CreateDesktopSkillPanelInner>d__);
		return <CreateDesktopSkillPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600E005 RID: 57349 RVA: 0x003479C0 File Offset: 0x00345BC0
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

	// Token: 0x0600E006 RID: 57350 RVA: 0x00347A14 File Offset: 0x00345C14
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

	// Token: 0x0600E007 RID: 57351 RVA: 0x00347A68 File Offset: 0x00345C68
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

	// Token: 0x0600E008 RID: 57352 RVA: 0x00347AC7 File Offset: 0x00345CC7
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

	// Token: 0x0600E009 RID: 57353 RVA: 0x00347B04 File Offset: 0x00345D04
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

	// Token: 0x04006719 RID: 26393
	[Nullable(1)]
	public MotorcycleArrowBattleMain FightInfoPanel;

	// Token: 0x0400671A RID: 26394
	public MotorcycleArrowSkillPanel MobileSkillPanel;

	// Token: 0x0400671B RID: 26395
	public MotorcycleArrowSkillPanel DesktopSkillPanel;

	// Token: 0x0400671C RID: 26396
	private AUIContainerActor ScreenEffectFightRoot;
}
