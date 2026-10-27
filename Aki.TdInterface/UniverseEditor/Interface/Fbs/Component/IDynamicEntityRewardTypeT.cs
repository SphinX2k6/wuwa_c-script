using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050DF RID: 20703
	public class IDynamicEntityRewardTypeT
	{
		// Token: 0x170096BB RID: 38587
		// (get) Token: 0x06021543 RID: 136515 RVA: 0x004A0F86 File Offset: 0x0049F186
		// (set) Token: 0x06021544 RID: 136516 RVA: 0x004A0F8E File Offset: 0x0049F18E
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x06021545 RID: 136517 RVA: 0x004A0F97 File Offset: 0x0049F197
		public IDynamicEntityRewardTypeT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
		}
	}
}
