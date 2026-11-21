using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004641 RID: 17985
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ComposeItemGridTemplateData : MultiTemplateGridDataBase<ComposeItemGridData, ComposeItemGridProxy>
	{
		// Token: 0x0602D358 RID: 185176 RVA: 0x00CA41B1 File Offset: 0x00CA23B1
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0602D359 RID: 185177 RVA: 0x00CA41B4 File Offset: 0x00CA23B4
		public override ComposeItemGridProxy CreateProxy()
		{
			return new ComposeItemGridProxy();
		}
	}
}
