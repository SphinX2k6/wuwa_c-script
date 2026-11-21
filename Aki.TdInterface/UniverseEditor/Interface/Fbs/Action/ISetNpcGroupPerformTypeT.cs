using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FB RID: 30715
	public class ISetNpcGroupPerformTypeT
	{
		// Token: 0x1700E11E RID: 57630
		// (get) Token: 0x06035F65 RID: 221029 RVA: 0x0073A7EE File Offset: 0x007389EE
		// (set) Token: 0x06035F66 RID: 221030 RVA: 0x0073A7F6 File Offset: 0x007389F6
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x06035F67 RID: 221031 RVA: 0x0073A7FF File Offset: 0x007389FF
		public ISetNpcGroupPerformTypeT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
		}
	}
}
