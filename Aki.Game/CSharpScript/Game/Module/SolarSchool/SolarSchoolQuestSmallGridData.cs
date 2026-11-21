using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059EB RID: 23019
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolQuestSmallGridData : MultiTemplateGridDataBase<int, SolarSchoolQuestSmallItem>
	{
		// Token: 0x06038B25 RID: 232229 RVA: 0x00FDE75F File Offset: 0x00FDC95F
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06038B26 RID: 232230 RVA: 0x00FDE762 File Offset: 0x00FDC962
		public override SolarSchoolQuestSmallItem CreateProxy()
		{
			return new SolarSchoolQuestSmallItem();
		}
	}
}
