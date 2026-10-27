using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006868 RID: 26728
	public class IFunctionT
	{
		// Token: 0x1700C68E RID: 50830
		// (get) Token: 0x0602E9D5 RID: 190933 RVA: 0x0065BA04 File Offset: 0x00659C04
		// (set) Token: 0x0602E9D6 RID: 190934 RVA: 0x0065BA0C File Offset: 0x00659C0C
		public string Name { get; set; }

		// Token: 0x1700C68F RID: 50831
		// (get) Token: 0x0602E9D7 RID: 190935 RVA: 0x0065BA15 File Offset: 0x00659C15
		// (set) Token: 0x0602E9D8 RID: 190936 RVA: 0x0065BA1D File Offset: 0x00659C1D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x0602E9D9 RID: 190937 RVA: 0x0065BA26 File Offset: 0x00659C26
		public IFunctionT()
		{
			this.Name = null;
			this.Actions = null;
		}
	}
}
