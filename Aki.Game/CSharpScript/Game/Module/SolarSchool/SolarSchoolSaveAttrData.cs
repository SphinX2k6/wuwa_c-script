using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A02 RID: 23042
	public readonly struct SolarSchoolSaveAttrData
	{
		// Token: 0x06038BDD RID: 232413 RVA: 0x00FE18EE File Offset: 0x00FDFAEE
		public SolarSchoolSaveAttrData(int activityId, ESolarSchoolSecondAttr attr, int value)
		{
			this.ActivityId = activityId;
			this.Attr = attr;
			this.Value = value;
		}

		// Token: 0x0401DDF5 RID: 122357
		public readonly int ActivityId;

		// Token: 0x0401DDF6 RID: 122358
		public readonly ESolarSchoolSecondAttr Attr;

		// Token: 0x0401DDF7 RID: 122359
		public readonly int Value;
	}
}
