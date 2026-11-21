using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F65 RID: 16229
	public class TTimeDisplayParamsUnion
	{
		// Token: 0x17006DC7 RID: 28103
		// (get) Token: 0x0601615D RID: 90461 RVA: 0x0032B742 File Offset: 0x00329942
		// (set) Token: 0x0601615E RID: 90462 RVA: 0x0032B74A File Offset: 0x0032994A
		public TTimeDisplayParams Type { get; set; }

		// Token: 0x17006DC8 RID: 28104
		// (get) Token: 0x0601615F RID: 90463 RVA: 0x0032B753 File Offset: 0x00329953
		// (set) Token: 0x06016160 RID: 90464 RVA: 0x0032B75B File Offset: 0x0032995B
		public object Value { get; set; }

		// Token: 0x06016161 RID: 90465 RVA: 0x0032B764 File Offset: 0x00329964
		public TTimeDisplayParamsUnion()
		{
			this.Type = TTimeDisplayParams.NONE;
			this.Value = null;
		}

		// Token: 0x06016162 RID: 90466 RVA: 0x0032B77A File Offset: 0x0032997A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016163 RID: 90467 RVA: 0x0032B78C File Offset: 0x0032998C
		public ITimeDisplayParamsConstantT AsITimeDisplayParamsConstant()
		{
			return this.As<ITimeDisplayParamsConstantT>();
		}

		// Token: 0x06016164 RID: 90468 RVA: 0x0032B794 File Offset: 0x00329994
		public static TTimeDisplayParamsUnion FromITimeDisplayParamsConstant(ITimeDisplayParamsConstantT _itimedisplayparamsconstant)
		{
			return new TTimeDisplayParamsUnion
			{
				Type = TTimeDisplayParams.ITimeDisplayParamsConstant,
				Value = _itimedisplayparamsconstant
			};
		}

		// Token: 0x06016165 RID: 90469 RVA: 0x0032B7A9 File Offset: 0x003299A9
		public ITimeDisplayParamsVarT AsITimeDisplayParamsVar()
		{
			return this.As<ITimeDisplayParamsVarT>();
		}

		// Token: 0x06016166 RID: 90470 RVA: 0x0032B7B1 File Offset: 0x003299B1
		public static TTimeDisplayParamsUnion FromITimeDisplayParamsVar(ITimeDisplayParamsVarT _itimedisplayparamsvar)
		{
			return new TTimeDisplayParamsUnion
			{
				Type = TTimeDisplayParams.ITimeDisplayParamsVar,
				Value = _itimedisplayparamsvar
			};
		}

		// Token: 0x06016167 RID: 90471 RVA: 0x0032B7C8 File Offset: 0x003299C8
		public static int Pack(FlatBufferBuilder builder, TTimeDisplayParamsUnion _o)
		{
			TTimeDisplayParams type = _o.Type;
			if (type == TTimeDisplayParams.ITimeDisplayParamsConstant)
			{
				return ITimeDisplayParamsConstant.Pack(builder, _o.AsITimeDisplayParamsConstant()).Value;
			}
			if (type != TTimeDisplayParams.ITimeDisplayParamsVar)
			{
				return 0;
			}
			return ITimeDisplayParamsVar.Pack(builder, _o.AsITimeDisplayParamsVar()).Value;
		}
	}
}
