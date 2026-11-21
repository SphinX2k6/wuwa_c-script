using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200472B RID: 18219
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class OverviewEmptyGridData : MultiTemplateGridDataBase<int, EmptyGrid>
	{
		// Token: 0x0602DC21 RID: 187425 RVA: 0x00CCD226 File Offset: 0x00CCB426
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x0602DC22 RID: 187426 RVA: 0x00CCD229 File Offset: 0x00CCB429
		public override EmptyGrid CreateProxy()
		{
			return new EmptyGrid();
		}
	}
}
