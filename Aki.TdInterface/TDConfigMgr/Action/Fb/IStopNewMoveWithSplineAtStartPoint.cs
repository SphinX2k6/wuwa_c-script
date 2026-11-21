using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FA RID: 10746
	public class IStopNewMoveWithSplineAtStartPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600EDA4 RID: 60836 RVA: 0x0022EDBE File Offset: 0x0022CFBE
		public static IStopNewMoveWithSplineAtStartPoint Create(IStopNewMoveWithSplineAtStartPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtStartPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x0600EDA5 RID: 60837 RVA: 0x0022EDDD File Offset: 0x0022CFDD
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x040082C8 RID: 33480
		private IStopNewMoveWithSplineAtStartPoint Instance;
	}
}
