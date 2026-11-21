using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004205 RID: 16901
	public struct IDateTime : IFlatbufferObject
	{
		// Token: 0x1700730E RID: 29454
		// (get) Token: 0x0601774C RID: 96076 RVA: 0x003599F9 File Offset: 0x00357BF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601774D RID: 96077 RVA: 0x00359A06 File Offset: 0x00357C06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601774E RID: 96078 RVA: 0x00359A10 File Offset: 0x00357C10
		public static IDateTime GetRootAsIDateTime(ByteBuffer _bb)
		{
			return IDateTime.GetRootAsIDateTime(_bb, default(IDateTime));
		}

		// Token: 0x0601774F RID: 96079 RVA: 0x00359A2C File Offset: 0x00357C2C
		public static IDateTime GetRootAsIDateTime(ByteBuffer _bb, IDateTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017750 RID: 96080 RVA: 0x00359A49 File Offset: 0x00357C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017751 RID: 96081 RVA: 0x00359A58 File Offset: 0x00357C58
		public IDateTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700730F RID: 29455
		// (get) Token: 0x06017752 RID: 96082 RVA: 0x00359A68 File Offset: 0x00357C68
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

		// Token: 0x17007310 RID: 29456
		// (get) Token: 0x06017753 RID: 96083 RVA: 0x00359AA4 File Offset: 0x00357CA4
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

		// Token: 0x17007311 RID: 29457
		// (get) Token: 0x06017754 RID: 96084 RVA: 0x00359AE0 File Offset: 0x00357CE0
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

		// Token: 0x17007312 RID: 29458
		// (get) Token: 0x06017755 RID: 96085 RVA: 0x00359B1C File Offset: 0x00357D1C
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

		// Token: 0x06017756 RID: 96086 RVA: 0x00359B59 File Offset: 0x00357D59
		public static Offset<IDateTime> CreateIDateTime(FlatBufferBuilder builder, int Hours = 0, int Minutes = 0, int Days = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDateTime.AddDays(builder, Days);
			IDateTime.AddMinutes(builder, Minutes);
			IDateTime.AddHours(builder, Hours);
			IDateTime.AddNullMask(builder, NullMask);
			return IDateTime.EndIDateTime(builder);
		}

		// Token: 0x06017757 RID: 96087 RVA: 0x00359B85 File Offset: 0x00357D85
		public static void StartIDateTime(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017758 RID: 96088 RVA: 0x00359B8E File Offset: 0x00357D8E
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(0, hours, 0);
		}

		// Token: 0x06017759 RID: 96089 RVA: 0x00359B99 File Offset: 0x00357D99
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(1, minutes, 0);
		}

		// Token: 0x0601775A RID: 96090 RVA: 0x00359BA4 File Offset: 0x00357DA4
		public static void AddDays(FlatBufferBuilder builder, int days)
		{
			builder.AddInt(2, days, 0);
		}

		// Token: 0x0601775B RID: 96091 RVA: 0x00359BAF File Offset: 0x00357DAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601775C RID: 96092 RVA: 0x00359BBA File Offset: 0x00357DBA
		public static Offset<IDateTime> EndIDateTime(FlatBufferBuilder builder)
		{
			return new Offset<IDateTime>(builder.EndTable());
		}

		// Token: 0x0601775D RID: 96093 RVA: 0x00359BC8 File Offset: 0x00357DC8
		public IDateTimeT UnPack()
		{
			IDateTimeT dateTimeT = new IDateTimeT();
			this.UnPackTo(dateTimeT);
			return dateTimeT;
		}

		// Token: 0x0601775E RID: 96094 RVA: 0x00359BE3 File Offset: 0x00357DE3
		public void UnPackTo(IDateTimeT _o)
		{
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Days = this.Days;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601775F RID: 96095 RVA: 0x00359C18 File Offset: 0x00357E18
		public static Offset<IDateTime> Pack(FlatBufferBuilder builder, IDateTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDateTime>);
			}
			return IDateTime.CreateIDateTime(builder, _o.Hours, _o.Minutes, _o.Days, _o.NullMask);
		}

		// Token: 0x0400C0DE RID: 49374
		private Table __p;
	}
}
