using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C83 RID: 3203
	public class IOnMoveWithSplineEndAttachTiming : IAttachTiming
	{
		// Token: 0x06004950 RID: 18768 RVA: 0x000B7DDF File Offset: 0x000B5FDF
		[NullableContext(1)]
		public static IOnMoveWithSplineEndAttachTiming Create(IOnMoveWithSplineEndAttachTiming? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnMoveWithSplineEndAttachTiming
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x000B7DFE File Offset: 0x000B5FFE
		public override EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x000B7E0B File Offset: 0x000B600B
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x040029D2 RID: 10706
		private IOnMoveWithSplineEndAttachTiming Instance;
	}
}
