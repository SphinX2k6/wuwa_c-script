using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200457A RID: 17786
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GameCommandWithReceivers<[Nullable(0)] T> : GameCommandWithValidators<T>, IGameCommandWithReceivers<T>, IGameCommand<T>, IGameCommandBase where T : ICommandType
	{
		// Token: 0x17007593 RID: 30099
		// (get) Token: 0x0602DE70 RID: 188016 RVA: 0x00A8DAF1 File Offset: 0x00A8BCF1
		// (set) Token: 0x0602DE71 RID: 188017 RVA: 0x00A8DAF9 File Offset: 0x00A8BCF9
		public HashSet<IReceiver<T>> Receivers { get; set; } = new HashSet<IReceiver<T>>();

		// Token: 0x0602DE72 RID: 188018 RVA: 0x00A8DB02 File Offset: 0x00A8BD02
		public GameCommandWithReceivers(TCommandHandleParams<T> @params)
		{
			base.Params = @params;
		}

		// Token: 0x0602DE73 RID: 188019 RVA: 0x00A8DB1C File Offset: 0x00A8BD1C
		public void AddReceiver(IReceiver<T> receiver)
		{
			this.Receivers.Add(receiver);
		}

		// Token: 0x0602DE74 RID: 188020 RVA: 0x00A8DB2B File Offset: 0x00A8BD2B
		public void RemoveReceiver(IReceiver<T> receiver)
		{
			this.Receivers.Remove(receiver);
		}
	}
}
