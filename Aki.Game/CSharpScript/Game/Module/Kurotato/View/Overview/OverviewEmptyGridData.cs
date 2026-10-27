using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005754 RID: 22356
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class OverviewEmptyGridData : MultiTemplateGridDataBase<int, EmptyGrid>
	{
		// Token: 0x06038D11 RID: 232721 RVA: 0x00D7E846 File Offset: 0x00D7CA46
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x06038D12 RID: 232722 RVA: 0x00D7E849 File Offset: 0x00D7CA49
		public override EmptyGrid CreateProxy()
		{
			return new EmptyGrid();
		}
	}
}
