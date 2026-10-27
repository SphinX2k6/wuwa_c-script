using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002734 RID: 10036
	public class IPlayerNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600DFB9 RID: 57273 RVA: 0x002123E5 File Offset: 0x002105E5
		[NullableContext(1)]
		public static IPlayerNewSplineStopTarget Create(IPlayerNewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x0600DFBA RID: 57274 RVA: 0x00212404 File Offset: 0x00210604
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007C20 RID: 31776
		private IPlayerNewSplineStopTarget Instance;
	}
}
