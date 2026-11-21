using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.Command;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200636D RID: 25453
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PlayerFollowerSwallowHandler : IPlayerFollowerHandler
	{
		// Token: 0x1700750C RID: 29964
		// (get) Token: 0x0603DAC1 RID: 252609 RVA: 0x011DEA6B File Offset: 0x011DCC6B
		// (set) Token: 0x0603DAC2 RID: 252610 RVA: 0x011DEA73 File Offset: 0x011DCC73
		public CommandInvoker CommandInvoker { get; set; } = new CommandSwallowInvoker();

		// Token: 0x0603DAC3 RID: 252611 RVA: 0x011DEA7C File Offset: 0x011DCC7C
		public virtual IReceiver<ICommandTypeAddFollower> AddFollowerReceiver()
		{
			Receiver<ICommandTypeAddFollower> receiver = new Receiver<ICommandTypeAddFollower>();
			receiver.ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeAddFollower> _)
			{
			};
			return receiver;
		}

		// Token: 0x0603DAC4 RID: 252612 RVA: 0x011DEAA8 File Offset: 0x011DCCA8
		public virtual IReceiver<ICommandTypeRemoveFollower> RemoveFollowerReceiver()
		{
			Receiver<ICommandTypeRemoveFollower> receiver = new Receiver<ICommandTypeRemoveFollower>();
			receiver.ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeRemoveFollower> _)
			{
			};
			return receiver;
		}

		// Token: 0x0603DAC5 RID: 252613 RVA: 0x011DEAD4 File Offset: 0x011DCCD4
		public virtual IReceiver<ICommandTypeFlushFollower> FlushFollowerReceiver()
		{
			Receiver<ICommandTypeFlushFollower> receiver = new Receiver<ICommandTypeFlushFollower>();
			receiver.ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeFlushFollower> _)
			{
			};
			return receiver;
		}

		// Token: 0x0603DAC6 RID: 252614 RVA: 0x011DEB00 File Offset: 0x011DCD00
		public virtual bool HasFollower(long creatureDataId)
		{
			return false;
		}

		// Token: 0x0603DAC7 RID: 252615 RVA: 0x011DEB03 File Offset: 0x011DCD03
		public virtual void OnClear()
		{
		}
	}
}
