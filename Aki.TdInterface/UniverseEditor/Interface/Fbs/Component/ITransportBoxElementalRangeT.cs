using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E6 RID: 24806
	public class ITransportBoxElementalRangeT
	{
		// Token: 0x1700B883 RID: 47235
		// (get) Token: 0x0602A034 RID: 172084 RVA: 0x005BC0E2 File Offset: 0x005BA2E2
		// (set) Token: 0x0602A035 RID: 172085 RVA: 0x005BC0EA File Offset: 0x005BA2EA
		public EElementalRangeType Type { get; set; }

		// Token: 0x0602A036 RID: 172086 RVA: 0x005BC0F3 File Offset: 0x005BA2F3
		public ITransportBoxElementalRangeT()
		{
			this.Type = EElementalRangeType.BaseShape;
		}
	}
}
