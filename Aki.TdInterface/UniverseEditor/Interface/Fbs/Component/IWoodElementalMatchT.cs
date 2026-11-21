using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A0 RID: 24992
	public class IWoodElementalMatchT
	{
		// Token: 0x1700BA5F RID: 47711
		// (get) Token: 0x0602A7A1 RID: 173985 RVA: 0x005CB342 File Offset: 0x005C9542
		// (set) Token: 0x0602A7A2 RID: 173986 RVA: 0x005CB34A File Offset: 0x005C954A
		public EElementalType Type { get; set; }

		// Token: 0x0602A7A3 RID: 173987 RVA: 0x005CB353 File Offset: 0x005C9553
		public IWoodElementalMatchT()
		{
			this.Type = EElementalType.Fire;
		}
	}
}
