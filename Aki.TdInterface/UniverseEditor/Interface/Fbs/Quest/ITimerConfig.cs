using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D8 RID: 16856
	public struct ITimerConfig : IFlatbufferObject
	{
		// Token: 0x17007781 RID: 30593
		// (get) Token: 0x06018D4E RID: 101710 RVA: 0x003929C3 File Offset: 0x00390BC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D4F RID: 101711 RVA: 0x003929D0 File Offset: 0x00390BD0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D50 RID: 101712 RVA: 0x003929D8 File Offset: 0x00390BD8
		public static ITimerConfig GetRootAsITimerConfig(ByteBuffer _bb)
		{
			return ITimerConfig.GetRootAsITimerConfig(_bb, default(ITimerConfig));
		}

		// Token: 0x06018D51 RID: 101713 RVA: 0x003929F4 File Offset: 0x00390BF4
		public static ITimerConfig GetRootAsITimerConfig(ByteBuffer _bb, ITimerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D52 RID: 101714 RVA: 0x00392A11 File Offset: 0x00390C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D53 RID: 101715 RVA: 0x00392A20 File Offset: 0x00390C20
		public ITimerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007782 RID: 30594
		// (get) Token: 0x06018D54 RID: 101716 RVA: 0x00392A30 File Offset: 0x00390C30
		public int Time
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

		// Token: 0x17007783 RID: 30595
		// (get) Token: 0x06018D55 RID: 101717 RVA: 0x00392A6C File Offset: 0x00390C6C
		public TVarRef VarForTimeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018D56 RID: 101718 RVA: 0x00392AA8 File Offset: 0x00390CA8
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018D57 RID: 101719 RVA: 0x00392AEC File Offset: 0x00390CEC
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x06018D58 RID: 101720 RVA: 0x00392B08 File Offset: 0x00390D08
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x06018D59 RID: 101721 RVA: 0x00392B24 File Offset: 0x00390D24
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x06018D5A RID: 101722 RVA: 0x00392B40 File Offset: 0x00390D40
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x06018D5B RID: 101723 RVA: 0x00392B5C File Offset: 0x00390D5C
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x17007784 RID: 30596
		// (get) Token: 0x06018D5C RID: 101724 RVA: 0x00392B78 File Offset: 0x00390D78
		public ETimerType TimerType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ETimerType.CountDownChallenge;
				}
				return (ETimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007785 RID: 30597
		// (get) Token: 0x06018D5D RID: 101725 RVA: 0x00392BB8 File Offset: 0x00390DB8
		public ITimerUiConfig? UiConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITimerUiConfig?(default(ITimerUiConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007786 RID: 30598
		// (get) Token: 0x06018D5E RID: 101726 RVA: 0x00392C18 File Offset: 0x00390E18
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

		// Token: 0x06018D5F RID: 101727 RVA: 0x00392C55 File Offset: 0x00390E55
		public static Offset<ITimerConfig> CreateITimerConfig(FlatBufferBuilder builder, int Time = 0, TVarRef VarForTime_type = TVarRef.NONE, int VarForTimeOffset = 0, ETimerType TimerType = ETimerType.CountDownChallenge, Offset<ITimerUiConfig> UiConfigOffset = default(Offset<ITimerUiConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ITimerConfig.AddUiConfig(builder, UiConfigOffset);
			ITimerConfig.AddVarForTime(builder, VarForTimeOffset);
			ITimerConfig.AddTime(builder, Time);
			ITimerConfig.AddNullMask(builder, NullMask);
			ITimerConfig.AddTimerType(builder, TimerType);
			ITimerConfig.AddVarForTimeType(builder, VarForTime_type);
			return ITimerConfig.EndITimerConfig(builder);
		}

		// Token: 0x06018D60 RID: 101728 RVA: 0x00392C91 File Offset: 0x00390E91
		public static void StartITimerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018D61 RID: 101729 RVA: 0x00392C9A File Offset: 0x00390E9A
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x06018D62 RID: 101730 RVA: 0x00392CA5 File Offset: 0x00390EA5
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(1, (byte)varForTimeType, 0);
		}

		// Token: 0x06018D63 RID: 101731 RVA: 0x00392CB0 File Offset: 0x00390EB0
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(2, varForTimeOffset, 0);
		}

		// Token: 0x06018D64 RID: 101732 RVA: 0x00392CBB File Offset: 0x00390EBB
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(3, (byte)timerType, 0);
		}

		// Token: 0x06018D65 RID: 101733 RVA: 0x00392CC6 File Offset: 0x00390EC6
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<ITimerUiConfig> uiConfigOffset)
		{
			builder.AddOffset(4, uiConfigOffset.Value, 0);
		}

		// Token: 0x06018D66 RID: 101734 RVA: 0x00392CD6 File Offset: 0x00390ED6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06018D67 RID: 101735 RVA: 0x00392CE1 File Offset: 0x00390EE1
		public static Offset<ITimerConfig> EndITimerConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimerConfig>(builder.EndTable());
		}

		// Token: 0x06018D68 RID: 101736 RVA: 0x00392CF0 File Offset: 0x00390EF0
		public ITimerConfigT UnPack()
		{
			ITimerConfigT timerConfigT = new ITimerConfigT();
			this.UnPackTo(timerConfigT);
			return timerConfigT;
		}

		// Token: 0x06018D69 RID: 101737 RVA: 0x00392D0C File Offset: 0x00390F0C
		public void UnPackTo(ITimerConfigT _o)
		{
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

		// Token: 0x06018D6A RID: 101738 RVA: 0x00392ED0 File Offset: 0x003910D0
		public static Offset<ITimerConfig> Pack(FlatBufferBuilder builder, ITimerConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimerConfig>);
			}
			TVarRef varForTime_type = (_o.VarForTime == null) ? TVarRef.NONE : _o.VarForTime.Type;
			int varForTimeOffset = (_o.VarForTime == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarForTime);
			Offset<ITimerUiConfig> uiConfigOffset = (_o.UiConfig == null) ? default(Offset<ITimerUiConfig>) : ITimerUiConfig.Pack(builder, _o.UiConfig);
			return ITimerConfig.CreateITimerConfig(builder, _o.Time, varForTime_type, varForTimeOffset, _o.TimerType, uiConfigOffset, _o.NullMask);
		}

		// Token: 0x0400BE22 RID: 48674
		private Table __p;
	}
}
