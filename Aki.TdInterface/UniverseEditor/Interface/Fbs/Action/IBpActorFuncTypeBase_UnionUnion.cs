using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006893 RID: 26771
	public class IBpActorFuncTypeBase_UnionUnion
	{
		// Token: 0x1700C4BB RID: 50363
		// (get) Token: 0x0602DC35 RID: 187445 RVA: 0x006417F9 File Offset: 0x0063F9F9
		// (set) Token: 0x0602DC36 RID: 187446 RVA: 0x00641801 File Offset: 0x0063FA01
		public IBpActorFuncTypeBase_Union Type { get; set; }

		// Token: 0x1700C4BC RID: 50364
		// (get) Token: 0x0602DC37 RID: 187447 RVA: 0x0064180A File Offset: 0x0063FA0A
		// (set) Token: 0x0602DC38 RID: 187448 RVA: 0x00641812 File Offset: 0x0063FA12
		public object Value { get; set; }

		// Token: 0x0602DC39 RID: 187449 RVA: 0x0064181B File Offset: 0x0063FA1B
		public IBpActorFuncTypeBase_UnionUnion()
		{
			this.Type = IBpActorFuncTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DC3A RID: 187450 RVA: 0x00641831 File Offset: 0x0063FA31
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DC3B RID: 187451 RVA: 0x00641843 File Offset: 0x0063FA43
		public IBpActorFuncTypeBaseT AsIBpActorFuncTypeBase()
		{
			return this.As<IBpActorFuncTypeBaseT>();
		}

		// Token: 0x0602DC3C RID: 187452 RVA: 0x0064184B File Offset: 0x0063FA4B
		public static IBpActorFuncTypeBase_UnionUnion FromIBpActorFuncTypeBase(IBpActorFuncTypeBaseT _ibpactorfunctypebase)
		{
			return new IBpActorFuncTypeBase_UnionUnion
			{
				Type = IBpActorFuncTypeBase_Union.IBpActorFuncTypeBase,
				Value = _ibpactorfunctypebase
			};
		}

		// Token: 0x0602DC3D RID: 187453 RVA: 0x00641860 File Offset: 0x0063FA60
		public ICarPaintChangeBpActorFuncT AsICarPaintChangeBpActorFunc()
		{
			return this.As<ICarPaintChangeBpActorFuncT>();
		}

		// Token: 0x0602DC3E RID: 187454 RVA: 0x00641868 File Offset: 0x0063FA68
		public static IBpActorFuncTypeBase_UnionUnion FromICarPaintChangeBpActorFunc(ICarPaintChangeBpActorFuncT _icarpaintchangebpactorfunc)
		{
			return new IBpActorFuncTypeBase_UnionUnion
			{
				Type = IBpActorFuncTypeBase_Union.ICarPaintChangeBpActorFunc,
				Value = _icarpaintchangebpactorfunc
			};
		}

		// Token: 0x0602DC3F RID: 187455 RVA: 0x0064187D File Offset: 0x0063FA7D
		public IBrokenBridgeEffectInMobileBpActorFuncT AsIBrokenBridgeEffectInMobileBpActorFunc()
		{
			return this.As<IBrokenBridgeEffectInMobileBpActorFuncT>();
		}

		// Token: 0x0602DC40 RID: 187456 RVA: 0x00641885 File Offset: 0x0063FA85
		public static IBpActorFuncTypeBase_UnionUnion FromIBrokenBridgeEffectInMobileBpActorFunc(IBrokenBridgeEffectInMobileBpActorFuncT _ibrokenbridgeeffectinmobilebpactorfunc)
		{
			return new IBpActorFuncTypeBase_UnionUnion
			{
				Type = IBpActorFuncTypeBase_Union.IBrokenBridgeEffectInMobileBpActorFunc,
				Value = _ibrokenbridgeeffectinmobilebpactorfunc
			};
		}

		// Token: 0x0602DC41 RID: 187457 RVA: 0x0064189C File Offset: 0x0063FA9C
		public static int Pack(FlatBufferBuilder builder, IBpActorFuncTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBpActorFuncTypeBase_Union.IBpActorFuncTypeBase:
				return IBpActorFuncTypeBase.Pack(builder, _o.AsIBpActorFuncTypeBase()).Value;
			case IBpActorFuncTypeBase_Union.ICarPaintChangeBpActorFunc:
				return ICarPaintChangeBpActorFunc.Pack(builder, _o.AsICarPaintChangeBpActorFunc()).Value;
			case IBpActorFuncTypeBase_Union.IBrokenBridgeEffectInMobileBpActorFunc:
				return IBrokenBridgeEffectInMobileBpActorFunc.Pack(builder, _o.AsIBrokenBridgeEffectInMobileBpActorFunc()).Value;
			default:
				return 0;
			}
		}
	}
}
