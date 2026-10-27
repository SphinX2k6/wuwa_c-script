using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C4 RID: 22468
	public class IQteType_UnionUnion
	{
		// Token: 0x1700A7AF RID: 42927
		// (get) Token: 0x06025B56 RID: 154454 RVA: 0x0053352A File Offset: 0x0053172A
		// (set) Token: 0x06025B57 RID: 154455 RVA: 0x00533532 File Offset: 0x00531732
		public IQteType_Union Type { get; set; }

		// Token: 0x1700A7B0 RID: 42928
		// (get) Token: 0x06025B58 RID: 154456 RVA: 0x0053353B File Offset: 0x0053173B
		// (set) Token: 0x06025B59 RID: 154457 RVA: 0x00533543 File Offset: 0x00531743
		public object Value { get; set; }

		// Token: 0x06025B5A RID: 154458 RVA: 0x0053354C File Offset: 0x0053174C
		public IQteType_UnionUnion()
		{
			this.Type = IQteType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025B5B RID: 154459 RVA: 0x00533562 File Offset: 0x00531762
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025B5C RID: 154460 RVA: 0x00533574 File Offset: 0x00531774
		public IQteTypeT AsIQteType()
		{
			return this.As<IQteTypeT>();
		}

		// Token: 0x06025B5D RID: 154461 RVA: 0x0053357C File Offset: 0x0053177C
		public static IQteType_UnionUnion FromIQteType(IQteTypeT _iqtetype)
		{
			return new IQteType_UnionUnion
			{
				Type = IQteType_Union.IQteType,
				Value = _iqtetype
			};
		}

		// Token: 0x06025B5E RID: 154462 RVA: 0x00533591 File Offset: 0x00531791
		public ISingleBtnQteT AsISingleBtnQte()
		{
			return this.As<ISingleBtnQteT>();
		}

		// Token: 0x06025B5F RID: 154463 RVA: 0x00533599 File Offset: 0x00531799
		public static IQteType_UnionUnion FromISingleBtnQte(ISingleBtnQteT _isinglebtnqte)
		{
			return new IQteType_UnionUnion
			{
				Type = IQteType_Union.ISingleBtnQte,
				Value = _isinglebtnqte
			};
		}

		// Token: 0x06025B60 RID: 154464 RVA: 0x005335B0 File Offset: 0x005317B0
		public static int Pack(FlatBufferBuilder builder, IQteType_UnionUnion _o)
		{
			IQteType_Union type = _o.Type;
			if (type == IQteType_Union.IQteType)
			{
				return IQteType.Pack(builder, _o.AsIQteType()).Value;
			}
			if (type != IQteType_Union.ISingleBtnQte)
			{
				return 0;
			}
			return ISingleBtnQte.Pack(builder, _o.AsISingleBtnQte()).Value;
		}
	}
}
