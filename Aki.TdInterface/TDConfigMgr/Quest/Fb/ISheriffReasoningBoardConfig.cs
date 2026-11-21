using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001570 RID: 5488
	public class ISheriffReasoningBoardConfig
	{
		// Token: 0x06007BAC RID: 31660 RVA: 0x001260A6 File Offset: 0x001242A6
		public static ISheriffReasoningBoardConfig Create(ISheriffReasoningBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffReasoningBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x001260C5 File Offset: 0x001242C5
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04004742 RID: 18242
		private ISheriffReasoningBoardConfig Instance;
	}
}
