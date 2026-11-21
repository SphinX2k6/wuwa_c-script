using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200785D RID: 30813
	public struct ISetTime : IFlatbufferObject
	{
		// Token: 0x1700E202 RID: 57858
		// (get) Token: 0x06036307 RID: 221959 RVA: 0x007424BC File Offset: 0x007406BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036308 RID: 221960 RVA: 0x007424C9 File Offset: 0x007406C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036309 RID: 221961 RVA: 0x007424D0 File Offset: 0x007406D0
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb)
		{
			return ISetTime.GetRootAsISetTime(_bb, default(ISetTime));
		}

		// Token: 0x0603630A RID: 221962 RVA: 0x007424EC File Offset: 0x007406EC
		public static ISetTime GetRootAsISetTime(ByteBuffer _bb, ISetTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603630B RID: 221963 RVA: 0x00742509 File Offset: 0x00740709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603630C RID: 221964 RVA: 0x00742518 File Offset: 0x00740718
		public ISetTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E203 RID: 57859
		// (get) Token: 0x0603630D RID: 221965 RVA: 0x00742528 File Offset: 0x00740728
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

		// Token: 0x1700E204 RID: 57860
		// (get) Token: 0x0603630E RID: 221966 RVA: 0x00742564 File Offset: 0x00740764
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

		// Token: 0x1700E205 RID: 57861
		// (get) Token: 0x0603630F RID: 221967 RVA: 0x007425A0 File Offset: 0x007407A0
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

		// Token: 0x06036310 RID: 221968 RVA: 0x007425DC File Offset: 0x007407DC
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036311 RID: 221969 RVA: 0x00742624 File Offset: 0x00740824
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x06036312 RID: 221970 RVA: 0x00742640 File Offset: 0x00740840
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x06036313 RID: 221971 RVA: 0x0074265C File Offset: 0x0074085C
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x06036314 RID: 221972 RVA: 0x00742678 File Offset: 0x00740878
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x06036315 RID: 221973 RVA: 0x00742694 File Offset: 0x00740894
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x1700E206 RID: 57862
		// (get) Token: 0x06036316 RID: 221974 RVA: 0x007426B0 File Offset: 0x007408B0
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

		// Token: 0x06036317 RID: 221975 RVA: 0x007426ED File Offset: 0x007408ED
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

		// Token: 0x06036318 RID: 221976 RVA: 0x00742721 File Offset: 0x00740921
		public static void StartISetTime(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06036319 RID: 221977 RVA: 0x0074272A File Offset: 0x0074092A
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603631A RID: 221978 RVA: 0x00742735 File Offset: 0x00740935
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x0603631B RID: 221979 RVA: 0x00742740 File Offset: 0x00740940
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(2, (byte)varForTimeType, 0);
		}

		// Token: 0x0603631C RID: 221980 RVA: 0x0074274B File Offset: 0x0074094B
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(3, varForTimeOffset, 0);
		}

		// Token: 0x0603631D RID: 221981 RVA: 0x00742756 File Offset: 0x00740956
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603631E RID: 221982 RVA: 0x00742761 File Offset: 0x00740961
		public static Offset<ISetTime> EndISetTime(FlatBufferBuilder builder)
		{
			return new Offset<ISetTime>(builder.EndTable());
		}

		// Token: 0x0603631F RID: 221983 RVA: 0x00742770 File Offset: 0x00740970
		public ISetTimeT UnPack()
		{
			ISetTimeT setTimeT = new ISetTimeT();
			this.UnPackTo(setTimeT);
			return setTimeT;
		}

		// Token: 0x06036320 RID: 221984 RVA: 0x0074278C File Offset: 0x0074098C
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

		// Token: 0x06036321 RID: 221985 RVA: 0x00742920 File Offset: 0x00740B20
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

		// Token: 0x04012AE9 RID: 76521
		private Table __p;
	}
}
