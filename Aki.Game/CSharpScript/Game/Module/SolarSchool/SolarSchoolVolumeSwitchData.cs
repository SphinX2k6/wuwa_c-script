using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A5E RID: 23134
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolVolumeSwitchData : MultiTemplateGridDataBase<EFunction, SolarSchoolVolumeSwitchItem>
	{
		// Token: 0x06038FE9 RID: 233449 RVA: 0x00FF69D2 File Offset: 0x00FF4BD2
		public SolarSchoolVolumeSwitchData(EFunction functionId)
		{
			base.Data = functionId;
		}

		// Token: 0x06038FEA RID: 233450 RVA: 0x00FF69E1 File Offset: 0x00FF4BE1
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06038FEB RID: 233451 RVA: 0x00FF69E4 File Offset: 0x00FF4BE4
		public override SolarSchoolVolumeSwitchItem CreateProxy()
		{
			return new SolarSchoolVolumeSwitchItem();
		}
	}
}
