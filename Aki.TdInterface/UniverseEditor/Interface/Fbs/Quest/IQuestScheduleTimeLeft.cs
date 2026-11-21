using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200447E RID: 17534
	public struct IQuestScheduleTimeLeft : IFlatbufferObject
	{
		// Token: 0x170079BF RID: 31167
		// (get) Token: 0x06019377 RID: 103287 RVA: 0x0039934A File Offset: 0x0039754A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019378 RID: 103288 RVA: 0x00399357 File Offset: 0x00397557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019379 RID: 103289 RVA: 0x00399360 File Offset: 0x00397560
		public static IQuestScheduleTimeLeft GetRootAsIQuestScheduleTimeLeft(ByteBuffer _bb)
		{
			return IQuestScheduleTimeLeft.GetRootAsIQuestScheduleTimeLeft(_bb, default(IQuestScheduleTimeLeft));
		}

		// Token: 0x0601937A RID: 103290 RVA: 0x0039937C File Offset: 0x0039757C
		public static IQuestScheduleTimeLeft GetRootAsIQuestScheduleTimeLeft(ByteBuffer _bb, IQuestScheduleTimeLeft obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601937B RID: 103291 RVA: 0x00399399 File Offset: 0x00397599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601937C RID: 103292 RVA: 0x003993A8 File Offset: 0x003975A8
		public IQuestScheduleTimeLeft __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079C0 RID: 31168
		// (get) Token: 0x0601937D RID: 103293 RVA: 0x003993B8 File Offset: 0x003975B8
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

		// Token: 0x170079C1 RID: 31169
		// (get) Token: 0x0601937E RID: 103294 RVA: 0x003993F4 File Offset: 0x003975F4
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

		// Token: 0x170079C2 RID: 31170
		// (get) Token: 0x0601937F RID: 103295 RVA: 0x00399430 File Offset: 0x00397630
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

		// Token: 0x170079C3 RID: 31171
		// (get) Token: 0x06019380 RID: 103296 RVA: 0x0039946C File Offset: 0x0039766C
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

		// Token: 0x170079C4 RID: 31172
		// (get) Token: 0x06019381 RID: 103297 RVA: 0x003994AC File Offset: 0x003976AC
		public bool ShowTime
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170079C5 RID: 31173
		// (get) Token: 0x06019382 RID: 103298 RVA: 0x003994EC File Offset: 0x003976EC
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

		// Token: 0x06019383 RID: 103299 RVA: 0x00399529 File Offset: 0x00397729
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

		// Token: 0x06019384 RID: 103300 RVA: 0x00399565 File Offset: 0x00397765
		public static void StartIQuestScheduleTimeLeft(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019385 RID: 103301 RVA: 0x0039956E File Offset: 0x0039776E
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019386 RID: 103302 RVA: 0x00399579 File Offset: 0x00397779
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(1, (byte)timerType, 0);
		}

		// Token: 0x06019387 RID: 103303 RVA: 0x00399584 File Offset: 0x00397784
		public static void AddTimeLeft(FlatBufferBuilder builder, int timeLeft)
		{
			builder.AddInt(2, timeLeft, 0);
		}

		// Token: 0x06019388 RID: 103304 RVA: 0x0039958F File Offset: 0x0039778F
		public static void AddIconType(FlatBufferBuilder builder, ETimeLeftIconType iconType)
		{
			builder.AddByte(3, (byte)iconType, 0);
		}

		// Token: 0x06019389 RID: 103305 RVA: 0x0039959A File Offset: 0x0039779A
		public static void AddShowTime(FlatBufferBuilder builder, bool showTime)
		{
			builder.AddBool(4, showTime, false);
		}

		// Token: 0x0601938A RID: 103306 RVA: 0x003995A5 File Offset: 0x003977A5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601938B RID: 103307 RVA: 0x003995B0 File Offset: 0x003977B0
		public static Offset<IQuestScheduleTimeLeft> EndIQuestScheduleTimeLeft(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleTimeLeft>(builder.EndTable());
		}

		// Token: 0x0601938C RID: 103308 RVA: 0x003995C0 File Offset: 0x003977C0
		public IQuestScheduleTimeLeftT UnPack()
		{
			IQuestScheduleTimeLeftT questScheduleTimeLeftT = new IQuestScheduleTimeLeftT();
			this.UnPackTo(questScheduleTimeLeftT);
			return questScheduleTimeLeftT;
		}

		// Token: 0x0601938D RID: 103309 RVA: 0x003995DC File Offset: 0x003977DC
		public void UnPackTo(IQuestScheduleTimeLeftT _o)
		{
			_o.Type = this.Type;
			_o.TimerType = this.TimerType;
			_o.TimeLeft = this.TimeLeft;
			_o.IconType = this.IconType;
			_o.ShowTime = this.ShowTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601938E RID: 103310 RVA: 0x00399634 File Offset: 0x00397834
		public static Offset<IQuestScheduleTimeLeft> Pack(FlatBufferBuilder builder, IQuestScheduleTimeLeftT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleTimeLeft>);
			}
			return IQuestScheduleTimeLeft.CreateIQuestScheduleTimeLeft(builder, _o.Type, _o.TimerType, _o.TimeLeft, _o.IconType, _o.ShowTime, _o.NullMask);
		}

		// Token: 0x0400C558 RID: 50520
		private Table __p;
	}
}
