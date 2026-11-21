using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A5A RID: 23130
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolVolumeTitleData : MultiTemplateGridDataBase<EFunction, SolarSchoolVolumeTitleItem>
	{
		// Token: 0x06038FD8 RID: 233432 RVA: 0x00FF663F File Offset: 0x00FF483F
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038FD9 RID: 233433 RVA: 0x00FF6642 File Offset: 0x00FF4842
		public override SolarSchoolVolumeTitleItem CreateProxy()
		{
			return new SolarSchoolVolumeTitleItem();
		}

		// Token: 0x06038FDA RID: 233434 RVA: 0x00FF6649 File Offset: 0x00FF4849
		public override bool IsNavigable()
		{
			return false;
		}
	}
}
