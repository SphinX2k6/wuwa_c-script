using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F9 RID: 10745
	public class IStopNewMoveWithSplineAtCurrentPos : IStopNewMoveWithSplineType
	{
		// Token: 0x0600EDA1 RID: 60833 RVA: 0x0022ED8A File Offset: 0x0022CF8A
		public static IStopNewMoveWithSplineAtCurrentPos Create(IStopNewMoveWithSplineAtCurrentPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopNewMoveWithSplineAtCurrentPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x0600EDA2 RID: 60834 RVA: 0x0022EDA9 File Offset: 0x0022CFA9
		public override EStopNewMoveWithSplineType Type
		{
			get
			{
				return (EStopNewMoveWithSplineType)this.Instance.Type;
			}
		}

		// Token: 0x040082C7 RID: 33479
		private IStopNewMoveWithSplineAtCurrentPos Instance;
	}
}
