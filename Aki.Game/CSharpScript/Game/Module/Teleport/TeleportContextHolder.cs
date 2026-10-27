using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B68 RID: 19304
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportContextHolder
	{
		// Token: 0x06031FA6 RID: 204710 RVA: 0x00B9967C File Offset: 0x00B9787C
		public TeleportContextHolder(TeleportContext context)
		{
		}

		// Token: 0x0401AA46 RID: 109126
		public readonly TeleportContext TeleportContext = context;
	}
}
