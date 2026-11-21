using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200156E RID: 5486
	public class ITrackQuestBranchBoardConfig
	{
		// Token: 0x06007BA5 RID: 31653 RVA: 0x00126005 File Offset: 0x00124205
		public static ITrackQuestBranchBoardConfig Create(ITrackQuestBranchBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackQuestBranchBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x06007BA6 RID: 31654 RVA: 0x00126024 File Offset: 0x00124224
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x00126034 File Offset: 0x00124234
		public virtual bool? EnableAnimation
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableAnimation);
			}
		}

		// Token: 0x04004740 RID: 18240
		private ITrackQuestBranchBoardConfig Instance;
	}
}
