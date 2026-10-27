using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004106 RID: 16646
	public struct IScheduleTimeCondition : IFlatbufferObject
	{
		// Token: 0x17007552 RID: 30034
		// (get) Token: 0x06018451 RID: 99409 RVA: 0x0037E37F File Offset: 0x0037C57F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018452 RID: 99410 RVA: 0x0037E38C File Offset: 0x0037C58C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018453 RID: 99411 RVA: 0x0037E394 File Offset: 0x0037C594
		public static IScheduleTimeCondition GetRootAsIScheduleTimeCondition(ByteBuffer _bb)
		{
			return IScheduleTimeCondition.GetRootAsIScheduleTimeCondition(_bb, default(IScheduleTimeCondition));
		}

		// Token: 0x06018454 RID: 99412 RVA: 0x0037E3B0 File Offset: 0x0037C5B0
		public static IScheduleTimeCondition GetRootAsIScheduleTimeCondition(ByteBuffer _bb, IScheduleTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018455 RID: 99413 RVA: 0x0037E3CD File Offset: 0x0037C5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018456 RID: 99414 RVA: 0x0037E3DC File Offset: 0x0037C5DC
		public IScheduleTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007553 RID: 30035
		// (get) Token: 0x06018457 RID: 99415 RVA: 0x0037E3EC File Offset: 0x0037C5EC
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

		// Token: 0x17007554 RID: 30036
		// (get) Token: 0x06018458 RID: 99416 RVA: 0x0037E428 File Offset: 0x0037C628
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

		// Token: 0x17007555 RID: 30037
		// (get) Token: 0x06018459 RID: 99417 RVA: 0x0037E488 File Offset: 0x0037C688
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

		// Token: 0x17007556 RID: 30038
		// (get) Token: 0x0601845A RID: 99418 RVA: 0x0037E4E8 File Offset: 0x0037C6E8
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

		// Token: 0x17007557 RID: 30039
		// (get) Token: 0x0601845B RID: 99419 RVA: 0x0037E548 File Offset: 0x0037C748
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

		// Token: 0x17007558 RID: 30040
		// (get) Token: 0x0601845C RID: 99420 RVA: 0x0037E588 File Offset: 0x0037C788
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

		// Token: 0x0601845D RID: 99421 RVA: 0x0037E5C5 File Offset: 0x0037C7C5
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

		// Token: 0x0601845E RID: 99422 RVA: 0x0037E601 File Offset: 0x0037C801
		public static void StartIScheduleTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601845F RID: 99423 RVA: 0x0037E60A File Offset: 0x0037C80A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018460 RID: 99424 RVA: 0x0037E615 File Offset: 0x0037C815
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018461 RID: 99425 RVA: 0x0037E625 File Offset: 0x0037C825
		public static void AddStartTime(FlatBufferBuilder builder, Offset<IBaseTime> startTimeOffset)
		{
			builder.AddOffset(2, startTimeOffset.Value, 0);
		}

		// Token: 0x06018462 RID: 99426 RVA: 0x0037E635 File Offset: 0x0037C835
		public static void AddEndTime(FlatBufferBuilder builder, Offset<IBaseTime> endTimeOffset)
		{
			builder.AddOffset(3, endTimeOffset.Value, 0);
		}

		// Token: 0x06018463 RID: 99427 RVA: 0x0037E645 File Offset: 0x0037C845
		public static void AddDay(FlatBufferBuilder builder, int day)
		{
			builder.AddInt(4, day, 0);
		}

		// Token: 0x06018464 RID: 99428 RVA: 0x0037E650 File Offset: 0x0037C850
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06018465 RID: 99429 RVA: 0x0037E65B File Offset: 0x0037C85B
		public static Offset<IScheduleTimeCondition> EndIScheduleTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IScheduleTimeCondition>(builder.EndTable());
		}

		// Token: 0x06018466 RID: 99430 RVA: 0x0037E668 File Offset: 0x0037C868
		public IScheduleTimeConditionT UnPack()
		{
			IScheduleTimeConditionT scheduleTimeConditionT = new IScheduleTimeConditionT();
			this.UnPackTo(scheduleTimeConditionT);
			return scheduleTimeConditionT;
		}

		// Token: 0x06018467 RID: 99431 RVA: 0x0037E684 File Offset: 0x0037C884
		public void UnPackTo(IScheduleTimeConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.StartTime = ((this.StartTime != null) ? this.StartTime.Value.UnPack() : null);
			_o.EndTime = ((this.EndTime != null) ? this.EndTime.Value.UnPack() : null);
			_o.Day = this.Day;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018468 RID: 99432 RVA: 0x0037E744 File Offset: 0x0037C944
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

		// Token: 0x0400BCA9 RID: 48297
		private Table __p;
	}
}
