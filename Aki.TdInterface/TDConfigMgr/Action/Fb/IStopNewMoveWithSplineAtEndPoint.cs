using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FB RID: 10747
	public class IStopNewMoveWithSplineAtEndPoint : IStopNewMoveWithSplineType
	{
		// Token: 0x0600EDA7 RID: 60839 RVA: 0x0022EDF2 File Offset: 0x0022CFF2
		public static IStopNewMoveWithSplineAtEndPoint Create(IStopNewMoveWithSplineAtEndPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtEndPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x0600EDA8 RID: 60840 RVA: 0x0022EE11 File Offset: 0x0022D011
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x040082C9 RID: 33481
		private IStopNewMoveWithSplineAtEndPoint Instance;
	}
}
