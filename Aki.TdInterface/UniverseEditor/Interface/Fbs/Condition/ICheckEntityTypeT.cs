using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EDC RID: 20188
	public class ICheckEntityTypeT
	{
		// Token: 0x1700902B RID: 36907
		// (get) Token: 0x0601F576 RID: 128374 RVA: 0x0045E056 File Offset: 0x0045C256
		// (set) Token: 0x0601F577 RID: 128375 RVA: 0x0045E05E File Offset: 0x0045C25E
		public ECheckEntity Type { get; set; }

		// Token: 0x0601F578 RID: 128376 RVA: 0x0045E067 File Offset: 0x0045C267
		public ICheckEntityTypeT()
		{
			this.Type = ECheckEntity.OnlinePlayer;
		}
	}
}
