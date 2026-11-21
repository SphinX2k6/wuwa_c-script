using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F6 RID: 10742
	public class IFrontAxleTrackingSplineMove : INewSplineMoveType
	{
		// Token: 0x0600ED91 RID: 60817 RVA: 0x0022EB9E File Offset: 0x0022CD9E
		public static IFrontAxleTrackingSplineMove Create(IFrontAxleTrackingSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrontAxleTrackingSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x0600ED92 RID: 60818 RVA: 0x0022EBBD File Offset: 0x0022CDBD
		public override ENewSplineMoveType Type
		{
			get
			{
				return (ENewSplineMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x0600ED93 RID: 60819 RVA: 0x0022EBCA File Offset: 0x0022CDCA
		public virtual float EntityAxisLength
		{
			get
			{
				return this.Instance.EntityAxisLength;
			}
		}

		// Token: 0x040082C0 RID: 33472
		private IFrontAxleTrackingSplineMove Instance;
	}
}
