using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764E RID: 30286
	public class TBpActorFuncTypeUnion
	{
		// Token: 0x1700E5C7 RID: 58823
		// (get) Token: 0x06037248 RID: 225864 RVA: 0x0077A0C6 File Offset: 0x007782C6
		// (set) Token: 0x06037249 RID: 225865 RVA: 0x0077A0CE File Offset: 0x007782CE
		public TBpActorFuncType Type { get; set; }

		// Token: 0x1700E5C8 RID: 58824
		// (get) Token: 0x0603724A RID: 225866 RVA: 0x0077A0D7 File Offset: 0x007782D7
		// (set) Token: 0x0603724B RID: 225867 RVA: 0x0077A0DF File Offset: 0x007782DF
		public object Value { get; set; }

		// Token: 0x0603724C RID: 225868 RVA: 0x0077A0E8 File Offset: 0x007782E8
		public TBpActorFuncTypeUnion()
		{
			this.Type = TBpActorFuncType.NONE;
			this.Value = null;
		}

		// Token: 0x0603724D RID: 225869 RVA: 0x0077A0FE File Offset: 0x007782FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603724E RID: 225870 RVA: 0x0077A110 File Offset: 0x00778310
		public IBrokenBridgeEffectInMobileBpActorFuncT AsIBrokenBridgeEffectInMobileBpActorFunc()
		{
			return this.As<IBrokenBridgeEffectInMobileBpActorFuncT>();
		}

		// Token: 0x0603724F RID: 225871 RVA: 0x0077A118 File Offset: 0x00778318
		public static TBpActorFuncTypeUnion FromIBrokenBridgeEffectInMobileBpActorFunc(IBrokenBridgeEffectInMobileBpActorFuncT _ibrokenbridgeeffectinmobilebpactorfunc)
		{
			return new TBpActorFuncTypeUnion
			{
				Type = TBpActorFuncType.IBrokenBridgeEffectInMobileBpActorFunc,
				Value = _ibrokenbridgeeffectinmobilebpactorfunc
			};
		}

		// Token: 0x06037250 RID: 225872 RVA: 0x0077A12D File Offset: 0x0077832D
		public ICarPaintChangeBpActorFuncT AsICarPaintChangeBpActorFunc()
		{
			return this.As<ICarPaintChangeBpActorFuncT>();
		}

		// Token: 0x06037251 RID: 225873 RVA: 0x0077A135 File Offset: 0x00778335
		public static TBpActorFuncTypeUnion FromICarPaintChangeBpActorFunc(ICarPaintChangeBpActorFuncT _icarpaintchangebpactorfunc)
		{
			return new TBpActorFuncTypeUnion
			{
				Type = TBpActorFuncType.ICarPaintChangeBpActorFunc,
				Value = _icarpaintchangebpactorfunc
			};
		}

		// Token: 0x06037252 RID: 225874 RVA: 0x0077A14C File Offset: 0x0077834C
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
