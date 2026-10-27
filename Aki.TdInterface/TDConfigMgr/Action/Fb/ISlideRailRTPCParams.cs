using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A15 RID: 10773
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlideRailRTPCParams
	{
		// Token: 0x0600ED89 RID: 60809 RVA: 0x00229FB1 File Offset: 0x002281B1
		public static ISlideRailRTPCParams Create(ISlideRailRTPCParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailRTPCParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x0600ED8A RID: 60810 RVA: 0x00229FD0 File Offset: 0x002281D0
		public virtual string RTPCName
		{
			get
			{
				return this.Instance.RTPCName;
			}
		}

		// Token: 0x040082BF RID: 33471
		private ISlideRailRTPCParams Instance;
	}
}
