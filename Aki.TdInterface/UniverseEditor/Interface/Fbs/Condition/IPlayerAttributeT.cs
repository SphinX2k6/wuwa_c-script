using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200517C RID: 20860
	public class IPlayerAttributeT
	{
		// Token: 0x1700956E RID: 38254
		// (get) Token: 0x06020D37 RID: 134455 RVA: 0x0048B505 File Offset: 0x00489705
		// (set) Token: 0x06020D38 RID: 134456 RVA: 0x0048B50D File Offset: 0x0048970D
		public ETargetType Type { get; set; }

		// Token: 0x1700956F RID: 38255
		// (get) Token: 0x06020D39 RID: 134457 RVA: 0x0048B516 File Offset: 0x00489716
		// (set) Token: 0x06020D3A RID: 134458 RVA: 0x0048B51E File Offset: 0x0048971E
		public EPlayerCheckType Option { get; set; }

		// Token: 0x17009570 RID: 38256
		// (get) Token: 0x06020D3B RID: 134459 RVA: 0x0048B527 File Offset: 0x00489727
		// (set) Token: 0x06020D3C RID: 134460 RVA: 0x0048B52F File Offset: 0x0048972F
		public List<TPlayerAttributeUnion> AttributeTypes { get; set; }

		// Token: 0x06020D3D RID: 134461 RVA: 0x0048B538 File Offset: 0x00489738
		public IPlayerAttributeT()
		{
			this.Type = ETargetType.Player;
			this.Option = EPlayerCheckType.AnyRole;
			this.AttributeTypes = null;
		}
	}
}
