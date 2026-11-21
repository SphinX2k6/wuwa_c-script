using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200597F RID: 22911
	public readonly struct SolarSchoolAttrRequire
	{
		// Token: 0x0603879A RID: 231322 RVA: 0x00FCBA4E File Offset: 0x00FC9C4E
		public SolarSchoolAttrRequire(ESolarSchoolSecondAttr attr, int requireValue)
		{
			this.Attr = attr;
			this.RequireValue = requireValue;
		}

		// Token: 0x0401DC3F RID: 121919
		public readonly ESolarSchoolSecondAttr Attr;

		// Token: 0x0401DC40 RID: 121920
		public readonly int RequireValue;
	}
}
