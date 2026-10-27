using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020025A5 RID: 9637
public static class PhotoSelfieTeamHelper
{
	// Token: 0x06013845 RID: 79941 RVA: 0x004E064C File Offset: 0x004DE84C
	public static UniTask<bool> EnterSelfPortrait()
	{
		PhotoSelfieTeamHelper.<EnterSelfPortrait>d__0 <EnterSelfPortrait>d__;
		<EnterSelfPortrait>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EnterSelfPortrait>d__.<>1__state = -1;
		<EnterSelfPortrait>d__.<>t__builder.Start<PhotoSelfieTeamHelper.<EnterSelfPortrait>d__0>(ref <EnterSelfPortrait>d__);
		return <EnterSelfPortrait>d__.<>t__builder.Task;
	}

	// Token: 0x06013846 RID: 79942 RVA: 0x004E0688 File Offset: 0x004DE888
	public static UniTask<bool> ExitSelfPortrait()
	{
		PhotoSelfieTeamHelper.<ExitSelfPortrait>d__1 <ExitSelfPortrait>d__;
		<ExitSelfPortrait>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ExitSelfPortrait>d__.<>1__state = -1;
		<ExitSelfPortrait>d__.<>t__builder.Start<PhotoSelfieTeamHelper.<ExitSelfPortrait>d__1>(ref <ExitSelfPortrait>d__);
		return <ExitSelfPortrait>d__.<>t__builder.Task;
	}

	// Token: 0x06013847 RID: 79943 RVA: 0x004E06C4 File Offset: 0x004DE8C4
	private static int? GetCurrentRoleId()
	{
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		int? num = (instance != null) ? instance.GetId() : null;
		if (num == null)
		{
			return null;
		}
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(num.Value);
		if (teamPlayerData == null)
		{
			return null;
		}
		SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
		if (currentGroup == null)
		{
			return null;
		}
		SceneTeamRole currentRole = currentGroup.GetCurrentRole();
		if (currentRole == null)
		{
			return null;
		}
		return new int?(currentRole.RoleId);
	}

