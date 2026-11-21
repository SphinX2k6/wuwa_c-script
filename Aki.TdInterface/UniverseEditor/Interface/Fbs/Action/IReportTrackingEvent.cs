using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FA RID: 30202
	public struct IReportTrackingEvent : IFlatbufferObject
	{
		// Token: 0x1700DDFA RID: 56826
		// (get) Token: 0x06034FEB RID: 217067 RVA: 0x0071EA8C File Offset: 0x0071CC8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034FEC RID: 217068 RVA: 0x0071EA99 File Offset: 0x0071CC99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034FED RID: 217069 RVA: 0x0071EAA0 File Offset: 0x0071CCA0
		public static IReportTrackingEvent GetRootAsIReportTrackingEvent(ByteBuffer _bb)
		{
			return IReportTrackingEvent.GetRootAsIReportTrackingEvent(_bb, default(IReportTrackingEvent));
		}

		// Token: 0x06034FEE RID: 217070 RVA: 0x0071EABC File Offset: 0x0071CCBC
		public static IReportTrackingEvent GetRootAsIReportTrackingEvent(ByteBuffer _bb, IReportTrackingEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034FEF RID: 217071 RVA: 0x0071EAD9 File Offset: 0x0071CCD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034FF0 RID: 217072 RVA: 0x0071EAE8 File Offset: 0x0071CCE8
		public IReportTrackingEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDFB RID: 56827
		// (get) Token: 0x06034FF1 RID: 217073 RVA: 0x0071EAF8 File Offset: 0x0071CCF8
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

		// Token: 0x06034FF2 RID: 217074 RVA: 0x0071EB34 File Offset: 0x0071CD34
		public TTable? TrackingEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034FF3 RID: 217075 RVA: 0x0071EB78 File Offset: 0x0071CD78
		public IEasterEggTrackingEvent TrackingEventTypeAsIEasterEggTrackingEvent()
		{
			return this.TrackingEventType<IEasterEggTrackingEvent>().Value;
		}

		// Token: 0x06034FF4 RID: 217076 RVA: 0x0071EB94 File Offset: 0x0071CD94
		public IMotorParkourTrackingEvent TrackingEventTypeAsIMotorParkourTrackingEvent()
		{
			return this.TrackingEventType<IMotorParkourTrackingEvent>().Value;
		}

		// Token: 0x06034FF5 RID: 217077 RVA: 0x0071EBAF File Offset: 0x0071CDAF
		public static Offset<IReportTrackingEvent> CreateIReportTrackingEvent(FlatBufferBuilder builder, TTrackingEventType TrackingEventType_type = TTrackingEventType.NONE, int TrackingEventTypeOffset = 0)
		{
			builder.StartTable(2);
			IReportTrackingEvent.AddTrackingEventType(builder, TrackingEventTypeOffset);
			IReportTrackingEvent.AddTrackingEventTypeType(builder, TrackingEventType_type);
			return IReportTrackingEvent.EndIReportTrackingEvent(builder);
		}

		// Token: 0x06034FF6 RID: 217078 RVA: 0x0071EBCC File Offset: 0x0071CDCC
		public static void StartIReportTrackingEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034FF7 RID: 217079 RVA: 0x0071EBD5 File Offset: 0x0071CDD5
		public static void AddTrackingEventTypeType(FlatBufferBuilder builder, TTrackingEventType trackingEventTypeType)
		{
			builder.AddByte(0, (byte)trackingEventTypeType, 0);
		}

		// Token: 0x06034FF8 RID: 217080 RVA: 0x0071EBE0 File Offset: 0x0071CDE0
		public static void AddTrackingEventType(FlatBufferBuilder builder, int trackingEventTypeOffset)
		{
			builder.AddOffset(1, trackingEventTypeOffset, 0);
		}

		// Token: 0x06034FF9 RID: 217081 RVA: 0x0071EBEB File Offset: 0x0071CDEB
		public static Offset<IReportTrackingEvent> EndIReportTrackingEvent(FlatBufferBuilder builder)
		{
			return new Offset<IReportTrackingEvent>(builder.EndTable());
		}

		// Token: 0x06034FFA RID: 217082 RVA: 0x0071EBF8 File Offset: 0x0071CDF8
		public IReportTrackingEventT UnPack()
		{
			IReportTrackingEventT reportTrackingEventT = new IReportTrackingEventT();
			this.UnPackTo(reportTrackingEventT);
			return reportTrackingEventT;
		}

		// Token: 0x06034FFB RID: 217083 RVA: 0x0071EC14 File Offset: 0x0071CE14
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

		// Token: 0x06034FFC RID: 217084 RVA: 0x0071ECB8 File Offset: 0x0071CEB8
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

		// Token: 0x040127E9 RID: 75753
		private Table __p;
	}
}
