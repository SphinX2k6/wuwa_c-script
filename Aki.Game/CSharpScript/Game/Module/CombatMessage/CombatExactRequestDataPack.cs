using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;
using Google.Protobuf;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B8A RID: 19338
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatExactRequestDataPack
	{
		// Token: 0x060304DE RID: 197854 RVA: 0x00D75EFD File Offset: 0x00D740FD
		public CombatExactRequestDataPack(IMessage message, CombatRequestData.MessageOneofCase messageCase)
		{
		}

		// Token: 0x170060C3 RID: 24771
		// (get) Token: 0x060304DF RID: 197855 RVA: 0x00D75F13 File Offset: 0x00D74113
		// (set) Token: 0x060304E0 RID: 197856 RVA: 0x00D75F1B File Offset: 0x00D7411B
		public IMessage Message { get; private set; } = message;

		// Token: 0x170060C4 RID: 24772
		// (get) Token: 0x060304E1 RID: 197857 RVA: 0x00D75F24 File Offset: 0x00D74124
		// (set) Token: 0x060304E2 RID: 197858 RVA: 0x00D75F2C File Offset: 0x00D7412C
		public CombatRequestData.MessageOneofCase MessageCase { get; private set; } = messageCase;
	}
}
