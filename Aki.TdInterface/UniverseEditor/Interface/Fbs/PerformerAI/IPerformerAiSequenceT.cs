using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004379 RID: 17273
	public class IPerformerAiSequenceT
	{
		// Token: 0x17007A08 RID: 31240
		// (get) Token: 0x06019AC0 RID: 105152 RVA: 0x003AD2C7 File Offset: 0x003AB4C7
		// (set) Token: 0x06019AC1 RID: 105153 RVA: 0x003AD2CF File Offset: 0x003AB4CF
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x17007A09 RID: 31241
		// (get) Token: 0x06019AC2 RID: 105154 RVA: 0x003AD2D8 File Offset: 0x003AB4D8
		// (set) Token: 0x06019AC3 RID: 105155 RVA: 0x003AD2E0 File Offset: 0x003AB4E0
		public int Id { get; set; }

		// Token: 0x17007A0A RID: 31242
		// (get) Token: 0x06019AC4 RID: 105156 RVA: 0x003AD2E9 File Offset: 0x003AB4E9
		// (set) Token: 0x06019AC5 RID: 105157 RVA: 0x003AD2F1 File Offset: 0x003AB4F1
		public string Desc { get; set; }

		// Token: 0x17007A0B RID: 31243
		// (get) Token: 0x06019AC6 RID: 105158 RVA: 0x003AD2FA File Offset: 0x003AB4FA
		// (set) Token: 0x06019AC7 RID: 105159 RVA: 0x003AD302 File Offset: 0x003AB502
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x17007A0C RID: 31244
		// (get) Token: 0x06019AC8 RID: 105160 RVA: 0x003AD30B File Offset: 0x003AB50B
		// (set) Token: 0x06019AC9 RID: 105161 RVA: 0x003AD313 File Offset: 0x003AB513
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007A0D RID: 31245
		// (get) Token: 0x06019ACA RID: 105162 RVA: 0x003AD31C File Offset: 0x003AB51C
		// (set) Token: 0x06019ACB RID: 105163 RVA: 0x003AD324 File Offset: 0x003AB524
		public List<TPerformerAiNodeUnion> Children { get; set; }

		// Token: 0x17007A0E RID: 31246
		// (get) Token: 0x06019ACC RID: 105164 RVA: 0x003AD32D File Offset: 0x003AB52D
		// (set) Token: 0x06019ACD RID: 105165 RVA: 0x003AD335 File Offset: 0x003AB535
		public byte NullMask { get; set; }

		// Token: 0x06019ACE RID: 105166 RVA: 0x003AD33E File Offset: 0x003AB53E
		public IPerformerAiSequenceT()
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
