using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566B RID: 22123
	public class IDynamicTrafficRewardT
	{
		// Token: 0x17009F10 RID: 40720
		// (get) Token: 0x06023608 RID: 144904 RVA: 0x004DDEF4 File Offset: 0x004DC0F4
		// (set) Token: 0x06023609 RID: 144905 RVA: 0x004DDEFC File Offset: 0x004DC0FC
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x17009F11 RID: 40721
		// (get) Token: 0x0602360A RID: 144906 RVA: 0x004DDF05 File Offset: 0x004DC105
		// (set) Token: 0x0602360B RID: 144907 RVA: 0x004DDF0D File Offset: 0x004DC10D
		public int RewardId { get; set; }

		// Token: 0x0602360C RID: 144908 RVA: 0x004DDF16 File Offset: 0x004DC116
		public IDynamicTrafficRewardT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
			this.RewardId = 0;
		}
	}
}
