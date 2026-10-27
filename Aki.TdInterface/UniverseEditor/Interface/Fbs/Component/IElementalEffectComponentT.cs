using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200512A RID: 20778
	public class IElementalEffectComponentT
	{
		// Token: 0x17009773 RID: 38771
		// (get) Token: 0x06021826 RID: 137254 RVA: 0x004A72B1 File Offset: 0x004A54B1
		// (set) Token: 0x06021827 RID: 137255 RVA: 0x004A72B9 File Offset: 0x004A54B9
		public bool Disabled { get; set; }

		// Token: 0x17009774 RID: 38772
		// (get) Token: 0x06021828 RID: 137256 RVA: 0x004A72C2 File Offset: 0x004A54C2
		// (set) Token: 0x06021829 RID: 137257 RVA: 0x004A72CA File Offset: 0x004A54CA
		public TElementalMatchConfigUnion MatchConfig { get; set; }

		// Token: 0x17009775 RID: 38773
		// (get) Token: 0x0602182A RID: 137258 RVA: 0x004A72D3 File Offset: 0x004A54D3
		// (set) Token: 0x0602182B RID: 137259 RVA: 0x004A72DB File Offset: 0x004A54DB
		public TElementalRangeUnion Range { get; set; }

		// Token: 0x17009776 RID: 38774
		// (get) Token: 0x0602182C RID: 137260 RVA: 0x004A72E4 File Offset: 0x004A54E4
		// (set) Token: 0x0602182D RID: 137261 RVA: 0x004A72EC File Offset: 0x004A54EC
		public List<IElementalMatchActionsT> OnActiveEffectActions { get; set; }

		// Token: 0x17009777 RID: 38775
		// (get) Token: 0x0602182E RID: 137262 RVA: 0x004A72F5 File Offset: 0x004A54F5
		// (set) Token: 0x0602182F RID: 137263 RVA: 0x004A72FD File Offset: 0x004A54FD
		public List<IElementalMatchActionsT> OnLoseEffectActions { get; set; }

		// Token: 0x17009778 RID: 38776
		// (get) Token: 0x06021830 RID: 137264 RVA: 0x004A7306 File Offset: 0x004A5506
		// (set) Token: 0x06021831 RID: 137265 RVA: 0x004A730E File Offset: 0x004A550E
		public byte NullMask { get; set; }

		// Token: 0x06021832 RID: 137266 RVA: 0x004A7317 File Offset: 0x004A5517
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
