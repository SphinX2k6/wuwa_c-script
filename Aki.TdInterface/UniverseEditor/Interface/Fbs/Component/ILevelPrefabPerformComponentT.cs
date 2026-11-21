using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6F RID: 23151
	public class ILevelPrefabPerformComponentT
	{
		// Token: 0x1700A890 RID: 43152
		// (get) Token: 0x06025E8D RID: 155277 RVA: 0x0053289C File Offset: 0x00530A9C
		// (set) Token: 0x06025E8E RID: 155278 RVA: 0x005328A4 File Offset: 0x00530AA4
		public bool Disabled { get; set; }

		// Token: 0x1700A891 RID: 43153
		// (get) Token: 0x06025E8F RID: 155279 RVA: 0x005328AD File Offset: 0x00530AAD
		// (set) Token: 0x06025E90 RID: 155280 RVA: 0x005328B5 File Offset: 0x00530AB5
		public List<ITowardEntityConfigT> TowardEntity { get; set; }

		// Token: 0x1700A892 RID: 43154
		// (get) Token: 0x06025E91 RID: 155281 RVA: 0x005328BE File Offset: 0x00530ABE
		// (set) Token: 0x06025E92 RID: 155282 RVA: 0x005328C6 File Offset: 0x00530AC6
		public ILevelPrefabParamsConfigT PrefabParams { get; set; }

		// Token: 0x1700A893 RID: 43155
		// (get) Token: 0x06025E93 RID: 155283 RVA: 0x005328CF File Offset: 0x00530ACF
		// (set) Token: 0x06025E94 RID: 155284 RVA: 0x005328D7 File Offset: 0x00530AD7
		public List<IPrefabCompTransformT> CompTransform { get; set; }

		// Token: 0x1700A894 RID: 43156
		// (get) Token: 0x06025E95 RID: 155285 RVA: 0x005328E0 File Offset: 0x00530AE0
		// (set) Token: 0x06025E96 RID: 155286 RVA: 0x005328E8 File Offset: 0x00530AE8
		public byte NullMask { get; set; }

		// Token: 0x06025E97 RID: 155287 RVA: 0x005328F1 File Offset: 0x00530AF1
		public ILevelPrefabPerformComponentT()
		{
			this.Disabled = false;
			this.TowardEntity = null;
			this.PrefabParams = null;
			this.CompTransform = null;
			this.NullMask = 0;
		}
	}
}
