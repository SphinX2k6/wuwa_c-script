using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.Command;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006368 RID: 25448
	[NullableContext(1)]
	public interface IPlayerFollowerHandler
	{
		// Token: 0x1700750B RID: 29963
		// (get) Token: 0x0603DAA6 RID: 252582
		CommandInvoker CommandInvoker { get; }

		// Token: 0x0603DAA7 RID: 252583
		IReceiver<ICommandTypeAddFollower> AddFollowerReceiver();

		// Token: 0x0603DAA8 RID: 252584
		IReceiver<ICommandTypeRemoveFollower> RemoveFollowerReceiver();

		// Token: 0x0603DAA9 RID: 252585
		IReceiver<ICommandTypeFlushFollower> FlushFollowerReceiver();

		// Token: 0x0603DAAA RID: 252586
		void OnClear();

		// Token: 0x0603DAAB RID: 252587
		bool HasFollower(long creatureDataId);
	}
}
