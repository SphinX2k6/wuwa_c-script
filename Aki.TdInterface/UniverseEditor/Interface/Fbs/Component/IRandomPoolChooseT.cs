using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F1 RID: 22513
	public class IRandomPoolChooseT
	{
		// Token: 0x1700A828 RID: 43048
		// (get) Token: 0x06025D66 RID: 154982 RVA: 0x00537EA3 File Offset: 0x005360A3
		// (set) Token: 0x06025D67 RID: 154983 RVA: 0x00537EAB File Offset: 0x005360AB
		public EMonsterChooseType Type { get; set; }

		// Token: 0x1700A829 RID: 43049
		// (get) Token: 0x06025D68 RID: 154984 RVA: 0x00537EB4 File Offset: 0x005360B4
		// (set) Token: 0x06025D69 RID: 154985 RVA: 0x00537EBC File Offset: 0x005360BC
		public List<IRandomPoolConfigT> RandomPoolConfigs { get; set; }

		// Token: 0x06025D6A RID: 154986 RVA: 0x00537EC5 File Offset: 0x005360C5
		public IRandomPoolChooseT()
		{
			this.Type = EMonsterChooseType.RandomPoolChoose;
			this.RandomPoolConfigs = null;
		}
	}
}
