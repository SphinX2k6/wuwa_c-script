using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200067B RID: 1659
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)]
	public class CompilationRelaxationsAttribute : Attribute
	{
		// Token: 0x0600738E RID: 29582 RVA: 0x00113493 File Offset: 0x00111693
		public CompilationRelaxationsAttribute(int relaxations)
		{
			this.CompilationRelaxations = relaxations;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x00113493 File Offset: 0x00111693
		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		{
			this.CompilationRelaxations = relaxations;
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06007390 RID: 29584 RVA: 0x001134A2 File Offset: 0x001116A2
		public int CompilationRelaxations { get; }
	}
}
