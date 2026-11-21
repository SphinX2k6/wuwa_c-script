using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B9 RID: 18105
	public class IUseVarT
	{
		// Token: 0x17007ED4 RID: 32468
		// (get) Token: 0x0601A9B3 RID: 108979 RVA: 0x003C8ACF File Offset: 0x003C6CCF
		// (set) Token: 0x0601A9B4 RID: 108980 RVA: 0x003C8AD7 File Offset: 0x003C6CD7
		public EProgressBarLeftType Type { get; set; }

		// Token: 0x17007ED5 RID: 32469
		// (get) Token: 0x0601A9B5 RID: 108981 RVA: 0x003C8AE0 File Offset: 0x003C6CE0
		// (set) Token: 0x0601A9B6 RID: 108982 RVA: 0x003C8AE8 File Offset: 0x003C6CE8
		public TVarRefUnion Var { get; set; }

		// Token: 0x0601A9B7 RID: 108983 RVA: 0x003C8AF1 File Offset: 0x003C6CF1
		public IUseVarT()
		{
			this.Type = EProgressBarLeftType.UseCount;
			this.Var = null;
		}
	}
}
