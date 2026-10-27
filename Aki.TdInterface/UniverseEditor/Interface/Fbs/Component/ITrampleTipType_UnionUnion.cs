using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD3 RID: 23251
	public class ITrampleTipType_UnionUnion
	{
		// Token: 0x1700AF38 RID: 44856
		// (get) Token: 0x06027A60 RID: 162400 RVA: 0x00574335 File Offset: 0x00572535
		// (set) Token: 0x06027A61 RID: 162401 RVA: 0x0057433D File Offset: 0x0057253D
		public ITrampleTipType_Union Type { get; set; }

		// Token: 0x1700AF39 RID: 44857
		// (get) Token: 0x06027A62 RID: 162402 RVA: 0x00574346 File Offset: 0x00572546
		// (set) Token: 0x06027A63 RID: 162403 RVA: 0x0057434E File Offset: 0x0057254E
		public object Value { get; set; }

		// Token: 0x06027A64 RID: 162404 RVA: 0x00574357 File Offset: 0x00572557
		public ITrampleTipType_UnionUnion()
		{
			this.Type = ITrampleTipType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027A65 RID: 162405 RVA: 0x0057436D File Offset: 0x0057256D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027A66 RID: 162406 RVA: 0x0057437F File Offset: 0x0057257F
		public ITrampleTipTypeT AsITrampleTipType()
		{
			return this.As<ITrampleTipTypeT>();
		}

		// Token: 0x06027A67 RID: 162407 RVA: 0x00574387 File Offset: 0x00572587
		public static ITrampleTipType_UnionUnion FromITrampleTipType(ITrampleTipTypeT _itrampletiptype)
		{
			return new ITrampleTipType_UnionUnion
			{
				Type = ITrampleTipType_Union.ITrampleTipType,
				Value = _itrampletiptype
			};
		}

		// Token: 0x06027A68 RID: 162408 RVA: 0x0057439C File Offset: 0x0057259C
		public ICountDownTextTipT AsICountDownTextTip()
		{
			return this.As<ICountDownTextTipT>();
		}

		// Token: 0x06027A69 RID: 162409 RVA: 0x005743A4 File Offset: 0x005725A4
		public static ITrampleTipType_UnionUnion FromICountDownTextTip(ICountDownTextTipT _icountdowntexttip)
		{
			return new ITrampleTipType_UnionUnion
			{
				Type = ITrampleTipType_Union.ICountDownTextTip,
				Value = _icountdowntexttip
			};
		}

		// Token: 0x06027A6A RID: 162410 RVA: 0x005743BC File Offset: 0x005725BC
		public static int Pack(FlatBufferBuilder builder, ITrampleTipType_UnionUnion _o)
		{
			ITrampleTipType_Union type = _o.Type;
			if (type == ITrampleTipType_Union.ITrampleTipType)
			{
				return ITrampleTipType.Pack(builder, _o.AsITrampleTipType()).Value;
			}
			if (type != ITrampleTipType_Union.ICountDownTextTip)
			{
				return 0;
			}
			return ICountDownTextTip.Pack(builder, _o.AsICountDownTextTip()).Value;
		}
	}
}
