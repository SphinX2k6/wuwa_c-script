using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D26 RID: 27942
	public class IEnterMovieCameraT
	{
		// Token: 0x1700CD00 RID: 52480
		// (get) Token: 0x06030325 RID: 197413 RVA: 0x0068D8F5 File Offset: 0x0068BAF5
		// (set) Token: 0x06030326 RID: 197414 RVA: 0x0068D8FD File Offset: 0x0068BAFD
		public TEnterMovieCameraTypeUnion MovieCameraConfig { get; set; }

		// Token: 0x06030327 RID: 197415 RVA: 0x0068D906 File Offset: 0x0068BB06
		public IEnterMovieCameraT()
		{
			this.MovieCameraConfig = null;
		}
	}
}
