using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004064 RID: 16484
	public struct IQuestUnlockDelayTime : IFlatbufferObject
	{
		// Token: 0x17007423 RID: 29731
		// (get) Token: 0x06017EB9 RID: 97977 RVA: 0x00373CAA File Offset: 0x00371EAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017EBA RID: 97978 RVA: 0x00373CB7 File Offset: 0x00371EB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017EBB RID: 97979 RVA: 0x00373CC0 File Offset: 0x00371EC0
		public static IQuestUnlockDelayTime GetRootAsIQuestUnlockDelayTime(ByteBuffer _bb)
		{
			return IQuestUnlockDelayTime.GetRootAsIQuestUnlockDelayTime(_bb, default(IQuestUnlockDelayTime));
		}

		// Token: 0x06017EBC RID: 97980 RVA: 0x00373CDC File Offset: 0x00371EDC
		public static IQuestUnlockDelayTime GetRootAsIQuestUnlockDelayTime(ByteBuffer _bb, IQuestUnlockDelayTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017EBD RID: 97981 RVA: 0x00373CF9 File Offset: 0x00371EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017EBE RID: 97982 RVA: 0x00373D08 File Offset: 0x00371F08
		public IQuestUnlockDelayTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007424 RID: 29732
		// (get) Token: 0x06017EBF RID: 97983 RVA: 0x00373D18 File Offset: 0x00371F18
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

		// Token: 0x17007425 RID: 29733
		// (get) Token: 0x06017EC0 RID: 97984 RVA: 0x00373D54 File Offset: 0x00371F54
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

		// Token: 0x17007426 RID: 29734
		// (get) Token: 0x06017EC1 RID: 97985 RVA: 0x00373D90 File Offset: 0x00371F90
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

		// Token: 0x06017EC2 RID: 97986 RVA: 0x00373DCC File Offset: 0x00371FCC
		public static Offset<IQuestUnlockDelayTime> CreateIQuestUnlockDelayTime(FlatBufferBuilder builder, int Day = 0, int Hour = 0, int Minute = 0)
		{
			builder.StartTable(3);
			IQuestUnlockDelayTime.AddMinute(builder, Minute);
			IQuestUnlockDelayTime.AddHour(builder, Hour);
			IQuestUnlockDelayTime.AddDay(builder, Day);
			return IQuestUnlockDelayTime.EndIQuestUnlockDelayTime(builder);
		}

		// Token: 0x06017EC3 RID: 97987 RVA: 0x00373DF0 File Offset: 0x00371FF0
		public static void StartIQuestUnlockDelayTime(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017EC4 RID: 97988 RVA: 0x00373DF9 File Offset: 0x00371FF9
		public static void AddDay(FlatBufferBuilder builder, int day)
		{
			builder.AddInt(0, day, 0);
		}

		// Token: 0x06017EC5 RID: 97989 RVA: 0x00373E04 File Offset: 0x00372004
		public static void AddHour(FlatBufferBuilder builder, int hour)
		{
			builder.AddInt(1, hour, 0);
		}

		// Token: 0x06017EC6 RID: 97990 RVA: 0x00373E0F File Offset: 0x0037200F
		public static void AddMinute(FlatBufferBuilder builder, int minute)
		{
			builder.AddInt(2, minute, 0);
		}

		// Token: 0x06017EC7 RID: 97991 RVA: 0x00373E1A File Offset: 0x0037201A
		public static Offset<IQuestUnlockDelayTime> EndIQuestUnlockDelayTime(FlatBufferBuilder builder)
		{
			return new Offset<IQuestUnlockDelayTime>(builder.EndTable());
		}

		// Token: 0x06017EC8 RID: 97992 RVA: 0x00373E28 File Offset: 0x00372028
		public IQuestUnlockDelayTimeT UnPack()
		{
			IQuestUnlockDelayTimeT questUnlockDelayTimeT = new IQuestUnlockDelayTimeT();
			this.UnPackTo(questUnlockDelayTimeT);
			return questUnlockDelayTimeT;
		}

		// Token: 0x06017EC9 RID: 97993 RVA: 0x00373E43 File Offset: 0x00372043
		public void UnPackTo(IQuestUnlockDelayTimeT _o)
		{
			_o.Day = this.Day;
			_o.Hour = this.Hour;
			_o.Minute = this.Minute;
		}

		// Token: 0x06017ECA RID: 97994 RVA: 0x00373E6C File Offset: 0x0037206C
		public static Offset<IQuestUnlockDelayTime> Pack(FlatBufferBuilder builder, IQuestUnlockDelayTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestUnlockDelayTime>);
			}
			return IQuestUnlockDelayTime.CreateIQuestUnlockDelayTime(builder, _o.Day, _o.Hour, _o.Minute);
		}

		// Token: 0x0400BBC8 RID: 48072
		private Table __p;
	}
}
