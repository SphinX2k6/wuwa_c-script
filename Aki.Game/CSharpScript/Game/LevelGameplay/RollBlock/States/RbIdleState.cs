using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.States
{
	// Token: 0x02006AAC RID: 27308
	public class RbIdleState : RbBaseMoveState
	{
		// Token: 0x06043D80 RID: 277888 RVA: 0x0109F986 File Offset: 0x0109DB86
		[NullableContext(1)]
		public RbIdleState(RbBlockComponent owner) : base(owner)
		{
		}

		// Token: 0x06043D81 RID: 277889 RVA: 0x0109F990 File Offset: 0x0109DB90
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

		// Token: 0x0402374C RID: 145228
		[Nullable(2)]
		public RbBlockIdlePbState Info;
	}
}
