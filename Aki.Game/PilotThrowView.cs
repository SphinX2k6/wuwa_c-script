using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001ACF RID: 6863
[NullableContext(1)]
[Nullable(0)]
public class PilotThrowView : UiTickViewBase, IUiProhibitRefreshData
{
	// Token: 0x06011069 RID: 69737 RVA: 0x00500E68 File Offset: 0x004FF068
	public PilotThrowView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601106A RID: 69738 RVA: 0x00500E7C File Offset: 0x004FF07C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBackBtnClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnLaunchBtnClick))
		};
	}

	// Token: 0x0601106B RID: 69739 RVA: 0x00500F40 File Offset: 0x004FF140
	protected override UniTask OnBeforeStartAsync()
	{
		PilotThrowView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PilotThrowView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601106C RID: 69740 RVA: 0x00500F84 File Offset: 0x004FF184
	protected override void OnStart()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayLevelSequenceByName("Number_In", false, null, false);
		}
		this.RegisterExtraUiProhibitRefresh();
	}

	// Token: 0x0601106D RID: 69741 RVA: 0x00500FB8 File Offset: 0x004FF1B8
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		PilotThrowController.Instance.GenerateProjectilePoints();
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
	}

	// Token: 0x0601106E RID: 69742 RVA: 0x00500FE8 File Offset: 0x004FF1E8
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		PilotThrowController.Instance.ClearProjectilePoints();
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitSpecialGameplayCamera();
		EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
	}

	// Token: 0x0601106F RID: 69743 RVA: 0x0050103A File Offset: 0x004FF23A
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterExtraUiProhibitRefresh();
	}

	// Token: 0x06011070 RID: 69744 RVA: 0x00501042 File Offset: 0x004FF242
	private void InitSequencePlayer()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06011071 RID: 69745 RVA: 0x00501058 File Offset: 0x004FF258
	private UniTask InitTargetItems(IReadOnlyList<IPilotThrowTarget> targetConfigs)
	{
		PilotThrowView.<InitTargetItems>d__10 <InitTargetItems>d__;
		<InitTargetItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTargetItems>d__.<>4__this = this;
		<InitTargetItems>d__.targetConfigs = targetConfigs;
		<InitTargetItems>d__.<>1__state = -1;
		<InitTargetItems>d__.<>t__builder.Start<PilotThrowView.<InitTargetItems>d__10>(ref <InitTargetItems>d__);
		return <InitTargetItems>d__.<>t__builder.Task;
	}

	// Token: 0x06011072 RID: 69746 RVA: 0x005010A4 File Offset: 0x004FF2A4
	protected override void OnTick(float delta)
	{
		foreach (PilotThrowTargetItem pilotThrowTargetItem in this.TargetItem)
		{
			pilotThrowTargetItem.OnTick(delta);
		}
	}

	// Token: 0x06011073 RID: 69747 RVA: 0x005010F8 File Offset: 0x004FF2F8
	private void OnBackBtnClick()
	{
		PilotThrowController.Instance.RequestChangePilotState(false);
		LevelPlayController.Instance.LogReportMotorcycleLevelPlay(PilotThrowModel.Instance.GetCurrentInteractHookPoint(), EMotorcycleLevelPlayType.PilotThrow, null, 1, 1);
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Entity != null)
		{
			CharacterSkillComponent component = getCurrentEntity.Entity.GetComponent<CharacterSkillComponent>();
			if (component != null)
			{
				component.StopAllSkills("铁驭中断,停止技能");
			}
		}
		foreach (PilotThrowTargetItem pilotThrowTargetItem in this.TargetItem)
		{
			pilotThrowTargetItem.Close();
		}
		this.TargetItem.Clear();
		base.CloseMe(null);
	}

	// Token: 0x06011074 RID: 69748 RVA: 0x005011B8 File Offset: 0x004FF3B8
	private void OnLaunchBtnClick()
	{
		PilotThrowController.Instance.RequestChangePilotState(true);
		LevelPlayController.Instance.LogReportMotorcycleLevelPlay(PilotThrowModel.Instance.GetCurrentInteractHookPoint(), EMotorcycleLevelPlayType.PilotThrow, null, 2, 1);
		foreach (PilotThrowTargetItem pilotThrowTargetItem in this.TargetItem)
		{
			pilotThrowTargetItem.Close();
		}
		this.TargetItem.Clear();
		this.CloseMeAsync().Forget<bool>();
	}

	// Token: 0x06011075 RID: 69749 RVA: 0x0050124C File Offset: 0x004FF44C
	private void OnTeleportStart(bool loading)
	{
		foreach (PilotThrowTargetItem pilotThrowTargetItem in this.TargetItem)
		{
			pilotThrowTargetItem.Close();
		}
		this.TargetItem.Clear();
		this.CloseMeAsync().Forget<bool>();
	}

	// Token: 0x06011076 RID: 69750 RVA: 0x005012B4 File Offset: 0x004FF4B4
	public bool CheckCondition()
	{
		return true;
	}

	// Token: 0x06011077 RID: 69751 RVA: 0x005012B7 File Offset: 0x004FF4B7
	public string[] GetDistributeTags()
	{
		return new string[]
		{
			"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
			"UiInputRoot"
		};
	}

	// Token: 0x06011078 RID: 69752 RVA: 0x005012CF File Offset: 0x004FF4CF
	private void RegisterExtraUiProhibitRefresh()
	{
		UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
	}

	// Token: 0x06011079 RID: 69753 RVA: 0x005012EC File Offset: 0x004FF4EC
	private void UnRegisterExtraUiProhibitRefresh()
	{
		UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
	}

	// Token: 0x0601107A RID: 69754 RVA: 0x00501308 File Offset: 0x004FF508
	private void OnTargetInOutRange(bool inRange)
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopSequenceByKey("Ready_In", false, false);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 != null)
		{
			sequencePlayer2.StopSequenceByKey("Ready_Out", false, false);
		}
		LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
		if (sequencePlayer3 == null)
		{
			return;
		}
		sequencePlayer3.PlayLevelSequenceByName(inRange ? "Ready_In" : "Ready_Out", false, null, false);
	}

	// Token: 0x040095F2 RID: 38386
	private readonly List<PilotThrowTargetItem> TargetItem = new List<PilotThrowTargetItem>();

	// Token: 0x040095F3 RID: 38387
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040095F4 RID: 38388
	private const string NUMBERIN_ANIM = "Number_In";

	// Token: 0x02007DA5 RID: 32165
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04028AE1 RID: 166625
		public const int BackBtn = 0;

		// Token: 0x04028AE2 RID: 166626
		public const int FallPointCountText = 1;

		// Token: 0x04028AE3 RID: 166627
		public const int BtnLaunch = 2;

		// Token: 0x04028AE4 RID: 166628
		public const int MarkRoot = 3;

		// Token: 0x04028AE5 RID: 166629
		public const int AimItem = 4;
	}
}
