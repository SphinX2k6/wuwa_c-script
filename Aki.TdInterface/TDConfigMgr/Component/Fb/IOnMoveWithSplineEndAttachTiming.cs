using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D62 RID: 3426
	public class IOnMoveWithSplineEndAttachTiming : IAttachTiming
	{
		// Token: 0x06004DEF RID: 19951 RVA: 0x000C25E3 File Offset: 0x000C07E3
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

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x000C2602 File Offset: 0x000C0802
		public override EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06004DF1 RID: 19953 RVA: 0x000C260F File Offset: 0x000C080F
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x04002C3F RID: 11327
		private IOnMoveWithSplineEndAttachTiming Instance;
	}
}
