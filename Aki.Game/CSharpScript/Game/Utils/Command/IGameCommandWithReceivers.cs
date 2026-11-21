using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x020034A0 RID: 13472
	[NullableContext(1)]
	public interface IGameCommandWithReceivers<[Nullable(0)] T> : IGameCommand<T>, IGameCommandBase where T : ICommandType
	{
		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x06022545 RID: 140613
		// (set) Token: 0x06022546 RID: 140614
		HashSet<IReceiver<T>> Receivers { get; set; }

		// Token: 0x06022547 RID: 140615
		void AddReceiver(IReceiver<T> receiver);

		// Token: 0x06022548 RID: 140616
		void RemoveReceiver(IReceiver<T> receiver);
	}
}
