using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.Command;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200713A RID: 28986
	[NullableContext(1)]
	public interface IPlayerFollowerHandler
	{
		// Token: 0x17009D39 RID: 40249
		// (get) Token: 0x06046C55 RID: 289877
		CommandInvoker CommandInvoker { get; }

		// Token: 0x06046C56 RID: 289878
		IReceiver<ICommandTypeAddFollower> AddFollowerReceiver();

		// Token: 0x06046C57 RID: 289879
		IReceiver<ICommandTypeRemoveFollower> RemoveFollowerReceiver();

		// Token: 0x06046C58 RID: 289880
		IReceiver<ICommandTypeFlushFollower> FlushFollowerReceiver();

		// Token: 0x06046C59 RID: 289881
		void OnClear();

		// Token: 0x06046C5A RID: 289882
		bool HasFollower(long creatureDataId);
	}
}
