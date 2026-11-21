using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F3 RID: 20979
	public struct ITimePeriod : IFlatbufferObject
	{
		// Token: 0x1700962E RID: 38446
		// (get) Token: 0x06021099 RID: 135321 RVA: 0x00490E34 File Offset: 0x0048F034
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602109A RID: 135322 RVA: 0x00490E41 File Offset: 0x0048F041
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602109B RID: 135323 RVA: 0x00490E48 File Offset: 0x0048F048
		public static ITimePeriod GetRootAsITimePeriod(ByteBuffer _bb)
		{
			return ITimePeriod.GetRootAsITimePeriod(_bb, default(ITimePeriod));
		}

		// Token: 0x0602109C RID: 135324 RVA: 0x00490E64 File Offset: 0x0048F064
		public static ITimePeriod GetRootAsITimePeriod(ByteBuffer _bb, ITimePeriod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602109D RID: 135325 RVA: 0x00490E81 File Offset: 0x0048F081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602109E RID: 135326 RVA: 0x00490E90 File Offset: 0x0048F090
		public ITimePeriod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700962F RID: 38447
		// (get) Token: 0x0602109F RID: 135327 RVA: 0x00490EA0 File Offset: 0x0048F0A0
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

		// Token: 0x17009630 RID: 38448
		// (get) Token: 0x060210A0 RID: 135328 RVA: 0x00490EDC File Offset: 0x0048F0DC
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

		// Token: 0x17009631 RID: 38449
		// (get) Token: 0x060210A1 RID: 135329 RVA: 0x00490F18 File Offset: 0x0048F118
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

		// Token: 0x060210A2 RID: 135330 RVA: 0x00490F54 File Offset: 0x0048F154
		public static Offset<ITimePeriod> CreateITimePeriod(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, ETimePeriod TimePeriod = ETimePeriod.DayTime)
		{
			builder.StartTable(3);
			ITimePeriod.AddTimePeriod(builder, TimePeriod);
			ITimePeriod.AddCompare(builder, Compare);
			ITimePeriod.AddType(builder, Type);
			return ITimePeriod.EndITimePeriod(builder);
		}

		// Token: 0x060210A3 RID: 135331 RVA: 0x00490F78 File Offset: 0x0048F178
		public static void StartITimePeriod(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060210A4 RID: 135332 RVA: 0x00490F81 File Offset: 0x0048F181
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060210A5 RID: 135333 RVA: 0x00490F8C File Offset: 0x0048F18C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060210A6 RID: 135334 RVA: 0x00490F97 File Offset: 0x0048F197
		public static void AddTimePeriod(FlatBufferBuilder builder, ETimePeriod timePeriod)
		{
			builder.AddByte(2, (byte)timePeriod, 0);
		}

		// Token: 0x060210A7 RID: 135335 RVA: 0x00490FA2 File Offset: 0x0048F1A2
		public static Offset<ITimePeriod> EndITimePeriod(FlatBufferBuilder builder)
		{
			return new Offset<ITimePeriod>(builder.EndTable());
		}

		// Token: 0x060210A8 RID: 135336 RVA: 0x00490FB0 File Offset: 0x0048F1B0
		public ITimePeriodT UnPack()
		{
			ITimePeriodT timePeriodT = new ITimePeriodT();
			this.UnPackTo(timePeriodT);
			return timePeriodT;
		}

		// Token: 0x060210A9 RID: 135337 RVA: 0x00490FCB File Offset: 0x0048F1CB
		public void UnPackTo(ITimePeriodT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.TimePeriod = this.TimePeriod;
		}

		// Token: 0x060210AA RID: 135338 RVA: 0x00490FF4 File Offset: 0x0048F1F4
		public static Offset<ITimePeriod> Pack(FlatBufferBuilder builder, ITimePeriodT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePeriod>);
			}
			return ITimePeriod.CreateITimePeriod(builder, _o.Type, _o.Compare, _o.TimePeriod);
		}

		// Token: 0x0400E1FF RID: 57855
		private Table __p;
	}
}
