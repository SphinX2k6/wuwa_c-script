using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E5 RID: 16869
	public class ITitlePreStateT
	{
		// Token: 0x170077AE RID: 30638
		// (get) Token: 0x06018DF4 RID: 101876 RVA: 0x003942A3 File Offset: 0x003924A3
		// (set) Token: 0x06018DF5 RID: 101877 RVA: 0x003942AB File Offset: 0x003924AB
		public string TidPreStateTitle { get; set; }

		// Token: 0x170077AF RID: 30639
		// (get) Token: 0x06018DF6 RID: 101878 RVA: 0x003942B4 File Offset: 0x003924B4
		// (set) Token: 0x06018DF7 RID: 101879 RVA: 0x003942BC File Offset: 0x003924BC
		public IConditionGroupT SwitchConditions { get; set; }

		// Token: 0x06018DF8 RID: 101880 RVA: 0x003942C5 File Offset: 0x003924C5
		public ITitlePreStateT()
		{
			this.TidPreStateTitle = null;
			this.SwitchConditions = null;
		}
	}
}
