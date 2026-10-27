using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005668 RID: 22120
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ComposeGroupTitleData : MultiTemplateGridDataBase<ComposeGroupTitleData_Data, ComposeGroupTitleItem>
	{
		// Token: 0x06038450 RID: 230480 RVA: 0x00D56135 File Offset: 0x00D54335
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038451 RID: 230481 RVA: 0x00D56138 File Offset: 0x00D54338
		public override ComposeGroupTitleItem CreateProxy()
		{
			return new ComposeGroupTitleItem();
		}
	}
}
