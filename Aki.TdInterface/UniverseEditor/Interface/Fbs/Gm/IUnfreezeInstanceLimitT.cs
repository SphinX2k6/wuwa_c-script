using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B32 RID: 19250
	public class IUnfreezeInstanceLimitT
	{
		// Token: 0x17008707 RID: 34567
		// (get) Token: 0x0601D0AC RID: 118956 RVA: 0x00414E12 File Offset: 0x00413012
		// (set) Token: 0x0601D0AD RID: 118957 RVA: 0x00414E1A File Offset: 0x0041301A
		public EGmCommand Type { get; set; }

		// Token: 0x0601D0AE RID: 118958 RVA: 0x00414E23 File Offset: 0x00413023
		public IUnfreezeInstanceLimitT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
