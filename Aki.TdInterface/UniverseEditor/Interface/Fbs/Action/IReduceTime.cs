using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007597 RID: 30103
	public struct IReduceTime : IFlatbufferObject
	{
		// Token: 0x1700DD61 RID: 56673
		// (get) Token: 0x06034CD6 RID: 216278 RVA: 0x0071970C File Offset: 0x0071790C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034CD7 RID: 216279 RVA: 0x00719719 File Offset: 0x00717919
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034CD8 RID: 216280 RVA: 0x00719720 File Offset: 0x00717920
		public static IReduceTime GetRootAsIReduceTime(ByteBuffer _bb)
		{
			return IReduceTime.GetRootAsIReduceTime(_bb, default(IReduceTime));
		}

		// Token: 0x06034CD9 RID: 216281 RVA: 0x0071973C File Offset: 0x0071793C
		public static IReduceTime GetRootAsIReduceTime(ByteBuffer _bb, IReduceTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034CDA RID: 216282 RVA: 0x00719759 File Offset: 0x00717959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034CDB RID: 216283 RVA: 0x00719768 File Offset: 0x00717968
		public IReduceTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD62 RID: 56674
		// (get) Token: 0x06034CDC RID: 216284 RVA: 0x00719778 File Offset: 0x00717978
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

		// Token: 0x1700DD63 RID: 56675
		// (get) Token: 0x06034CDD RID: 216285 RVA: 0x007197B4 File Offset: 0x007179B4
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

		// Token: 0x1700DD64 RID: 56676
		// (get) Token: 0x06034CDE RID: 216286 RVA: 0x007197F0 File Offset: 0x007179F0
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

		// Token: 0x06034CDF RID: 216287 RVA: 0x0071982C File Offset: 0x00717A2C
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034CE0 RID: 216288 RVA: 0x00719874 File Offset: 0x00717A74
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x06034CE1 RID: 216289 RVA: 0x00719890 File Offset: 0x00717A90
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x06034CE2 RID: 216290 RVA: 0x007198AC File Offset: 0x00717AAC
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x06034CE3 RID: 216291 RVA: 0x007198C8 File Offset: 0x00717AC8
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x06034CE4 RID: 216292 RVA: 0x007198E4 File Offset: 0x00717AE4
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x1700DD65 RID: 56677
		// (get) Token: 0x06034CE5 RID: 216293 RVA: 0x00719900 File Offset: 0x00717B00
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

		// Token: 0x1700DD66 RID: 56678
		// (get) Token: 0x06034CE6 RID: 216294 RVA: 0x00719954 File Offset: 0x00717B54
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

		// Token: 0x06034CE7 RID: 216295 RVA: 0x00719994 File Offset: 0x00717B94
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

		// Token: 0x06034CE8 RID: 216296 RVA: 0x007199E1 File Offset: 0x00717BE1
		public static void StartIReduceTime(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06034CE9 RID: 216297 RVA: 0x007199EA File Offset: 0x00717BEA
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034CEA RID: 216298 RVA: 0x007199F5 File Offset: 0x00717BF5
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x06034CEB RID: 216299 RVA: 0x00719A00 File Offset: 0x00717C00
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(2, (byte)varForTimeType, 0);
		}

		// Token: 0x06034CEC RID: 216300 RVA: 0x00719A0B File Offset: 0x00717C0B
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(3, varForTimeOffset, 0);
		}

		// Token: 0x06034CED RID: 216301 RVA: 0x00719A16 File Offset: 0x00717C16
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IChangeTimerUiConfig> uiConfigOffset)
		{
			builder.AddStruct(4, uiConfigOffset.Value, 0);
		}

		// Token: 0x06034CEE RID: 216302 RVA: 0x00719A26 File Offset: 0x00717C26
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06034CEF RID: 216303 RVA: 0x00719A31 File Offset: 0x00717C31
		public static Offset<IReduceTime> EndIReduceTime(FlatBufferBuilder builder)
		{
			return new Offset<IReduceTime>(builder.EndTable());
		}

		// Token: 0x06034CF0 RID: 216304 RVA: 0x00719A40 File Offset: 0x00717C40
		public IReduceTimeT UnPack()
		{
			IReduceTimeT reduceTimeT = new IReduceTimeT();
			this.UnPackTo(reduceTimeT);
			return reduceTimeT;
		}

		// Token: 0x06034CF1 RID: 216305 RVA: 0x00719A5C File Offset: 0x00717C5C
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

		// Token: 0x06034CF2 RID: 216306 RVA: 0x00719C20 File Offset: 0x00717E20
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

		// Token: 0x04012780 RID: 75648
		private Table __p;
	}
}
