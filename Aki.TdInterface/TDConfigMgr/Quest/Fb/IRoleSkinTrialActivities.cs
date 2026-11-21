using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F0 RID: 5360
	public class IRoleSkinTrialActivities : IShowUi
	{
		// Token: 0x06007975 RID: 31093 RVA: 0x001223C1 File Offset: 0x001205C1
		public static IRoleSkinTrialActivities Create(IRoleSkinTrialActivities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleSkinTrialActivities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x06007976 RID: 31094 RVA: 0x001223E0 File Offset: 0x001205E0
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x040045DE RID: 17886
		private IRoleSkinTrialActivities Instance;
	}
}
