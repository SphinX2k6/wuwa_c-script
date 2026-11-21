using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004631 RID: 17969
	public struct ITimerConfig : IFlatbufferObject
	{
		// Token: 0x17007DAD RID: 32173
		// (get) Token: 0x0601A4A4 RID: 107684 RVA: 0x003BDE17 File Offset: 0x003BC017
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4A5 RID: 107685 RVA: 0x003BDE24 File Offset: 0x003BC024
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A4A6 RID: 107686 RVA: 0x003BDE2C File Offset: 0x003BC02C
		public static ITimerConfig GetRootAsITimerConfig(ByteBuffer _bb)
		{
			return ITimerConfig.GetRootAsITimerConfig(_bb, default(ITimerConfig));
		}

		// Token: 0x0601A4A7 RID: 107687 RVA: 0x003BDE48 File Offset: 0x003BC048
		public static ITimerConfig GetRootAsITimerConfig(ByteBuffer _bb, ITimerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A4A8 RID: 107688 RVA: 0x003BDE65 File Offset: 0x003BC065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A4A9 RID: 107689 RVA: 0x003BDE74 File Offset: 0x003BC074
		public ITimerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DAE RID: 32174
		// (get) Token: 0x0601A4AA RID: 107690 RVA: 0x003BDE84 File Offset: 0x003BC084
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

		// Token: 0x17007DAF RID: 32175
		// (get) Token: 0x0601A4AB RID: 107691 RVA: 0x003BDEC0 File Offset: 0x003BC0C0
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

		// Token: 0x0601A4AC RID: 107692 RVA: 0x003BDEFC File Offset: 0x003BC0FC
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A4AD RID: 107693 RVA: 0x003BDF40 File Offset: 0x003BC140
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x0601A4AE RID: 107694 RVA: 0x003BDF5C File Offset: 0x003BC15C
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x0601A4AF RID: 107695 RVA: 0x003BDF78 File Offset: 0x003BC178
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x0601A4B0 RID: 107696 RVA: 0x003BDF94 File Offset: 0x003BC194
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x0601A4B1 RID: 107697 RVA: 0x003BDFB0 File Offset: 0x003BC1B0
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x17007DB0 RID: 32176
		// (get) Token: 0x0601A4B2 RID: 107698 RVA: 0x003BDFCC File Offset: 0x003BC1CC
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

		// Token: 0x17007DB1 RID: 32177
		// (get) Token: 0x0601A4B3 RID: 107699 RVA: 0x003BE00C File Offset: 0x003BC20C
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

		// Token: 0x17007DB2 RID: 32178
		// (get) Token: 0x0601A4B4 RID: 107700 RVA: 0x003BE06C File Offset: 0x003BC26C
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

		// Token: 0x0601A4B5 RID: 107701 RVA: 0x003BE0A9 File Offset: 0x003BC2A9
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

		// Token: 0x0601A4B6 RID: 107702 RVA: 0x003BE0E5 File Offset: 0x003BC2E5
		public static void StartITimerConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A4B7 RID: 107703 RVA: 0x003BE0EE File Offset: 0x003BC2EE
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x0601A4B8 RID: 107704 RVA: 0x003BE0F9 File Offset: 0x003BC2F9
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(1, (byte)varForTimeType, 0);
		}

		// Token: 0x0601A4B9 RID: 107705 RVA: 0x003BE104 File Offset: 0x003BC304
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(2, varForTimeOffset, 0);
		}

		// Token: 0x0601A4BA RID: 107706 RVA: 0x003BE10F File Offset: 0x003BC30F
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(3, (byte)timerType, 0);
		}

		// Token: 0x0601A4BB RID: 107707 RVA: 0x003BE11A File Offset: 0x003BC31A
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<ITimerUiConfig> uiConfigOffset)
		{
			builder.AddOffset(4, uiConfigOffset.Value, 0);
		}

		// Token: 0x0601A4BC RID: 107708 RVA: 0x003BE12A File Offset: 0x003BC32A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601A4BD RID: 107709 RVA: 0x003BE135 File Offset: 0x003BC335
		public static Offset<ITimerConfig> EndITimerConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimerConfig>(builder.EndTable());
		}

		// Token: 0x0601A4BE RID: 107710 RVA: 0x003BE144 File Offset: 0x003BC344
		public ITimerConfigT UnPack()
		{
			ITimerConfigT timerConfigT = new ITimerConfigT();
			this.UnPackTo(timerConfigT);
			return timerConfigT;
		}

		// Token: 0x0601A4BF RID: 107711 RVA: 0x003BE160 File Offset: 0x003BC360
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

		// Token: 0x0601A4C0 RID: 107712 RVA: 0x003BE324 File Offset: 0x003BC524
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

		// Token: 0x0400C82C RID: 51244
		private Table __p;
	}
}
