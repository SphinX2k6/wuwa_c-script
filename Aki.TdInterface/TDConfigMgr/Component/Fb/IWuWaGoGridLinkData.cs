using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EFF RID: 3839
	public class IWuWaGoGridLinkData
	{
		// Token: 0x06005662 RID: 22114 RVA: 0x000D404D File Offset: 0x000D224D
		public static IWuWaGoGridLinkData Create(IWuWaGoGridLinkData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGridLinkData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x000D406C File Offset: 0x000D226C
		public virtual EWuWaGoGridLinkType GridLinkType
		{
			get
			{
				return (EWuWaGoGridLinkType)this.Instance.GridLinkType;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x000D4079 File Offset: 0x000D2279
		public virtual EWuWaGoGridRotationType RotationType
		{
			get
			{
				return (EWuWaGoGridRotationType)this.Instance.RotationType;
			}
		}

		// Token: 0x04003188 RID: 12680
		private IWuWaGoGridLinkData Instance;
	}
}
