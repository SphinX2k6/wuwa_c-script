using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FBD RID: 20413
	public class ICheckPlayerFaceToConditionT
	{
		// Token: 0x17009204 RID: 37380
		// (get) Token: 0x0601FD35 RID: 130357 RVA: 0x0046BD91 File Offset: 0x00469F91
		// (set) Token: 0x0601FD36 RID: 130358 RVA: 0x0046BD99 File Offset: 0x00469F99
		public ECondition Type { get; set; }

		// Token: 0x17009205 RID: 37381
		// (get) Token: 0x0601FD37 RID: 130359 RVA: 0x0046BDA2 File Offset: 0x00469FA2
		// (set) Token: 0x0601FD38 RID: 130360 RVA: 0x0046BDAA File Offset: 0x00469FAA
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17009206 RID: 37382
		// (get) Token: 0x0601FD39 RID: 130361 RVA: 0x0046BDB3 File Offset: 0x00469FB3
		// (set) Token: 0x0601FD3A RID: 130362 RVA: 0x0046BDBB File Offset: 0x00469FBB
		public float AngleInterval { get; set; }

		// Token: 0x0601FD3B RID: 130363 RVA: 0x0046BDC4 File Offset: 0x00469FC4
		public ICheckPlayerFaceToConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.AngleInterval = 0f;
		}
	}
}
