using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059EA RID: 23018
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolQuestBigGridData : MultiTemplateGridDataBase<int, SolarSchoolQuestBigItem>
	{
		// Token: 0x06038B22 RID: 232226 RVA: 0x00FDE741 File Offset: 0x00FDC941
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038B23 RID: 232227 RVA: 0x00FDE744 File Offset: 0x00FDC944
		public override SolarSchoolQuestBigItem CreateProxy()
		{
			SolarSchoolQuestBigItem solarSchoolQuestBigItem = new SolarSchoolQuestBigItem();
			solarSchoolQuestBigItem.SetClickCallback(this.ClickCallback);
			return solarSchoolQuestBigItem;
		}

		// Token: 0x0401DDA9 RID: 122281
		[Nullable(2)]
		public Action<int> ClickCallback;
	}
}
