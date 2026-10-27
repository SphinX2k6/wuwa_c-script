using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006137 RID: 24887
	public struct IAddTime : IFlatbufferObject
	{
		// Token: 0x1700B77D RID: 46973
		// (get) Token: 0x0602A8DD RID: 174301 RVA: 0x005DC03B File Offset: 0x005DA23B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A8DE RID: 174302 RVA: 0x005DC048 File Offset: 0x005DA248
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A8DF RID: 174303 RVA: 0x005DC050 File Offset: 0x005DA250
		public static IAddTime GetRootAsIAddTime(ByteBuffer _bb)
		{
			return IAddTime.GetRootAsIAddTime(_bb, default(IAddTime));
		}

		// Token: 0x0602A8E0 RID: 174304 RVA: 0x005DC06C File Offset: 0x005DA26C
		public static IAddTime GetRootAsIAddTime(ByteBuffer _bb, IAddTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A8E1 RID: 174305 RVA: 0x005DC089 File Offset: 0x005DA289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A8E2 RID: 174306 RVA: 0x005DC098 File Offset: 0x005DA298
		public IAddTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B77E RID: 46974
		// (get) Token: 0x0602A8E3 RID: 174307 RVA: 0x005DC0A8 File Offset: 0x005DA2A8
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

		// Token: 0x1700B77F RID: 46975
		// (get) Token: 0x0602A8E4 RID: 174308 RVA: 0x005DC0E4 File Offset: 0x005DA2E4
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

		// Token: 0x1700B780 RID: 46976
		// (get) Token: 0x0602A8E5 RID: 174309 RVA: 0x005DC120 File Offset: 0x005DA320
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

		// Token: 0x0602A8E6 RID: 174310 RVA: 0x005DC15C File Offset: 0x005DA35C
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A8E7 RID: 174311 RVA: 0x005DC1A4 File Offset: 0x005DA3A4
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x0602A8E8 RID: 174312 RVA: 0x005DC1C0 File Offset: 0x005DA3C0
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x0602A8E9 RID: 174313 RVA: 0x005DC1DC File Offset: 0x005DA3DC
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x0602A8EA RID: 174314 RVA: 0x005DC1F8 File Offset: 0x005DA3F8
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x0602A8EB RID: 174315 RVA: 0x005DC214 File Offset: 0x005DA414
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x1700B781 RID: 46977
		// (get) Token: 0x0602A8EC RID: 174316 RVA: 0x005DC230 File Offset: 0x005DA430
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

		// Token: 0x1700B782 RID: 46978
		// (get) Token: 0x0602A8ED RID: 174317 RVA: 0x005DC284 File Offset: 0x005DA484
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

		// Token: 0x0602A8EE RID: 174318 RVA: 0x005DC2C4 File Offset: 0x005DA4C4
		public static Offset<IAddTime> CreateIAddTime(FlatBufferBuilder builder, EChangeTimerType Type = EChangeTimerType.Add, int Time = 0, TVarRef VarForTime_type = TVarRef.NONE, int VarForTimeOffset = 0, IChangeTimerUiConfigT UiConfig = null, byte NullMask = 0)
		{
			builder.StartTable(6);
			IAddTime.AddUiConfig(builder, IChangeTimerUiConfig.Pack(builder, UiConfig));
			IAddTime.AddVarForTime(builder, VarForTimeOffset);
			IAddTime.AddTime(builder, Time);
			IAddTime.AddNullMask(builder, NullMask);
			IAddTime.AddVarForTimeType(builder, VarForTime_type);
			IAddTime.AddType(builder, Type);
			return IAddTime.EndIAddTime(builder);
		}

		// Token: 0x0602A8EF RID: 174319 RVA: 0x005DC311 File Offset: 0x005DA511
		public static void StartIAddTime(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A8F0 RID: 174320 RVA: 0x005DC31A File Offset: 0x005DA51A
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A8F1 RID: 174321 RVA: 0x005DC325 File Offset: 0x005DA525
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x0602A8F2 RID: 174322 RVA: 0x005DC330 File Offset: 0x005DA530
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(2, (byte)varForTimeType, 0);
		}

		// Token: 0x0602A8F3 RID: 174323 RVA: 0x005DC33B File Offset: 0x005DA53B
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(3, varForTimeOffset, 0);
		}

		// Token: 0x0602A8F4 RID: 174324 RVA: 0x005DC346 File Offset: 0x005DA546
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IChangeTimerUiConfig> uiConfigOffset)
		{
			builder.AddStruct(4, uiConfigOffset.Value, 0);
		}

		// Token: 0x0602A8F5 RID: 174325 RVA: 0x005DC356 File Offset: 0x005DA556
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A8F6 RID: 174326 RVA: 0x005DC361 File Offset: 0x005DA561
		public static Offset<IAddTime> EndIAddTime(FlatBufferBuilder builder)
		{
			return new Offset<IAddTime>(builder.EndTable());
		}

		// Token: 0x0602A8F7 RID: 174327 RVA: 0x005DC370 File Offset: 0x005DA570
		public IAddTimeT UnPack()
		{
			IAddTimeT addTimeT = new IAddTimeT();
			this.UnPackTo(addTimeT);
			return addTimeT;
		}

		// Token: 0x0602A8F8 RID: 174328 RVA: 0x005DC38C File Offset: 0x005DA58C
		public void UnPackTo(IAddTimeT _o)
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

		// Token: 0x0602A8F9 RID: 174329 RVA: 0x005DC550 File Offset: 0x005DA750
		public static Offset<IAddTime> Pack(FlatBufferBuilder builder, IAddTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTime>);
			}
			TVarRef varForTime_type = (_o.VarForTime == null) ? TVarRef.NONE : _o.VarForTime.Type;
			int varForTimeOffset = (_o.VarForTime == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarForTime);
			return IAddTime.CreateIAddTime(builder, _o.Type, _o.Time, varForTime_type, varForTimeOffset, _o.UiConfig, _o.NullMask);
		}

		// Token: 0x04010515 RID: 66837
		private Table __p;
	}
}
