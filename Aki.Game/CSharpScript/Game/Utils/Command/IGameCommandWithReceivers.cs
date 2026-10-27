using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004578 RID: 17784
	[NullableContext(1)]
	public interface IGameCommandWithReceivers<[Nullable(0)] T> : IGameCommand<T>, IGameCommandBase where T : ICommandType
	{
		// Token: 0x1700758F RID: 30095
		// (get) Token: 0x0602DE63 RID: 188003
		// (set) Token: 0x0602DE64 RID: 188004
		HashSet<IReceiver<T>> Receivers { get; set; }

		// Token: 0x0602DE65 RID: 188005
		void AddReceiver(IReceiver<T> receiver);

		// Token: 0x0602DE66 RID: 188006
		void RemoveReceiver(IReceiver<T> receiver);
	}
}
