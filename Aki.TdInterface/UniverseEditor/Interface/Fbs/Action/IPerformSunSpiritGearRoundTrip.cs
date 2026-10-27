using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C93 RID: 27795
	public struct IPerformSunSpiritGearRoundTrip : IFlatbufferObject
	{
		// Token: 0x1700CEF9 RID: 52985
		// (get) Token: 0x06030FAB RID: 200619 RVA: 0x006A64AC File Offset: 0x006A46AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FAC RID: 200620 RVA: 0x006A64B9 File Offset: 0x006A46B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FAD RID: 200621 RVA: 0x006A64C0 File Offset: 0x006A46C0
		public static IPerformSunSpiritGearRoundTrip GetRootAsIPerformSunSpiritGearRoundTrip(ByteBuffer _bb)
		{
			return IPerformSunSpiritGearRoundTrip.GetRootAsIPerformSunSpiritGearRoundTrip(_bb, default(IPerformSunSpiritGearRoundTrip));
		}

		// Token: 0x06030FAE RID: 200622 RVA: 0x006A64DC File Offset: 0x006A46DC
		public static IPerformSunSpiritGearRoundTrip GetRootAsIPerformSunSpiritGearRoundTrip(ByteBuffer _bb, IPerformSunSpiritGearRoundTrip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FAF RID: 200623 RVA: 0x006A64F9 File Offset: 0x006A46F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FB0 RID: 200624 RVA: 0x006A6508 File Offset: 0x006A4708
		public IPerformSunSpiritGearRoundTrip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEFA RID: 52986
		// (get) Token: 0x06030FB1 RID: 200625 RVA: 0x006A6518 File Offset: 0x006A4718
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

		// Token: 0x1700CEFB RID: 52987
		// (get) Token: 0x06030FB2 RID: 200626 RVA: 0x006A6554 File Offset: 0x006A4754
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

		// Token: 0x06030FB3 RID: 200627 RVA: 0x006A6590 File Offset: 0x006A4790
		public static Offset<IPerformSunSpiritGearRoundTrip> CreateIPerformSunSpiritGearRoundTrip(FlatBufferBuilder builder, ESunSpiritGearRoundTripType PerformType = ESunSpiritGearRoundTripType.FlyToGear, int SunSpiritGearId = 0)
		{
			builder.StartTable(2);
			IPerformSunSpiritGearRoundTrip.AddSunSpiritGearId(builder, SunSpiritGearId);
			IPerformSunSpiritGearRoundTrip.AddPerformType(builder, PerformType);
			return IPerformSunSpiritGearRoundTrip.EndIPerformSunSpiritGearRoundTrip(builder);
		}

		// Token: 0x06030FB4 RID: 200628 RVA: 0x006A65AD File Offset: 0x006A47AD
		public static void StartIPerformSunSpiritGearRoundTrip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030FB5 RID: 200629 RVA: 0x006A65B6 File Offset: 0x006A47B6
		public static void AddPerformType(FlatBufferBuilder builder, ESunSpiritGearRoundTripType performType)
		{
			builder.AddByte(0, (byte)performType, 0);
		}

		// Token: 0x06030FB6 RID: 200630 RVA: 0x006A65C1 File Offset: 0x006A47C1
		public static void AddSunSpiritGearId(FlatBufferBuilder builder, int sunSpiritGearId)
		{
			builder.AddInt(1, sunSpiritGearId, 0);
		}

		// Token: 0x06030FB7 RID: 200631 RVA: 0x006A65CC File Offset: 0x006A47CC
		public static Offset<IPerformSunSpiritGearRoundTrip> EndIPerformSunSpiritGearRoundTrip(FlatBufferBuilder builder)
		{
			return new Offset<IPerformSunSpiritGearRoundTrip>(builder.EndTable());
		}

		// Token: 0x06030FB8 RID: 200632 RVA: 0x006A65DC File Offset: 0x006A47DC
		public IPerformSunSpiritGearRoundTripT UnPack()
		{
			IPerformSunSpiritGearRoundTripT performSunSpiritGearRoundTripT = new IPerformSunSpiritGearRoundTripT();
			this.UnPackTo(performSunSpiritGearRoundTripT);
			return performSunSpiritGearRoundTripT;
		}

		// Token: 0x06030FB9 RID: 200633 RVA: 0x006A65F7 File Offset: 0x006A47F7
		public void UnPackTo(IPerformSunSpiritGearRoundTripT _o)
		{
			_o.PerformType = this.PerformType;
			_o.SunSpiritGearId = this.SunSpiritGearId;
		}

		// Token: 0x06030FBA RID: 200634 RVA: 0x006A6614 File Offset: 0x006A4814
		public static Offset<IPerformSunSpiritGearRoundTrip> Pack(FlatBufferBuilder builder, IPerformSunSpiritGearRoundTripT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformSunSpiritGearRoundTrip>);
			}
			return IPerformSunSpiritGearRoundTrip.CreateIPerformSunSpiritGearRoundTrip(builder, _o.PerformType, _o.SunSpiritGearId);
		}

		// Token: 0x040115E7 RID: 71143
		private Table __p;
	}
}
