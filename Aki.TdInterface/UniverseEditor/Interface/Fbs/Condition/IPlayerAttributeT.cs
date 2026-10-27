using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C83 RID: 19587
	public class IPlayerAttributeT
	{
		// Token: 0x17008E40 RID: 36416
		// (get) Token: 0x0601F115 RID: 127253 RVA: 0x004579B5 File Offset: 0x00455BB5
		// (set) Token: 0x0601F116 RID: 127254 RVA: 0x004579BD File Offset: 0x00455BBD
		public ETargetType Type { get; set; }

		// Token: 0x17008E41 RID: 36417
		// (get) Token: 0x0601F117 RID: 127255 RVA: 0x004579C6 File Offset: 0x00455BC6
		// (set) Token: 0x0601F118 RID: 127256 RVA: 0x004579CE File Offset: 0x00455BCE
		public EPlayerCheckType Option { get; set; }

		// Token: 0x17008E42 RID: 36418
		// (get) Token: 0x0601F119 RID: 127257 RVA: 0x004579D7 File Offset: 0x00455BD7
		// (set) Token: 0x0601F11A RID: 127258 RVA: 0x004579DF File Offset: 0x00455BDF
		public List<TPlayerAttributeUnion> AttributeTypes { get; set; }

		// Token: 0x0601F11B RID: 127259 RVA: 0x004579E8 File Offset: 0x00455BE8
		public IPlayerAttributeT()
		{
			this.Type = ETargetType.Player;
			this.Option = EPlayerCheckType.AnyRole;
			this.AttributeTypes = null;
		}
	}
}
