using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005106 RID: 20742
	public class IDynamicTrafficRewardT
	{
		// Token: 0x17009723 RID: 38691
		// (get) Token: 0x060216B4 RID: 136884 RVA: 0x004A3F68 File Offset: 0x004A2168
		// (set) Token: 0x060216B5 RID: 136885 RVA: 0x004A3F70 File Offset: 0x004A2170
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x17009724 RID: 38692
		// (get) Token: 0x060216B6 RID: 136886 RVA: 0x004A3F79 File Offset: 0x004A2179
		// (set) Token: 0x060216B7 RID: 136887 RVA: 0x004A3F81 File Offset: 0x004A2181
		public int RewardId { get; set; }

		// Token: 0x060216B8 RID: 136888 RVA: 0x004A3F8A File Offset: 0x004A218A
		public IDynamicTrafficRewardT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
			this.RewardId = 0;
		}
	}
}
