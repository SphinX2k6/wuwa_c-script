using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D8 RID: 18392
	public class IPerformerAiSelectorT
	{
		// Token: 0x1700802C RID: 32812
		// (get) Token: 0x0601B202 RID: 111106 RVA: 0x003D7ED7 File Offset: 0x003D60D7
		// (set) Token: 0x0601B203 RID: 111107 RVA: 0x003D7EDF File Offset: 0x003D60DF
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x1700802D RID: 32813
		// (get) Token: 0x0601B204 RID: 111108 RVA: 0x003D7EE8 File Offset: 0x003D60E8
		// (set) Token: 0x0601B205 RID: 111109 RVA: 0x003D7EF0 File Offset: 0x003D60F0
		public int Id { get; set; }

		// Token: 0x1700802E RID: 32814
		// (get) Token: 0x0601B206 RID: 111110 RVA: 0x003D7EF9 File Offset: 0x003D60F9
		// (set) Token: 0x0601B207 RID: 111111 RVA: 0x003D7F01 File Offset: 0x003D6101
		public string Desc { get; set; }

		// Token: 0x1700802F RID: 32815
		// (get) Token: 0x0601B208 RID: 111112 RVA: 0x003D7F0A File Offset: 0x003D610A
		// (set) Token: 0x0601B209 RID: 111113 RVA: 0x003D7F12 File Offset: 0x003D6112
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17008030 RID: 32816
		// (get) Token: 0x0601B20A RID: 111114 RVA: 0x003D7F1B File Offset: 0x003D611B
		// (set) Token: 0x0601B20B RID: 111115 RVA: 0x003D7F23 File Offset: 0x003D6123
		public bool _FoldedForTree { get; set; }

		// Token: 0x17008031 RID: 32817
		// (get) Token: 0x0601B20C RID: 111116 RVA: 0x003D7F2C File Offset: 0x003D612C
		// (set) Token: 0x0601B20D RID: 111117 RVA: 0x003D7F34 File Offset: 0x003D6134
		public List<TPerformerAiNodeUnion> Children { get; set; }

		// Token: 0x17008032 RID: 32818
		// (get) Token: 0x0601B20E RID: 111118 RVA: 0x003D7F3D File Offset: 0x003D613D
		// (set) Token: 0x0601B20F RID: 111119 RVA: 0x003D7F45 File Offset: 0x003D6145
		public byte NullMask { get; set; }

		// Token: 0x0601B210 RID: 111120 RVA: 0x003D7F4E File Offset: 0x003D614E
		public IPerformerAiSelectorT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}
