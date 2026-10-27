using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066AF RID: 26287
	public class IEnterMovieCameraTypeT
	{
		// Token: 0x1700C352 RID: 50002
		// (get) Token: 0x0602DB1A RID: 187162 RVA: 0x006407EE File Offset: 0x0063E9EE
		// (set) Token: 0x0602DB1B RID: 187163 RVA: 0x006407F6 File Offset: 0x0063E9F6
		public EMovieCameraType Type { get; set; }

		// Token: 0x0602DB1C RID: 187164 RVA: 0x006407FF File Offset: 0x0063E9FF
		public IEnterMovieCameraTypeT()
		{
			this.Type = EMovieCameraType.Common;
		}
	}
}
