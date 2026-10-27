using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200566B RID: 22123
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ComposeItemGridTemplateData : MultiTemplateGridDataBase<ComposeItemGridData, ComposeItemGridProxy>
	{
		// Token: 0x0603845A RID: 230490 RVA: 0x00D56225 File Offset: 0x00D54425
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603845B RID: 230491 RVA: 0x00D56228 File Offset: 0x00D54428
		public override ComposeItemGridProxy CreateProxy()
		{
			return new ComposeItemGridProxy();
		}
	}
}
