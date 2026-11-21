using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A9A RID: 6810
public class FightPhotographView : PhotographView
{
	// Token: 0x06010DBD RID: 69053 RVA: 0x004F1A80 File Offset: 0x004EFC80
	[NullableContext(1)]
	public FightPhotographView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010DBE RID: 69054 RVA: 0x004F1A8C File Offset: 0x004EFC8C
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotographView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotographView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010DBF RID: 69055 RVA: 0x004F1ACF File Offset: 0x004EFCCF
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		FightPhotoModel.Instance.RefreshTabList();
		base.RefreshFightPhotoOptionTab();
	}

	// Token: 0x06010DC0 RID: 69056 RVA: 0x004F1AE8 File Offset: 0x004EFCE8
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

	// Token: 0x06010DC1 RID: 69057 RVA: 0x004F1B3E File Offset: 0x004EFD3E
	protected override void OnAfterHide()
	{
		base.OnAfterHide();
		this.AccumulateColorAdjustDuration();
	}

	// Token: 0x06010DC2 RID: 69058 RVA: 0x004F1B4C File Offset: 0x004EFD4C
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

	// Token: 0x06010DC3 RID: 69059 RVA: 0x004F1B8F File Offset: 0x004EFD8F
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
	}

	// Token: 0x06010DC4 RID: 69060 RVA: 0x004F1BB4 File Offset: 0x004EFDB4
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

	// Token: 0x06010DC5 RID: 69061 RVA: 0x004F1C6D File Offset: 0x004EFE6D
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.NotifyBtFightPhotoTaskFinish, new Action(this.OnFightPhotoTaskFinish));
	}

	// Token: 0x06010DC6 RID: 69062 RVA: 0x004F1C94 File Offset: 0x004EFE94
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

	// Token: 0x06010DC7 RID: 69063 RVA: 0x004F1CF8 File Offset: 0x004EFEF8
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

	// Token: 0x06010DC8 RID: 69064 RVA: 0x004F1D74 File Offset: 0x004EFF74
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

	// Token: 0x06010DC9 RID: 69065 RVA: 0x004F1DEE File Offset: 0x004EFFEE
	private void OnFightPhotoTaskFinish()
	{
		this.IsFinishTask = true;
	}

	// Token: 0x06010DCA RID: 69066 RVA: 0x004F1DF7 File Offset: 0x004EFFF7
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

	// Token: 0x04009509 RID: 38153
	private bool IsFinishTask;

	// Token: 0x0400950A RID: 38154
	private bool LastStatus;

	// Token: 0x0400950B RID: 38155
	private long ColorAdjustOpenMs;
}
