using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DB RID: 16859
	public struct ITimerQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700778C RID: 30604
		// (get) Token: 0x06018D77 RID: 101751 RVA: 0x00393089 File Offset: 0x00391289
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D78 RID: 101752 RVA: 0x00393096 File Offset: 0x00391296
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D79 RID: 101753 RVA: 0x003930A0 File Offset: 0x003912A0
		public static ITimerQuestCondition GetRootAsITimerQuestCondition(ByteBuffer _bb)
		{
			return ITimerQuestCondition.GetRootAsITimerQuestCondition(_bb, default(ITimerQuestCondition));
		}

		// Token: 0x06018D7A RID: 101754 RVA: 0x003930BC File Offset: 0x003912BC
		public static ITimerQuestCondition GetRootAsITimerQuestCondition(ByteBuffer _bb, ITimerQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D7B RID: 101755 RVA: 0x003930D9 File Offset: 0x003912D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D7C RID: 101756 RVA: 0x003930E8 File Offset: 0x003912E8
		public ITimerQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700778D RID: 30605
		// (get) Token: 0x06018D7D RID: 101757 RVA: 0x003930F8 File Offset: 0x003912F8
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

		// Token: 0x1700778E RID: 30606
		// (get) Token: 0x06018D7E RID: 101758 RVA: 0x00393134 File Offset: 0x00391334
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

		// Token: 0x1700778F RID: 30607
		// (get) Token: 0x06018D7F RID: 101759 RVA: 0x00393194 File Offset: 0x00391394
		public int Time
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

		// Token: 0x17007790 RID: 30608
		// (get) Token: 0x06018D80 RID: 101760 RVA: 0x003931D0 File Offset: 0x003913D0
		public TVarRef VarForTimeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018D81 RID: 101761 RVA: 0x00393210 File Offset: 0x00391410
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018D82 RID: 101762 RVA: 0x00393258 File Offset: 0x00391458
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x06018D83 RID: 101763 RVA: 0x00393274 File Offset: 0x00391474
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x06018D84 RID: 101764 RVA: 0x00393290 File Offset: 0x00391490
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x06018D85 RID: 101765 RVA: 0x003932AC File Offset: 0x003914AC
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x06018D86 RID: 101766 RVA: 0x003932C8 File Offset: 0x003914C8
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x17007791 RID: 30609
		// (get) Token: 0x06018D87 RID: 101767 RVA: 0x003932E4 File Offset: 0x003914E4
		public ETimerType TimerType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ETimerType.CountDownChallenge;
				}
				return (ETimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007792 RID: 30610
		// (get) Token: 0x06018D88 RID: 101768 RVA: 0x00393324 File Offset: 0x00391524
		public ITimerUiConfig? UiConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ITimerUiConfig?(default(ITimerUiConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007793 RID: 30611
		// (get) Token: 0x06018D89 RID: 101769 RVA: 0x00393384 File Offset: 0x00391584
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018D8A RID: 101770 RVA: 0x003933C4 File Offset: 0x003915C4
		public static Offset<ITimerQuestCondition> CreateITimerQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int Time = 0, TVarRef VarForTime_type = TVarRef.NONE, int VarForTimeOffset = 0, ETimerType TimerType = ETimerType.CountDownChallenge, Offset<ITimerUiConfig> UiConfigOffset = default(Offset<ITimerUiConfig>), byte NullMask = 0)
		{
			builder.StartTable(8);
			ITimerQuestCondition.AddUiConfig(builder, UiConfigOffset);
			ITimerQuestCondition.AddVarForTime(builder, VarForTimeOffset);
			ITimerQuestCondition.AddTime(builder, Time);
			ITimerQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ITimerQuestCondition.AddNullMask(builder, NullMask);
			ITimerQuestCondition.AddTimerType(builder, TimerType);
			ITimerQuestCondition.AddVarForTimeType(builder, VarForTime_type);
			ITimerQuestCondition.AddType(builder, Type);
			return ITimerQuestCondition.EndITimerQuestCondition(builder);
		}

		// Token: 0x06018D8B RID: 101771 RVA: 0x0039341B File Offset: 0x0039161B
		public static void StartITimerQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06018D8C RID: 101772 RVA: 0x00393424 File Offset: 0x00391624
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018D8D RID: 101773 RVA: 0x0039342F File Offset: 0x0039162F
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018D8E RID: 101774 RVA: 0x0039343F File Offset: 0x0039163F
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(2, time, 0);
		}

		// Token: 0x06018D8F RID: 101775 RVA: 0x0039344A File Offset: 0x0039164A
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(3, (byte)varForTimeType, 0);
		}

		// Token: 0x06018D90 RID: 101776 RVA: 0x00393455 File Offset: 0x00391655
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(4, varForTimeOffset, 0);
		}

		// Token: 0x06018D91 RID: 101777 RVA: 0x00393460 File Offset: 0x00391660
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(5, (byte)timerType, 0);
		}

		// Token: 0x06018D92 RID: 101778 RVA: 0x0039346B File Offset: 0x0039166B
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<ITimerUiConfig> uiConfigOffset)
		{
			builder.AddOffset(6, uiConfigOffset.Value, 0);
		}

		// Token: 0x06018D93 RID: 101779 RVA: 0x0039347B File Offset: 0x0039167B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06018D94 RID: 101780 RVA: 0x00393486 File Offset: 0x00391686
		public static Offset<ITimerQuestCondition> EndITimerQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITimerQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018D95 RID: 101781 RVA: 0x00393494 File Offset: 0x00391694
		public ITimerQuestConditionT UnPack()
		{
			ITimerQuestConditionT timerQuestConditionT = new ITimerQuestConditionT();
			this.UnPackTo(timerQuestConditionT);
			return timerQuestConditionT;
		}

		// Token: 0x06018D96 RID: 101782 RVA: 0x003934B0 File Offset: 0x003916B0
		public void UnPackTo(ITimerQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Time = this.Time;
			_o.VarForTime = new TVarRefUnion();
			_o.VarForTime.Type = this.VarForTimeType;
			switch (this.VarForTimeType)
			{
			case TVarRef.IConstVarRef:
				_o.VarForTime.Value = ((this.VarForTime<IConstVarRef>() != null) ? this.VarForTime<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.VarForTime.Value = ((this.VarForTime<IGlobalVarRef>() != null) ? this.VarForTime<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.VarForTime.Value = ((this.VarForTime<IOtherVarRef>() != null) ? this.VarForTime<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.VarForTime.Value = ((this.VarForTime<ISelfVarRef>() != null) ? this.VarForTime<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.VarForTime.Value = ((this.VarForTime<ISystemVarRef>() != null) ? this.VarForTime<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.TimerType = this.TimerType;
			_o.UiConfig = ((this.UiConfig != null) ? this.UiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018D97 RID: 101783 RVA: 0x003936B4 File Offset: 0x003918B4
		public static Offset<ITimerQuestCondition> Pack(FlatBufferBuilder builder, ITimerQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimerQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TVarRef varForTime_type = (_o.VarForTime == null) ? TVarRef.NONE : _o.VarForTime.Type;
			int varForTimeOffset = (_o.VarForTime == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarForTime);
			Offset<ITimerUiConfig> uiConfigOffset = (_o.UiConfig == null) ? default(Offset<ITimerUiConfig>) : ITimerUiConfig.Pack(builder, _o.UiConfig);
			return ITimerQuestCondition.CreateITimerQuestCondition(builder, _o.Type, preConditionsOffset, _o.Time, varForTime_type, varForTimeOffset, _o.TimerType, uiConfigOffset, _o.NullMask);
		}

		// Token: 0x0400BE28 RID: 48680
		private Table __p;
	}
}