	// Token: 0x06013848 RID: 79944 RVA: 0x004E0750 File Offset: 0x004DE950
	private static UniTask<bool> SendChangeRoleRequest(SelfPortraitOpState state)
	{
		PhotoSelfieTeamHelper.<SendChangeRoleRequest>d__3 <SendChangeRoleRequest>d__;
		<SendChangeRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendChangeRoleRequest>d__.state = state;
		<SendChangeRoleRequest>d__.<>1__state = -1;
		<SendChangeRoleRequest>d__.<>t__builder.Start<PhotoSelfieTeamHelper.<SendChangeRoleRequest>d__3>(ref <SendChangeRoleRequest>d__);
		return <SendChangeRoleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x02008B9C RID: 35740
	[NullableContext(2)]
	[Nullable(0)]
	private class SettleWaiter
	{
		// Token: 0x0604B2D4 RID: 307924 RVA: 0x013B4380 File Offset: 0x013B2580
		[NullableContext(1)]
		public SettleWaiter(EntityHandle entityHandle)
		{
			this.EntityHandle = entityHandle;
		}

		// Token: 0x0604B2D5 RID: 307925 RVA: 0x013B438F File Offset: 0x013B258F
		public void Start()
		{
			if (!PhotographModel.Instance.IsOpenPhotograph)
			{
				this.Finish(null);
				return;
			}
			if (this.TryWaitLanding())
			{
				return;
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.RecheckInAirBeforeFinish();
			}, null, null);
		}

		// Token: 0x0604B2D6 RID: 307926 RVA: 0x013B43C8 File Offset: 0x013B25C8
		private void RecheckInAirBeforeFinish()
		{
			if (this.TryWaitLanding())
			{
				Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "自拍切主角:换人后延迟挂上空中Tag,继续等落地", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Finish(null);
		}

		// Token: 0x0604B2D7 RID: 307927 RVA: 0x013B4404 File Offset: 0x013B2604
		private bool TryWaitLanding()
		{
			WorldEntity entity = this.EntityHandle.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			int num = GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"];
			if (baseTagComponent == null || !baseTagComponent.HasTag(num))
			{
				return false;
			}
			this.TagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnInAirTagSwitched), null);
			this.TimeoutHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnSettleTimeout), (float)ConfigCommonParamById.GetIntConfig("SELFIE_CHANGE_ROLE_SETTLE_TIMEOUT_MS").GetValueOrDefault(3000), null, "PhotoSelfieTeamHelper.SettleWaiter", true, 1f);
			return true;
		}

		// Token: 0x0604B2D8 RID: 307928 RVA: 0x013B44A7 File Offset: 0x013B26A7
		private void OnInAirTagSwitched(int _, bool tagExists)
		{
			if (tagExists)
			{
				return;
			}
			this.Finish("自拍切主角:新角色已落地,解除切换标记");
		}

		// Token: 0x0604B2D9 RID: 307929 RVA: 0x013B44B8 File Offset: 0x013B26B8
		private void OnSettleTimeout(float _)
		{
			this.Finish("自拍切主角:等待新角色落地超时");
		}

		// Token: 0x0604B2DA RID: 307930 RVA: 0x013B44C8 File Offset: 0x013B26C8
		private void Finish(string reason = null)
		{
			if (this.IsFinished)
			{
				return;
			}
			this.IsFinished = true;
			ITagTask tagTask = this.TagTask;
			if (tagTask != null)
			{
				tagTask.EndTask();
			}
			this.TagTask = null;
			TimerSystem.Instance.Remove(this.TimeoutHandle);
			this.TimeoutHandle = null;
			PhotographController.Instance.UnmarkSelfPortraitSwitching();
			if (!PhotographModel.Instance.IsOpenPhotograph)
			{
				return;
			}
			if (reason != null)
			{
				Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, reason, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			WorldEntity entity = this.EntityHandle.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null || !baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
			{
				return;
			}
			if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]))
			{
				Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "自拍切主角:解除标记时悬浮近地,忽略空中Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "自拍切主角:解除标记时仍在空中,补触发未落地处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			PhotographController.Instance.OnSelfPortraitSettleTimeout();
		}

		// Token: 0x0402D53D RID: 185661
		[Nullable(1)]
		private readonly EntityHandle EntityHandle;

		// Token: 0x0402D53E RID: 185662
		private bool IsFinished;

		// Token: 0x0402D53F RID: 185663
		private ITagTask TagTask;

		// Token: 0x0402D540 RID: 185664
		private TimerHandle TimeoutHandle;
	}

	// Token: 0x02008B9D RID: 35741
	private class ChangeRoleWaiter
	{
		// Token: 0x0604B2DC RID: 307932 RVA: 0x013B45EB File Offset: 0x013B27EB
		public ChangeRoleWaiter(SelfPortraitOpState state)
		{
			this.State = state;
		}

		// Token: 0x0604B2DD RID: 307933 RVA: 0x013B4605 File Offset: 0x013B2805
		public UniTask<bool> StartWait()
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleDone));
			this.RestartTimeout();
			return this.Promise.Promise;
		}

		// Token: 0x0604B2DE RID: 307934 RVA: 0x013B4634 File Offset: 0x013B2834
		public void RestartTimeout()
		{
			if (this.IsFinished)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.TimeoutHandle);
			this.TimeoutHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnWaitTimeout), (float)ConfigCommonParamById.GetIntConfig("WAIT_CHANGE_ROLE_TIMEOUT_MS").GetValueOrDefault(60000), null, "PhotoSelfieTeamHelper.ChangeRoleWaiter", true, 1f);
		}

		// Token: 0x0604B2DF RID: 307935 RVA: 0x013B469C File Offset: 0x013B289C
		public void FinishWait(bool success)
		{
			if (this.IsFinished)
			{
				return;
			}
			this.IsFinished = true;
			TimerSystem.Instance.Remove(this.TimeoutHandle);
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleDone));
			this.Promise.SetResult(success);
		}

		// Token: 0x0604B2E0 RID: 307936 RVA: 0x013B46F4 File Offset: 0x013B28F4
		[NullableContext(1)]
		private void OnChangeRoleDone(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle _)
		{
			if (this.IsFinished)
			{
				return;
			}
			PhotoCamera photoCamera = PhotographController.Instance.GetPhotoCamera();
			if (photoCamera != null)
			{
				WorldEntity entity = newEntityHandle.Entity;
				TsBaseCharacter character;
				if (entity == null)
				{
					character = null;
				}
				else
				{
					CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
					character = ((component != null) ? component.Actor : null);
				}
				photoCamera.ChangeCharacter(character);
			}
			new PhotoSelfieTeamHelper.SettleWaiter(newEntityHandle).Start();
			this.FinishWait(true);
		}

		// Token: 0x0604B2E1 RID: 307937 RVA: 0x013B4750 File Offset: 0x013B2950
		private void OnWaitTimeout(float _)
		{
			if (this.IsFinished)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "自拍切主角:等待换人超时";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("State", this.State);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			PhotographController.Instance.UnmarkSelfPortraitSwitching();
			this.FinishWait(false);
		}

		// Token: 0x0402D541 RID: 185665
		private readonly SelfPortraitOpState State;

		// Token: 0x0402D542 RID: 185666
		[Nullable(1)]
		private readonly CustomPromise<bool> Promise = new CustomPromise<bool>();

		// Token: 0x0402D543 RID: 185667
		private bool IsFinished;

		// Token: 0x0402D544 RID: 185668
		[Nullable(2)]
		private TimerHandle TimeoutHandle;
	}
}
