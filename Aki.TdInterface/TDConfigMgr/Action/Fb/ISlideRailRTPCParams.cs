using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D02 RID: 11522
	public class ISlideRailRTPCParams
	{
		// Token: 0x0600FC20 RID: 64544 RVA: 0x00247935 File Offset: 0x00245B35
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

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x0600FC21 RID: 64545 RVA: 0x00247954 File Offset: 0x00245B54
		public virtual string RTPCName
		{
			get
			{
				return this.Instance.RTPCName;
			}
		}

		// Token: 0x040089B0 RID: 35248
		private ISlideRailRTPCParams Instance;
	}
}
