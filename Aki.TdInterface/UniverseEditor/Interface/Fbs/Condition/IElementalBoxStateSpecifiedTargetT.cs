using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C08 RID: 19464
	public class IElementalBoxStateSpecifiedTargetT
	{
		// Token: 0x17008D65 RID: 36197
		// (get) Token: 0x0601ED3B RID: 126267 RVA: 0x00451191 File Offset: 0x0044F391
		// (set) Token: 0x0601ED3C RID: 126268 RVA: 0x00451199 File Offset: 0x0044F399
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x17008D66 RID: 36198
		// (get) Token: 0x0601ED3D RID: 126269 RVA: 0x004511A2 File Offset: 0x0044F3A2
		// (set) Token: 0x0601ED3E RID: 126270 RVA: 0x004511AA File Offset: 0x0044F3AA
		public int ElementalBoxId { get; set; }

		// Token: 0x17008D67 RID: 36199
		// (get) Token: 0x0601ED3F RID: 126271 RVA: 0x004511B3 File Offset: 0x0044F3B3
		// (set) Token: 0x0601ED40 RID: 126272 RVA: 0x004511BB File Offset: 0x0044F3BB
		public string State { get; set; }

		// Token: 0x0601ED41 RID: 126273 RVA: 0x004511C4 File Offset: 0x0044F3C4
		public IElementalBoxStateSpecifiedTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.ElementalBoxId = 0;
			this.State = null;
		}
	}
}
