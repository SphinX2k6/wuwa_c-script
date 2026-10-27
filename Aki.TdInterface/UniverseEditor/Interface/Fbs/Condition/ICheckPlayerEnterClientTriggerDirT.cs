using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE5 RID: 19173
	public class ICheckPlayerEnterClientTriggerDirT
	{
		// Token: 0x17008B05 RID: 35589
		// (get) Token: 0x0601E1FE RID: 123390 RVA: 0x00439C0F File Offset: 0x00437E0F
		// (set) Token: 0x0601E1FF RID: 123391 RVA: 0x00439C17 File Offset: 0x00437E17
		public ECondition Type { get; set; }

		// Token: 0x17008B06 RID: 35590
		// (get) Token: 0x0601E200 RID: 123392 RVA: 0x00439C20 File Offset: 0x00437E20
		// (set) Token: 0x0601E201 RID: 123393 RVA: 0x00439C28 File Offset: 0x00437E28
		public ECheckEnterClientTriggerTargetType TargetType { get; set; }

		// Token: 0x17008B07 RID: 35591
		// (get) Token: 0x0601E202 RID: 123394 RVA: 0x00439C31 File Offset: 0x00437E31
		// (set) Token: 0x0601E203 RID: 123395 RVA: 0x00439C39 File Offset: 0x00437E39
		public List<TCheckEnterTriggerDirTypeUnion> DirConfigs { get; set; }

		// Token: 0x17008B08 RID: 35592
		// (get) Token: 0x0601E204 RID: 123396 RVA: 0x00439C42 File Offset: 0x00437E42
		// (set) Token: 0x0601E205 RID: 123397 RVA: 0x00439C4A File Offset: 0x00437E4A
		public byte NullMask { get; set; }

		// Token: 0x0601E206 RID: 123398 RVA: 0x00439C53 File Offset: 0x00437E53
		public ICheckPlayerEnterClientTriggerDirT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetType = ECheckEnterClientTriggerTargetType.Player;
			this.DirConfigs = null;
			this.NullMask = 0;
		}
	}
}
