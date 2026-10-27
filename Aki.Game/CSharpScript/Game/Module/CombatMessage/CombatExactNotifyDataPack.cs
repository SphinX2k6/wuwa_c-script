using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02005BA9 RID: 23465
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatExactNotifyDataPack
	{
		// Token: 0x0603B58C RID: 243084 RVA: 0x00E25B4D File Offset: 0x00E23D4D
		public CombatExactNotifyDataPack(IMessage message, CombatNotifyData.MessageOneofCase messageCase)
		{
		}

		// Token: 0x17008CEF RID: 36079
		// (get) Token: 0x0603B58D RID: 243085 RVA: 0x00E25B63 File Offset: 0x00E23D63
		// (set) Token: 0x0603B58E RID: 243086 RVA: 0x00E25B6B File Offset: 0x00E23D6B
		public IMessage Message { get; private set; } = message;

		// Token: 0x17008CF0 RID: 36080
		// (get) Token: 0x0603B58F RID: 243087 RVA: 0x00E25B74 File Offset: 0x00E23D74
		// (set) Token: 0x0603B590 RID: 243088 RVA: 0x00E25B7C File Offset: 0x00E23D7C
		public CombatNotifyData.MessageOneofCase MessageCase { get; private set; } = messageCase;
	}
}
