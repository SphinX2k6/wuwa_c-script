using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D58 RID: 11608
	public class ILookAtPerformOverlapMontageConfig
	{
		// Token: 0x0600FD67 RID: 64871 RVA: 0x002497D6 File Offset: 0x002479D6
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

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x0600FD68 RID: 64872 RVA: 0x002497F8 File Offset: 0x002479F8
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

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x0600FD69 RID: 64873 RVA: 0x00249830 File Offset: 0x00247A30
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

		// Token: 0x04008A52 RID: 35410
		private ILookAtPerformOverlapMontageConfig Instance;
	}
}
