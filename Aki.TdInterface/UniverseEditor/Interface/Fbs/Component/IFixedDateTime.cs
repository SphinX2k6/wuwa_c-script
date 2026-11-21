using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D2 RID: 22482
	public struct IFixedDateTime : IFlatbufferObject
	{
		// Token: 0x1700A282 RID: 41602
		// (get) Token: 0x060244C5 RID: 148677 RVA: 0x004FCC8B File Offset: 0x004FAE8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060244C6 RID: 148678 RVA: 0x004FCC98 File Offset: 0x004FAE98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060244C7 RID: 148679 RVA: 0x004FCCA0 File Offset: 0x004FAEA0
		public static IFixedDateTime GetRootAsIFixedDateTime(ByteBuffer _bb)
		{
			return IFixedDateTime.GetRootAsIFixedDateTime(_bb, default(IFixedDateTime));
		}

		// Token: 0x060244C8 RID: 148680 RVA: 0x004FCCBC File Offset: 0x004FAEBC
		public static IFixedDateTime GetRootAsIFixedDateTime(ByteBuffer _bb, IFixedDateTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060244C9 RID: 148681 RVA: 0x004FCCD9 File Offset: 0x004FAED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060244CA RID: 148682 RVA: 0x004FCCE8 File Offset: 0x004FAEE8
		public IFixedDateTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A283 RID: 41603
		// (get) Token: 0x060244CB RID: 148683 RVA: 0x004FCCF8 File Offset: 0x004FAEF8
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

		// Token: 0x1700A284 RID: 41604
		// (get) Token: 0x060244CC RID: 148684 RVA: 0x004FCD34 File Offset: 0x004FAF34
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

		// Token: 0x1700A285 RID: 41605
		// (get) Token: 0x060244CD RID: 148685 RVA: 0x004FCD70 File Offset: 0x004FAF70
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

		// Token: 0x060244CE RID: 148686 RVA: 0x004FCDAC File Offset: 0x004FAFAC
		public static Offset<IFixedDateTime> CreateIFixedDateTime(FlatBufferBuilder builder, int Hours = 0, int Minutes = 0, int Seconds = 0)
		{
			builder.StartTable(3);
			IFixedDateTime.AddSeconds(builder, Seconds);
			IFixedDateTime.AddMinutes(builder, Minutes);
			IFixedDateTime.AddHours(builder, Hours);
			return IFixedDateTime.EndIFixedDateTime(builder);
		}

		// Token: 0x060244CF RID: 148687 RVA: 0x004FCDD0 File Offset: 0x004FAFD0
		public static void StartIFixedDateTime(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060244D0 RID: 148688 RVA: 0x004FCDD9 File Offset: 0x004FAFD9
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(0, hours, 0);
		}

		// Token: 0x060244D1 RID: 148689 RVA: 0x004FCDE4 File Offset: 0x004FAFE4
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(1, minutes, 0);
		}

		// Token: 0x060244D2 RID: 148690 RVA: 0x004FCDEF File Offset: 0x004FAFEF
		public static void AddSeconds(FlatBufferBuilder builder, int seconds)
		{
			builder.AddInt(2, seconds, 0);
		}

		// Token: 0x060244D3 RID: 148691 RVA: 0x004FCDFA File Offset: 0x004FAFFA
		public static Offset<IFixedDateTime> EndIFixedDateTime(FlatBufferBuilder builder)
		{
			return new Offset<IFixedDateTime>(builder.EndTable());
		}

		// Token: 0x060244D4 RID: 148692 RVA: 0x004FCE08 File Offset: 0x004FB008
		public IFixedDateTimeT UnPack()
		{
			IFixedDateTimeT fixedDateTimeT = new IFixedDateTimeT();
			this.UnPackTo(fixedDateTimeT);
			return fixedDateTimeT;
		}

		// Token: 0x060244D5 RID: 148693 RVA: 0x004FCE23 File Offset: 0x004FB023
		public void UnPackTo(IFixedDateTimeT _o)
		{
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Seconds = this.Seconds;
		}

		// Token: 0x060244D6 RID: 148694 RVA: 0x004FCE4C File Offset: 0x004FB04C
		public static Offset<IFixedDateTime> Pack(FlatBufferBuilder builder, IFixedDateTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedDateTime>);
			}
			return IFixedDateTime.CreateIFixedDateTime(builder, _o.Hours, _o.Minutes, _o.Seconds);
		}

		// Token: 0x0400EFC2 RID: 61378
		private Table __p;
	}
}
