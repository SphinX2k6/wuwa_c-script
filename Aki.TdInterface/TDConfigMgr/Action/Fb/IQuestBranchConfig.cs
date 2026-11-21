using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291E RID: 10526
	public class IQuestBranchConfig
	{
		// Token: 0x0600E9F6 RID: 59894 RVA: 0x00228995 File Offset: 0x00226B95
		public static IQuestBranchConfig Create(IQuestBranchConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestBranchConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x002289B4 File Offset: 0x00226BB4
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

		// Token: 0x040080FA RID: 33018
		private IQuestBranchConfig Instance;
	}
}
