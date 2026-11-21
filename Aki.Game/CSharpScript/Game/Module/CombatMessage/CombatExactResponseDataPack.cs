using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B8B RID: 19339
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatExactResponseDataPack
	{
		// Token: 0x060304E3 RID: 197859 RVA: 0x00D75F35 File Offset: 0x00D74135
		public CombatExactResponseDataPack(IMessage message, CombatResponseData.MessageOneofCase messageCase)
		{
		}

		// Token: 0x170060C5 RID: 24773
		// (get) Token: 0x060304E4 RID: 197860 RVA: 0x00D75F4B File Offset: 0x00D7414B
		// (set) Token: 0x060304E5 RID: 197861 RVA: 0x00D75F53 File Offset: 0x00D74153
		public IMessage Message { get; private set; } = message;

		// Token: 0x170060C6 RID: 24774
		// (get) Token: 0x060304E6 RID: 197862 RVA: 0x00D75F5C File Offset: 0x00D7415C
		// (set) Token: 0x060304E7 RID: 197863 RVA: 0x00D75F64 File Offset: 0x00D74164
		public CombatResponseData.MessageOneofCase MessageCase { get; private set; } = messageCase;
	}
}
