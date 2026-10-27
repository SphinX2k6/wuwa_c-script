using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EF9 RID: 28409
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class DollPlayDescriptionItemTemplateData : MultiTemplateGridDataBase<IDollDescriptionItemData, DollPlayDescriptionItem>
	{
		// Token: 0x060452A2 RID: 283298 RVA: 0x0111B458 File Offset: 0x01119658
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x060452A3 RID: 283299 RVA: 0x0111B45B File Offset: 0x0111965B
		public override DollPlayDescriptionItem CreateProxy()
		{
			return new DollPlayDescriptionItem();
		}
	}
}
