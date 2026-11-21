using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020021D5 RID: 8661
public class UiCalabashAnsContext : UiAnsContextBase
{
	// Token: 0x17002046 RID: 8262
	// (get) Token: 0x0601551A RID: 87322 RVA: 0x00632F31 File Offset: 0x00631131
	public FName Socket { get; }

	// Token: 0x17002047 RID: 8263
	// (get) Token: 0x0601551B RID: 87323 RVA: 0x00632F39 File Offset: 0x00631139
	public bool IsRotate { get; }

	// Token: 0x0601551C RID: 87324 RVA: 0x00632F41 File Offset: 0x00631141
	public UiCalabashAnsContext(FName socket, bool isRotate)
	{
		this.Socket = socket;
		this.IsRotate = isRotate;
	}

	// Token: 0x0601551D RID: 87325 RVA: 0x00632F58 File Offset: 0x00631158
	[NullableContext(1)]
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiCalabashAnsContext uiCalabashAnsContext = inAnsContext as UiCalabashAnsContext;
		return uiCalabashAnsContext != null && this.Socket == uiCalabashAnsContext.Socket;
	}
}
