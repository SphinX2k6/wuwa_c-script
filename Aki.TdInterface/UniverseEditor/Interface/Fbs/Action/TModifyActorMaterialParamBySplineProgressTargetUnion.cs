using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F3A RID: 32570
	public class TModifyActorMaterialParamBySplineProgressTargetUnion
	{
		// Token: 0x1700F29F RID: 62111
		// (get) Token: 0x0603ABE1 RID: 240609 RVA: 0x007E6122 File Offset: 0x007E4322
		// (set) Token: 0x0603ABE2 RID: 240610 RVA: 0x007E612A File Offset: 0x007E432A
		public TModifyActorMaterialParamBySplineProgressTarget Type { get; set; }

		// Token: 0x1700F2A0 RID: 62112
		// (get) Token: 0x0603ABE3 RID: 240611 RVA: 0x007E6133 File Offset: 0x007E4333
		// (set) Token: 0x0603ABE4 RID: 240612 RVA: 0x007E613B File Offset: 0x007E433B
		public object Value { get; set; }

		// Token: 0x0603ABE5 RID: 240613 RVA: 0x007E6144 File Offset: 0x007E4344
		public TModifyActorMaterialParamBySplineProgressTargetUnion()
		{
			this.Type = TModifyActorMaterialParamBySplineProgressTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABE6 RID: 240614 RVA: 0x007E615A File Offset: 0x007E435A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABE7 RID: 240615 RVA: 0x007E616C File Offset: 0x007E436C
		public IModifyActorMaterialParamByEntitySplineProgressT AsIModifyActorMaterialParamByEntitySplineProgress()
		{
			return this.As<IModifyActorMaterialParamByEntitySplineProgressT>();
		}

		// Token: 0x0603ABE8 RID: 240616 RVA: 0x007E6174 File Offset: 0x007E4374
		public static TModifyActorMaterialParamBySplineProgressTargetUnion FromIModifyActorMaterialParamByEntitySplineProgress(IModifyActorMaterialParamByEntitySplineProgressT _imodifyactormaterialparambyentitysplineprogress)
		{
			return new TModifyActorMaterialParamBySplineProgressTargetUnion
			{
				Type = TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByEntitySplineProgress,
				Value = _imodifyactormaterialparambyentitysplineprogress
			};
		}

		// Token: 0x0603ABE9 RID: 240617 RVA: 0x007E6189 File Offset: 0x007E4389
		public IModifyActorMaterialParamByPlayerSplineProgressT AsIModifyActorMaterialParamByPlayerSplineProgress()
		{
			return this.As<IModifyActorMaterialParamByPlayerSplineProgressT>();
		}

		// Token: 0x0603ABEA RID: 240618 RVA: 0x007E6191 File Offset: 0x007E4391
		public static TModifyActorMaterialParamBySplineProgressTargetUnion FromIModifyActorMaterialParamByPlayerSplineProgress(IModifyActorMaterialParamByPlayerSplineProgressT _imodifyactormaterialparambyplayersplineprogress)
		{
			return new TModifyActorMaterialParamBySplineProgressTargetUnion
			{
				Type = TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByPlayerSplineProgress,
				Value = _imodifyactormaterialparambyplayersplineprogress
			};
		}

		// Token: 0x0603ABEB RID: 240619 RVA: 0x007E61A8 File Offset: 0x007E43A8
		public static int Pack(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgressTargetUnion _o)
		{
			TModifyActorMaterialParamBySplineProgressTarget type = _o.Type;
			if (type == TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByEntitySplineProgress)
			{
				return IModifyActorMaterialParamByEntitySplineProgress.Pack(builder, _o.AsIModifyActorMaterialParamByEntitySplineProgress()).Value;
			}
			if (type != TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByPlayerSplineProgress)
			{
				return 0;
			}
			return IModifyActorMaterialParamByPlayerSplineProgress.Pack(builder, _o.AsIModifyActorMaterialParamByPlayerSplineProgress()).Value;
		}
	}
}
