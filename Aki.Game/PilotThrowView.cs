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

// Token: 0x020025E4 RID: 9700
[NullableContext(1)]
[Nullable(0)]
public class PilotThrowView : UiTickViewBase, IUiProhibitRefreshData
{
	// Token: 0x06013B87 RID: 80775 RVA: 0x004F2138 File Offset: 0x004F0338
	public PilotThrowView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06013B88 RID: 80776 RVA: 0x004F214C File Offset: 0x004F034C
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

	// Token: 0x06013B89 RID: 80777 RVA: 0x004F2210 File Offset: 0x004F0410
	protected override UniTask OnBeforeStartAsync()
	{
		PilotThrowView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PilotThrowView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B8A RID: 80778 RVA: 0x004F2254 File Offset: 0x004F0454
	protected override void OnStart()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayLevelSequenceByName("Number_In", false, null, false);
		}
		this.RegisterExtraUiProhibitRefresh();
	}

	// Token: 0x06013B8B RID: 80779 RVA: 0x004F2288 File Offset: 0x004F0488
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		PilotThrowController.Instance.GenerateProjectilePoints();
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
	}

	// Token: 0x06013B8C RID: 80780 RVA: 0x004F22B8 File Offset: 0x004F04B8
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		PilotThrowController.Instance.ClearProjectilePoints();
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitSpecialGameplayCamera();
		EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
	}

	// Token: 0x06013B8D RID: 80781 RVA: 0x004F230A File Offset: 0x004F050A
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterExtraUiProhibitRefresh();
	}

	// Token: 0x06013B8E RID: 80782 RVA: 0x004F2312 File Offset: 0x004F0512
	private void InitSequencePlayer()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013B8F RID: 80783 RVA: 0x004F2328 File Offset: 0x004F0528
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

	// Token: 0x06013B90 RID: 80784 RVA: 0x004F2374 File Offset: 0x004F0574
	protected override void OnTick(float delta)
	{
		foreach (PilotThrowTargetItem pilotThrowTargetItem in this.TargetItem)
		{
			pilotThrowTargetItem.OnTick(delta);
		}
	}

	// Token: 0x06013B91 RID: 80785 RVA: 0x004F23C8 File Offset: 0x004F05C8
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

	// Token: 0x06013B92 RID: 80786 RVA: 0x004F2488 File Offset: 0x004F0688
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

	// Token: 0x06013B93 RID: 80787 RVA: 0x004F251C File Offset: 0x004F071C
	private void OnTeleportStart(bool loading)
	{
		foreach (PilotThrowTargetItem pilotThrowTargetItem in this.TargetItem)
		{
			pilotThrowTargetItem.Close();
		}
		this.TargetItem.Clear();
		this.CloseMeAsync().Forget<bool>();
	}

	// Token: 0x06013B94 RID: 80788 RVA: 0x004F2584 File Offset: 0x004F0784
	public bool CheckCondition()
	{
		return true;
	}

	// Token: 0x06013B95 RID: 80789 RVA: 0x004F2587 File Offset: 0x004F0787
	public string[] GetDistributeTags()
	{
		return new string[]
		{
			"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
			"UiInputRoot"
		};
	}

	// Token: 0x06013B96 RID: 80790 RVA: 0x004F259F File Offset: 0x004F079F
	private void RegisterExtraUiProhibitRefresh()
	{
		UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
	}

	// Token: 0x06013B97 RID: 80791 RVA: 0x004F25BC File Offset: 0x004F07BC
	private void UnRegisterExtraUiProhibitRefresh()
	{
		UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
	}

	// Token: 0x06013B98 RID: 80792 RVA: 0x004F25D8 File Offset: 0x004F07D8
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

	// Token: 0x0400949B RID: 38043
	private readonly List<PilotThrowTargetItem> TargetItem = new List<PilotThrowTargetItem>();

	// Token: 0x0400949C RID: 38044
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400949D RID: 38045
	private const string NUMBERIN_ANIM = "Number_In";

	// Token: 0x02008C1C RID: 35868
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x0402D7C9 RID: 186313
		public const int BackBtn = 0;

		// Token: 0x0402D7CA RID: 186314
		public const int FallPointCountText = 1;

		// Token: 0x0402D7CB RID: 186315
		public const int BtnLaunch = 2;

		// Token: 0x0402D7CC RID: 186316
		public const int MarkRoot = 3;

		// Token: 0x0402D7CD RID: 186317
		public const int AimItem = 4;
	}
}
