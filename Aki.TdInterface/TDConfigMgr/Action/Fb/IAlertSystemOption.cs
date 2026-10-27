using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029ED RID: 10733
	public class IAlertSystemOption
	{
		// Token: 0x0600ECFE RID: 60670 RVA: 0x00229554 File Offset: 0x00227754
		[NullableContext(1)]
		public static IAlertSystemOption Create(IAlertSystemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertSystemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x00229573 File Offset: 0x00227773
		public virtual EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x0600ED00 RID: 60672 RVA: 0x00229580 File Offset: 0x00227780
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x04008285 RID: 33413
		private IAlertSystemOption Instance;
	}
}
