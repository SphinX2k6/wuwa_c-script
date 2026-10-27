using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAE RID: 23214
	public struct ITimeScheduleRandomSchedulePositionDistribution : IFlatbufferObject
	{
		// Token: 0x1700AED8 RID: 44760
		// (get) Token: 0x060278D6 RID: 162006 RVA: 0x00570E06 File Offset: 0x0056F006
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278D7 RID: 162007 RVA: 0x00570E13 File Offset: 0x0056F013
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278D8 RID: 162008 RVA: 0x00570E1C File Offset: 0x0056F01C
		public static ITimeScheduleRandomSchedulePositionDistribution GetRootAsITimeScheduleRandomSchedulePositionDistribution(ByteBuffer _bb)
		{
			return ITimeScheduleRandomSchedulePositionDistribution.GetRootAsITimeScheduleRandomSchedulePositionDistribution(_bb, default(ITimeScheduleRandomSchedulePositionDistribution));
		}

		// Token: 0x060278D9 RID: 162009 RVA: 0x00570E38 File Offset: 0x0056F038
		public static ITimeScheduleRandomSchedulePositionDistribution GetRootAsITimeScheduleRandomSchedulePositionDistribution(ByteBuffer _bb, ITimeScheduleRandomSchedulePositionDistribution obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278DA RID: 162010 RVA: 0x00570E55 File Offset: 0x0056F055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278DB RID: 162011 RVA: 0x00570E64 File Offset: 0x0056F064
		public ITimeScheduleRandomSchedulePositionDistribution __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AED9 RID: 44761
		// (get) Token: 0x060278DC RID: 162012 RVA: 0x00570E74 File Offset: 0x0056F074
		public ETimeScheduleDistributionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleDistributionType.RandomSchedulePosition;
				}
				return (ETimeScheduleDistributionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060278DD RID: 162013 RVA: 0x00570EB0 File Offset: 0x0056F0B0
		public static Offset<ITimeScheduleRandomSchedulePositionDistribution> CreateITimeScheduleRandomSchedulePositionDistribution(FlatBufferBuilder builder, ETimeScheduleDistributionType Type = ETimeScheduleDistributionType.RandomSchedulePosition)
		{
			builder.StartTable(1);
			ITimeScheduleRandomSchedulePositionDistribution.AddType(builder, Type);
			return ITimeScheduleRandomSchedulePositionDistribution.EndITimeScheduleRandomSchedulePositionDistribution(builder);
		}

		// Token: 0x060278DE RID: 162014 RVA: 0x00570EC6 File Offset: 0x0056F0C6
		public static void StartITimeScheduleRandomSchedulePositionDistribution(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060278DF RID: 162015 RVA: 0x00570ECF File Offset: 0x0056F0CF
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleDistributionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060278E0 RID: 162016 RVA: 0x00570EDA File Offset: 0x0056F0DA
		public static Offset<ITimeScheduleRandomSchedulePositionDistribution> EndITimeScheduleRandomSchedulePositionDistribution(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleRandomSchedulePositionDistribution>(builder.EndTable());
		}

		// Token: 0x060278E1 RID: 162017 RVA: 0x00570EE8 File Offset: 0x0056F0E8
		public ITimeScheduleRandomSchedulePositionDistributionT UnPack()
		{
			ITimeScheduleRandomSchedulePositionDistributionT timeScheduleRandomSchedulePositionDistributionT = new ITimeScheduleRandomSchedulePositionDistributionT();
			this.UnPackTo(timeScheduleRandomSchedulePositionDistributionT);
			return timeScheduleRandomSchedulePositionDistributionT;
		}

		// Token: 0x060278E2 RID: 162018 RVA: 0x00570F03 File Offset: 0x0056F103
		public void UnPackTo(ITimeScheduleRandomSchedulePositionDistributionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060278E3 RID: 162019 RVA: 0x00570F14 File Offset: 0x0056F114
		public static Offset<ITimeScheduleRandomSchedulePositionDistribution> Pack(FlatBufferBuilder builder, ITimeScheduleRandomSchedulePositionDistributionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleRandomSchedulePositionDistribution>);
			}
			return ITimeScheduleRandomSchedulePositionDistribution.CreateITimeScheduleRandomSchedulePositionDistribution(builder, _o.Type);
		}

		// Token: 0x0400F173 RID: 61811
		private Table __p;
	}
}
