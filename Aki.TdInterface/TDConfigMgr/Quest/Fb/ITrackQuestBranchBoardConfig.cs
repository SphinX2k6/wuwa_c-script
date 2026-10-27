using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001417 RID: 5143
	public class ITrackQuestBranchBoardConfig
	{
		// Token: 0x060074E4 RID: 29924 RVA: 0x00117621 File Offset: 0x00115821
		[NullableContext(1)]
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

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x00117640 File Offset: 0x00115840
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x060074E6 RID: 29926 RVA: 0x00117650 File Offset: 0x00115850
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

		// Token: 0x040043AF RID: 17327
		private ITrackQuestBranchBoardConfig Instance;
	}
}
