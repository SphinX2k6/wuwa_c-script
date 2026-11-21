using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A5 RID: 17573
	public struct IQuestUnlockDelayTime : IFlatbufferObject
	{
		// Token: 0x17007A25 RID: 31269
		// (get) Token: 0x06019552 RID: 103762 RVA: 0x0039DA9E File Offset: 0x0039BC9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019553 RID: 103763 RVA: 0x0039DAAB File Offset: 0x0039BCAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019554 RID: 103764 RVA: 0x0039DAB4 File Offset: 0x0039BCB4
		public static IQuestUnlockDelayTime GetRootAsIQuestUnlockDelayTime(ByteBuffer _bb)
		{
			return IQuestUnlockDelayTime.GetRootAsIQuestUnlockDelayTime(_bb, default(IQuestUnlockDelayTime));
		}

		// Token: 0x06019555 RID: 103765 RVA: 0x0039DAD0 File Offset: 0x0039BCD0
		public static IQuestUnlockDelayTime GetRootAsIQuestUnlockDelayTime(ByteBuffer _bb, IQuestUnlockDelayTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019556 RID: 103766 RVA: 0x0039DAED File Offset: 0x0039BCED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019557 RID: 103767 RVA: 0x0039DAFC File Offset: 0x0039BCFC
		public IQuestUnlockDelayTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A26 RID: 31270
		// (get) Token: 0x06019558 RID: 103768 RVA: 0x0039DB0C File Offset: 0x0039BD0C
		public int Day
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

		// Token: 0x17007A27 RID: 31271
		// (get) Token: 0x06019559 RID: 103769 RVA: 0x0039DB48 File Offset: 0x0039BD48
		public int Hour
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

		// Token: 0x17007A28 RID: 31272
		// (get) Token: 0x0601955A RID: 103770 RVA: 0x0039DB84 File Offset: 0x0039BD84
		public int Minute
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

		// Token: 0x0601955B RID: 103771 RVA: 0x0039DBC0 File Offset: 0x0039BDC0
		public static Offset<IQuestUnlockDelayTime> CreateIQuestUnlockDelayTime(FlatBufferBuilder builder, int Day = 0, int Hour = 0, int Minute = 0)
		{
			builder.StartTable(3);
			IQuestUnlockDelayTime.AddMinute(builder, Minute);
			IQuestUnlockDelayTime.AddHour(builder, Hour);
			IQuestUnlockDelayTime.AddDay(builder, Day);
			return IQuestUnlockDelayTime.EndIQuestUnlockDelayTime(builder);
		}

		// Token: 0x0601955C RID: 103772 RVA: 0x0039DBE4 File Offset: 0x0039BDE4
		public static void StartIQuestUnlockDelayTime(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601955D RID: 103773 RVA: 0x0039DBED File Offset: 0x0039BDED
		public static void AddDay(FlatBufferBuilder builder, int day)
		{
			builder.AddInt(0, day, 0);
		}

		// Token: 0x0601955E RID: 103774 RVA: 0x0039DBF8 File Offset: 0x0039BDF8
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(1, hour, 0);
		}

		// Token: 0x0601955F RID: 103775 RVA: 0x0039DC03 File Offset: 0x0039BE03
		public static void AddMinute(FlatBufferBuilder builder, int minute)
		{
			builder.AddInt(2, minute, 0);
		}

		// Token: 0x06019560 RID: 103776 RVA: 0x0039DC0E File Offset: 0x0039BE0E
		public static Offset<IQuestUnlockDelayTime> EndIQuestUnlockDelayTime(FlatBufferBuilder builder)
		{
			return new Offset<IQuestUnlockDelayTime>(builder.EndTable());
		}

		// Token: 0x06019561 RID: 103777 RVA: 0x0039DC1C File Offset: 0x0039BE1C
		public IQuestUnlockDelayTimeT UnPack()
		{
			IQuestUnlockDelayTimeT questUnlockDelayTimeT = new IQuestUnlockDelayTimeT();
			this.UnPackTo(questUnlockDelayTimeT);
			return questUnlockDelayTimeT;
		}

		// Token: 0x06019562 RID: 103778 RVA: 0x0039DC37 File Offset: 0x0039BE37
		public void UnPackTo(IQuestUnlockDelayTimeT _o)
		{
			_o.Day = this.Day;
			_o.Hour = this.Hour;
			_o.Minute = this.Minute;
		}

		// Token: 0x06019563 RID: 103779 RVA: 0x0039DC60 File Offset: 0x0039BE60
		public static Offset<IQuestUnlockDelayTime> Pack(FlatBufferBuilder builder, IQuestUnlockDelayTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestUnlockDelayTime>);
			}
			return IQuestUnlockDelayTime.CreateIQuestUnlockDelayTime(builder, _o.Day, _o.Hour, _o.Minute);
		}

		// Token: 0x0400C5AF RID: 50607
		private Table __p;
	}
}
