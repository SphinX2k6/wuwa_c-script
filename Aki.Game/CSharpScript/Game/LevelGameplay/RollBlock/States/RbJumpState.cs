using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.States
{
	// Token: 0x02006AAD RID: 27309
	[NullableContext(2)]
	[Nullable(0)]
	public class RbJumpState : RbBaseMoveState
	{
		// Token: 0x06043D82 RID: 277890 RVA: 0x0109FA4A File Offset: 0x0109DC4A
		[NullableContext(1)]
		public RbJumpState(RbBlockComponent owner) : base(owner)
		{
		}

		// Token: 0x06043D83 RID: 277891 RVA: 0x0109FA54 File Offset: 0x0109DC54
		public override void Enter([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> info)
		{
			if (!RollBlockDefind.isRbBlockJumpState(info))
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbJumpState Enter without JumpState info", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.StateName = ERollBlockMoveState.Jump;
			this.Info = info.AsT2;
			if (this.DirectorActor == null)
			{
				this.GenerateStaticDirector();
			}
			if (this.DirectorActor == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbJumpState Enter DirectorActor create failed", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.DirectorActor.SequencePlayer.IsPlaying())
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbJumpState Enter but DirectorActor is playing", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.DirectorActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			FTransformDouble transform = this.Owner.Transform;
			global::Vector vector = this.Owner.PbDirToVector(this.Info.Direction);
			global::Rotator rotator = global::Rotator.Create();
			vector.Rotation(rotator);
			FRotator frotator = rotator.ToUeRotator();
			FQuat fquat = new FQuat(ref frotator);
			transform.SetRotation(fquat);
			udefaultLevelSequenceInstanceData.TransformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(transform);
			udefaultLevelSequenceInstanceData.ApplyWorldOrigin = true;
			ResourceSystem.Instance.LoadAsync<ULevelSequence>("/Game/Aki/Data/Gameplay/RollBlock/Sequence/RollBlockJump.RollBlockJump", delegate([Nullable(2)] ULevelSequence seq, string _)
			{
				AActor actor = this.Owner.GetActor();
				if (actor == null)
				{
					Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbJumpState Enter without Owner Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.DirectorActor.SetActorTickEnabled(true);
				this.DirectorActor.SetSequence(seq);
				this.DirectorActor.SequencePlayer.OnFinished.Clear();
				this.DirectorActor.AddBindingByTag(RollBlockDefind.RB_SEQ_BINDING_TAG, actor, false, false);
				if (this.DirectorActor.SequencePlayer == null || !this.DirectorActor.SequencePlayer.IsValid())
				{
					Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbJumpState Enter without SequencePlayer", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.OnSeqEnd(false);
					return;
				}
				this.DirectorActor.SequencePlayer.SetPlayRate(1f);
				this.DirectorActor.SequencePlayer.Play();
				this.DirectorActor.SequencePlayer.OnFinished.Add(delegate()
				{
					this.OnSeqEnd(true);
				});
			}, 100, "js_undefined");
			this.IsFinishedInternal = false;
		}

		// Token: 0x06043D84 RID: 277892 RVA: 0x0109FB98 File Offset: 0x0109DD98
		private void GenerateStaticDirector()
		{
			if (this.DirectorActor == null)
			{
				this.DirectorActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
				this.DirectorActor.bOverrideInstanceData = true;
			}
		}

		// Token: 0x06043D85 RID: 277893 RVA: 0x0109FBD4 File Offset: 0x0109DDD4
		private void OnSeqEnd(bool needNotify = false)
		{
			this.DirectorActor.SetActorTickEnabled(false);
			this.DirectorActor.SetSequence(null);
			this.DirectorActor.RemoveBindingByTag(RollBlockDefind.RB_SEQ_BINDING_TAG, this.Owner.GetActor(), false);
			this.DirectorActor.SequencePlayer.OnFinished.Clear();
			if (needNotify && RollBlockController.Instance.IsCurrentIncId(this.Owner.IncId.Value))
			{
				base.NotifyServerMovementFinish();
			}
			this.IsFinishedInternal = true;
		}

		// Token: 0x0402374D RID: 145229
		public RbJumpMovement Info;

		// Token: 0x0402374E RID: 145230
		private ALevelSequenceActor DirectorActor;
	}
}
