using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B5D RID: 15197
	public class TTimeDisplayParamsUnion
	{
		// Token: 0x17006828 RID: 26664
		// (get) Token: 0x06014C93 RID: 85139 RVA: 0x003051AA File Offset: 0x003033AA
		// (set) Token: 0x06014C94 RID: 85140 RVA: 0x003051B2 File Offset: 0x003033B2
		public TTimeDisplayParams Type { get; set; }

		// Token: 0x17006829 RID: 26665
		// (get) Token: 0x06014C95 RID: 85141 RVA: 0x003051BB File Offset: 0x003033BB
		// (set) Token: 0x06014C96 RID: 85142 RVA: 0x003051C3 File Offset: 0x003033C3
		public object Value { get; set; }

		// Token: 0x06014C97 RID: 85143 RVA: 0x003051CC File Offset: 0x003033CC
		public TTimeDisplayParamsUnion()
		{
			this.Type = TTimeDisplayParams.NONE;
			this.Value = null;
		}

		// Token: 0x06014C98 RID: 85144 RVA: 0x003051E2 File Offset: 0x003033E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014C99 RID: 85145 RVA: 0x003051F4 File Offset: 0x003033F4
		public ITimeDisplayParamsConstantT AsITimeDisplayParamsConstant()
		{
			return this.As<ITimeDisplayParamsConstantT>();
		}

		// Token: 0x06014C9A RID: 85146 RVA: 0x003051FC File Offset: 0x003033FC
		public static TTimeDisplayParamsUnion FromITimeDisplayParamsConstant(ITimeDisplayParamsConstantT _itimedisplayparamsconstant)
		{
			return new TTimeDisplayParamsUnion
			{
				Type = TTimeDisplayParams.ITimeDisplayParamsConstant,
				Value = _itimedisplayparamsconstant
			};
		}

		// Token: 0x06014C9B RID: 85147 RVA: 0x00305211 File Offset: 0x00303411
		public ITimeDisplayParamsVarT AsITimeDisplayParamsVar()
		{
			return this.As<ITimeDisplayParamsVarT>();
		}

		// Token: 0x06014C9C RID: 85148 RVA: 0x00305219 File Offset: 0x00303419
		public static TTimeDisplayParamsUnion FromITimeDisplayParamsVar(ITimeDisplayParamsVarT _itimedisplayparamsvar)
		{
			return new TTimeDisplayParamsUnion
			{
				Type = TTimeDisplayParams.ITimeDisplayParamsVar,
				Value = _itimedisplayparamsvar
			};
		}

		// Token: 0x06014C9D RID: 85149 RVA: 0x00305230 File Offset: 0x00303430
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
