using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D32 RID: 27954
	public class IEnterMovieModeDurationTypeT
	{
		// Token: 0x1700CD15 RID: 52501
		// (get) Token: 0x06030383 RID: 197507 RVA: 0x0068E482 File Offset: 0x0068C682
		// (set) Token: 0x06030384 RID: 197508 RVA: 0x0068E48A File Offset: 0x0068C68A
		public EEnterMovieModeDurationType Type { get; set; }

		// Token: 0x06030385 RID: 197509 RVA: 0x0068E493 File Offset: 0x0068C693
		public IEnterMovieModeDurationTypeT()
		{
			this.Type = EEnterMovieModeDurationType.BorderAnimFinished;
		}
	}
}
