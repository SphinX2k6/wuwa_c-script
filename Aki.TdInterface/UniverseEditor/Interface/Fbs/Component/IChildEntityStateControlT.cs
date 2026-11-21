using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CA RID: 21706
	public class IChildEntityStateControlT
	{
		// Token: 0x17009AF7 RID: 39671
		// (get) Token: 0x060223D9 RID: 140249 RVA: 0x004B84D0 File Offset: 0x004B66D0
		// (set) Token: 0x060223DA RID: 140250 RVA: 0x004B84D8 File Offset: 0x004B66D8
		public ETemplateEntityGroupType GroupType { get; set; }

		// Token: 0x17009AF8 RID: 39672
		// (get) Token: 0x060223DB RID: 140251 RVA: 0x004B84E1 File Offset: 0x004B66E1
		// (set) Token: 0x060223DC RID: 140252 RVA: 0x004B84E9 File Offset: 0x004B66E9
		public string InitState { get; set; }

		// Token: 0x17009AF9 RID: 39673
		// (get) Token: 0x060223DD RID: 140253 RVA: 0x004B84F2 File Offset: 0x004B66F2
		// (set) Token: 0x060223DE RID: 140254 RVA: 0x004B84FA File Offset: 0x004B66FA
		public List<IChildStateChangedConfigT> OnChildStateChangedConfigs { get; set; }

		// Token: 0x17009AFA RID: 39674
		// (get) Token: 0x060223DF RID: 140255 RVA: 0x004B8503 File Offset: 0x004B6703
		// (set) Token: 0x060223E0 RID: 140256 RVA: 0x004B850B File Offset: 0x004B670B
		public byte NullMask { get; set; }

		// Token: 0x060223E1 RID: 140257 RVA: 0x004B8514 File Offset: 0x004B6714
		public IChildEntityStateControlT()
		{
			this.GroupType = ETemplateEntityGroupType.None;
			this.InitState = null;
			this.OnChildStateChangedConfigs = null;
			this.NullMask = 0;
		}
	}
}
