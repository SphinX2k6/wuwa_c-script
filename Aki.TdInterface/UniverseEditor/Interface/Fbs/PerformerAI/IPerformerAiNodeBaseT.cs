using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047CF RID: 18383
	public class IPerformerAiNodeBaseT
	{
		// Token: 0x17008007 RID: 32775
		// (get) Token: 0x0601B14C RID: 110924 RVA: 0x003D5EFF File Offset: 0x003D40FF
		// (set) Token: 0x0601B14D RID: 110925 RVA: 0x003D5F07 File Offset: 0x003D4107
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x17008008 RID: 32776
		// (get) Token: 0x0601B14E RID: 110926 RVA: 0x003D5F10 File Offset: 0x003D4110
		// (set) Token: 0x0601B14F RID: 110927 RVA: 0x003D5F18 File Offset: 0x003D4118
		public int Id { get; set; }

		// Token: 0x17008009 RID: 32777
		// (get) Token: 0x0601B150 RID: 110928 RVA: 0x003D5F21 File Offset: 0x003D4121
		// (set) Token: 0x0601B151 RID: 110929 RVA: 0x003D5F29 File Offset: 0x003D4129
		public string Desc { get; set; }

		// Token: 0x1700800A RID: 32778
		// (get) Token: 0x0601B152 RID: 110930 RVA: 0x003D5F32 File Offset: 0x003D4132
		// (set) Token: 0x0601B153 RID: 110931 RVA: 0x003D5F3A File Offset: 0x003D413A
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700800B RID: 32779
		// (get) Token: 0x0601B154 RID: 110932 RVA: 0x003D5F43 File Offset: 0x003D4143
		// (set) Token: 0x0601B155 RID: 110933 RVA: 0x003D5F4B File Offset: 0x003D414B
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700800C RID: 32780
		// (get) Token: 0x0601B156 RID: 110934 RVA: 0x003D5F54 File Offset: 0x003D4154
		// (set) Token: 0x0601B157 RID: 110935 RVA: 0x003D5F5C File Offset: 0x003D415C
		public byte NullMask { get; set; }

		// Token: 0x0601B158 RID: 110936 RVA: 0x003D5F65 File Offset: 0x003D4165
		public IPerformerAiNodeBaseT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.NullMask = 0;
		}
	}
}
