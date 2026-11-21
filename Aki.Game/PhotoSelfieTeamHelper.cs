using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001A90 RID: 6800
public static class PhotoSelfieTeamHelper
{
	// Token: 0x06010D27 RID: 68903 RVA: 0x004EF180 File Offset: 0x004ED380
	public static UniTask<bool> EnterSelfPortrait()
	{
		PhotoSelfieTeamHelper.<EnterSelfPortrait>d__0 <EnterSelfPortrait>d__;
		<EnterSelfPortrait>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EnterSelfPortrait>d__.<>1__state = -1;
		<EnterSelfPortrait>d__.<>t__builder.Start<PhotoSelfieTeamHelper.<EnterSelfPortrait>d__0>(ref <EnterSelfPortrait>d__);
		return <EnterSelfPortrait>d__.<>t__builder.Task;
	}

	// Token: 0x06010D28 RID: 68904 RVA: 0x004EF1BC File Offset: 0x004ED3BC
	public static UniTask<bool> ExitSelfPortrait()
	{
		PhotoSelfieTeamHelper.<ExitSelfPortrait>d__1 <ExitSelfPortrait>d__;
		<ExitSelfPortrait>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ExitSelfPortrait>d__.<>1__state = -1;
		<ExitSelfPortrait>d__.<>t__builder.Start<PhotoSelfieTeamHelper.<ExitSelfPortrait>d__1>(ref <ExitSelfPortrait>d__);
		return <ExitSelfPortrait>d__.<>t__builder.Task;
	}

	// Token: 0x06010D29 RID: 68905 RVA: 0x004EF1F8 File Offset: 0x004ED3F8
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

	// Token: 0x06010D2A RID: 68906 RVA: 0x004EF284 File Offset: 0x004ED484
	private static UniTask<bool> SendChangeRoleRequest(SelfPortraitOpState state)
	{
		PhotoSelfieTeamHelper.<SendChangeRoleRequest>d__3 <SendChangeRoleRequest>d__;
		<SendChangeRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendChangeRoleRequest>d__.state = state;
		<SendChangeRoleRequest>d__.<>1__state = -1;
		<SendChangeRoleRequest>d__.<>t__builder.Start<PhotoSelfieTeamHelper.<SendChangeRoleRequest>d__3>(ref <SendChangeRoleRequest>d__);
		return <SendChangeRoleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x02007D24 RID: 32036
	[NullableContext(2)]
	[Nullable(0)]
	private class SettleWaiter
	{
		// Token: 0x060416A5 RID: 267941 RVA: 0x01357D78 File Offset: 0x01355F78
		[NullableContext(1)]
		public SettleWaiter(EntityHandle entityHandle)
		{
			this.EntityHandle = entityHandle;
		}

		// Token: 0x060416A6 RID: 267942 RVA: 0x01357D87 File Offset: 0x01355F87
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

		// Token: 0x060416A7 RID: 267943 RVA: 0x01357DC0 File Offset: 0x01355FC0
		private void RecheckInAirBeforeFinish()
		{
			if (this.TryWaitLanding())
			{
				Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "自拍切主角:换人后延迟挂上空中Tag,继续等落地", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Finish(null);
		}

		// Token: 0x060416A8 RID: 267944 RVA: 0x01357DFC File Offset: 0x01355FFC
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

		// Token: 0x060416A9 RID: 267945 RVA: 0x01357E9F File Offset: 0x0135609F
		private void OnInAirTagSwitched(int _, bool tagExists)
		{
			if (tagExists)
			{
				return;
			}
			this.Finish("自拍切主角:新角色已落地,解除切换标记");
		}

		// Token: 0x060416AA RID: 267946 RVA: 0x01357EB0 File Offset: 0x013560B0
		private void OnSettleTimeout(float _)
		{
			this.Finish("自拍切主角:等待新角色落地超时");
		}

		// Token: 0x060416AB RID: 267947 RVA: 0x01357EC0 File Offset: 0x013560C0
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

		// Token: 0x04028852 RID: 165970
		[Nullable(1)]
		private readonly EntityHandle EntityHandle;

		// Token: 0x04028853 RID: 165971
		private bool IsFinished;

		// Token: 0x04028854 RID: 165972
		private ITagTask TagTask;

		// Token: 0x04028855 RID: 165973
		private TimerHandle TimeoutHandle;
	}

	// Token: 0x02007D25 RID: 32037
	private class ChangeRoleWaiter
	{
		// Token: 0x060416AD RID: 267949 RVA: 0x01357FE3 File Offset: 0x013561E3
		public ChangeRoleWaiter(SelfPortraitOpState state)
		{
			this.State = state;
		}

		// Token: 0x060416AE RID: 267950 RVA: 0x01357FFD File Offset: 0x013561FD
		public UniTask<bool> StartWait()
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleDone));
			this.RestartTimeout();
			return this.Promise.Promise;
		}

		// Token: 0x060416AF RID: 267951 RVA: 0x0135802C File Offset: 0x0135622C
		public void RestartTimeout()
		{
			if (this.IsFinished)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.TimeoutHandle);
			this.TimeoutHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnWaitTimeout), (float)ConfigCommonParamById.GetIntConfig("WAIT_CHANGE_ROLE_TIMEOUT_MS").GetValueOrDefault(60000), null, "PhotoSelfieTeamHelper.ChangeRoleWaiter", true, 1f);
		}

		// Token: 0x060416B0 RID: 267952 RVA: 0x01358094 File Offset: 0x01356294
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

		// Token: 0x060416B1 RID: 267953 RVA: 0x013580EC File Offset: 0x013562EC
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

		// Token: 0x060416B2 RID: 267954 RVA: 0x01358148 File Offset: 0x01356348
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

		// Token: 0x04028856 RID: 165974
		private readonly SelfPortraitOpState State;

		// Token: 0x04028857 RID: 165975
		[Nullable(1)]
		private readonly CustomPromise<bool> Promise = new CustomPromise<bool>();

		// Token: 0x04028858 RID: 165976
		private bool IsFinished;

		// Token: 0x04028859 RID: 165977
		[Nullable(2)]
		private TimerHandle TimeoutHandle;
	}
}
