using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006078 RID: 24696
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class DollDescriptionItemTemplateData : MultiTemplateGridDataBase<IDollDescriptionItemData, DollDescriptionItem>
	{
		// Token: 0x0603B448 RID: 242760 RVA: 0x010C51D6 File Offset: 0x010C33D6
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603B449 RID: 242761 RVA: 0x010C51D9 File Offset: 0x010C33D9
		public override DollDescriptionItem CreateProxy()
		{
			return new DollDescriptionItem();
		}
	}
}
