using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E0 RID: 24800
	public class ITrampleTipType_UnionUnion
	{
		// Token: 0x1700B874 RID: 47220
		// (get) Token: 0x06029FEA RID: 172010 RVA: 0x005BB765 File Offset: 0x005B9965
		// (set) Token: 0x06029FEB RID: 172011 RVA: 0x005BB76D File Offset: 0x005B996D
		public ITrampleTipType_Union Type { get; set; }

		// Token: 0x1700B875 RID: 47221
		// (get) Token: 0x06029FEC RID: 172012 RVA: 0x005BB776 File Offset: 0x005B9976
		// (set) Token: 0x06029FED RID: 172013 RVA: 0x005BB77E File Offset: 0x005B997E
		public object Value { get; set; }

		// Token: 0x06029FEE RID: 172014 RVA: 0x005BB787 File Offset: 0x005B9987
		public ITrampleTipType_UnionUnion()
		{
			this.Type = ITrampleTipType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029FEF RID: 172015 RVA: 0x005BB79D File Offset: 0x005B999D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029FF0 RID: 172016 RVA: 0x005BB7AF File Offset: 0x005B99AF
		public ITrampleTipTypeT AsITrampleTipType()
		{
			return this.As<ITrampleTipTypeT>();
		}

		// Token: 0x06029FF1 RID: 172017 RVA: 0x005BB7B7 File Offset: 0x005B99B7
		public static ITrampleTipType_UnionUnion FromITrampleTipType(ITrampleTipTypeT _itrampletiptype)
		{
			return new ITrampleTipType_UnionUnion
			{
				Type = ITrampleTipType_Union.ITrampleTipType,
				Value = _itrampletiptype
			};
		}

		// Token: 0x06029FF2 RID: 172018 RVA: 0x005BB7CC File Offset: 0x005B99CC
		public ICountDownTextTipT AsICountDownTextTip()
		{
			return this.As<ICountDownTextTipT>();
		}

		// Token: 0x06029FF3 RID: 172019 RVA: 0x005BB7D4 File Offset: 0x005B99D4
		public static ITrampleTipType_UnionUnion FromICountDownTextTip(ICountDownTextTipT _icountdowntexttip)
		{
			return new ITrampleTipType_UnionUnion
			{
				Type = ITrampleTipType_Union.ICountDownTextTip,
				Value = _icountdowntexttip
			};
		}

		// Token: 0x06029FF4 RID: 172020 RVA: 0x005BB7E9 File Offset: 0x005B99E9
		public IMechaTrackCountDownTipT AsIMechaTrackCountDownTip()
		{
			return this.As<IMechaTrackCountDownTipT>();
		}

		// Token: 0x06029FF5 RID: 172021 RVA: 0x005BB7F1 File Offset: 0x005B99F1
		public static ITrampleTipType_UnionUnion FromIMechaTrackCountDownTip(IMechaTrackCountDownTipT _imechatrackcountdowntip)
		{
			return new ITrampleTipType_UnionUnion
			{
				Type = ITrampleTipType_Union.IMechaTrackCountDownTip,
				Value = _imechatrackcountdowntip
			};
		}

		// Token: 0x06029FF6 RID: 172022 RVA: 0x005BB808 File Offset: 0x005B9A08
		public static int Pack(FlatBufferBuilder builder, ITrampleTipType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrampleTipType_Union.ITrampleTipType:
				return ITrampleTipType.Pack(builder, _o.AsITrampleTipType()).Value;
			case ITrampleTipType_Union.ICountDownTextTip:
				return ICountDownTextTip.Pack(builder, _o.AsICountDownTextTip()).Value;
			case ITrampleTipType_Union.IMechaTrackCountDownTip:
				return IMechaTrackCountDownTip.Pack(builder, _o.AsIMechaTrackCountDownTip()).Value;
			default:
				return 0;
			}
		}
	}
}
