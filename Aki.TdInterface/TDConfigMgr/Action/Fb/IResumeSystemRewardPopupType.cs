using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C98 RID: 11416
	public class IResumeSystemRewardPopupType
	{
		// Token: 0x0600FA9F RID: 64159 RVA: 0x002456F5 File Offset: 0x002438F5
		public static IResumeSystemRewardPopupType Create(IResumeSystemRewardPopupType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResumeSystemRewardPopupType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x0600FAA0 RID: 64160 RVA: 0x00245714 File Offset: 0x00243914
		public virtual ESystemType Type
		{
			get
			{
				return (ESystemType)this.Instance.Type;
			}
		}

		// Token: 0x040088EC RID: 35052
		private IResumeSystemRewardPopupType Instance;
	}
}
