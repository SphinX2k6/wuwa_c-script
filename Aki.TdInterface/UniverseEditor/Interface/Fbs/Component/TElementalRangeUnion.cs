using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006229 RID: 25129
	public class TElementalRangeUnion
	{
		// Token: 0x1700BB32 RID: 47922
		// (get) Token: 0x0602AC9F RID: 175263 RVA: 0x005D8374 File Offset: 0x005D6574
		// (set) Token: 0x0602ACA0 RID: 175264 RVA: 0x005D837C File Offset: 0x005D657C
		public TElementalRange Type { get; set; }

		// Token: 0x1700BB33 RID: 47923
		// (get) Token: 0x0602ACA1 RID: 175265 RVA: 0x005D8385 File Offset: 0x005D6585
		// (set) Token: 0x0602ACA2 RID: 175266 RVA: 0x005D838D File Offset: 0x005D658D
		public object Value { get; set; }

		// Token: 0x0602ACA3 RID: 175267 RVA: 0x005D8396 File Offset: 0x005D6596
		public TElementalRangeUnion()
		{
			this.Type = TElementalRange.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACA4 RID: 175268 RVA: 0x005D83AC File Offset: 0x005D65AC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ACA5 RID: 175269 RVA: 0x005D83BE File Offset: 0x005D65BE
		public IBaseShapeElementalRangeT AsIBaseShapeElementalRange()
		{
			return this.As<IBaseShapeElementalRangeT>();
		}

		// Token: 0x0602ACA6 RID: 175270 RVA: 0x005D83C6 File Offset: 0x005D65C6
		public static TElementalRangeUnion FromIBaseShapeElementalRange(IBaseShapeElementalRangeT _ibaseshapeelementalrange)
		{
			return new TElementalRangeUnion
			{
				Type = TElementalRange.IBaseShapeElementalRange,
				Value = _ibaseshapeelementalrange
			};
		}

		// Token: 0x0602ACA7 RID: 175271 RVA: 0x005D83DB File Offset: 0x005D65DB
		public ITransportBoxElementalRangeT AsITransportBoxElementalRange()
		{
			return this.As<ITransportBoxElementalRangeT>();
		}

		// Token: 0x0602ACA8 RID: 175272 RVA: 0x005D83E3 File Offset: 0x005D65E3
		public static TElementalRangeUnion FromITransportBoxElementalRange(ITransportBoxElementalRangeT _itransportboxelementalrange)
		{
			return new TElementalRangeUnion
			{
				Type = TElementalRange.ITransportBoxElementalRange,
				Value = _itransportboxelementalrange
			};
		}

		// Token: 0x0602ACA9 RID: 175273 RVA: 0x005D83F8 File Offset: 0x005D65F8
		public static int Pack(FlatBufferBuilder builder, TElementalRangeUnion _o)
		{
			TElementalRange type = _o.Type;
			if (type == TElementalRange.IBaseShapeElementalRange)
			{
				return IBaseShapeElementalRange.Pack(builder, _o.AsIBaseShapeElementalRange()).Value;
			}
			if (type != TElementalRange.ITransportBoxElementalRange)
			{
				return 0;
			}
			return ITransportBoxElementalRange.Pack(builder, _o.AsITransportBoxElementalRange()).Value;
		}
	}
}
