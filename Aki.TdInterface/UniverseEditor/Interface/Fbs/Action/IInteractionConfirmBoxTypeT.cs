using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698B RID: 27019
	public class IInteractionConfirmBoxTypeT
	{
		// Token: 0x1700C85F RID: 51295
		// (get) Token: 0x0602F304 RID: 193284 RVA: 0x0066D74A File Offset: 0x0066B94A
		// (set) Token: 0x0602F305 RID: 193285 RVA: 0x0066D752 File Offset: 0x0066B952
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x0602F306 RID: 193286 RVA: 0x0066D75B File Offset: 0x0066B95B
		public IInteractionConfirmBoxTypeT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
		}
	}
}
