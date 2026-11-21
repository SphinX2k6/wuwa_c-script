using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B5 RID: 29365
	public class IMovieCameraConfigT
	{
		// Token: 0x1700D754 RID: 55124
		// (get) Token: 0x06033318 RID: 209688 RVA: 0x006E8739 File Offset: 0x006E6939
		// (set) Token: 0x06033319 RID: 209689 RVA: 0x006E8741 File Offset: 0x006E6941
		public TEnterMovieCameraTypeUnion MovieCameraType { get; set; }

		// Token: 0x0603331A RID: 209690 RVA: 0x006E874A File Offset: 0x006E694A
		public IMovieCameraConfigT()
		{
			this.MovieCameraType = null;
		}
	}
}
