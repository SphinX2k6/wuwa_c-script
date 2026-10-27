using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066AC RID: 26284
	public class IEnterMovieCameraT
	{
		// Token: 0x1700C34F RID: 49999
		// (get) Token: 0x0602DB08 RID: 187144 RVA: 0x00640641 File Offset: 0x0063E841
		// (set) Token: 0x0602DB09 RID: 187145 RVA: 0x00640649 File Offset: 0x0063E849
		public TEnterMovieCameraTypeUnion MovieCameraConfig { get; set; }

		// Token: 0x0602DB0A RID: 187146 RVA: 0x00640652 File Offset: 0x0063E852
		public IEnterMovieCameraT()
		{
			this.MovieCameraConfig = null;
		}
	}
}
