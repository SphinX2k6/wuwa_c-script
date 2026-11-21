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
	// Token: 0x0200368A RID: 13962
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[Controller(0)]
	public class MoveMonsterController : WuWaGoMonsterControllerBase<WuWaGoMoveMonster>
	{
		// Token: 0x060243C7 RID: 148423 RVA: 0x00A3FF4A File Offset: 0x00A3E14A
		public MoveMonsterController(WuWaGoMoveMonster role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(role, gameData, gameMode)
		{
		}

		// Token: 0x060243C8 RID: 148424 RVA: 0x00A3FF61 File Offset: 0x00A3E161
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			this.PlayIdleMontage();
			return true;
		}

		// Token: 0x060243C9 RID: 148425 RVA: 0x00A3FF74 File Offset: 0x00A3E174
		protected override void OnDestroy()
		{
			this.StopIdleMontage("Destroy");
			base.OnDestroy();
		}

		// Token: 0x060243CA RID: 148426 RVA: 0x00A3FF87 File Offset: 0x00A3E187
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

		// Token: 0x060243CB RID: 148427 RVA: 0x00A3FFB0 File Offset: 0x00A3E1B0
		protected override UniTask OnExecuteAction()
		{
			MoveMonsterController.<OnExecuteAction>d__7 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<MoveMonsterController.<OnExecuteAction>d__7>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x060243CC RID: 148428 RVA: 0x00A3FFF4 File Offset: 0x00A3E1F4
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

		// Token: 0x060243CD RID: 148429 RVA: 0x00A40040 File Offset: 0x00A3E240
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

		// Token: 0x060243CE RID: 148430 RVA: 0x00A400B0 File Offset: 0x00A3E2B0
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

		// Token: 0x060243CF RID: 148431 RVA: 0x00A400FC File Offset: 0x00A3E2FC
		private UniTask PlayAlertMontage()
		{
			MoveMonsterController.<PlayAlertMontage>d__11 <PlayAlertMontage>d__;
			<PlayAlertMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAlertMontage>d__.<>4__this = this;
			<PlayAlertMontage>d__.<>1__state = -1;
			<PlayAlertMontage>d__.<>t__builder.Start<MoveMonsterController.<PlayAlertMontage>d__11>(ref <PlayAlertMontage>d__);
			return <PlayAlertMontage>d__.<>t__builder.Task;
		}

		// Token: 0x060243D0 RID: 148432 RVA: 0x00A40140 File Offset: 0x00A3E340
		private UniTask AdvanceOneStep()
		{
			MoveMonsterController.<AdvanceOneStep>d__12 <AdvanceOneStep>d__;
			<AdvanceOneStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AdvanceOneStep>d__.<>4__this = this;
			<AdvanceOneStep>d__.<>1__state = -1;
			<AdvanceOneStep>d__.<>t__builder.Start<MoveMonsterController.<AdvanceOneStep>d__12>(ref <AdvanceOneStep>d__);
			return <AdvanceOneStep>d__.<>t__builder.Task;
		}

		// Token: 0x060243D1 RID: 148433 RVA: 0x00A40184 File Offset: 0x00A3E384
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

		// Token: 0x060243D2 RID: 148434 RVA: 0x00A401B0 File Offset: 0x00A3E3B0
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

		// Token: 0x060243D3 RID: 148435 RVA: 0x00A401FC File Offset: 0x00A3E3FC
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

		// Token: 0x060243D4 RID: 148436 RVA: 0x00A40364 File Offset: 0x00A3E564
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

		// Token: 0x060243D5 RID: 148437 RVA: 0x00A403D0 File Offset: 0x00A3E5D0
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

		// Token: 0x040142F2 RID: 82674
		private static readonly float IdleMontageBlendOutTime = 0.1f;

		// Token: 0x040142F3 RID: 82675
		private readonly MoveCapability MoveCapability = new MoveCapability(role);

		// Token: 0x040142F4 RID: 82676
		[Nullable(2)]
		private UAnimMontage PlayingIdleMontage;
	}
}
