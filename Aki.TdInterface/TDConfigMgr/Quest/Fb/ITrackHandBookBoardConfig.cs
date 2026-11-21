using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001573 RID: 5491
	public class ITrackHandBookBoardConfig
	{
		// Token: 0x06007BB3 RID: 31667 RVA: 0x00126128 File Offset: 0x00124328
		public static ITrackHandBookBoardConfig Create(ITrackHandBookBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackHandBookBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x06007BB4 RID: 31668 RVA: 0x00126147 File Offset: 0x00124347
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04004745 RID: 18245
		private ITrackHandBookBoardConfig Instance;
	}
}
