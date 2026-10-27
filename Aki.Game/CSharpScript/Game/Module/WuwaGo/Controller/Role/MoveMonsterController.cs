using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role
{
	// Token: 0x02004759 RID: 18265
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[Controller(0)]
	public class MoveMonsterController : WuWaGoMonsterControllerBase<WuWaGoMoveMonster>
	{
		// Token: 0x0602FBFD RID: 195581 RVA: 0x00B0FF8A File Offset: 0x00B0E18A
		public MoveMonsterController(WuWaGoMoveMonster role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(role, gameData, gameMode)
		{
		}

		// Token: 0x0602FBFE RID: 195582 RVA: 0x00B0FFA1 File Offset: 0x00B0E1A1
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			this.PlayIdleMontage();
			return true;
		}

		// Token: 0x0602FBFF RID: 195583 RVA: 0x00B0FFB4 File Offset: 0x00B0E1B4
		protected override void OnDestroy()
		{
			this.StopIdleMontage("Destroy");
			base.OnDestroy();
		}

		// Token: 0x0602FC00 RID: 195584 RVA: 0x00B0FFC7 File Offset: 0x00B0E1C7
		public override void OnRollbackRestore()
		{
			base.OnRollbackRestore();
			if (this.Role.HasObservedPlayer)
			{
				this.StopIdleMontage("RollbackRestore");
				return;
			}
			this.PlayIdleMontage();
		}

		// Token: 0x0602FC01 RID: 195585 RVA: 0x00B0FFF0 File Offset: 0x00B0E1F0
		protected override UniTask OnExecuteAction()
		{
			MoveMonsterController.<OnExecuteAction>d__7 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<MoveMonsterController.<OnExecuteAction>d__7>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC02 RID: 195586 RVA: 0x00B10034 File Offset: 0x00B0E234
		protected override UniTask OnBeforeAttack(WuWaGoGrid targetGrid)
		{
			MoveMonsterController.<OnBeforeAttack>d__8 <OnBeforeAttack>d__;
			<OnBeforeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeAttack>d__.<>4__this = this;
			<OnBeforeAttack>d__.targetGrid = targetGrid;
			<OnBeforeAttack>d__.<>1__state = -1;
			<OnBeforeAttack>d__.<>t__builder.Start<MoveMonsterController.<OnBeforeAttack>d__8>(ref <OnBeforeAttack>d__);
			return <OnBeforeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC03 RID: 195587 RVA: 0x00B10080 File Offset: 0x00B0E280
		private void UpdateFootprintsByObservation(WuWaGoGrid playerGrid)
		{
			if (!this.Role.IsTracking)
			{
				return;
			}
			if (this.Role.LastSeenPlayerGridId == 0)
			{
				return;
			}
			if (playerGrid.Id == this.Role.LastSeenPlayerGridId)
			{
				return;
			}
			WuWaGoGrid gridById = WuWaGoModel.Instance.GetGridById(this.Role.LastSeenPlayerGridId);
			if (gridById == null)
			{
				return;
			}
			if (!gridById.IsBidirectionalLinkedTo(playerGrid))
			{
				return;
			}
			this.Role.PushFootprint(playerGrid);
		}

		// Token: 0x0602FC04 RID: 195588 RVA: 0x00B100F0 File Offset: 0x00B0E2F0
		private UniTask TryEnterTracking(WuWaGoGrid playerGrid)
		{
			MoveMonsterController.<TryEnterTracking>d__10 <TryEnterTracking>d__;
			<TryEnterTracking>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryEnterTracking>d__.<>4__this = this;
			<TryEnterTracking>d__.playerGrid = playerGrid;
			<TryEnterTracking>d__.<>1__state = -1;
			<TryEnterTracking>d__.<>t__builder.Start<MoveMonsterController.<TryEnterTracking>d__10>(ref <TryEnterTracking>d__);
			return <TryEnterTracking>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC05 RID: 195589 RVA: 0x00B1013C File Offset: 0x00B0E33C
		private UniTask PlayAlertMontage()
		{
			MoveMonsterController.<PlayAlertMontage>d__11 <PlayAlertMontage>d__;
			<PlayAlertMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAlertMontage>d__.<>4__this = this;
			<PlayAlertMontage>d__.<>1__state = -1;
			<PlayAlertMontage>d__.<>t__builder.Start<MoveMonsterController.<PlayAlertMontage>d__11>(ref <PlayAlertMontage>d__);
			return <PlayAlertMontage>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC06 RID: 195590 RVA: 0x00B10180 File Offset: 0x00B0E380
		private UniTask AdvanceOneStep()
		{
			MoveMonsterController.<AdvanceOneStep>d__12 <AdvanceOneStep>d__;
			<AdvanceOneStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AdvanceOneStep>d__.<>4__this = this;
			<AdvanceOneStep>d__.<>1__state = -1;
			<AdvanceOneStep>d__.<>t__builder.Start<MoveMonsterController.<AdvanceOneStep>d__12>(ref <AdvanceOneStep>d__);
			return <AdvanceOneStep>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC07 RID: 195591 RVA: 0x00B101C4 File Offset: 0x00B0E3C4
		[NullableContext(2)]
		private WuWaGoRole GetPlayerRole()
		{
			WuWaGoMainControlRole mainControlRole = WuWaGoModel.Instance.GameData.MainControlRole;
			if (mainControlRole == null || mainControlRole.IsDead)
			{
				return null;
			}
			return mainControlRole;
		}

		// Token: 0x0602FC08 RID: 195592 RVA: 0x00B101F0 File Offset: 0x00B0E3F0
		private void ResetTracking(string reason)
		{
			WuWaGoMoveMonster role = this.Role;
			if (role != null && !role.IsTracking)
			{
				IReadOnlyList<WuWaGoGrid> footprints = role.Footprints;
				if (footprints != null && footprints.Count == 0)
				{
					return;
				}
			}
			this.Role.SetIsTracking(false);
			this.Role.ClearFootprints();
		}

		// Token: 0x0602FC09 RID: 195593 RVA: 0x00B1023C File Offset: 0x00B0E43C
		private unsafe void PlayIdleMontage()
		{
			if (this.Role.HasObservedPlayer || this.Role.IsDead || !this.Role.IsActorValid())
			{
				return;
			}
			UAnimMontage idleMontage = WuWaGoGlobal.GetIdleMontage();
			if (idleMontage == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MoveMonster：待机动画未找到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("monsterId", this.Role.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UAnimInstance actorAnimInstance = WuWaGoUtil.GetActorAnimInstance(this.Role, "StartIdleMontage");
			if (actorAnimInstance == null)
			{
				return;
			}
			if (this.PlayingIdleMontage == idleMontage && actorAnimInstance.Montage_IsPlaying(idleMontage))
			{
				return;
			}
			WuWaGoUtil.ResetRoleRootMotionState(this.Role, "MoveMonster.PlayIdleMontage");
			if (actorAnimInstance.Montage_Play(idleMontage, WuWaGoUtil.GetMontagePlayRate(), EMontagePlayReturnType.MontageLength, 0f, true) <= 0f)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.WuWaGo;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "MoveMonster：待机动画播放失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("monsterId", this.Role.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("montage", idleMontage);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.PlayingIdleMontage = idleMontage;
			actorAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnIdleMontageEnded));
			actorAnimInstance.OnMontageEnded.Add(new Action<UAnimMontage, bool>(this.OnIdleMontageEnded));
		}

		// Token: 0x0602FC0A RID: 195594 RVA: 0x00B103A4 File Offset: 0x00B0E5A4
		private void StopIdleMontage(string reason)
		{
			UAnimMontage playingIdleMontage = this.PlayingIdleMontage;
			if (playingIdleMontage == null)
			{
				return;
			}
			UKuroAnimInstanceChar animInstance = this.Role.GetAnimInstance();
			this.PlayingIdleMontage = null;
			if (animInstance != null)
			{
				animInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnIdleMontageEnded));
			}
			if (animInstance == null || !animInstance.IsValid() || !animInstance.Montage_IsPlaying(playingIdleMontage))
			{
				return;
			}
			animInstance.Montage_Stop(MoveMonsterController.IdleMontageBlendOutTime, playingIdleMontage);
		}

		// Token: 0x0602FC0B RID: 195595 RVA: 0x00B10410 File Offset: 0x00B0E610
		[NullableContext(2)]
		private void OnIdleMontageEnded(UAnimMontage montage, bool bInterrupted)
		{
			if (montage != this.PlayingIdleMontage)
			{
				return;
			}
			UKuroAnimInstanceChar animInstance = this.Role.GetAnimInstance();
			this.PlayingIdleMontage = null;
			if (animInstance != null)
			{
				animInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnIdleMontageEnded));
			}
			this.PlayIdleMontage();
		}

		// Token: 0x04019C42 RID: 105538
		private static readonly float IdleMontageBlendOutTime = 0.1f;

		// Token: 0x04019C43 RID: 105539
		private readonly MoveCapability MoveCapability = new MoveCapability(role);

		// Token: 0x04019C44 RID: 105540
		[Nullable(2)]
		private UAnimMontage PlayingIdleMontage;
	}
}
