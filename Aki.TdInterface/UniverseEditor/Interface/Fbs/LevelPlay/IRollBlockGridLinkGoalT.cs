using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E1 RID: 18913
	public class IRollBlockGridLinkGoalT
	{
		// Token: 0x1700849C RID: 33948
		// (get) Token: 0x0601C580 RID: 116096 RVA: 0x00401709 File Offset: 0x003FF909
		// (set) Token: 0x0601C581 RID: 116097 RVA: 0x00401711 File Offset: 0x003FF911
		public ERollBlockGridType Type { get; set; }

		// Token: 0x1700849D RID: 33949
		// (get) Token: 0x0601C582 RID: 116098 RVA: 0x0040171A File Offset: 0x003FF91A
		// (set) Token: 0x0601C583 RID: 116099 RVA: 0x00401722 File Offset: 0x003FF922
		public TRollBlockUnion Block { get; set; }

		// Token: 0x1700849E RID: 33950
		// (get) Token: 0x0601C584 RID: 116100 RVA: 0x0040172B File Offset: 0x003FF92B
		// (set) Token: 0x0601C585 RID: 116101 RVA: 0x00401733 File Offset: 0x003FF933
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x1700849F RID: 33951
		// (get) Token: 0x0601C586 RID: 116102 RVA: 0x0040173C File Offset: 0x003FF93C
		// (set) Token: 0x0601C587 RID: 116103 RVA: 0x00401744 File Offset: 0x003FF944
		public ERollBlockLayType LinkDirection { get; set; }

		// Token: 0x170084A0 RID: 33952
		// (get) Token: 0x0601C588 RID: 116104 RVA: 0x0040174D File Offset: 0x003FF94D
		// (set) Token: 0x0601C589 RID: 116105 RVA: 0x00401755 File Offset: 0x003FF955
		public byte NullMask { get; set; }

		// Token: 0x0601C58A RID: 116106 RVA: 0x0040175E File Offset: 0x003FF95E
		public IRollBlockGridLinkGoalT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.LinkDirection = ERollBlockLayType.Left;
			this.NullMask = 0;
		}
	}
}
