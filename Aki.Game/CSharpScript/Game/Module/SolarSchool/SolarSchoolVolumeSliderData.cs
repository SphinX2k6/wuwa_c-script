using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A5C RID: 23132
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolVolumeSliderData : MultiTemplateGridDataBase<EFunction, SolarSchoolVolumeSliderItem>
	{
		// Token: 0x06038FDF RID: 233439 RVA: 0x00FF672B File Offset: 0x00FF492B
		public SolarSchoolVolumeSliderData(EFunction functionId)
		{
			base.Data = functionId;
		}

		// Token: 0x06038FE0 RID: 233440 RVA: 0x00FF673A File Offset: 0x00FF493A
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x06038FE1 RID: 233441 RVA: 0x00FF673D File Offset: 0x00FF493D
		public override SolarSchoolVolumeSliderItem CreateProxy()
		{
			return new SolarSchoolVolumeSliderItem();
		}
	}
}
