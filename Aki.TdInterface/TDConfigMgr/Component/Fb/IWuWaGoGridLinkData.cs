using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E03 RID: 3587
	public class IWuWaGoGridLinkData
	{
		// Token: 0x0600513B RID: 20795 RVA: 0x000C8785 File Offset: 0x000C6985
		[NullableContext(1)]
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

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x000C87A4 File Offset: 0x000C69A4
		public virtual EWuWaGoGridLinkType GridLinkType
		{
			get
			{
				return (EWuWaGoGridLinkType)this.Instance.GridLinkType;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600513D RID: 20797 RVA: 0x000C87B1 File Offset: 0x000C69B1
		public virtual EWuWaGoGridRotationType RotationType
		{
			get
			{
				return (EWuWaGoGridRotationType)this.Instance.RotationType;
			}
		}

		// Token: 0x04002EC0 RID: 11968
		private IWuWaGoGridLinkData Instance;
	}
}
