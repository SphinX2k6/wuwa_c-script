using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005644 RID: 22084
	public class IDynamicEntityRewardTypeT
	{
		// Token: 0x17009EA8 RID: 40616
		// (get) Token: 0x06023497 RID: 144535 RVA: 0x004DAF12 File Offset: 0x004D9112
		// (set) Token: 0x06023498 RID: 144536 RVA: 0x004DAF1A File Offset: 0x004D911A
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x06023499 RID: 144537 RVA: 0x004DAF23 File Offset: 0x004D9123
		public IDynamicEntityRewardTypeT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
		}
	}
}
