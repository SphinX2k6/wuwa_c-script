using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A50 RID: 19024
	public class IVariableRewardConfigT
	{
		// Token: 0x1700857F RID: 34175
		// (get) Token: 0x0601C978 RID: 117112 RVA: 0x00409067 File Offset: 0x00407267
		// (set) Token: 0x0601C979 RID: 117113 RVA: 0x0040906F File Offset: 0x0040726F
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17008580 RID: 34176
		// (get) Token: 0x0601C97A RID: 117114 RVA: 0x00409078 File Offset: 0x00407278
		// (set) Token: 0x0601C97B RID: 117115 RVA: 0x00409080 File Offset: 0x00407280
		public ECompare Compare { get; set; }

		// Token: 0x17008581 RID: 34177
		// (get) Token: 0x0601C97C RID: 117116 RVA: 0x00409089 File Offset: 0x00407289
		// (set) Token: 0x0601C97D RID: 117117 RVA: 0x00409091 File Offset: 0x00407291
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x17008582 RID: 34178
		// (get) Token: 0x0601C97E RID: 117118 RVA: 0x0040909A File Offset: 0x0040729A
		// (set) Token: 0x0601C97F RID: 117119 RVA: 0x004090A2 File Offset: 0x004072A2
		public int RewardId { get; set; }

		// Token: 0x0601C980 RID: 117120 RVA: 0x004090AB File Offset: 0x004072AB
		public IVariableRewardConfigT()
		{
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
			this.RewardId = 0;
		}
	}
}
