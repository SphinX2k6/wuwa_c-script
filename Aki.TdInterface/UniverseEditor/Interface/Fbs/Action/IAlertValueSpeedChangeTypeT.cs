using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FA RID: 26618
	public class IAlertValueSpeedChangeTypeT
	{
		// Token: 0x1700C3B0 RID: 50096
		// (get) Token: 0x0602D783 RID: 186243 RVA: 0x00639B1E File Offset: 0x00637D1E
		// (set) Token: 0x0602D784 RID: 186244 RVA: 0x00639B26 File Offset: 0x00637D26
		public EValueChangeType Type { get; set; }

		// Token: 0x0602D785 RID: 186245 RVA: 0x00639B2F File Offset: 0x00637D2F
		public IAlertValueSpeedChangeTypeT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
