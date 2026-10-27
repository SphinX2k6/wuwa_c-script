using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C7 RID: 27079
	public class IItemInspectFinishEffectT
	{
		// Token: 0x1700C8DA RID: 51418
		// (get) Token: 0x0602F523 RID: 193827 RVA: 0x00671C85 File Offset: 0x0066FE85
		// (set) Token: 0x0602F524 RID: 193828 RVA: 0x00671C8D File Offset: 0x0066FE8D
		public List<TInteractEffectUnion> EffectList { get; set; }

		// Token: 0x1700C8DB RID: 51419
		// (get) Token: 0x0602F525 RID: 193829 RVA: 0x00671C96 File Offset: 0x0066FE96
		// (set) Token: 0x0602F526 RID: 193830 RVA: 0x00671C9E File Offset: 0x0066FE9E
		public float ProtectTime { get; set; }

		// Token: 0x1700C8DC RID: 51420
		// (get) Token: 0x0602F527 RID: 193831 RVA: 0x00671CA7 File Offset: 0x0066FEA7
		// (set) Token: 0x0602F528 RID: 193832 RVA: 0x00671CAF File Offset: 0x0066FEAF
		public byte NullMask { get; set; }

		// Token: 0x0602F529 RID: 193833 RVA: 0x00671CB8 File Offset: 0x0066FEB8
		public IItemInspectFinishEffectT()
		{
			this.EffectList = null;
			this.ProtectTime = 0f;
			this.NullMask = 0;
		}
	}
}
