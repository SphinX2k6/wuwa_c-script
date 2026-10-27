using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200526A RID: 21098
	public struct IFixedDateTime : IFlatbufferObject
	{
		// Token: 0x17009A86 RID: 39558
		// (get) Token: 0x0602252F RID: 140591 RVA: 0x004C21C7 File Offset: 0x004C03C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022530 RID: 140592 RVA: 0x004C21D4 File Offset: 0x004C03D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022531 RID: 140593 RVA: 0x004C21DC File Offset: 0x004C03DC
		public static IFixedDateTime GetRootAsIFixedDateTime(ByteBuffer _bb)
		{
			return IFixedDateTime.GetRootAsIFixedDateTime(_bb, default(IFixedDateTime));
		}

		// Token: 0x06022532 RID: 140594 RVA: 0x004C21F8 File Offset: 0x004C03F8
		public static IFixedDateTime GetRootAsIFixedDateTime(ByteBuffer _bb, IFixedDateTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022533 RID: 140595 RVA: 0x004C2215 File Offset: 0x004C0415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022534 RID: 140596 RVA: 0x004C2224 File Offset: 0x004C0424
		public IFixedDateTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A87 RID: 39559
		// (get) Token: 0x06022535 RID: 140597 RVA: 0x004C2234 File Offset: 0x004C0434
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

		// Token: 0x17009A88 RID: 39560
		// (get) Token: 0x06022536 RID: 140598 RVA: 0x004C2270 File Offset: 0x004C0470
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

		// Token: 0x17009A89 RID: 39561
		// (get) Token: 0x06022537 RID: 140599 RVA: 0x004C22AC File Offset: 0x004C04AC
		public int Seconds
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

		// Token: 0x06022538 RID: 140600 RVA: 0x004C22E8 File Offset: 0x004C04E8
		public static Offset<IFixedDateTime> CreateIFixedDateTime(FlatBufferBuilder builder, int Hours = 0, int Minutes = 0, int Seconds = 0)
		{
			builder.StartTable(3);
			IFixedDateTime.AddSeconds(builder, Seconds);
			IFixedDateTime.AddMinutes(builder, Minutes);
			IFixedDateTime.AddHours(builder, Hours);
			return IFixedDateTime.EndIFixedDateTime(builder);
		}

		// Token: 0x06022539 RID: 140601 RVA: 0x004C230C File Offset: 0x004C050C
		public static void StartIFixedDateTime(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602253A RID: 140602 RVA: 0x004C2315 File Offset: 0x004C0515
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(0, hours, 0);
		}

		// Token: 0x0602253B RID: 140603 RVA: 0x004C2320 File Offset: 0x004C0520
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(1, minutes, 0);
		}

		// Token: 0x0602253C RID: 140604 RVA: 0x004C232B File Offset: 0x004C052B
		public static void AddSeconds(FlatBufferBuilder builder, int seconds)
		{
			builder.AddInt(2, seconds, 0);
		}

		// Token: 0x0602253D RID: 140605 RVA: 0x004C2336 File Offset: 0x004C0536
		public static Offset<IFixedDateTime> EndIFixedDateTime(FlatBufferBuilder builder)
		{
			return new Offset<IFixedDateTime>(builder.EndTable());
		}

		// Token: 0x0602253E RID: 140606 RVA: 0x004C2344 File Offset: 0x004C0544
		public IFixedDateTimeT UnPack()
		{
			IFixedDateTimeT fixedDateTimeT = new IFixedDateTimeT();
			this.UnPackTo(fixedDateTimeT);
			return fixedDateTimeT;
		}

		// Token: 0x0602253F RID: 140607 RVA: 0x004C235F File Offset: 0x004C055F
		public void UnPackTo(IFixedDateTimeT _o)
		{
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Seconds = this.Seconds;
		}

		// Token: 0x06022540 RID: 140608 RVA: 0x004C2388 File Offset: 0x004C0588
		public static Offset<IFixedDateTime> Pack(FlatBufferBuilder builder, IFixedDateTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedDateTime>);
			}
			return IFixedDateTime.CreateIFixedDateTime(builder, _o.Hours, _o.Minutes, _o.Seconds);
		}

		// Token: 0x0400E3BC RID: 58300
		private Table __p;
	}
}
