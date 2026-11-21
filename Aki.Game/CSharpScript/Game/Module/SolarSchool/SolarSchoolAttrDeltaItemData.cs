using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200598C RID: 22924
	public readonly struct SolarSchoolAttrDeltaItemData
	{
		// Token: 0x06038865 RID: 231525 RVA: 0x00FD096A File Offset: 0x00FCEB6A
		public SolarSchoolAttrDeltaItemData(ESolarSchoolSecondAttr attr, int delta)
		{
			this.Attr = attr;
			this.Delta = delta;
			this.FatigueBase = 0;
			this.HasFatigueBase = false;
		}

		// Token: 0x06038866 RID: 231526 RVA: 0x00FD0988 File Offset: 0x00FCEB88
		public SolarSchoolAttrDeltaItemData(ESolarSchoolSecondAttr attr, int delta, int fatigueBase)
		{
			this.Attr = attr;
			this.Delta = delta;
			this.FatigueBase = fatigueBase;
			this.HasFatigueBase = true;
		}

		// Token: 0x0401DC6F RID: 121967
		public readonly ESolarSchoolSecondAttr Attr;

		// Token: 0x0401DC70 RID: 121968
		public readonly int Delta;

		// Token: 0x0401DC71 RID: 121969
		public readonly int FatigueBase;

		// Token: 0x0401DC72 RID: 121970
		public readonly bool HasFatigueBase;
	}
}
