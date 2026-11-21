using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FA RID: 29690
	public struct IPerformSunSpiritGearRoundTrip : IFlatbufferObject
	{
		// Token: 0x1700DA14 RID: 55828
		// (get) Token: 0x06033F06 RID: 212742 RVA: 0x007009AC File Offset: 0x006FEBAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F07 RID: 212743 RVA: 0x007009B9 File Offset: 0x006FEBB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F08 RID: 212744 RVA: 0x007009C0 File Offset: 0x006FEBC0
		public static IPerformSunSpiritGearRoundTrip GetRootAsIPerformSunSpiritGearRoundTrip(ByteBuffer _bb)
		{
			return IPerformSunSpiritGearRoundTrip.GetRootAsIPerformSunSpiritGearRoundTrip(_bb, default(IPerformSunSpiritGearRoundTrip));
		}

		// Token: 0x06033F09 RID: 212745 RVA: 0x007009DC File Offset: 0x006FEBDC
		public static IPerformSunSpiritGearRoundTrip GetRootAsIPerformSunSpiritGearRoundTrip(ByteBuffer _bb, IPerformSunSpiritGearRoundTrip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F0A RID: 212746 RVA: 0x007009F9 File Offset: 0x006FEBF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F0B RID: 212747 RVA: 0x00700A08 File Offset: 0x006FEC08
		public IPerformSunSpiritGearRoundTrip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA15 RID: 55829
		// (get) Token: 0x06033F0C RID: 212748 RVA: 0x00700A18 File Offset: 0x006FEC18
		public ESunSpiritGearRoundTripType PerformType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESunSpiritGearRoundTripType.FlyToGear;
				}
				return (ESunSpiritGearRoundTripType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA16 RID: 55830
		// (get) Token: 0x06033F0D RID: 212749 RVA: 0x00700A54 File Offset: 0x006FEC54
		public int SunSpiritGearId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F0E RID: 212750 RVA: 0x00700A90 File Offset: 0x006FEC90
		public static Offset<IPerformSunSpiritGearRoundTrip> CreateIPerformSunSpiritGearRoundTrip(FlatBufferBuilder builder, ESunSpiritGearRoundTripType PerformType = ESunSpiritGearRoundTripType.FlyToGear, int SunSpiritGearId = 0)
		{
			builder.StartTable(2);
			IPerformSunSpiritGearRoundTrip.AddSunSpiritGearId(builder, SunSpiritGearId);
			IPerformSunSpiritGearRoundTrip.AddPerformType(builder, PerformType);
			return IPerformSunSpiritGearRoundTrip.EndIPerformSunSpiritGearRoundTrip(builder);
		}

		// Token: 0x06033F0F RID: 212751 RVA: 0x00700AAD File Offset: 0x006FECAD
		public static void StartIPerformSunSpiritGearRoundTrip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033F10 RID: 212752 RVA: 0x00700AB6 File Offset: 0x006FECB6
		public static void AddPerformType(FlatBufferBuilder builder, ESunSpiritGearRoundTripType performType)
		{
			builder.AddByte(0, (byte)performType, 0);
		}

		// Token: 0x06033F11 RID: 212753 RVA: 0x00700AC1 File Offset: 0x006FECC1
		public static void AddSunSpiritGearId(FlatBufferBuilder builder, int sunSpiritGearId)
		{
			builder.AddInt(1, sunSpiritGearId, 0);
		}

		// Token: 0x06033F12 RID: 212754 RVA: 0x00700ACC File Offset: 0x006FECCC
		public static Offset<IPerformSunSpiritGearRoundTrip> EndIPerformSunSpiritGearRoundTrip(FlatBufferBuilder builder)
		{
			return new Offset<IPerformSunSpiritGearRoundTrip>(builder.EndTable());
		}

		// Token: 0x06033F13 RID: 212755 RVA: 0x00700ADC File Offset: 0x006FECDC
		public IPerformSunSpiritGearRoundTripT UnPack()
		{
			IPerformSunSpiritGearRoundTripT performSunSpiritGearRoundTripT = new IPerformSunSpiritGearRoundTripT();
			this.UnPackTo(performSunSpiritGearRoundTripT);
			return performSunSpiritGearRoundTripT;
		}

		// Token: 0x06033F14 RID: 212756 RVA: 0x00700AF7 File Offset: 0x006FECF7
		public void UnPackTo(IPerformSunSpiritGearRoundTripT _o)
		{
			_o.PerformType = this.PerformType;
			_o.SunSpiritGearId = this.SunSpiritGearId;
		}

		// Token: 0x06033F15 RID: 212757 RVA: 0x00700B14 File Offset: 0x006FED14
		public static Offset<IPerformSunSpiritGearRoundTrip> Pack(FlatBufferBuilder builder, IPerformSunSpiritGearRoundTripT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformSunSpiritGearRoundTrip>);
			}
			return IPerformSunSpiritGearRoundTrip.CreateIPerformSunSpiritGearRoundTrip(builder, _o.PerformType, _o.SunSpiritGearId);
		}

		// Token: 0x0401253F RID: 75071
		private Table __p;
	}
}
