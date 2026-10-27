using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006222 RID: 25122
	public class IBpActorFuncTypeBase_UnionUnion
	{
		// Token: 0x1700BB33 RID: 47923
		// (get) Token: 0x0602B4D4 RID: 177364 RVA: 0x005F69F1 File Offset: 0x005F4BF1
		// (set) Token: 0x0602B4D5 RID: 177365 RVA: 0x005F69F9 File Offset: 0x005F4BF9
		public IBpActorFuncTypeBase_Union Type { get; set; }

		// Token: 0x1700BB34 RID: 47924
		// (get) Token: 0x0602B4D6 RID: 177366 RVA: 0x005F6A02 File Offset: 0x005F4C02
		// (set) Token: 0x0602B4D7 RID: 177367 RVA: 0x005F6A0A File Offset: 0x005F4C0A
		public object Value { get; set; }

		// Token: 0x0602B4D8 RID: 177368 RVA: 0x005F6A13 File Offset: 0x005F4C13
		public IBpActorFuncTypeBase_UnionUnion()
		{
			this.Type = IBpActorFuncTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B4D9 RID: 177369 RVA: 0x005F6A29 File Offset: 0x005F4C29
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B4DA RID: 177370 RVA: 0x005F6A3B File Offset: 0x005F4C3B
		public IBpActorFuncTypeBaseT AsIBpActorFuncTypeBase()
		{
			return this.As<IBpActorFuncTypeBaseT>();
		}

		// Token: 0x0602B4DB RID: 177371 RVA: 0x005F6A43 File Offset: 0x005F4C43
		public static IBpActorFuncTypeBase_UnionUnion FromIBpActorFuncTypeBase(IBpActorFuncTypeBaseT _ibpactorfunctypebase)
		{
			return new IBpActorFuncTypeBase_UnionUnion
			{
				Type = IBpActorFuncTypeBase_Union.IBpActorFuncTypeBase,
				Value = _ibpactorfunctypebase
			};
		}

		// Token: 0x0602B4DC RID: 177372 RVA: 0x005F6A58 File Offset: 0x005F4C58
		public ICarPaintChangeBpActorFuncT AsICarPaintChangeBpActorFunc()
		{
			return this.As<ICarPaintChangeBpActorFuncT>();
		}

		// Token: 0x0602B4DD RID: 177373 RVA: 0x005F6A60 File Offset: 0x005F4C60
		public static IBpActorFuncTypeBase_UnionUnion FromICarPaintChangeBpActorFunc(ICarPaintChangeBpActorFuncT _icarpaintchangebpactorfunc)
		{
			return new IBpActorFuncTypeBase_UnionUnion
			{
				Type = IBpActorFuncTypeBase_Union.ICarPaintChangeBpActorFunc,
				Value = _icarpaintchangebpactorfunc
			};
		}

		// Token: 0x0602B4DE RID: 177374 RVA: 0x005F6A75 File Offset: 0x005F4C75
		public IBrokenBridgeEffectInMobileBpActorFuncT AsIBrokenBridgeEffectInMobileBpActorFunc()
		{
			return this.As<IBrokenBridgeEffectInMobileBpActorFuncT>();
		}

		// Token: 0x0602B4DF RID: 177375 RVA: 0x005F6A7D File Offset: 0x005F4C7D
		public static IBpActorFuncTypeBase_UnionUnion FromIBrokenBridgeEffectInMobileBpActorFunc(IBrokenBridgeEffectInMobileBpActorFuncT _ibrokenbridgeeffectinmobilebpactorfunc)
		{
			return new IBpActorFuncTypeBase_UnionUnion
			{
				Type = IBpActorFuncTypeBase_Union.IBrokenBridgeEffectInMobileBpActorFunc,
				Value = _ibrokenbridgeeffectinmobilebpactorfunc
			};
		}

		// Token: 0x0602B4E0 RID: 177376 RVA: 0x005F6A94 File Offset: 0x005F4C94
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
