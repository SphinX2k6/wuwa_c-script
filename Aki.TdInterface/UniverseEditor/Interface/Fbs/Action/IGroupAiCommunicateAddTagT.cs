using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F45 RID: 28485
	public class IGroupAiCommunicateAddTagT
	{
		// Token: 0x1700D0C8 RID: 53448
		// (get) Token: 0x060314DA RID: 201946 RVA: 0x006ADB97 File Offset: 0x006ABD97
		// (set) Token: 0x060314DB RID: 201947 RVA: 0x006ADB9F File Offset: 0x006ABD9F
		public EGroupAiCommunicateType Type { get; set; }

		// Token: 0x1700D0C9 RID: 53449
		// (get) Token: 0x060314DC RID: 201948 RVA: 0x006ADBA8 File Offset: 0x006ABDA8
		// (set) Token: 0x060314DD RID: 201949 RVA: 0x006ADBB0 File Offset: 0x006ABDB0
		public List<string> Tags { get; set; }

		// Token: 0x060314DE RID: 201950 RVA: 0x006ADBB9 File Offset: 0x006ABDB9
		public IGroupAiCommunicateAddTagT()
		{
			this.Type = EGroupAiCommunicateType.AddTag;
			this.Tags = null;
		}
	}
}
