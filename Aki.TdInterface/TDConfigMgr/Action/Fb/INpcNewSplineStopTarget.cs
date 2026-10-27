using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002732 RID: 10034
	public class INpcNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600DFB1 RID: 57265 RVA: 0x00212363 File Offset: 0x00210563
		[NullableContext(1)]
		public static INpcNewSplineStopTarget Create(INpcNewSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcNewSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x0600DFB2 RID: 57266 RVA: 0x00212382 File Offset: 0x00210582
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x0600DFB3 RID: 57267 RVA: 0x0021238F File Offset: 0x0021058F
		public virtual int NpcId
		{
			get
			{
				return this.Instance.NpcId;
			}
		}

		// Token: 0x04007C1E RID: 31774
		private INpcNewSplineStopTarget Instance;
	}
}
