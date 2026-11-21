using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ECF RID: 24271
	public class ISceneItemEventListenerComponentT
	{
		// Token: 0x1700B353 RID: 45907
		// (get) Token: 0x06028AEA RID: 166634 RVA: 0x0058FA19 File Offset: 0x0058DC19
		// (set) Token: 0x06028AEB RID: 166635 RVA: 0x0058FA21 File Offset: 0x0058DC21
		public bool Disabled { get; set; }

		// Token: 0x1700B354 RID: 45908
		// (get) Token: 0x06028AEC RID: 166636 RVA: 0x0058FA2A File Offset: 0x0058DC2A
		// (set) Token: 0x06028AED RID: 166637 RVA: 0x0058FA32 File Offset: 0x0058DC32
		public List<ISceneItemEventConfigT> Events { get; set; }

		// Token: 0x1700B355 RID: 45909
		// (get) Token: 0x06028AEE RID: 166638 RVA: 0x0058FA3B File Offset: 0x0058DC3B
		// (set) Token: 0x06028AEF RID: 166639 RVA: 0x0058FA43 File Offset: 0x0058DC43
		public byte NullMask { get; set; }

		// Token: 0x06028AF0 RID: 166640 RVA: 0x0058FA4C File Offset: 0x0058DC4C
		public ISceneItemEventListenerComponentT()
		{
			this.Disabled = false;
			this.Events = null;
			this.NullMask = 0;
		}
	}
}
