using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004634 RID: 17972
	public struct ITimerQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007DB8 RID: 32184
		// (get) Token: 0x0601A4CD RID: 107725 RVA: 0x003BE4DD File Offset: 0x003BC6DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4CE RID: 107726 RVA: 0x003BE4EA File Offset: 0x003BC6EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A4CF RID: 107727 RVA: 0x003BE4F4 File Offset: 0x003BC6F4
		public static ITimerQuestCondition GetRootAsITimerQuestCondition(ByteBuffer _bb)
		{
			return ITimerQuestCondition.GetRootAsITimerQuestCondition(_bb, default(ITimerQuestCondition));
		}

		// Token: 0x0601A4D0 RID: 107728 RVA: 0x003BE510 File Offset: 0x003BC710
		public static ITimerQuestCondition GetRootAsITimerQuestCondition(ByteBuffer _bb, ITimerQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A4D1 RID: 107729 RVA: 0x003BE52D File Offset: 0x003BC72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A4D2 RID: 107730 RVA: 0x003BE53C File Offset: 0x003BC73C
		public ITimerQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DB9 RID: 32185
		// (get) Token: 0x0601A4D3 RID: 107731 RVA: 0x003BE54C File Offset: 0x003BC74C
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

		// Token: 0x17007DBA RID: 32186
		// (get) Token: 0x0601A4D4 RID: 107732 RVA: 0x003BE588 File Offset: 0x003BC788
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

		// Token: 0x17007DBB RID: 32187
		// (get) Token: 0x0601A4D5 RID: 107733 RVA: 0x003BE5E8 File Offset: 0x003BC7E8
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

		// Token: 0x17007DBC RID: 32188
		// (get) Token: 0x0601A4D6 RID: 107734 RVA: 0x003BE624 File Offset: 0x003BC824
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

		// Token: 0x0601A4D7 RID: 107735 RVA: 0x003BE664 File Offset: 0x003BC864
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A4D8 RID: 107736 RVA: 0x003BE6AC File Offset: 0x003BC8AC
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x0601A4D9 RID: 107737 RVA: 0x003BE6C8 File Offset: 0x003BC8C8
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x0601A4DA RID: 107738 RVA: 0x003BE6E4 File Offset: 0x003BC8E4
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x0601A4DB RID: 107739 RVA: 0x003BE700 File Offset: 0x003BC900
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x0601A4DC RID: 107740 RVA: 0x003BE71C File Offset: 0x003BC91C
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x17007DBD RID: 32189
		// (get) Token: 0x0601A4DD RID: 107741 RVA: 0x003BE738 File Offset: 0x003BC938
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

		// Token: 0x17007DBE RID: 32190
		// (get) Token: 0x0601A4DE RID: 107742 RVA: 0x003BE778 File Offset: 0x003BC978
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

		// Token: 0x17007DBF RID: 32191
		// (get) Token: 0x0601A4DF RID: 107743 RVA: 0x003BE7D8 File Offset: 0x003BC9D8
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

		// Token: 0x0601A4E0 RID: 107744 RVA: 0x003BE818 File Offset: 0x003BCA18
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

		// Token: 0x0601A4E1 RID: 107745 RVA: 0x003BE86F File Offset: 0x003BCA6F
		public static void StartITimerQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601A4E2 RID: 107746 RVA: 0x003BE878 File Offset: 0x003BCA78
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A4E3 RID: 107747 RVA: 0x003BE883 File Offset: 0x003BCA83
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A4E4 RID: 107748 RVA: 0x003BE893 File Offset: 0x003BCA93
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(2, time, 0);
		}

		// Token: 0x0601A4E5 RID: 107749 RVA: 0x003BE89E File Offset: 0x003BCA9E
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(3, (byte)varForTimeType, 0);
		}

		// Token: 0x0601A4E6 RID: 107750 RVA: 0x003BE8A9 File Offset: 0x003BCAA9
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(4, varForTimeOffset, 0);
		}

		// Token: 0x0601A4E7 RID: 107751 RVA: 0x003BE8B4 File Offset: 0x003BCAB4
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(5, (byte)timerType, 0);
		}

		// Token: 0x0601A4E8 RID: 107752 RVA: 0x003BE8BF File Offset: 0x003BCABF
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<ITimerUiConfig> uiConfigOffset)
		{
			builder.AddOffset(6, uiConfigOffset.Value, 0);
		}

		// Token: 0x0601A4E9 RID: 107753 RVA: 0x003BE8CF File Offset: 0x003BCACF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601A4EA RID: 107754 RVA: 0x003BE8DA File Offset: 0x003BCADA
		public static Offset<ITimerQuestCondition> EndITimerQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITimerQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601A4EB RID: 107755 RVA: 0x003BE8E8 File Offset: 0x003BCAE8
		public ITimerQuestConditionT UnPack()
		{
			ITimerQuestConditionT timerQuestConditionT = new ITimerQuestConditionT();
			this.UnPackTo(timerQuestConditionT);
			return timerQuestConditionT;
		}

		// Token: 0x0601A4EC RID: 107756 RVA: 0x003BE904 File Offset: 0x003BCB04
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

		// Token: 0x0601A4ED RID: 107757 RVA: 0x003BEB08 File Offset: 0x003BCD08
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

		// Token: 0x0400C832 RID: 51250
		private Table __p;
	}
}
