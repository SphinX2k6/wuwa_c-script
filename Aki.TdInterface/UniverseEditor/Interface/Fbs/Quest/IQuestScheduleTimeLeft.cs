using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200403D RID: 16445
	public struct IQuestScheduleTimeLeft : IFlatbufferObject
	{
		// Token: 0x170073BD RID: 29629
		// (get) Token: 0x06017CDE RID: 97502 RVA: 0x0036F556 File Offset: 0x0036D756
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017CDF RID: 97503 RVA: 0x0036F563 File Offset: 0x0036D763
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017CE0 RID: 97504 RVA: 0x0036F56C File Offset: 0x0036D76C
		public static IQuestScheduleTimeLeft GetRootAsIQuestScheduleTimeLeft(ByteBuffer _bb)
		{
			return IQuestScheduleTimeLeft.GetRootAsIQuestScheduleTimeLeft(_bb, default(IQuestScheduleTimeLeft));
		}

		// Token: 0x06017CE1 RID: 97505 RVA: 0x0036F588 File Offset: 0x0036D788
		public static IQuestScheduleTimeLeft GetRootAsIQuestScheduleTimeLeft(ByteBuffer _bb, IQuestScheduleTimeLeft obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017CE2 RID: 97506 RVA: 0x0036F5A5 File Offset: 0x0036D7A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017CE3 RID: 97507 RVA: 0x0036F5B4 File Offset: 0x0036D7B4
		public IQuestScheduleTimeLeft __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073BE RID: 29630
		// (get) Token: 0x06017CE4 RID: 97508 RVA: 0x0036F5C4 File Offset: 0x0036D7C4
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073BF RID: 29631
		// (get) Token: 0x06017CE5 RID: 97509 RVA: 0x0036F600 File Offset: 0x0036D800
		public ETimerType TimerType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETimerType.CountDownChallenge;
				}
				return (ETimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073C0 RID: 29632
		// (get) Token: 0x06017CE6 RID: 97510 RVA: 0x0036F63C File Offset: 0x0036D83C
		public int TimeLeft
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

		// Token: 0x170073C1 RID: 29633
		// (get) Token: 0x06017CE7 RID: 97511 RVA: 0x0036F678 File Offset: 0x0036D878
		public ETimeLeftIconType IconType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ETimeLeftIconType.AkiWorld;
				}
				return (ETimeLeftIconType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073C2 RID: 29634
		// (get) Token: 0x06017CE8 RID: 97512 RVA: 0x0036F6B8 File Offset: 0x0036D8B8
		public bool ShowTime
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170073C3 RID: 29635
		// (get) Token: 0x06017CE9 RID: 97513 RVA: 0x0036F6F8 File Offset: 0x0036D8F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017CEA RID: 97514 RVA: 0x0036F735 File Offset: 0x0036D935
		public static Offset<IQuestScheduleTimeLeft> CreateIQuestScheduleTimeLeft(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, ETimerType TimerType = ETimerType.CountDownChallenge, int TimeLeft = 0, ETimeLeftIconType IconType = ETimeLeftIconType.AkiWorld, bool ShowTime = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IQuestScheduleTimeLeft.AddTimeLeft(builder, TimeLeft);
			IQuestScheduleTimeLeft.AddNullMask(builder, NullMask);
			IQuestScheduleTimeLeft.AddShowTime(builder, ShowTime);
			IQuestScheduleTimeLeft.AddIconType(builder, IconType);
			IQuestScheduleTimeLeft.AddTimerType(builder, TimerType);
			IQuestScheduleTimeLeft.AddType(builder, Type);
			return IQuestScheduleTimeLeft.EndIQuestScheduleTimeLeft(builder);
		}

		// Token: 0x06017CEB RID: 97515 RVA: 0x0036F771 File Offset: 0x0036D971
		public static void StartIQuestScheduleTimeLeft(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017CEC RID: 97516 RVA: 0x0036F77A File Offset: 0x0036D97A
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017CED RID: 97517 RVA: 0x0036F785 File Offset: 0x0036D985
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(1, (byte)timerType, 0);
		}

		// Token: 0x06017CEE RID: 97518 RVA: 0x0036F790 File Offset: 0x0036D990
		public static void AddTimeLeft(FlatBufferBuilder builder, int timeLeft)
		{
			builder.AddInt(2, timeLeft, 0);
		}

		// Token: 0x06017CEF RID: 97519 RVA: 0x0036F79B File Offset: 0x0036D99B
		public static void AddIconType(FlatBufferBuilder builder, ETimeLeftIconType iconType)
		{
			builder.AddByte(3, (byte)iconType, 0);
		}

		// Token: 0x06017CF0 RID: 97520 RVA: 0x0036F7A6 File Offset: 0x0036D9A6
		public static void AddShowTime(FlatBufferBuilder builder, bool showTime)
		{
			builder.AddBool(4, showTime, false);
		}

		// Token: 0x06017CF1 RID: 97521 RVA: 0x0036F7B1 File Offset: 0x0036D9B1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06017CF2 RID: 97522 RVA: 0x0036F7BC File Offset: 0x0036D9BC
		public static Offset<IQuestScheduleTimeLeft> EndIQuestScheduleTimeLeft(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleTimeLeft>(builder.EndTable());
		}

		// Token: 0x06017CF3 RID: 97523 RVA: 0x0036F7CC File Offset: 0x0036D9CC
		public IQuestScheduleTimeLeftT UnPack()
		{
			IQuestScheduleTimeLeftT questScheduleTimeLeftT = new IQuestScheduleTimeLeftT();
			this.UnPackTo(questScheduleTimeLeftT);
			return questScheduleTimeLeftT;
		}

		// Token: 0x06017CF4 RID: 97524 RVA: 0x0036F7E8 File Offset: 0x0036D9E8
		public void UnPackTo(IQuestScheduleTimeLeftT _o)
		{
			_o.Type = this.Type;
			_o.TimerType = this.TimerType;
			_o.TimeLeft = this.TimeLeft;
			_o.IconType = this.IconType;
			_o.ShowTime = this.ShowTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017CF5 RID: 97525 RVA: 0x0036F840 File Offset: 0x0036DA40
		public static Offset<IQuestScheduleTimeLeft> Pack(FlatBufferBuilder builder, IQuestScheduleTimeLeftT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleTimeLeft>);
			}
			return IQuestScheduleTimeLeft.CreateIQuestScheduleTimeLeft(builder, _o.Type, _o.TimerType, _o.TimeLeft, _o.IconType, _o.ShowTime, _o.NullMask);
		}

		// Token: 0x0400BB71 RID: 47985
		private Table __p;
	}
}
