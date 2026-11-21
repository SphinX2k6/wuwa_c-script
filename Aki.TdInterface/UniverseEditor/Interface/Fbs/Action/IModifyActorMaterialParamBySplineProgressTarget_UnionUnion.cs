using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E7 RID: 29159
	public class IModifyActorMaterialParamBySplineProgressTarget_UnionUnion
	{
		// Token: 0x1700D579 RID: 54649
		// (get) Token: 0x06032B94 RID: 207764 RVA: 0x006DA191 File Offset: 0x006D8391
		// (set) Token: 0x06032B95 RID: 207765 RVA: 0x006DA199 File Offset: 0x006D8399
		public IModifyActorMaterialParamBySplineProgressTarget_Union Type { get; set; }

		// Token: 0x1700D57A RID: 54650
		// (get) Token: 0x06032B96 RID: 207766 RVA: 0x006DA1A2 File Offset: 0x006D83A2
		// (set) Token: 0x06032B97 RID: 207767 RVA: 0x006DA1AA File Offset: 0x006D83AA
		public object Value { get; set; }

		// Token: 0x06032B98 RID: 207768 RVA: 0x006DA1B3 File Offset: 0x006D83B3
		public IModifyActorMaterialParamBySplineProgressTarget_UnionUnion()
		{
			this.Type = IModifyActorMaterialParamBySplineProgressTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032B99 RID: 207769 RVA: 0x006DA1C9 File Offset: 0x006D83C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032B9A RID: 207770 RVA: 0x006DA1DB File Offset: 0x006D83DB
		public IModifyActorMaterialParamBySplineProgressTargetT AsIModifyActorMaterialParamBySplineProgressTarget()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressTargetT>();
		}

		// Token: 0x06032B9B RID: 207771 RVA: 0x006DA1E3 File Offset: 0x006D83E3
		public static IModifyActorMaterialParamBySplineProgressTarget_UnionUnion FromIModifyActorMaterialParamBySplineProgressTarget(IModifyActorMaterialParamBySplineProgressTargetT _imodifyactormaterialparambysplineprogresstarget)
		{
			return new IModifyActorMaterialParamBySplineProgressTarget_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressTarget_Union.IModifyActorMaterialParamBySplineProgressTarget,
				Value = _imodifyactormaterialparambysplineprogresstarget
			};
		}

		// Token: 0x06032B9C RID: 207772 RVA: 0x006DA1F8 File Offset: 0x006D83F8
		public IModifyActorMaterialParamByPlayerSplineProgressT AsIModifyActorMaterialParamByPlayerSplineProgress()
		{
			return this.As<IModifyActorMaterialParamByPlayerSplineProgressT>();
		}

		// Token: 0x06032B9D RID: 207773 RVA: 0x006DA200 File Offset: 0x006D8400
		public static IModifyActorMaterialParamBySplineProgressTarget_UnionUnion FromIModifyActorMaterialParamByPlayerSplineProgress(IModifyActorMaterialParamByPlayerSplineProgressT _imodifyactormaterialparambyplayersplineprogress)
		{
			return new IModifyActorMaterialParamBySplineProgressTarget_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressTarget_Union.IModifyActorMaterialParamByPlayerSplineProgress,
				Value = _imodifyactormaterialparambyplayersplineprogress
			};
		}

		// Token: 0x06032B9E RID: 207774 RVA: 0x006DA215 File Offset: 0x006D8415
		public IModifyActorMaterialParamByEntitySplineProgressT AsIModifyActorMaterialParamByEntitySplineProgress()
		{
			return this.As<IModifyActorMaterialParamByEntitySplineProgressT>();
		}

		// Token: 0x06032B9F RID: 207775 RVA: 0x006DA21D File Offset: 0x006D841D
		public static IModifyActorMaterialParamBySplineProgressTarget_UnionUnion FromIModifyActorMaterialParamByEntitySplineProgress(IModifyActorMaterialParamByEntitySplineProgressT _imodifyactormaterialparambyentitysplineprogress)
		{
			return new IModifyActorMaterialParamBySplineProgressTarget_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressTarget_Union.IModifyActorMaterialParamByEntitySplineProgress,
				Value = _imodifyactormaterialparambyentitysplineprogress
			};
		}

		// Token: 0x06032BA0 RID: 207776 RVA: 0x006DA234 File Offset: 0x006D8434
		public static int Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IModifyActorMaterialParamBySplineProgressTarget_Union.IModifyActorMaterialParamBySplineProgressTarget:
				return IModifyActorMaterialParamBySplineProgressTarget.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressTarget()).Value;
			case IModifyActorMaterialParamBySplineProgressTarget_Union.IModifyActorMaterialParamByPlayerSplineProgress:
				return IModifyActorMaterialParamByPlayerSplineProgress.Pack(builder, _o.AsIModifyActorMaterialParamByPlayerSplineProgress()).Value;
			case IModifyActorMaterialParamBySplineProgressTarget_Union.IModifyActorMaterialParamByEntitySplineProgress:
				return IModifyActorMaterialParamByEntitySplineProgress.Pack(builder, _o.AsIModifyActorMaterialParamByEntitySplineProgress()).Value;
			default:
				return 0;
			}
		}
	}
}
