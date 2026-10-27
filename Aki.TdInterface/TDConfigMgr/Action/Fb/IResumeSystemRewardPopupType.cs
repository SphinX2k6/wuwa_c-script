using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AB RID: 10667
	public class IResumeSystemRewardPopupType
	{
		// Token: 0x0600EC08 RID: 60424 RVA: 0x00227D70 File Offset: 0x00225F70
		[NullableContext(1)]
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

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x0600EC09 RID: 60425 RVA: 0x00227D8F File Offset: 0x00225F8F
		public virtual ESystemType Type
		{
			get
			{
				return (ESystemType)this.Instance.Type;
			}
		}

		// Token: 0x040081FB RID: 33275
		private IResumeSystemRewardPopupType Instance;
	}
}
