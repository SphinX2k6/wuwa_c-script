using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5A RID: 23130
	public class ILevelAiPointOffsetConfigT
	{
		// Token: 0x1700A83C RID: 43068
		// (get) Token: 0x06025D58 RID: 154968 RVA: 0x0052F863 File Offset: 0x0052DA63
		// (set) Token: 0x06025D59 RID: 154969 RVA: 0x0052F86B File Offset: 0x0052DA6B
		public float Radius { get; set; }

		// Token: 0x1700A83D RID: 43069
		// (get) Token: 0x06025D5A RID: 154970 RVA: 0x0052F874 File Offset: 0x0052DA74
		// (set) Token: 0x06025D5B RID: 154971 RVA: 0x0052F87C File Offset: 0x0052DA7C
		public IVectorInfoT Normal { get; set; }

		// Token: 0x06025D5C RID: 154972 RVA: 0x0052F885 File Offset: 0x0052DA85
		public ILevelAiPointOffsetConfigT()
		{
			this.Radius = 0f;
			this.Normal = null;
		}
	}
}
