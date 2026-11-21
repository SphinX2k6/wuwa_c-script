using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D29 RID: 27945
	public class IEnterMovieCameraTypeT
	{
		// Token: 0x1700CD03 RID: 52483
		// (get) Token: 0x06030337 RID: 197431 RVA: 0x0068DAA2 File Offset: 0x0068BCA2
		// (set) Token: 0x06030338 RID: 197432 RVA: 0x0068DAAA File Offset: 0x0068BCAA
		public EMovieCameraType Type { get; set; }

		// Token: 0x06030339 RID: 197433 RVA: 0x0068DAB3 File Offset: 0x0068BCB3
		public IEnterMovieCameraTypeT()
		{
			this.Type = EMovieCameraType.Common;
		}
	}
}
