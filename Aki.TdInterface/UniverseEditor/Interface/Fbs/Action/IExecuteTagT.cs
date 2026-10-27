using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006718 RID: 26392
	public class IExecuteTagT
	{
		// Token: 0x1700C40B RID: 50187
		// (get) Token: 0x0602DE83 RID: 188035 RVA: 0x00646E47 File Offset: 0x00645047
		// (set) Token: 0x0602DE84 RID: 188036 RVA: 0x00646E4F File Offset: 0x0064504F
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700C40C RID: 50188
		// (get) Token: 0x0602DE85 RID: 188037 RVA: 0x00646E58 File Offset: 0x00645058
		// (set) Token: 0x0602DE86 RID: 188038 RVA: 0x00646E60 File Offset: 0x00645060
		public float DelayTime { get; set; }

		// Token: 0x1700C40D RID: 50189
		// (get) Token: 0x0602DE87 RID: 188039 RVA: 0x00646E69 File Offset: 0x00645069
		// (set) Token: 0x0602DE88 RID: 188040 RVA: 0x00646E71 File Offset: 0x00645071
		public List<int> Tags { get; set; }

		// Token: 0x1700C40E RID: 50190
		// (get) Token: 0x0602DE89 RID: 188041 RVA: 0x00646E7A File Offset: 0x0064507A
		// (set) Token: 0x0602DE8A RID: 188042 RVA: 0x00646E82 File Offset: 0x00645082
		public byte NullMask { get; set; }

		// Token: 0x0602DE8B RID: 188043 RVA: 0x00646E8B File Offset: 0x0064508B
		public IExecuteTagT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.Tags = null;
			this.NullMask = 0;
		}
	}
}
