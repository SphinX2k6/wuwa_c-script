using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A30 RID: 23088
	public class IJigsawFoundationT
	{
		// Token: 0x1700A7D5 RID: 42965
		// (get) Token: 0x06025BAC RID: 154540 RVA: 0x0052C112 File Offset: 0x0052A312
		// (set) Token: 0x06025BAD RID: 154541 RVA: 0x0052C11A File Offset: 0x0052A31A
		public bool Disabled { get; set; }

		// Token: 0x1700A7D6 RID: 42966
		// (get) Token: 0x06025BAE RID: 154542 RVA: 0x0052C123 File Offset: 0x0052A323
		// (set) Token: 0x06025BAF RID: 154543 RVA: 0x0052C12B File Offset: 0x0052A32B
		public int ModelId { get; set; }

		// Token: 0x1700A7D7 RID: 42967
		// (get) Token: 0x06025BB0 RID: 154544 RVA: 0x0052C134 File Offset: 0x0052A334
		// (set) Token: 0x06025BB1 RID: 154545 RVA: 0x0052C13C File Offset: 0x0052A33C
		public IVectorInfoT PlaceOffset { get; set; }

		// Token: 0x1700A7D8 RID: 42968
		// (get) Token: 0x06025BB2 RID: 154546 RVA: 0x0052C145 File Offset: 0x0052A345
		// (set) Token: 0x06025BB3 RID: 154547 RVA: 0x0052C14D File Offset: 0x0052A34D
		public List<IJigsawPieceMatchT> InitMatchList { get; set; }

		// Token: 0x1700A7D9 RID: 42969
		// (get) Token: 0x06025BB4 RID: 154548 RVA: 0x0052C156 File Offset: 0x0052A356
		// (set) Token: 0x06025BB5 RID: 154549 RVA: 0x0052C15E File Offset: 0x0052A35E
		public TJigsawCompleteConditionUnion CompleteCondition { get; set; }

		// Token: 0x1700A7DA RID: 42970
		// (get) Token: 0x06025BB6 RID: 154550 RVA: 0x0052C167 File Offset: 0x0052A367
		// (set) Token: 0x06025BB7 RID: 154551 RVA: 0x0052C16F File Offset: 0x0052A36F
		public IJigsawCompletedConfigT CompletedConfig { get; set; }

		// Token: 0x1700A7DB RID: 42971
		// (get) Token: 0x06025BB8 RID: 154552 RVA: 0x0052C178 File Offset: 0x0052A378
		// (set) Token: 0x06025BB9 RID: 154553 RVA: 0x0052C180 File Offset: 0x0052A380
		public IJigsawConfigT JigsawConfig { get; set; }

		// Token: 0x1700A7DC RID: 42972
		// (get) Token: 0x06025BBA RID: 154554 RVA: 0x0052C189 File Offset: 0x0052A389
		// (set) Token: 0x06025BBB RID: 154555 RVA: 0x0052C191 File Offset: 0x0052A391
		public List<IJigsawItemMatchedConfigT> MatchedConfig { get; set; }

		// Token: 0x1700A7DD RID: 42973
		// (get) Token: 0x06025BBC RID: 154556 RVA: 0x0052C19A File Offset: 0x0052A39A
		// (set) Token: 0x06025BBD RID: 154557 RVA: 0x0052C1A2 File Offset: 0x0052A3A2
		public byte NullMask { get; set; }

		// Token: 0x06025BBE RID: 154558 RVA: 0x0052C1AC File Offset: 0x0052A3AC
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
