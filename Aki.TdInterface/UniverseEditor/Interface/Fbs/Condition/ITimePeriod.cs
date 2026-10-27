using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CF7 RID: 19703
	public struct ITimePeriod : IFlatbufferObject
	{
		// Token: 0x17008EF5 RID: 36597
		// (get) Token: 0x0601F454 RID: 128084 RVA: 0x0045CEE4 File Offset: 0x0045B0E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F455 RID: 128085 RVA: 0x0045CEF1 File Offset: 0x0045B0F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F456 RID: 128086 RVA: 0x0045CEF8 File Offset: 0x0045B0F8
		public static ITimePeriod GetRootAsITimePeriod(ByteBuffer _bb)
		{
			return ITimePeriod.GetRootAsITimePeriod(_bb, default(ITimePeriod));
		}

		// Token: 0x0601F457 RID: 128087 RVA: 0x0045CF14 File Offset: 0x0045B114
		public static ITimePeriod GetRootAsITimePeriod(ByteBuffer _bb, ITimePeriod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F458 RID: 128088 RVA: 0x0045CF31 File Offset: 0x0045B131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F459 RID: 128089 RVA: 0x0045CF40 File Offset: 0x0045B140
		public ITimePeriod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EF6 RID: 36598
		// (get) Token: 0x0601F45A RID: 128090 RVA: 0x0045CF50 File Offset: 0x0045B150
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EF7 RID: 36599
		// (get) Token: 0x0601F45B RID: 128091 RVA: 0x0045CF8C File Offset: 0x0045B18C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EF8 RID: 36600
		// (get) Token: 0x0601F45C RID: 128092 RVA: 0x0045CFC8 File Offset: 0x0045B1C8
		public ETimePeriod TimePeriod
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETimePeriod.DayTime;
				}
				return (ETimePeriod)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F45D RID: 128093 RVA: 0x0045D004 File Offset: 0x0045B204
		public static Offset<ITimePeriod> CreateITimePeriod(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, ETimePeriod TimePeriod = ETimePeriod.DayTime)
		{
			builder.StartTable(3);
			ITimePeriod.AddTimePeriod(builder, TimePeriod);
			ITimePeriod.AddCompare(builder, Compare);
			ITimePeriod.AddType(builder, Type);
			return ITimePeriod.EndITimePeriod(builder);
		}

		// Token: 0x0601F45E RID: 128094 RVA: 0x0045D028 File Offset: 0x0045B228
		public static void StartITimePeriod(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F45F RID: 128095 RVA: 0x0045D031 File Offset: 0x0045B231
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F460 RID: 128096 RVA: 0x0045D03C File Offset: 0x0045B23C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F461 RID: 128097 RVA: 0x0045D047 File Offset: 0x0045B247
		public static void AddTimePeriod(FlatBufferBuilder builder, ETimePeriod timePeriod)
		{
			builder.AddByte(2, (byte)timePeriod, 0);
		}

		// Token: 0x0601F462 RID: 128098 RVA: 0x0045D052 File Offset: 0x0045B252
		public static Offset<ITimePeriod> EndITimePeriod(FlatBufferBuilder builder)
		{
			return new Offset<ITimePeriod>(builder.EndTable());
		}

		// Token: 0x0601F463 RID: 128099 RVA: 0x0045D060 File Offset: 0x0045B260
		public ITimePeriodT UnPack()
		{
			ITimePeriodT timePeriodT = new ITimePeriodT();
			this.UnPackTo(timePeriodT);
			return timePeriodT;
		}

		// Token: 0x0601F464 RID: 128100 RVA: 0x0045D07B File Offset: 0x0045B27B
		public void UnPackTo(ITimePeriodT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.TimePeriod = this.TimePeriod;
		}

		// Token: 0x0601F465 RID: 128101 RVA: 0x0045D0A4 File Offset: 0x0045B2A4
		public static Offset<ITimePeriod> Pack(FlatBufferBuilder builder, ITimePeriodT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePeriod>);
			}
			return ITimePeriod.CreateITimePeriod(builder, _o.Type, _o.Compare, _o.TimePeriod);
		}

		// Token: 0x0400D6D2 RID: 54994
		private Table __p;
	}
}
