using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.Command;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200713F RID: 28991
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PlayerFollowerSwallowHandler : IPlayerFollowerHandler
	{
		// Token: 0x17009D3A RID: 40250
		// (get) Token: 0x06046C70 RID: 289904 RVA: 0x011D6056 File Offset: 0x011D4256
		// (set) Token: 0x06046C71 RID: 289905 RVA: 0x011D605E File Offset: 0x011D425E
		public CommandInvoker CommandInvoker { get; set; } = new CommandSwallowInvoker();

		// Token: 0x06046C72 RID: 289906 RVA: 0x011D6067 File Offset: 0x011D4267
		public virtual IReceiver<ICommandTypeAddFollower> AddFollowerReceiver()
		{
			Receiver<ICommandTypeAddFollower> receiver = new Receiver<ICommandTypeAddFollower>();
			receiver.ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeAddFollower> _)
			{
			};
			return receiver;
		}

		// Token: 0x06046C73 RID: 289907 RVA: 0x011D6093 File Offset: 0x011D4293
		public virtual IReceiver<ICommandTypeRemoveFollower> RemoveFollowerReceiver()
		{
			Receiver<ICommandTypeRemoveFollower> receiver = new Receiver<ICommandTypeRemoveFollower>();
			receiver.ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeRemoveFollower> _)
			{
			};
			return receiver;
		}

		// Token: 0x06046C74 RID: 289908 RVA: 0x011D60BF File Offset: 0x011D42BF
		public virtual IReceiver<ICommandTypeFlushFollower> FlushFollowerReceiver()
		{
			Receiver<ICommandTypeFlushFollower> receiver = new Receiver<ICommandTypeFlushFollower>();
			receiver.ReceiveExecute = delegate(TCommandHandleParams<ICommandTypeFlushFollower> _)
			{
			};
			return receiver;
		}

		// Token: 0x06046C75 RID: 289909 RVA: 0x011D60EB File Offset: 0x011D42EB
		public virtual bool HasFollower(long creatureDataId)
		{
			return false;
		}

		// Token: 0x06046C76 RID: 289910 RVA: 0x011D60EE File Offset: 0x011D42EE
		public virtual void OnClear()
		{
		}
	}
}
