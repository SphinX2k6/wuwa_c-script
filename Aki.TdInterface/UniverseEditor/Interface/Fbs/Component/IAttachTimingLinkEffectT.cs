using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F2 RID: 21490
	public class IAttachTimingLinkEffectT
	{
		// Token: 0x17009819 RID: 38937
		// (get) Token: 0x0602196B RID: 137579 RVA: 0x004A1A42 File Offset: 0x0049FC42
		// (set) Token: 0x0602196C RID: 137580 RVA: 0x004A1A4A File Offset: 0x0049FC4A
		public string EffectPath { get; set; }

		// Token: 0x1700981A RID: 38938
		// (get) Token: 0x0602196D RID: 137581 RVA: 0x004A1A53 File Offset: 0x0049FC53
		// (set) Token: 0x0602196E RID: 137582 RVA: 0x004A1A5B File Offset: 0x0049FC5B
		public IVectorInfoT StartPoint { get; set; }

		// Token: 0x1700981B RID: 38939
		// (get) Token: 0x0602196F RID: 137583 RVA: 0x004A1A64 File Offset: 0x0049FC64
		// (set) Token: 0x06021970 RID: 137584 RVA: 0x004A1A6C File Offset: 0x0049FC6C
		public IVectorInfoT EndPoint { get; set; }

		// Token: 0x06021971 RID: 137585 RVA: 0x004A1A75 File Offset: 0x0049FC75
		public IAttachTimingLinkEffectT()
		{
			this.EffectPath = null;
			this.StartPoint = null;
			this.EndPoint = null;
		}
	}
}
