using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B8 RID: 26296
	public class IEnterMovieModeDurationTypeT
	{
		// Token: 0x1700C364 RID: 50020
		// (get) Token: 0x0602DB66 RID: 187238 RVA: 0x006411CE File Offset: 0x0063F3CE
		// (set) Token: 0x0602DB67 RID: 187239 RVA: 0x006411D6 File Offset: 0x0063F3D6
		public EEnterMovieModeDurationType Type { get; set; }

		// Token: 0x0602DB68 RID: 187240 RVA: 0x006411DF File Offset: 0x0063F3DF
		public IEnterMovieModeDurationTypeT()
		{
			this.Type = EEnterMovieModeDurationType.BorderAnimFinished;
		}
	}
}
