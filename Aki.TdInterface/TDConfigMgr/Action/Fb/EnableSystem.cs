using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D1 RID: 10193
	public class EnableSystem : ActionParams
	{
		// Token: 0x0600E298 RID: 58008 RVA: 0x0021745A File Offset: 0x0021565A
		[NullableContext(1)]
		public static EnableSystem Create(IEnableSystem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSystem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x0600E299 RID: 58009 RVA: 0x00217479 File Offset: 0x00215679
		public virtual ESystem SystemType
		{
			get
			{
				return (ESystem)this.Instance.SystemType;
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x0600E29A RID: 58010 RVA: 0x00217486 File Offset: 0x00215686
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x04007DA3 RID: 32163
		private IEnableSystem Instance;
	}
}
