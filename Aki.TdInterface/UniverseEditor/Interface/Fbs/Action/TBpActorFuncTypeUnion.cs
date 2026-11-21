using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E5C RID: 32348
	public class TBpActorFuncTypeUnion
	{
		// Token: 0x1700F205 RID: 61957
		// (get) Token: 0x0603A6ED RID: 239341 RVA: 0x007DE1C2 File Offset: 0x007DC3C2
		// (set) Token: 0x0603A6EE RID: 239342 RVA: 0x007DE1CA File Offset: 0x007DC3CA
		public TBpActorFuncType Type { get; set; }

		// Token: 0x1700F206 RID: 61958
		// (get) Token: 0x0603A6EF RID: 239343 RVA: 0x007DE1D3 File Offset: 0x007DC3D3
		// (set) Token: 0x0603A6F0 RID: 239344 RVA: 0x007DE1DB File Offset: 0x007DC3DB
		public object Value { get; set; }

		// Token: 0x0603A6F1 RID: 239345 RVA: 0x007DE1E4 File Offset: 0x007DC3E4
		public TBpActorFuncTypeUnion()
		{
			this.Type = TBpActorFuncType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6F2 RID: 239346 RVA: 0x007DE1FA File Offset: 0x007DC3FA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6F3 RID: 239347 RVA: 0x007DE20C File Offset: 0x007DC40C
		public IBrokenBridgeEffectInMobileBpActorFuncT AsIBrokenBridgeEffectInMobileBpActorFunc()
		{
			return this.As<IBrokenBridgeEffectInMobileBpActorFuncT>();
		}

		// Token: 0x0603A6F4 RID: 239348 RVA: 0x007DE214 File Offset: 0x007DC414
		public static TBpActorFuncTypeUnion FromIBrokenBridgeEffectInMobileBpActorFunc(IBrokenBridgeEffectInMobileBpActorFuncT _ibrokenbridgeeffectinmobilebpactorfunc)
		{
			return new TBpActorFuncTypeUnion
			{
				Type = TBpActorFuncType.IBrokenBridgeEffectInMobileBpActorFunc,
				Value = _ibrokenbridgeeffectinmobilebpactorfunc
			};
		}

		// Token: 0x0603A6F5 RID: 239349 RVA: 0x007DE229 File Offset: 0x007DC429
		public ICarPaintChangeBpActorFuncT AsICarPaintChangeBpActorFunc()
		{
			return this.As<ICarPaintChangeBpActorFuncT>();
		}

		// Token: 0x0603A6F6 RID: 239350 RVA: 0x007DE231 File Offset: 0x007DC431
		public static TBpActorFuncTypeUnion FromICarPaintChangeBpActorFunc(ICarPaintChangeBpActorFuncT _icarpaintchangebpactorfunc)
		{
			return new TBpActorFuncTypeUnion
			{
				Type = TBpActorFuncType.ICarPaintChangeBpActorFunc,
				Value = _icarpaintchangebpactorfunc
			};
		}

		// Token: 0x0603A6F7 RID: 239351 RVA: 0x007DE248 File Offset: 0x007DC448
		public static int Pack(FlatBufferBuilder builder, TBpActorFuncTypeUnion _o)
		{
			TBpActorFuncType type = _o.Type;
			if (type == TBpActorFuncType.IBrokenBridgeEffectInMobileBpActorFunc)
			{
				return IBrokenBridgeEffectInMobileBpActorFunc.Pack(builder, _o.AsIBrokenBridgeEffectInMobileBpActorFunc()).Value;
			}
			if (type != TBpActorFuncType.ICarPaintChangeBpActorFunc)
			{
				return 0;
			}
			return ICarPaintChangeBpActorFunc.Pack(builder, _o.AsICarPaintChangeBpActorFunc()).Value;
		}
	}
}
