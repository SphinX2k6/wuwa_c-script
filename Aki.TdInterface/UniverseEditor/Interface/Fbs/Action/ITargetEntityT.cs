using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735C RID: 29532
	public class ITargetEntityT
	{
		// Token: 0x1700E048 RID: 57416
		// (get) Token: 0x060359AA RID: 219562 RVA: 0x0074CF10 File Offset: 0x0074B110
		// (set) Token: 0x060359AB RID: 219563 RVA: 0x0074CF18 File Offset: 0x0074B118
		public ETargetEntityType Type { get; set; }

		// Token: 0x1700E049 RID: 57417
		// (get) Token: 0x060359AC RID: 219564 RVA: 0x0074CF21 File Offset: 0x0074B121
		// (set) Token: 0x060359AD RID: 219565 RVA: 0x0074CF29 File Offset: 0x0074B129
		public int EntityId { get; set; }

		// Token: 0x060359AE RID: 219566 RVA: 0x0074CF32 File Offset: 0x0074B132
		public ITargetEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.EntityId = 0;
		}
	}
}
