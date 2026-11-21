using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC9 RID: 24265
	public class ISceneItemAttributeComponentT
	{
		// Token: 0x1700B344 RID: 45892
		// (get) Token: 0x06028AA6 RID: 166566 RVA: 0x0058F164 File Offset: 0x0058D364
		// (set) Token: 0x06028AA7 RID: 166567 RVA: 0x0058F16C File Offset: 0x0058D36C
		public bool Disabled { get; set; }

		// Token: 0x1700B345 RID: 45893
		// (get) Token: 0x06028AA8 RID: 166568 RVA: 0x0058F175 File Offset: 0x0058D375
		// (set) Token: 0x06028AA9 RID: 166569 RVA: 0x0058F17D File Offset: 0x0058D37D
		public string AttributeType { get; set; }

		// Token: 0x1700B346 RID: 45894
		// (get) Token: 0x06028AAA RID: 166570 RVA: 0x0058F186 File Offset: 0x0058D386
		// (set) Token: 0x06028AAB RID: 166571 RVA: 0x0058F18E File Offset: 0x0058D38E
		public List<int> DefaultTags { get; set; }

		// Token: 0x1700B347 RID: 45895
		// (get) Token: 0x06028AAC RID: 166572 RVA: 0x0058F197 File Offset: 0x0058D397
		// (set) Token: 0x06028AAD RID: 166573 RVA: 0x0058F19F File Offset: 0x0058D39F
		public byte NullMask { get; set; }

		// Token: 0x06028AAE RID: 166574 RVA: 0x0058F1A8 File Offset: 0x0058D3A8
		public ISceneItemAttributeComponentT()
		{
			this.Disabled = false;
			this.AttributeType = null;
			this.DefaultTags = null;
			this.NullMask = 0;
		}
	}
}
