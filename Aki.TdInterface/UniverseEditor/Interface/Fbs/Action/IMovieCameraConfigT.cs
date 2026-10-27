using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6F RID: 27503
	public class IMovieCameraConfigT
	{
		// Token: 0x1700CC6F RID: 52335
		// (get) Token: 0x060304C0 RID: 197824 RVA: 0x00690119 File Offset: 0x0068E319
		// (set) Token: 0x060304C1 RID: 197825 RVA: 0x00690121 File Offset: 0x0068E321
		public TEnterMovieCameraTypeUnion MovieCameraType { get; set; }

		// Token: 0x060304C2 RID: 197826 RVA: 0x0069012A File Offset: 0x0068E32A
		public IMovieCameraConfigT()
		{
			this.MovieCameraType = null;
		}
	}
}
