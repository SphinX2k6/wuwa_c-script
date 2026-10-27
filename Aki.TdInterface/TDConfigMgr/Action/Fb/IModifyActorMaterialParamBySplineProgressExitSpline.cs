using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002902 RID: 10498
	public class IModifyActorMaterialParamBySplineProgressExitSpline : IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x0600E918 RID: 59672 RVA: 0x00222FAD File Offset: 0x002211AD
		[NullableContext(1)]
		public static IModifyActorMaterialParamBySplineProgressExitSpline Create(IModifyActorMaterialParamBySplineProgressExitSpline? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressExitSpline
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x0600E919 RID: 59673 RVA: 0x00222FCC File Offset: 0x002211CC
		public override EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				return (EModifyActorMaterialParamBySplineProgressType)this.Instance.Type;
			}
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x00222FD9 File Offset: 0x002211D9
		public override int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x040080AE RID: 32942
		private IModifyActorMaterialParamBySplineProgressExitSpline Instance;
	}
}
