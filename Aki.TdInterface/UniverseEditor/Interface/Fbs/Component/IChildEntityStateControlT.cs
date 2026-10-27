using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F9B RID: 20379
	public class IChildEntityStateControlT
	{
		// Token: 0x1700937E RID: 37758
		// (get) Token: 0x06020687 RID: 132743 RVA: 0x004824E0 File Offset: 0x004806E0
		// (set) Token: 0x06020688 RID: 132744 RVA: 0x004824E8 File Offset: 0x004806E8
		public ETemplateEntityGroupType GroupType { get; set; }

		// Token: 0x1700937F RID: 37759
		// (get) Token: 0x06020689 RID: 132745 RVA: 0x004824F1 File Offset: 0x004806F1
		// (set) Token: 0x0602068A RID: 132746 RVA: 0x004824F9 File Offset: 0x004806F9
		public string InitState { get; set; }

		// Token: 0x17009380 RID: 37760
		// (get) Token: 0x0602068B RID: 132747 RVA: 0x00482502 File Offset: 0x00480702
		// (set) Token: 0x0602068C RID: 132748 RVA: 0x0048250A File Offset: 0x0048070A
		public List<IChildStateChangedConfigT> OnChildStateChangedConfigs { get; set; }

		// Token: 0x17009381 RID: 37761
		// (get) Token: 0x0602068D RID: 132749 RVA: 0x00482513 File Offset: 0x00480713
		// (set) Token: 0x0602068E RID: 132750 RVA: 0x0048251B File Offset: 0x0048071B
		public byte NullMask { get; set; }

		// Token: 0x0602068F RID: 132751 RVA: 0x00482524 File Offset: 0x00480724
		public IChildEntityStateControlT()
		{
			this.GroupType = ETemplateEntityGroupType.None;
			this.InitState = null;
			this.OnChildStateChangedConfigs = null;
			this.NullMask = 0;
		}
	}
}
