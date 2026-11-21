using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x020034A2 RID: 13474
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GameCommandWithReceivers<[Nullable(0)] T> : GameCommandWithValidators<T>, IGameCommandWithReceivers<T>, IGameCommand<T>, IGameCommandBase where T : ICommandType
	{
		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x06022552 RID: 140626 RVA: 0x009B9209 File Offset: 0x009B7409
		// (set) Token: 0x06022553 RID: 140627 RVA: 0x009B9211 File Offset: 0x009B7411
		public HashSet<IReceiver<T>> Receivers { get; set; } = new HashSet<IReceiver<T>>();

		// Token: 0x06022554 RID: 140628 RVA: 0x009B921A File Offset: 0x009B741A
		public GameCommandWithReceivers(TCommandHandleParams<T> @params)
		{
			base.Params = @params;
		}

		// Token: 0x06022555 RID: 140629 RVA: 0x009B9234 File Offset: 0x009B7434
		public void AddReceiver(IReceiver<T> receiver)
		{
			this.Receivers.Add(receiver);
		}

		// Token: 0x06022556 RID: 140630 RVA: 0x009B9243 File Offset: 0x009B7443
		public void RemoveReceiver(IReceiver<T> receiver)
		{
			this.Receivers.Remove(receiver);
		}
	}
}
