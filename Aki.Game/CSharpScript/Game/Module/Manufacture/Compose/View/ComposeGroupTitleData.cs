using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200463E RID: 17982
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class ComposeGroupTitleData : MultiTemplateGridDataBase<ComposeGroupTitleData_Data, ComposeGroupTitleItem>
	{
		// Token: 0x0602D34E RID: 185166 RVA: 0x00CA40C1 File Offset: 0x00CA22C1
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0602D34F RID: 185167 RVA: 0x00CA40C4 File Offset: 0x00CA22C4
		public override ComposeGroupTitleItem CreateProxy()
		{
			return new ComposeGroupTitleItem();
		}
	}
}
