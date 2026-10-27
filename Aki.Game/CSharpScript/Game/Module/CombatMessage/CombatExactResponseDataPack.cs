using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02005BAB RID: 23467
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatExactResponseDataPack
	{
		// Token: 0x0603B596 RID: 243094 RVA: 0x00E25BBD File Offset: 0x00E23DBD
		public CombatExactResponseDataPack(IMessage message, CombatResponseData.MessageOneofCase messageCase)
		{
		}

		// Token: 0x17008CF3 RID: 36083
		// (get) Token: 0x0603B597 RID: 243095 RVA: 0x00E25BD3 File Offset: 0x00E23DD3
		// (set) Token: 0x0603B598 RID: 243096 RVA: 0x00E25BDB File Offset: 0x00E23DDB
		public IMessage Message { get; private set; } = message;

		// Token: 0x17008CF4 RID: 36084
		// (get) Token: 0x0603B599 RID: 243097 RVA: 0x00E25BE4 File Offset: 0x00E23DE4
		// (set) Token: 0x0603B59A RID: 243098 RVA: 0x00E25BEC File Offset: 0x00E23DEC
		public CombatResponseData.MessageOneofCase MessageCase { get; private set; } = messageCase;
	}
}
