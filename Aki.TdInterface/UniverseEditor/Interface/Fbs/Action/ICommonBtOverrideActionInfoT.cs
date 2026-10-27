using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006469 RID: 25705
	public class ICommonBtOverrideActionInfoT
	{
		// Token: 0x1700BF4C RID: 48972
		// (get) Token: 0x0602C7D0 RID: 182224 RVA: 0x00619D5B File Offset: 0x00617F5B
		// (set) Token: 0x0602C7D1 RID: 182225 RVA: 0x00619D63 File Offset: 0x00617F63
		public ECommonBtPlaceholderTargetType Type { get; set; }

		// Token: 0x1700BF4D RID: 48973
		// (get) Token: 0x0602C7D2 RID: 182226 RVA: 0x00619D6C File Offset: 0x00617F6C
		// (set) Token: 0x0602C7D3 RID: 182227 RVA: 0x00619D74 File Offset: 0x00617F74
		public IActionInfoT Action { get; set; }

		// Token: 0x0602C7D4 RID: 182228 RVA: 0x00619D7D File Offset: 0x00617F7D
		public ICommonBtOverrideActionInfoT()
		{
			this.Type = ECommonBtPlaceholderTargetType.Action;
			this.Action = null;
		}
	}
}
