using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002733 RID: 10035
	public class ISceneNewItemSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600DFB5 RID: 57269 RVA: 0x002123A4 File Offset: 0x002105A4
		[NullableContext(1)]
		public static ISceneNewItemSplineStopTarget Create(ISceneNewItemSplineStopTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneNewItemSplineStopTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x0600DFB6 RID: 57270 RVA: 0x002123C3 File Offset: 0x002105C3
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x0600DFB7 RID: 57271 RVA: 0x002123D0 File Offset: 0x002105D0
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007C1F RID: 31775
		private ISceneNewItemSplineStopTarget Instance;
	}
}
