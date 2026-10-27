using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E76 RID: 28278
	public struct IReportTrackingEvent : IFlatbufferObject
	{
		// Token: 0x1700D2A3 RID: 53923
		// (get) Token: 0x06031FAB RID: 204715 RVA: 0x006C2D58 File Offset: 0x006C0F58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FAC RID: 204716 RVA: 0x006C2D65 File Offset: 0x006C0F65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FAD RID: 204717 RVA: 0x006C2D6C File Offset: 0x006C0F6C
		public static IReportTrackingEvent GetRootAsIReportTrackingEvent(ByteBuffer _bb)
		{
			return IReportTrackingEvent.GetRootAsIReportTrackingEvent(_bb, default(IReportTrackingEvent));
		}

		// Token: 0x06031FAE RID: 204718 RVA: 0x006C2D88 File Offset: 0x006C0F88
		public static IReportTrackingEvent GetRootAsIReportTrackingEvent(ByteBuffer _bb, IReportTrackingEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FAF RID: 204719 RVA: 0x006C2DA5 File Offset: 0x006C0FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FB0 RID: 204720 RVA: 0x006C2DB4 File Offset: 0x006C0FB4
		public IReportTrackingEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2A4 RID: 53924
		// (get) Token: 0x06031FB1 RID: 204721 RVA: 0x006C2DC4 File Offset: 0x006C0FC4
		public TTrackingEventType TrackingEventTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTrackingEventType.NONE;
				}
				return (TTrackingEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031FB2 RID: 204722 RVA: 0x006C2E00 File Offset: 0x006C1000
		public TTable? TrackingEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031FB3 RID: 204723 RVA: 0x006C2E44 File Offset: 0x006C1044
		public IEasterEggTrackingEvent TrackingEventTypeAsIEasterEggTrackingEvent()
		{
			return this.TrackingEventType<IEasterEggTrackingEvent>().Value;
		}

		// Token: 0x06031FB4 RID: 204724 RVA: 0x006C2E60 File Offset: 0x006C1060
		public IMotorParkourTrackingEvent TrackingEventTypeAsIMotorParkourTrackingEvent()
		{
			return this.TrackingEventType<IMotorParkourTrackingEvent>().Value;
		}

		// Token: 0x06031FB5 RID: 204725 RVA: 0x006C2E7B File Offset: 0x006C107B
		public static Offset<IReportTrackingEvent> CreateIReportTrackingEvent(FlatBufferBuilder builder, TTrackingEventType TrackingEventType_type = TTrackingEventType.NONE, int TrackingEventTypeOffset = 0)
		{
			builder.StartTable(2);
			IReportTrackingEvent.AddTrackingEventType(builder, TrackingEventTypeOffset);
			IReportTrackingEvent.AddTrackingEventTypeType(builder, TrackingEventType_type);
			return IReportTrackingEvent.EndIReportTrackingEvent(builder);
		}

		// Token: 0x06031FB6 RID: 204726 RVA: 0x006C2E98 File Offset: 0x006C1098
		public static void StartIReportTrackingEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031FB7 RID: 204727 RVA: 0x006C2EA1 File Offset: 0x006C10A1
		public static void AddTrackingEventTypeType(FlatBufferBuilder builder, TTrackingEventType trackingEventTypeType)
		{
			builder.AddByte(0, (byte)trackingEventTypeType, 0);
		}

		// Token: 0x06031FB8 RID: 204728 RVA: 0x006C2EAC File Offset: 0x006C10AC
		public static void AddTrackingEventType(FlatBufferBuilder builder, int trackingEventTypeOffset)
		{
			builder.AddOffset(1, trackingEventTypeOffset, 0);
		}

		// Token: 0x06031FB9 RID: 204729 RVA: 0x006C2EB7 File Offset: 0x006C10B7
		public static Offset<IReportTrackingEvent> EndIReportTrackingEvent(FlatBufferBuilder builder)
		{
			return new Offset<IReportTrackingEvent>(builder.EndTable());
		}

		// Token: 0x06031FBA RID: 204730 RVA: 0x006C2EC4 File Offset: 0x006C10C4
		public IReportTrackingEventT UnPack()
		{
			IReportTrackingEventT reportTrackingEventT = new IReportTrackingEventT();
			this.UnPackTo(reportTrackingEventT);
			return reportTrackingEventT;
		}

		// Token: 0x06031FBB RID: 204731 RVA: 0x006C2EE0 File Offset: 0x006C10E0
		public void UnPackTo(IReportTrackingEventT _o)
		{
			_o.TrackingEventType = new TTrackingEventTypeUnion();
			_o.TrackingEventType.Type = this.TrackingEventTypeType;
			TTrackingEventType trackingEventTypeType = this.TrackingEventTypeType;
			if (trackingEventTypeType == TTrackingEventType.IEasterEggTrackingEvent)
			{
				_o.TrackingEventType.Value = ((this.TrackingEventType<IEasterEggTrackingEvent>() != null) ? this.TrackingEventType<IEasterEggTrackingEvent>().Value.UnPack() : null);
				return;
			}
			if (trackingEventTypeType != TTrackingEventType.IMotorParkourTrackingEvent)
			{
				return;
			}
			_o.TrackingEventType.Value = ((this.TrackingEventType<IMotorParkourTrackingEvent>() != null) ? this.TrackingEventType<IMotorParkourTrackingEvent>().Value.UnPack() : null);
		}

		// Token: 0x06031FBC RID: 204732 RVA: 0x006C2F84 File Offset: 0x006C1184
		public static Offset<IReportTrackingEvent> Pack(FlatBufferBuilder builder, IReportTrackingEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReportTrackingEvent>);
			}
			TTrackingEventType trackingEventType_type = (_o.TrackingEventType == null) ? TTrackingEventType.NONE : _o.TrackingEventType.Type;
			int trackingEventTypeOffset = (_o.TrackingEventType == null) ? 0 : TTrackingEventTypeUnion.Pack(builder, _o.TrackingEventType);
			return IReportTrackingEvent.CreateIReportTrackingEvent(builder, trackingEventType_type, trackingEventTypeOffset);
		}

		// Token: 0x04011864 RID: 71780
		private Table __p;
	}
}
