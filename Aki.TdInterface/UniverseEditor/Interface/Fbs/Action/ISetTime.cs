using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007091 RID: 28817
	public struct ISetTime : IFlatbufferObject
	{
		// Token: 0x1700D61F RID: 54815
		// (get) Token: 0x06033065 RID: 208997 RVA: 0x006E1EB0 File Offset: 0x006E00B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033066 RID: 208998 RVA: 0x006E1EBD File Offset: 0x006E00BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033067 RID: 208999 RVA: 0x006E1EC4 File Offset: 0x006E00C4
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb)
		{
			return ISetTime.GetRootAsISetTime(_bb, default(ISetTime));
		}

		// Token: 0x06033068 RID: 209000 RVA: 0x006E1EE0 File Offset: 0x006E00E0
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb, ISetTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033069 RID: 209001 RVA: 0x006E1EFD File Offset: 0x006E00FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603306A RID: 209002 RVA: 0x006E1F0C File Offset: 0x006E010C
		public ISetTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D620 RID: 54816
		// (get) Token: 0x0603306B RID: 209003 RVA: 0x006E1F1C File Offset: 0x006E011C
		public EChangeTimerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeTimerType.Add;
				}
				return (EChangeTimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D621 RID: 54817
		// (get) Token: 0x0603306C RID: 209004 RVA: 0x006E1F58 File Offset: 0x006E0158
		public int Time
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

		// Token: 0x1700D622 RID: 54818
		// (get) Token: 0x0603306D RID: 209005 RVA: 0x006E1F94 File Offset: 0x006E0194
		public TVarRef VarForTimeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603306E RID: 209006 RVA: 0x006E1FD0 File Offset: 0x006E01D0
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603306F RID: 209007 RVA: 0x006E2018 File Offset: 0x006E0218
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x06033070 RID: 209008 RVA: 0x006E2034 File Offset: 0x006E0234
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x06033071 RID: 209009 RVA: 0x006E2050 File Offset: 0x006E0250
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x06033072 RID: 209010 RVA: 0x006E206C File Offset: 0x006E026C
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x06033073 RID: 209011 RVA: 0x006E2088 File Offset: 0x006E0288
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x1700D623 RID: 54819
		// (get) Token: 0x06033074 RID: 209012 RVA: 0x006E20A4 File Offset: 0x006E02A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033075 RID: 209013 RVA: 0x006E20E1 File Offset: 0x006E02E1
		public static Offset<ISetTime> CreateISetTime(FlatBufferBuilder builder, EChangeTimerType Type = EChangeTimerType.Add, int Time = 0, TVarRef VarForTime_type = TVarRef.NONE, int VarForTimeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISetTime.AddVarForTime(builder, VarForTimeOffset);
			ISetTime.AddTime(builder, Time);
			ISetTime.AddNullMask(builder, NullMask);
			ISetTime.AddVarForTimeType(builder, VarForTime_type);
			ISetTime.AddType(builder, Type);
			return ISetTime.EndISetTime(builder);
		}

		// Token: 0x06033076 RID: 209014 RVA: 0x006E2115 File Offset: 0x006E0315
		public static void StartISetTime(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033077 RID: 209015 RVA: 0x006E211E File Offset: 0x006E031E
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033078 RID: 209016 RVA: 0x006E2129 File Offset: 0x006E0329
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x06033079 RID: 209017 RVA: 0x006E2134 File Offset: 0x006E0334
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(2, (byte)varForTimeType, 0);
		}

		// Token: 0x0603307A RID: 209018 RVA: 0x006E213F File Offset: 0x006E033F
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(3, varForTimeOffset, 0);
		}

		// Token: 0x0603307B RID: 209019 RVA: 0x006E214A File Offset: 0x006E034A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603307C RID: 209020 RVA: 0x006E2155 File Offset: 0x006E0355
		public static Offset<ISetTime> EndISetTime(FlatBufferBuilder builder)
		{
			return new Offset<ISetTime>(builder.EndTable());
		}

		// Token: 0x0603307D RID: 209021 RVA: 0x006E2164 File Offset: 0x006E0364
		public ISetTimeT UnPack()
		{
			ISetTimeT setTimeT = new ISetTimeT();
			this.UnPackTo(setTimeT);
			return setTimeT;
		}

		// Token: 0x0603307E RID: 209022 RVA: 0x006E2180 File Offset: 0x006E0380
		public void UnPackTo(ISetTimeT _o)
		{
			_o.Type = this.Type;
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603307F RID: 209023 RVA: 0x006E2314 File Offset: 0x006E0514
		public static Offset<ISetTime> Pack(FlatBufferBuilder builder, ISetTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTime>);
			}
			TVarRef varForTime_type = (_o.VarForTime == null) ? TVarRef.NONE : _o.VarForTime.Type;
			int varForTimeOffset = (_o.VarForTime == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarForTime);
			return ISetTime.CreateISetTime(builder, _o.Type, _o.Time, varForTime_type, varForTimeOffset, _o.NullMask);
		}

		// Token: 0x04011AFB RID: 72443
		private Table __p;
	}
}
