using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FBA RID: 20410
	public class ICheckPlayerEnterClientTriggerDirT
	{
		// Token: 0x170091FC RID: 37372
		// (get) Token: 0x0601FD13 RID: 130323 RVA: 0x0046B8BB File Offset: 0x00469ABB
		// (set) Token: 0x0601FD14 RID: 130324 RVA: 0x0046B8C3 File Offset: 0x00469AC3
		public ECondition Type { get; set; }

		// Token: 0x170091FD RID: 37373
		// (get) Token: 0x0601FD15 RID: 130325 RVA: 0x0046B8CC File Offset: 0x00469ACC
		// (set) Token: 0x0601FD16 RID: 130326 RVA: 0x0046B8D4 File Offset: 0x00469AD4
		public ECheckEnterClientTriggerTargetType TargetType { get; set; }

		// Token: 0x170091FE RID: 37374
		// (get) Token: 0x0601FD17 RID: 130327 RVA: 0x0046B8DD File Offset: 0x00469ADD
		// (set) Token: 0x0601FD18 RID: 130328 RVA: 0x0046B8E5 File Offset: 0x00469AE5
		public List<TCheckEnterTriggerDirTypeUnion> DirConfigs { get; set; }

		// Token: 0x170091FF RID: 37375
		// (get) Token: 0x0601FD19 RID: 130329 RVA: 0x0046B8EE File Offset: 0x00469AEE
		// (set) Token: 0x0601FD1A RID: 130330 RVA: 0x0046B8F6 File Offset: 0x00469AF6
		public byte NullMask { get; set; }

		// Token: 0x0601FD1B RID: 130331 RVA: 0x0046B8FF File Offset: 0x00469AFF
		public ICheckPlayerEnterClientTriggerDirT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetType = ECheckEnterClientTriggerTargetType.Player;
			this.DirConfigs = null;
			this.NullMask = 0;
		}
	}
}
