using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DCA RID: 15818
	public struct IDateTime : IFlatbufferObject
	{
		// Token: 0x17006D2E RID: 27950
		// (get) Token: 0x0601612D RID: 90413 RVA: 0x00330FF5 File Offset: 0x0032F1F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601612E RID: 90414 RVA: 0x00331002 File Offset: 0x0032F202
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601612F RID: 90415 RVA: 0x0033100C File Offset: 0x0032F20C
		public static IDateTime GetRootAsIDateTime(ByteBuffer _bb)
		{
			return IDateTime.GetRootAsIDateTime(_bb, default(IDateTime));
		}

		// Token: 0x06016130 RID: 90416 RVA: 0x00331028 File Offset: 0x0032F228
		public static IDateTime GetRootAsIDateTime(ByteBuffer _bb, IDateTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016131 RID: 90417 RVA: 0x00331045 File Offset: 0x0032F245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016132 RID: 90418 RVA: 0x00331054 File Offset: 0x0032F254
		public IDateTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D2F RID: 27951
		// (get) Token: 0x06016133 RID: 90419 RVA: 0x00331064 File Offset: 0x0032F264
		public int Hours
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D30 RID: 27952
		// (get) Token: 0x06016134 RID: 90420 RVA: 0x003310A0 File Offset: 0x0032F2A0
		public int Minutes
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

		// Token: 0x17006D31 RID: 27953
		// (get) Token: 0x06016135 RID: 90421 RVA: 0x003310DC File Offset: 0x0032F2DC
		public int Days
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D32 RID: 27954
		// (get) Token: 0x06016136 RID: 90422 RVA: 0x00331118 File Offset: 0x0032F318
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016137 RID: 90423 RVA: 0x00331155 File Offset: 0x0032F355
		public static Offset<IDateTime> CreateIDateTime(FlatBufferBuilder builder, int Hours = 0, int Minutes = 0, int Days = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDateTime.AddDays(builder, Days);
			IDateTime.AddMinutes(builder, Minutes);
			IDateTime.AddHours(builder, Hours);
			IDateTime.AddNullMask(builder, NullMask);
			return IDateTime.EndIDateTime(builder);
		}

		// Token: 0x06016138 RID: 90424 RVA: 0x00331181 File Offset: 0x0032F381
		public static void StartIDateTime(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016139 RID: 90425 RVA: 0x0033118A File Offset: 0x0032F38A
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(0, hours, 0);
		}

		// Token: 0x0601613A RID: 90426 RVA: 0x00331195 File Offset: 0x0032F395
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(1, minutes, 0);
		}

		// Token: 0x0601613B RID: 90427 RVA: 0x003311A0 File Offset: 0x0032F3A0
		public static void AddDays(FlatBufferBuilder builder, int days)
		{
			builder.AddInt(2, days, 0);
		}

		// Token: 0x0601613C RID: 90428 RVA: 0x003311AB File Offset: 0x0032F3AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601613D RID: 90429 RVA: 0x003311B6 File Offset: 0x0032F3B6
		public static Offset<IDateTime> EndIDateTime(FlatBufferBuilder builder)
		{
			return new Offset<IDateTime>(builder.EndTable());
		}

		// Token: 0x0601613E RID: 90430 RVA: 0x003311C4 File Offset: 0x0032F3C4
		public IDateTimeT UnPack()
		{
			IDateTimeT dateTimeT = new IDateTimeT();
			this.UnPackTo(dateTimeT);
			return dateTimeT;
		}

		// Token: 0x0601613F RID: 90431 RVA: 0x003311DF File Offset: 0x0032F3DF
		public void UnPackTo(IDateTimeT _o)
		{
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Days = this.Days;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016140 RID: 90432 RVA: 0x00331214 File Offset: 0x0032F414
		public static Offset<IDateTime> Pack(FlatBufferBuilder builder, IDateTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDateTime>);
			}
			return IDateTime.CreateIDateTime(builder, _o.Hours, _o.Minutes, _o.Days, _o.NullMask);
		}

		// Token: 0x0400B70A RID: 46858
		private Table __p;
	}
}
