using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200453A RID: 17722
	public class IRangeAbsorbPhantomT
	{
		// Token: 0x17007DB2 RID: 32178
		// (get) Token: 0x0601AA7F RID: 109183 RVA: 0x003CDB0D File Offset: 0x003CBD0D
		// (set) Token: 0x0601AA80 RID: 109184 RVA: 0x003CDB15 File Offset: 0x003CBD15
		public int PlayerActiveFuncRangeEntity { get; set; }

		// Token: 0x17007DB3 RID: 32179
		// (get) Token: 0x0601AA81 RID: 109185 RVA: 0x003CDB1E File Offset: 0x003CBD1E
		// (set) Token: 0x0601AA82 RID: 109186 RVA: 0x003CDB26 File Offset: 0x003CBD26
		public int AutoAbsorbRangeEntity { get; set; }

		// Token: 0x17007DB4 RID: 32180
		// (get) Token: 0x0601AA83 RID: 109187 RVA: 0x003CDB2F File Offset: 0x003CBD2F
		// (set) Token: 0x0601AA84 RID: 109188 RVA: 0x003CDB37 File Offset: 0x003CBD37
		public List<int> IntervalKillNumber { get; set; }

		// Token: 0x17007DB5 RID: 32181
		// (get) Token: 0x0601AA85 RID: 109189 RVA: 0x003CDB40 File Offset: 0x003CBD40
		// (set) Token: 0x0601AA86 RID: 109190 RVA: 0x003CDB48 File Offset: 0x003CBD48
		public float DelayTime { get; set; }

		// Token: 0x17007DB6 RID: 32182
		// (get) Token: 0x0601AA87 RID: 109191 RVA: 0x003CDB51 File Offset: 0x003CBD51
		// (set) Token: 0x0601AA88 RID: 109192 RVA: 0x003CDB59 File Offset: 0x003CBD59
		public byte NullMask { get; set; }

		// Token: 0x0601AA89 RID: 109193 RVA: 0x003CDB62 File Offset: 0x003CBD62
		public IRangeAbsorbPhantomT()
		{
			this.PlayerActiveFuncRangeEntity = 0;
			this.AutoAbsorbRangeEntity = 0;
			this.IntervalKillNumber = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
