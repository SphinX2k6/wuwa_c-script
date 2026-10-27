using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E19 RID: 28185
	public struct IReduceTime : IFlatbufferObject
	{
		// Token: 0x1700D212 RID: 53778
		// (get) Token: 0x06031CC0 RID: 203968 RVA: 0x006BDD81 File Offset: 0x006BBF81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CC1 RID: 203969 RVA: 0x006BDD8E File Offset: 0x006BBF8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031CC2 RID: 203970 RVA: 0x006BDD98 File Offset: 0x006BBF98
		public static IReduceTime GetRootAsIReduceTime(ByteBuffer _bb)
		{
			return IReduceTime.GetRootAsIReduceTime(_bb, default(IReduceTime));
		}

		// Token: 0x06031CC3 RID: 203971 RVA: 0x006BDDB4 File Offset: 0x006BBFB4
		public static IReduceTime GetRootAsIReduceTime(ByteBuffer _bb, IReduceTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031CC4 RID: 203972 RVA: 0x006BDDD1 File Offset: 0x006BBFD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031CC5 RID: 203973 RVA: 0x006BDDE0 File Offset: 0x006BBFE0
		public IReduceTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D213 RID: 53779
		// (get) Token: 0x06031CC6 RID: 203974 RVA: 0x006BDDF0 File Offset: 0x006BBFF0
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

		// Token: 0x1700D214 RID: 53780
		// (get) Token: 0x06031CC7 RID: 203975 RVA: 0x006BDE2C File Offset: 0x006BC02C
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

		// Token: 0x1700D215 RID: 53781
		// (get) Token: 0x06031CC8 RID: 203976 RVA: 0x006BDE68 File Offset: 0x006BC068
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

		// Token: 0x06031CC9 RID: 203977 RVA: 0x006BDEA4 File Offset: 0x006BC0A4
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031CCA RID: 203978 RVA: 0x006BDEEC File Offset: 0x006BC0EC
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x06031CCB RID: 203979 RVA: 0x006BDF08 File Offset: 0x006BC108
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x06031CCC RID: 203980 RVA: 0x006BDF24 File Offset: 0x006BC124
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x06031CCD RID: 203981 RVA: 0x006BDF40 File Offset: 0x006BC140
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x06031CCE RID: 203982 RVA: 0x006BDF5C File Offset: 0x006BC15C
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x1700D216 RID: 53782
		// (get) Token: 0x06031CCF RID: 203983 RVA: 0x006BDF78 File Offset: 0x006BC178
		public IChangeTimerUiConfig? UiConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IChangeTimerUiConfig?(default(IChangeTimerUiConfig).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700D217 RID: 53783
		// (get) Token: 0x06031CD0 RID: 203984 RVA: 0x006BDFCC File Offset: 0x006BC1CC
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

		// Token: 0x06031CD1 RID: 203985 RVA: 0x006BE00C File Offset: 0x006BC20C
		public static Offset<IReduceTime> CreateIReduceTime(FlatBufferBuilder builder, EChangeTimerType Type = EChangeTimerType.Add, int Time = 0, TVarRef VarForTime_type = TVarRef.NONE, int VarForTimeOffset = 0, IChangeTimerUiConfigT UiConfig = null, byte NullMask = 0)
		{
			builder.StartTable(6);
			IReduceTime.AddUiConfig(builder, IChangeTimerUiConfig.Pack(builder, UiConfig));
			IReduceTime.AddVarForTime(builder, VarForTimeOffset);
			IReduceTime.AddTime(builder, Time);
			IReduceTime.AddNullMask(builder, NullMask);
			IReduceTime.AddVarForTimeType(builder, VarForTime_type);
			IReduceTime.AddType(builder, Type);
			return IReduceTime.EndIReduceTime(builder);
		}

		// Token: 0x06031CD2 RID: 203986 RVA: 0x006BE059 File Offset: 0x006BC259
		public static void StartIReduceTime(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06031CD3 RID: 203987 RVA: 0x006BE062 File Offset: 0x006BC262
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031CD4 RID: 203988 RVA: 0x006BE06D File Offset: 0x006BC26D
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x06031CD5 RID: 203989 RVA: 0x006BE078 File Offset: 0x006BC278
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(2, (byte)varForTimeType, 0);
		}

		// Token: 0x06031CD6 RID: 203990 RVA: 0x006BE083 File Offset: 0x006BC283
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(3, varForTimeOffset, 0);
		}

		// Token: 0x06031CD7 RID: 203991 RVA: 0x006BE08E File Offset: 0x006BC28E
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IChangeTimerUiConfig> uiConfigOffset)
		{
			builder.AddStruct(4, uiConfigOffset.Value, 0);
		}

		// Token: 0x06031CD8 RID: 203992 RVA: 0x006BE09E File Offset: 0x006BC29E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06031CD9 RID: 203993 RVA: 0x006BE0A9 File Offset: 0x006BC2A9
		public static Offset<IReduceTime> EndIReduceTime(FlatBufferBuilder builder)
		{
			return new Offset<IReduceTime>(builder.EndTable());
		}

		// Token: 0x06031CDA RID: 203994 RVA: 0x006BE0B8 File Offset: 0x006BC2B8
		public IReduceTimeT UnPack()
		{
			IReduceTimeT reduceTimeT = new IReduceTimeT();
			this.UnPackTo(reduceTimeT);
			return reduceTimeT;
		}

		// Token: 0x06031CDB RID: 203995 RVA: 0x006BE0D4 File Offset: 0x006BC2D4
		public void UnPackTo(IReduceTimeT _o)
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
			_o.UiConfig = ((this.UiConfig != null) ? this.UiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031CDC RID: 203996 RVA: 0x006BE298 File Offset: 0x006BC498
		public static Offset<IReduceTime> Pack(FlatBufferBuilder builder, IReduceTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReduceTime>);
			}
			TVarRef varForTime_type = (_o.VarForTime == null) ? TVarRef.NONE : _o.VarForTime.Type;
			int varForTimeOffset = (_o.VarForTime == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarForTime);
			return IReduceTime.CreateIReduceTime(builder, _o.Type, _o.Time, varForTime_type, varForTimeOffset, _o.UiConfig, _o.NullMask);
		}

		// Token: 0x04011800 RID: 71680
		private Table __p;
	}
}
