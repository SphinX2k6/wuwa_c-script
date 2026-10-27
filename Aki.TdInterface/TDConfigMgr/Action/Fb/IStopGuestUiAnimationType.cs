using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A10 RID: 10768
	public class IStopGuestUiAnimationType
	{
		// Token: 0x0600ED78 RID: 60792 RVA: 0x00229E4A File Offset: 0x0022804A
		[NullableContext(1)]
		public static IStopGuestUiAnimationType Create(IStopGuestUiAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestUiAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x0600ED79 RID: 60793 RVA: 0x00229E69 File Offset: 0x00228069
		public virtual EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040082B6 RID: 33462
		private IStopGuestUiAnimationType Instance;
	}
}
