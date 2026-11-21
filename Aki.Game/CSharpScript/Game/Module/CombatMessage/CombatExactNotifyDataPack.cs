using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B89 RID: 19337
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatExactNotifyDataPack
	{
		// Token: 0x060304D9 RID: 197849 RVA: 0x00D75EC5 File Offset: 0x00D740C5
		public CombatExactNotifyDataPack(IMessage message, CombatNotifyData.MessageOneofCase messageCase)
		{
		}

		// Token: 0x170060C1 RID: 24769
		// (get) Token: 0x060304DA RID: 197850 RVA: 0x00D75EDB File Offset: 0x00D740DB
		// (set) Token: 0x060304DB RID: 197851 RVA: 0x00D75EE3 File Offset: 0x00D740E3
		public IMessage Message { get; private set; } = message;

		// Token: 0x170060C2 RID: 24770
		// (get) Token: 0x060304DC RID: 197852 RVA: 0x00D75EEC File Offset: 0x00D740EC
		// (set) Token: 0x060304DD RID: 197853 RVA: 0x00D75EF4 File Offset: 0x00D740F4
		public CombatNotifyData.MessageOneofCase MessageCase { get; private set; } = messageCase;
	}
}
