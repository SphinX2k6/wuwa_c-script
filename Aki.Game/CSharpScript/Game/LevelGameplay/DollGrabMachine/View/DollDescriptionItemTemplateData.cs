using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EF8 RID: 28408
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class DollDescriptionItemTemplateData : MultiTemplateGridDataBase<IDollDescriptionItemData, DollDescriptionItem>
	{
		// Token: 0x0604529F RID: 283295 RVA: 0x0111B446 File Offset: 0x01119646
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060452A0 RID: 283296 RVA: 0x0111B449 File Offset: 0x01119649
		public override DollDescriptionItem CreateProxy()
		{
			return new DollDescriptionItem();
		}
	}
}
