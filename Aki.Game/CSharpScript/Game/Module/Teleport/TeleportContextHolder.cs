using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B12 RID: 15122
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportContextHolder
	{
		// Token: 0x06026D40 RID: 159040 RVA: 0x00ADDB07 File Offset: 0x00ADBD07
		public TeleportContextHolder(TeleportContext context)
		{
		}

		// Token: 0x0401539E RID: 86942
		public readonly TeleportContext TeleportContext = context;
	}
}
