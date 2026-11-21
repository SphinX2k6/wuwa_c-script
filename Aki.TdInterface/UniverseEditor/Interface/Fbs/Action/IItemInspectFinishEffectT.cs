using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007077 RID: 28791
	public class IItemInspectFinishEffectT
	{
		// Token: 0x1700D2DA RID: 53978
		// (get) Token: 0x06031EE3 RID: 204515 RVA: 0x006C1FDD File Offset: 0x006C01DD
		// (set) Token: 0x06031EE4 RID: 204516 RVA: 0x006C1FE5 File Offset: 0x006C01E5
		public List<TInteractEffectUnion> EffectList { get; set; }

		// Token: 0x1700D2DB RID: 53979
		// (get) Token: 0x06031EE5 RID: 204517 RVA: 0x006C1FEE File Offset: 0x006C01EE
		// (set) Token: 0x06031EE6 RID: 204518 RVA: 0x006C1FF6 File Offset: 0x006C01F6
		public float ProtectTime { get; set; }

		// Token: 0x1700D2DC RID: 53980
		// (get) Token: 0x06031EE7 RID: 204519 RVA: 0x006C1FFF File Offset: 0x006C01FF
		// (set) Token: 0x06031EE8 RID: 204520 RVA: 0x006C2007 File Offset: 0x006C0207
		public byte NullMask { get; set; }

		// Token: 0x06031EE9 RID: 204521 RVA: 0x006C2010 File Offset: 0x006C0210
		public IItemInspectFinishEffectT()
		{
			this.EffectList = null;
			this.ProtectTime = 0f;
			this.NullMask = 0;
		}
	}
}
