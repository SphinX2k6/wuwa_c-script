using System;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005981 RID: 22913
	public readonly struct SolarSchoolOptionInfo
	{
		// Token: 0x060387CF RID: 231375 RVA: 0x00FCD896 File Offset: 0x00FCBA96
		public SolarSchoolOptionInfo(SolarSchoolOptions row, bool canClick)
		{
			this.Row = row;
			this.CanClick = canClick;
		}

		// Token: 0x0401DC45 RID: 121925
		public readonly SolarSchoolOptions Row;

		// Token: 0x0401DC46 RID: 121926
		public readonly bool CanClick;
	}
}
