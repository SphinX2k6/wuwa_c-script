using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AA RID: 21674
	public class IJigsawFoundationT
	{
		// Token: 0x17009F9B RID: 40859
		// (get) Token: 0x06023AF4 RID: 146164 RVA: 0x004EF09E File Offset: 0x004ED29E
		// (set) Token: 0x06023AF5 RID: 146165 RVA: 0x004EF0A6 File Offset: 0x004ED2A6
		public bool Disabled { get; set; }

		// Token: 0x17009F9C RID: 40860
		// (get) Token: 0x06023AF6 RID: 146166 RVA: 0x004EF0AF File Offset: 0x004ED2AF
		// (set) Token: 0x06023AF7 RID: 146167 RVA: 0x004EF0B7 File Offset: 0x004ED2B7
		public int ModelId { get; set; }

		// Token: 0x17009F9D RID: 40861
		// (get) Token: 0x06023AF8 RID: 146168 RVA: 0x004EF0C0 File Offset: 0x004ED2C0
		// (set) Token: 0x06023AF9 RID: 146169 RVA: 0x004EF0C8 File Offset: 0x004ED2C8
		public IVectorInfoT PlaceOffset { get; set; }

		// Token: 0x17009F9E RID: 40862
		// (get) Token: 0x06023AFA RID: 146170 RVA: 0x004EF0D1 File Offset: 0x004ED2D1
		// (set) Token: 0x06023AFB RID: 146171 RVA: 0x004EF0D9 File Offset: 0x004ED2D9
		public List<IJigsawPieceMatchT> InitMatchList { get; set; }

		// Token: 0x17009F9F RID: 40863
		// (get) Token: 0x06023AFC RID: 146172 RVA: 0x004EF0E2 File Offset: 0x004ED2E2
		// (set) Token: 0x06023AFD RID: 146173 RVA: 0x004EF0EA File Offset: 0x004ED2EA
		public TJigsawCompleteConditionUnion CompleteCondition { get; set; }

		// Token: 0x17009FA0 RID: 40864
		// (get) Token: 0x06023AFE RID: 146174 RVA: 0x004EF0F3 File Offset: 0x004ED2F3
		// (set) Token: 0x06023AFF RID: 146175 RVA: 0x004EF0FB File Offset: 0x004ED2FB
		public IJigsawCompletedConfigT CompletedConfig { get; set; }

		// Token: 0x17009FA1 RID: 40865
		// (get) Token: 0x06023B00 RID: 146176 RVA: 0x004EF104 File Offset: 0x004ED304
		// (set) Token: 0x06023B01 RID: 146177 RVA: 0x004EF10C File Offset: 0x004ED30C
		public IJigsawConfigT JigsawConfig { get; set; }

		// Token: 0x17009FA2 RID: 40866
		// (get) Token: 0x06023B02 RID: 146178 RVA: 0x004EF115 File Offset: 0x004ED315
		// (set) Token: 0x06023B03 RID: 146179 RVA: 0x004EF11D File Offset: 0x004ED31D
		public List<IJigsawItemMatchedConfigT> MatchedConfig { get; set; }

		// Token: 0x17009FA3 RID: 40867
		// (get) Token: 0x06023B04 RID: 146180 RVA: 0x004EF126 File Offset: 0x004ED326
		// (set) Token: 0x06023B05 RID: 146181 RVA: 0x004EF12E File Offset: 0x004ED32E
		public byte NullMask { get; set; }

		// Token: 0x06023B06 RID: 146182 RVA: 0x004EF138 File Offset: 0x004ED338
		public IJigsawFoundationT()
		{
			this.Disabled = false;
			this.ModelId = 0;
			this.PlaceOffset = null;
			this.InitMatchList = null;
			this.CompleteCondition = null;
			this.CompletedConfig = null;
			this.JigsawConfig = null;
			this.MatchedConfig = null;
			this.NullMask = 0;
		}
	}
}
