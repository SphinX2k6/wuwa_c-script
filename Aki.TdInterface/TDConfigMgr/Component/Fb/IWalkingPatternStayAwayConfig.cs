using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E7C RID: 3708
	public class IWalkingPatternStayAwayConfig
	{
		// Token: 0x060053C4 RID: 21444 RVA: 0x000CE87A File Offset: 0x000CCA7A
		public static IWalkingPatternStayAwayConfig Create(IWalkingPatternStayAwayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWalkingPatternStayAwayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x060053C5 RID: 21445 RVA: 0x000CE899 File Offset: 0x000CCA99
		public virtual int SplineDistance
		{
			get
			{
				return this.Instance.SplineDistance;
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x060053C6 RID: 21446 RVA: 0x000CE8A8 File Offset: 0x000CCAA8
		public virtual int? StayAwayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.StayAwayTime);
			}
		}

		// Token: 0x04002FE9 RID: 12265
		private IWalkingPatternStayAwayConfig Instance;
	}
}
