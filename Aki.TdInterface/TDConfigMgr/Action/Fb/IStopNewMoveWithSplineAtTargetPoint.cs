using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FC RID: 10748
	public class IStopNewMoveWithSplineAtTargetPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600EDAA RID: 60842 RVA: 0x0022EE26 File Offset: 0x0022D026
		public static IStopNewMoveWithSplineAtTargetPoint Create(IStopNewMoveWithSplineAtTargetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtTargetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x0600EDAB RID: 60843 RVA: 0x0022EE45 File Offset: 0x0022D045
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x0600EDAC RID: 60844 RVA: 0x0022EE52 File Offset: 0x0022D052
		public virtual int PointId
		{
			get
			{
				return this.Instance.PointId;
			}
		}

		// Token: 0x040082CA RID: 33482
		private IStopNewMoveWithSplineAtTargetPoint Instance;
	}
}
