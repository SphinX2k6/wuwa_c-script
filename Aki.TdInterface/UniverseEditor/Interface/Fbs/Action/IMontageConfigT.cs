using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007229 RID: 29225
	public class IMontageConfigT
	{
		// Token: 0x1700D5EA RID: 54762
		// (get) Token: 0x06032DB2 RID: 208306 RVA: 0x006DDC4E File Offset: 0x006DBE4E
		// (set) Token: 0x06032DB3 RID: 208307 RVA: 0x006DDC56 File Offset: 0x006DBE56
		public EMontageConfigType Type { get; set; }

		// Token: 0x06032DB4 RID: 208308 RVA: 0x006DDC5F File Offset: 0x006DBE5F
		public IMontageConfigT()
		{
			this.Type = EMontageConfigType.Asset;
		}
	}
}
