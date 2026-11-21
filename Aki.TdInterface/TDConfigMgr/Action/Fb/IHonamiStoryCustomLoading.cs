using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002959 RID: 10585
	public class IHonamiStoryCustomLoading : ISpecialCustomLoadingOption
	{
		// Token: 0x0600EAF7 RID: 60151 RVA: 0x0022A46C File Offset: 0x0022866C
		public static IHonamiStoryCustomLoading Create(IHonamiStoryCustomLoading? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryCustomLoading
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x0600EAF8 RID: 60152 RVA: 0x0022A48B File Offset: 0x0022868B
		public override ESpecialCustomLoadingType Type
		{
			get
			{
				return (ESpecialCustomLoadingType)this.Instance.Type;
			}
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x0600EAF9 RID: 60153 RVA: 0x0022A498 File Offset: 0x00228698
		public virtual int LoadingId
		{
			get
			{
				return this.Instance.LoadingId;
			}
		}

		// Token: 0x0400816D RID: 33133
		private IHonamiStoryCustomLoading Instance;
	}
}
