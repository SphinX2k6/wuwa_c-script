using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004547 RID: 17735
	public struct IScheduleTimeCondition : IFlatbufferObject
	{
		// Token: 0x17007B58 RID: 31576
		// (get) Token: 0x06019AF2 RID: 105202 RVA: 0x003A82CF File Offset: 0x003A64CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019AF3 RID: 105203 RVA: 0x003A82DC File Offset: 0x003A64DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019AF4 RID: 105204 RVA: 0x003A82E4 File Offset: 0x003A64E4
		public static IScheduleTimeCondition GetRootAsIScheduleTimeCondition(ByteBuffer _bb)
		{
			return IScheduleTimeCondition.GetRootAsIScheduleTimeCondition(_bb, default(IScheduleTimeCondition));
		}

		// Token: 0x06019AF5 RID: 105205 RVA: 0x003A8300 File Offset: 0x003A6500
		public static IScheduleTimeCondition GetRootAsIScheduleTimeCondition(ByteBuffer _bb, IScheduleTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019AF6 RID: 105206 RVA: 0x003A831D File Offset: 0x003A651D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019AF7 RID: 105207 RVA: 0x003A832C File Offset: 0x003A652C
		public IScheduleTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B59 RID: 31577
		// (get) Token: 0x06019AF8 RID: 105208 RVA: 0x003A833C File Offset: 0x003A653C
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B5A RID: 31578
		// (get) Token: 0x06019AF9 RID: 105209 RVA: 0x003A8378 File Offset: 0x003A6578
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007B5B RID: 31579
		// (get) Token: 0x06019AFA RID: 105210 RVA: 0x003A83D8 File Offset: 0x003A65D8
		public IBaseTime? StartTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IBaseTime?(default(IBaseTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007B5C RID: 31580
		// (get) Token: 0x06019AFB RID: 105211 RVA: 0x003A8438 File Offset: 0x003A6638
		public IBaseTime? EndTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IBaseTime?(default(IBaseTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007B5D RID: 31581
		// (get) Token: 0x06019AFC RID: 105212 RVA: 0x003A8498 File Offset: 0x003A6698
		public int Day
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B5E RID: 31582
		// (get) Token: 0x06019AFD RID: 105213 RVA: 0x003A84D8 File Offset: 0x003A66D8
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

		// Token: 0x06019AFE RID: 105214 RVA: 0x003A8515 File Offset: 0x003A6715
		public static Offset<IScheduleTimeCondition> CreateIScheduleTimeCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IBaseTime> StartTimeOffset = default(Offset<IBaseTime>), Offset<IBaseTime> EndTimeOffset = default(Offset<IBaseTime>), int Day = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IScheduleTimeCondition.AddDay(builder, Day);
			IScheduleTimeCondition.AddEndTime(builder, EndTimeOffset);
			IScheduleTimeCondition.AddStartTime(builder, StartTimeOffset);
			IScheduleTimeCondition.AddPreConditions(builder, PreConditionsOffset);
			IScheduleTimeCondition.AddNullMask(builder, NullMask);
			IScheduleTimeCondition.AddType(builder, Type);
			return IScheduleTimeCondition.EndIScheduleTimeCondition(builder);
		}

		// Token: 0x06019AFF RID: 105215 RVA: 0x003A8551 File Offset: 0x003A6751
		public static void StartIScheduleTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019B00 RID: 105216 RVA: 0x003A855A File Offset: 0x003A675A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019B01 RID: 105217 RVA: 0x003A8565 File Offset: 0x003A6765
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019B02 RID: 105218 RVA: 0x003A8575 File Offset: 0x003A6775
		public static void AddStartTime(FlatBufferBuilder builder, Offset<IBaseTime> startTimeOffset)
		{
			builder.AddOffset(2, startTimeOffset.Value, 0);
		}

		// Token: 0x06019B03 RID: 105219 RVA: 0x003A8585 File Offset: 0x003A6785
		public static void AddEndTime(FlatBufferBuilder builder, Offset<IBaseTime> endTimeOffset)
		{
			builder.AddOffset(3, endTimeOffset.Value, 0);
		}

		// Token: 0x06019B04 RID: 105220 RVA: 0x003A8595 File Offset: 0x003A6795
		public static void AddDay(FlatBufferBuilder builder, int day)
		{
			builder.AddInt(4, day, 0);
		}

		// Token: 0x06019B05 RID: 105221 RVA: 0x003A85A0 File Offset: 0x003A67A0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06019B06 RID: 105222 RVA: 0x003A85AB File Offset: 0x003A67AB
		public static Offset<IScheduleTimeCondition> EndIScheduleTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IScheduleTimeCondition>(builder.EndTable());
		}

		// Token: 0x06019B07 RID: 105223 RVA: 0x003A85B8 File Offset: 0x003A67B8
		public IScheduleTimeConditionT UnPack()
		{
			IScheduleTimeConditionT scheduleTimeConditionT = new IScheduleTimeConditionT();
			this.UnPackTo(scheduleTimeConditionT);
			return scheduleTimeConditionT;
		}

		// Token: 0x06019B08 RID: 105224 RVA: 0x003A85D4 File Offset: 0x003A67D4
		public void UnPackTo(IScheduleTimeConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.StartTime = ((this.StartTime != null) ? this.StartTime.Value.UnPack() : null);
			_o.EndTime = ((this.EndTime != null) ? this.EndTime.Value.UnPack() : null);
			_o.Day = this.Day;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019B09 RID: 105225 RVA: 0x003A8694 File Offset: 0x003A6894
		public static Offset<IScheduleTimeCondition> Pack(FlatBufferBuilder builder, IScheduleTimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScheduleTimeCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IBaseTime> startTimeOffset = (_o.StartTime == null) ? default(Offset<IBaseTime>) : IBaseTime.Pack(builder, _o.StartTime);
			Offset<IBaseTime> endTimeOffset = (_o.EndTime == null) ? default(Offset<IBaseTime>) : IBaseTime.Pack(builder, _o.EndTime);
			return IScheduleTimeCondition.CreateIScheduleTimeCondition(builder, _o.Type, preConditionsOffset, startTimeOffset, endTimeOffset, _o.Day, _o.NullMask);
		}

		// Token: 0x0400C692 RID: 50834
		private Table __p;
	}
}
