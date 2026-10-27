using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D80 RID: 3456
	public class IWalkingPatternStayAwayConfig
	{
		// Token: 0x06004E9F RID: 20127 RVA: 0x000C302A File Offset: 0x000C122A
		[NullableContext(1)]
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

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x000C3049 File Offset: 0x000C1249
		public virtual int SplineDistance
		{
			get
			{
				return this.Instance.SplineDistance;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x000C3058 File Offset: 0x000C1258
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

		// Token: 0x04002D23 RID: 11555
		private IWalkingPatternStayAwayConfig Instance;
	}
}
