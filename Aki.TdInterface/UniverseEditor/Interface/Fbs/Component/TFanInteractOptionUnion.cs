using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200623E RID: 25150
	public class TFanInteractOptionUnion
	{
		// Token: 0x1700BB40 RID: 47936
		// (get) Token: 0x0602AD13 RID: 175379 RVA: 0x005D8E9E File Offset: 0x005D709E
		// (set) Token: 0x0602AD14 RID: 175380 RVA: 0x005D8EA6 File Offset: 0x005D70A6
		public TFanInteractOption Type { get; set; }

		// Token: 0x1700BB41 RID: 47937
		// (get) Token: 0x0602AD15 RID: 175381 RVA: 0x005D8EAF File Offset: 0x005D70AF
		// (set) Token: 0x0602AD16 RID: 175382 RVA: 0x005D8EB7 File Offset: 0x005D70B7
		public object Value { get; set; }

		// Token: 0x0602AD17 RID: 175383 RVA: 0x005D8EC0 File Offset: 0x005D70C0
		public TFanInteractOptionUnion()
		{
			this.Type = TFanInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD18 RID: 175384 RVA: 0x005D8ED6 File Offset: 0x005D70D6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD19 RID: 175385 RVA: 0x005D8EE8 File Offset: 0x005D70E8
		public IFanInteractByFKeyT AsIFanInteractByFKey()
		{
			return this.As<IFanInteractByFKeyT>();
		}

		// Token: 0x0602AD1A RID: 175386 RVA: 0x005D8EF0 File Offset: 0x005D70F0
		public static TFanInteractOptionUnion FromIFanInteractByFKey(IFanInteractByFKeyT _ifaninteractbyfkey)
		{
			return new TFanInteractOptionUnion
			{
				Type = TFanInteractOption.IFanInteractByFKey,
				Value = _ifaninteractbyfkey
			};
		}

		// Token: 0x0602AD1B RID: 175387 RVA: 0x005D8F05 File Offset: 0x005D7105
		public IFanInteractByHitT AsIFanInteractByHit()
		{
			return this.As<IFanInteractByHitT>();
		}

		// Token: 0x0602AD1C RID: 175388 RVA: 0x005D8F0D File Offset: 0x005D710D
		public static TFanInteractOptionUnion FromIFanInteractByHit(IFanInteractByHitT _ifaninteractbyhit)
		{
			return new TFanInteractOptionUnion
			{
				Type = TFanInteractOption.IFanInteractByHit,
				Value = _ifaninteractbyhit
			};
		}

		// Token: 0x0602AD1D RID: 175389 RVA: 0x005D8F24 File Offset: 0x005D7124
		public static int Pack(FlatBufferBuilder builder, TFanInteractOptionUnion _o)
		{
			TFanInteractOption type = _o.Type;
			if (type == TFanInteractOption.IFanInteractByFKey)
			{
				return IFanInteractByFKey.Pack(builder, _o.AsIFanInteractByFKey()).Value;
			}
			if (type != TFanInteractOption.IFanInteractByHit)
			{
				return 0;
			}
			return IFanInteractByHit.Pack(builder, _o.AsIFanInteractByHit()).Value;
		}
	}
}
