using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568F RID: 22159
	public class IElementalEffectComponentT
	{
		// Token: 0x17009F60 RID: 40800
		// (get) Token: 0x0602377A RID: 145274 RVA: 0x004E123D File Offset: 0x004DF43D
		// (set) Token: 0x0602377B RID: 145275 RVA: 0x004E1245 File Offset: 0x004DF445
		public bool Disabled { get; set; }

		// Token: 0x17009F61 RID: 40801
		// (get) Token: 0x0602377C RID: 145276 RVA: 0x004E124E File Offset: 0x004DF44E
		// (set) Token: 0x0602377D RID: 145277 RVA: 0x004E1256 File Offset: 0x004DF456
		public TElementalMatchConfigUnion MatchConfig { get; set; }

		// Token: 0x17009F62 RID: 40802
		// (get) Token: 0x0602377E RID: 145278 RVA: 0x004E125F File Offset: 0x004DF45F
		// (set) Token: 0x0602377F RID: 145279 RVA: 0x004E1267 File Offset: 0x004DF467
		public TElementalRangeUnion Range { get; set; }

		// Token: 0x17009F63 RID: 40803
		// (get) Token: 0x06023780 RID: 145280 RVA: 0x004E1270 File Offset: 0x004DF470
		// (set) Token: 0x06023781 RID: 145281 RVA: 0x004E1278 File Offset: 0x004DF478
		public List<IElementalMatchActionsT> OnActiveEffectActions { get; set; }

		// Token: 0x17009F64 RID: 40804
		// (get) Token: 0x06023782 RID: 145282 RVA: 0x004E1281 File Offset: 0x004DF481
		// (set) Token: 0x06023783 RID: 145283 RVA: 0x004E1289 File Offset: 0x004DF489
		public List<IElementalMatchActionsT> OnLoseEffectActions { get; set; }

		// Token: 0x17009F65 RID: 40805
		// (get) Token: 0x06023784 RID: 145284 RVA: 0x004E1292 File Offset: 0x004DF492
		// (set) Token: 0x06023785 RID: 145285 RVA: 0x004E129A File Offset: 0x004DF49A
		public byte NullMask { get; set; }

		// Token: 0x06023786 RID: 145286 RVA: 0x004E12A3 File Offset: 0x004DF4A3
		public IElementalEffectComponentT()
		{
			this.Disabled = false;
			this.MatchConfig = null;
			this.Range = null;
			this.OnActiveEffectActions = null;
			this.OnLoseEffectActions = null;
			this.NullMask = 0;
		}
	}
}
