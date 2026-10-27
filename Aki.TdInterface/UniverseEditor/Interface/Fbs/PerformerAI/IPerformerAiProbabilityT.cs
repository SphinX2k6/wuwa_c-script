using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004373 RID: 17267
	public class IPerformerAiProbabilityT
	{
		// Token: 0x170079E5 RID: 31205
		// (get) Token: 0x06019A26 RID: 104998 RVA: 0x003AB670 File Offset: 0x003A9870
		// (set) Token: 0x06019A27 RID: 104999 RVA: 0x003AB678 File Offset: 0x003A9878
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x170079E6 RID: 31206
		// (get) Token: 0x06019A28 RID: 105000 RVA: 0x003AB681 File Offset: 0x003A9881
		// (set) Token: 0x06019A29 RID: 105001 RVA: 0x003AB689 File Offset: 0x003A9889
		public int Id { get; set; }

		// Token: 0x170079E7 RID: 31207
		// (get) Token: 0x06019A2A RID: 105002 RVA: 0x003AB692 File Offset: 0x003A9892
		// (set) Token: 0x06019A2B RID: 105003 RVA: 0x003AB69A File Offset: 0x003A989A
		public string Desc { get; set; }

		// Token: 0x170079E8 RID: 31208
		// (get) Token: 0x06019A2C RID: 105004 RVA: 0x003AB6A3 File Offset: 0x003A98A3
		// (set) Token: 0x06019A2D RID: 105005 RVA: 0x003AB6AB File Offset: 0x003A98AB
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x170079E9 RID: 31209
		// (get) Token: 0x06019A2E RID: 105006 RVA: 0x003AB6B4 File Offset: 0x003A98B4
		// (set) Token: 0x06019A2F RID: 105007 RVA: 0x003AB6BC File Offset: 0x003A98BC
		public bool _FoldedForTree { get; set; }

		// Token: 0x170079EA RID: 31210
		// (get) Token: 0x06019A30 RID: 105008 RVA: 0x003AB6C5 File Offset: 0x003A98C5
		// (set) Token: 0x06019A31 RID: 105009 RVA: 0x003AB6CD File Offset: 0x003A98CD
		public List<TPerformerAiNodeUnion> Children { get; set; }

		// Token: 0x170079EB RID: 31211
		// (get) Token: 0x06019A32 RID: 105010 RVA: 0x003AB6D6 File Offset: 0x003A98D6
		// (set) Token: 0x06019A33 RID: 105011 RVA: 0x003AB6DE File Offset: 0x003A98DE
		public List<float> RandomWeights { get; set; }

		// Token: 0x170079EC RID: 31212
		// (get) Token: 0x06019A34 RID: 105012 RVA: 0x003AB6E7 File Offset: 0x003A98E7
		// (set) Token: 0x06019A35 RID: 105013 RVA: 0x003AB6EF File Offset: 0x003A98EF
		public byte NullMask { get; set; }

		// Token: 0x06019A36 RID: 105014 RVA: 0x003AB6F8 File Offset: 0x003A98F8
		public IPerformerAiProbabilityT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.RandomWeights = null;
			this.NullMask = 0;
		}
	}
}
