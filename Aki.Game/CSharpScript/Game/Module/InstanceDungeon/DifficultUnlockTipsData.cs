using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005860 RID: 22624
	[NullableContext(1)]
	[Nullable(0)]
	public class DifficultUnlockTipsData
	{
		// Token: 0x17008A5A RID: 35418
		// (get) Token: 0x06039856 RID: 235606 RVA: 0x00DA8492 File Offset: 0x00DA6692
		// (set) Token: 0x06039857 RID: 235607 RVA: 0x00DA849A File Offset: 0x00DA669A
		public string Text { get; set; } = string.Empty;

		// Token: 0x17008A5B RID: 35419
		// (get) Token: 0x06039858 RID: 235608 RVA: 0x00DA84A3 File Offset: 0x00DA66A3
		// (set) Token: 0x06039859 RID: 235609 RVA: 0x00DA84AB File Offset: 0x00DA66AB
		public object[] Params { get; set; } = Array.Empty<object>();
	}
}
