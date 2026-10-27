using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007455 RID: 29781
	public class ITransitionPopupYuanChengArtTextT
	{
		// Token: 0x1700E217 RID: 57879
		// (get) Token: 0x060361B5 RID: 221621 RVA: 0x0075B9FC File Offset: 0x00759BFC
		// (set) Token: 0x060361B6 RID: 221622 RVA: 0x0075BA04 File Offset: 0x00759C04
		public ETransitionPopupArtTextType Type { get; set; }

		// Token: 0x1700E218 RID: 57880
		// (get) Token: 0x060361B7 RID: 221623 RVA: 0x0075BA0D File Offset: 0x00759C0D
		// (set) Token: 0x060361B8 RID: 221624 RVA: 0x0075BA15 File Offset: 0x00759C15
		public IVector2T Position { get; set; }

		// Token: 0x1700E219 RID: 57881
		// (get) Token: 0x060361B9 RID: 221625 RVA: 0x0075BA1E File Offset: 0x00759C1E
		// (set) Token: 0x060361BA RID: 221626 RVA: 0x0075BA26 File Offset: 0x00759C26
		public string Texture { get; set; }

		// Token: 0x1700E21A RID: 57882
		// (get) Token: 0x060361BB RID: 221627 RVA: 0x0075BA2F File Offset: 0x00759C2F
		// (set) Token: 0x060361BC RID: 221628 RVA: 0x0075BA37 File Offset: 0x00759C37
		public string SubtitleText { get; set; }

		// Token: 0x060361BD RID: 221629 RVA: 0x0075BA40 File Offset: 0x00759C40
		public ITransitionPopupYuanChengArtTextT()
		{
			this.Type = ETransitionPopupArtTextType.YuanCheng;
			this.Position = null;
			this.Texture = null;
			this.SubtitleText = null;
		}
	}
}
