using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.States
{
	// Token: 0x02005C09 RID: 23561
	public class RbIdleState : RbBaseMoveState
	{
		// Token: 0x06039DD6 RID: 237014 RVA: 0x0104408F File Offset: 0x0104228F
		[NullableContext(1)]
		public RbIdleState(RbBlockComponent owner) : base(owner)
		{
		}

		// Token: 0x06039DD7 RID: 237015 RVA: 0x01044098 File Offset: 0x01042298
		public override void Enter([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> info)
		{
			if (!RollBlockDefind.isRbBlockIdleState(info))
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbIdleState Enter without IdleState info", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.StateName = ERollBlockMoveState.Idle;
			this.Info = info.AsT1;
			this.Owner.AvailableInputDirs = new List<RbGridDirection>();
			global::Vector vector = global::Vector.Create();
			vector.FromConfigVector(this.Info.Position);
			global::Rotator rotation = global::Rotator.Create(this.Info.Rotation.Y, this.Info.Rotation.Z, this.Info.Rotation.X);
			this.Owner.SetActorLocationAndRotation(vector, rotation);
			this.IsFinishedInternal = true;
		}

		// Token: 0x0401E93E RID: 125246
		[Nullable(2)]
		public RbBlockIdlePbState Info;
	}
}
