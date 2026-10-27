using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025AF RID: 9647
public class FightPhotographView : PhotographView
{
	// Token: 0x060138DD RID: 80093 RVA: 0x004E2E80 File Offset: 0x004E1080
	[NullableContext(1)]
	public FightPhotographView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060138DE RID: 80094 RVA: 0x004E2E8C File Offset: 0x004E108C
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotographView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotographView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060138DF RID: 80095 RVA: 0x004E2ECF File Offset: 0x004E10CF
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		FightPhotoModel.Instance.RefreshTabList();
		base.RefreshFightPhotoOptionTab();
	}

	// Token: 0x060138E0 RID: 80096 RVA: 0x004E2EE8 File Offset: 0x004E10E8
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ColorAdjustOpenMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		RenderModuleModel instance = RenderModuleModel.Instance;
		if (instance != null)
		{
			instance.EnableForceTickCharRenderShell("FightPhotographView OnAfterShow");
		}
		AudioSystem.Instance.SetState("game_sys_fightphoto", "pause", true);
		this.TryAddTag();
	}

	// Token: 0x060138E1 RID: 80097 RVA: 0x004E2F3E File Offset: 0x004E113E
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.AccumulateColorAdjustDuration();
	}

	// Token: 0x060138E2 RID: 80098 RVA: 0x004E2F4C File Offset: 0x004E114C
	private void AccumulateColorAdjustDuration()
	{
		if (this.ColorAdjustOpenMs > 0L)
		{
			FightPhotoController instance = FightPhotoController.Instance;
			if (instance != null)
			{
				instance.AddColorAdjustDuration(DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.ColorAdjustOpenMs);
			}
			this.ColorAdjustOpenMs = 0L;
		}
	}

	// Token: 0x060138E3 RID: 80099 RVA: 0x004E2F8F File Offset: 0x004E118F
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
	}

	// Token: 0x060138E4 RID: 80100 RVA: 0x004E2FB4 File Offset: 0x004E11B4
	protected override void OnAfterTick(float delta)
	{
		base.RefreshFightPhotoMissionState();
		if (PhotographController.Instance.CurrentBtNode == null || this.IsFinishTask)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null && uiViewSequence.HasSequenceNameInPlaying("Loop"))
			{
				this.UiViewSequence.StopSequenceByKey("Loop", false, true);
			}
			return;
		}
		bool flag = PhotographController.Instance.IsSatisfyAllConditions();
		if (this.LastStatus == flag)
		{
			return;
		}
		this.LastStatus = flag;
		if (flag)
		{
			this.UiViewSequence.PlaySequence("ShowChanging", false, null);
			this.UiViewSequence.PlaySequence("Loop", false, null);
			return;
		}
		this.UiViewSequence.StopSequenceByKey("Loop", false, true);
	}

	// Token: 0x060138E5 RID: 80101 RVA: 0x004E306D File Offset: 0x004E126D
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
	}

	// Token: 0x060138E6 RID: 80102 RVA: 0x004E3094 File Offset: 0x004E1294
	protected override void OnBeforeDestroy()
	{
		this.AccumulateColorAdjustDuration();
		RenderModuleModel instance = RenderModuleModel.Instance;
		if (instance != null)
		{
			instance.DisableForceTickCharRenderShell("FightPhotographView OnBeforeDestroy");
		}
		AudioSystem.Instance.SetState("game_sys_fightphoto", "none", true);
		this.TryRemoveTag();
		PhotographController.SetFightPhotographSetupOption(EFightPhotoSetupOptionType.TiltAngle, 0, true);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.DLSS.EnableFixDof 0", null);
		base.OnBeforeDestroy();
	}

	// Token: 0x060138E7 RID: 80103 RVA: 0x004E30F8 File Offset: 0x004E12F8
	private void TryAddTag()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid || getCurrentEntity.Entity == null || !getCurrentEntity.Entity.Valid)
		{
			return;
		}
		BaseTagComponent component = getCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component != null && !component.HasTag(GameplayTagDefine.EGameplayTagId["系统.活动.拍照活动.虚化调整子镜头"]))
		{
			component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["系统.活动.拍照活动.虚化调整子镜头"]));
		}
	}

	// Token: 0x060138E8 RID: 80104 RVA: 0x004E3174 File Offset: 0x004E1374
	private void TryRemoveTag()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid || getCurrentEntity.Entity == null || !getCurrentEntity.Entity.Valid)
		{
			return;
		}
		BaseTagComponent component = getCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["系统.活动.拍照活动.虚化调整子镜头"]))
		{
			component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["系统.活动.拍照活动.虚化调整子镜头"]));
		}
	}

	// Token: 0x060138E9 RID: 80105 RVA: 0x004E31EE File Offset: 0x004E13EE
	private void OnFightPhotoTaskFinish()
	{
		this.IsFinishTask = true;
	}

	// Token: 0x060138EA RID: 80106 RVA: 0x004E31F7 File Offset: 0x004E13F7
	protected override void OnBackButtonClicked()
	{
		if (PhotographController.Instance.IsFightPhotoCanSettle())
		{
			UiManager.Instance.OpenView(EUiViewName.FightPhotoResultView, null, null);
			return;
		}
		PhotographController.Instance.CloseFightPhotographMode();
		FilterSettingController.Instance.ApplyFilterSetting();
	}

	// Token: 0x040093B3 RID: 37811
	private bool IsFinishTask;

	// Token: 0x040093B4 RID: 37812
	private bool LastStatus;

	// Token: 0x040093B5 RID: 37813
	private long ColorAdjustOpenMs;
}
