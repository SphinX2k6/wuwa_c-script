using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006655 RID: 26197
	public class IEnableClientFunctionT
	{
		// Token: 0x1700C2A1 RID: 49825
		// (get) Token: 0x0602D815 RID: 186389 RVA: 0x0063B43E File Offset: 0x0063963E
		// (set) Token: 0x0602D816 RID: 186390 RVA: 0x0063B446 File Offset: 0x00639646
		public EEnableClientFunctionType Type { get; set; }

		// Token: 0x0602D817 RID: 186391 RVA: 0x0063B44F File Offset: 0x0063964F
		public IEnableClientFunctionT()
		{
			this.Type = EEnableClientFunctionType.HealthBarDisplay;
		}
	}
}
