using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A64 RID: 10852
	public class ILookAtPerformOverlapMontageConfig
	{
		// Token: 0x0600EEB1 RID: 61105 RVA: 0x0022BACA File Offset: 0x00229CCA
		[NullableContext(1)]
		public static ILookAtPerformOverlapMontageConfig Create(ILookAtPerformOverlapMontageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtPerformOverlapMontageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x0600EEB2 RID: 61106 RVA: 0x0022BAEC File Offset: 0x00229CEC
		public virtual float? OverlapMontageLoopDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.OverlapMontageLoopDuration);
			}
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x0600EEB3 RID: 61107 RVA: 0x0022BB24 File Offset: 0x00229D24
		public virtual int? OverlapMontageRepeatTimes
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OverlapMontageRepeatTimes);
			}
		}

		// Token: 0x0400834E RID: 33614
		private ILookAtPerformOverlapMontageConfig Instance;
	}
}
