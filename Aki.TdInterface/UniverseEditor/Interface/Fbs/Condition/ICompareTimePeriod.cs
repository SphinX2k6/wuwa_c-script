using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B5 RID: 20661
	public struct ICompareTimePeriod : IFlatbufferObject
	{
		// Token: 0x17009409 RID: 37897
		// (get) Token: 0x060205A5 RID: 132517 RVA: 0x0047AFE4 File Offset: 0x004791E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060205A6 RID: 132518 RVA: 0x0047AFF1 File Offset: 0x004791F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060205A7 RID: 132519 RVA: 0x0047AFF8 File Offset: 0x004791F8
		public static ICompareTimePeriod GetRootAsICompareTimePeriod(ByteBuffer _bb)
		{
			return ICompareTimePeriod.GetRootAsICompareTimePeriod(_bb, default(ICompareTimePeriod));
		}

		// Token: 0x060205A8 RID: 132520 RVA: 0x0047B014 File Offset: 0x00479214
		public static ICompareTimePeriod GetRootAsICompareTimePeriod(ByteBuffer _bb, ICompareTimePeriod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060205A9 RID: 132521 RVA: 0x0047B031 File Offset: 0x00479231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060205AA RID: 132522 RVA: 0x0047B040 File Offset: 0x00479240
		public ICompareTimePeriod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700940A RID: 37898
		// (get) Token: 0x060205AB RID: 132523 RVA: 0x0047B050 File Offset: 0x00479250
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700940B RID: 37899
		// (get) Token: 0x060205AC RID: 132524 RVA: 0x0047B08C File Offset: 0x0047928C
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

		// Token: 0x1700940C RID: 37900
		// (get) Token: 0x060205AD RID: 132525 RVA: 0x0047B0C8 File Offset: 0x004792C8
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

		// Token: 0x060205AE RID: 132526 RVA: 0x0047B104 File Offset: 0x00479304
		public static Offset<ICompareTimePeriod> CreateICompareTimePeriod(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, ETimePeriod TimePeriod = ETimePeriod.DayTime)
		{
			builder.StartTable(3);
			ICompareTimePeriod.AddTimePeriod(builder, TimePeriod);
			ICompareTimePeriod.AddCompare(builder, Compare);
			ICompareTimePeriod.AddType(builder, Type);
			return ICompareTimePeriod.EndICompareTimePeriod(builder);
		}

		// Token: 0x060205AF RID: 132527 RVA: 0x0047B128 File Offset: 0x00479328
		public static void StartICompareTimePeriod(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060205B0 RID: 132528 RVA: 0x0047B131 File Offset: 0x00479331
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060205B1 RID: 132529 RVA: 0x0047B13C File Offset: 0x0047933C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060205B2 RID: 132530 RVA: 0x0047B147 File Offset: 0x00479347
		public static void AddTimePeriod(FlatBufferBuilder builder, ETimePeriod timePeriod)
		{
			builder.AddByte(2, (byte)timePeriod, 0);
		}

		// Token: 0x060205B3 RID: 132531 RVA: 0x0047B152 File Offset: 0x00479352
		public static Offset<ICompareTimePeriod> EndICompareTimePeriod(FlatBufferBuilder builder)
		{
			return new Offset<ICompareTimePeriod>(builder.EndTable());
		}

		// Token: 0x060205B4 RID: 132532 RVA: 0x0047B160 File Offset: 0x00479360
		public ICompareTimePeriodT UnPack()
		{
			ICompareTimePeriodT compareTimePeriodT = new ICompareTimePeriodT();
			this.UnPackTo(compareTimePeriodT);
			return compareTimePeriodT;
		}

		// Token: 0x060205B5 RID: 132533 RVA: 0x0047B17B File Offset: 0x0047937B
		public void UnPackTo(ICompareTimePeriodT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.TimePeriod = this.TimePeriod;
		}

		// Token: 0x060205B6 RID: 132534 RVA: 0x0047B1A4 File Offset: 0x004793A4
		public static Offset<ICompareTimePeriod> Pack(FlatBufferBuilder builder, ICompareTimePeriodT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareTimePeriod>);
			}
			return ICompareTimePeriod.CreateICompareTimePeriod(builder, _o.Type, _o.Compare, _o.TimePeriod);
		}

		// Token: 0x0400DFBF RID: 57279
		private Table __p;
	}
}
