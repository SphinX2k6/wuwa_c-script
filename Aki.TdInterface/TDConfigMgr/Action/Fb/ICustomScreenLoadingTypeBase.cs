using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002961 RID: 10593
	public class ICustomScreenLoadingTypeBase
	{
		// Token: 0x0600EB19 RID: 60185 RVA: 0x0022A79C File Offset: 0x0022899C
		public static ICustomScreenLoadingTypeBase Create(ICustomScreenLoadingTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x0600EB1A RID: 60186 RVA: 0x0022A7BB File Offset: 0x002289BB
		public virtual ECustomScreenLoading Type
		{
			get
			{
				return (ECustomScreenLoading)this.Instance.Type;
			}
		}

		// Token: 0x0400817F RID: 33151
		private ICustomScreenLoadingTypeBase Instance;
	}
}
