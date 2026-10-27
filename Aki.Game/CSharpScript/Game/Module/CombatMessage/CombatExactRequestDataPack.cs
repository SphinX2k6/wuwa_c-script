using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02005BAA RID: 23466
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatExactRequestDataPack
	{
		// Token: 0x0603B591 RID: 243089 RVA: 0x00E25B85 File Offset: 0x00E23D85
		public CombatExactRequestDataPack(IMessage message, CombatRequestData.MessageOneofCase messageCase)
		{
		}

		// Token: 0x17008CF1 RID: 36081
		// (get) Token: 0x0603B592 RID: 243090 RVA: 0x00E25B9B File Offset: 0x00E23D9B
		// (set) Token: 0x0603B593 RID: 243091 RVA: 0x00E25BA3 File Offset: 0x00E23DA3
		public IMessage Message { get; private set; } = message;

		// Token: 0x17008CF2 RID: 36082
		// (get) Token: 0x0603B594 RID: 243092 RVA: 0x00E25BAC File Offset: 0x00E23DAC
		// (set) Token: 0x0603B595 RID: 243093 RVA: 0x00E25BB4 File Offset: 0x00E23DB4
		public CombatRequestData.MessageOneofCase MessageCase { get; private set; } = messageCase;
	}
}
