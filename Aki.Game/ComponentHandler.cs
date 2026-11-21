using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C76 RID: 3190
public class ComponentHandler : IHandler
{
	// Token: 0x17000ED6 RID: 3798
	// (get) Token: 0x0600854A RID: 34122 RVA: 0x0028C9A8 File Offset: 0x0028ABA8
	public EHandlerType Type
	{
		get
		{
			return EHandlerType.Component;
		}
	}

	// Token: 0x17000ED7 RID: 3799
	// (get) Token: 0x0600854B RID: 34123 RVA: 0x0028C9AB File Offset: 0x0028ABAB
	// (set) Token: 0x0600854C RID: 34124 RVA: 0x0028C9B3 File Offset: 0x0028ABB3
	public bool? IsSync { get; set; }

	// Token: 0x17000ED8 RID: 3800
	// (get) Token: 0x0600854D RID: 34125 RVA: 0x0028C9BC File Offset: 0x0028ABBC
	// (set) Token: 0x0600854E RID: 34126 RVA: 0x0028C9C4 File Offset: 0x0028ABC4
	public bool? IsCache { get; set; }

	// Token: 0x04005129 RID: 20777
	[Nullable(2)]
	public Type Component;
}
