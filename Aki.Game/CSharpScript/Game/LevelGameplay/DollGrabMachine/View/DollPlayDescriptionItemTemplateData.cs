using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006079 RID: 24697
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class DollPlayDescriptionItemTemplateData : MultiTemplateGridDataBase<IDollDescriptionItemData, DollPlayDescriptionItem>
	{
		// Token: 0x0603B44B RID: 242763 RVA: 0x010C51E8 File Offset: 0x010C33E8
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603B44C RID: 242764 RVA: 0x010C51EB File Offset: 0x010C33EB
		public override DollPlayDescriptionItem CreateProxy()
		{
			return new DollPlayDescriptionItem();
		}
	}
}
