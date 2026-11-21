using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679C RID: 26524
	public struct IAddTime : IFlatbufferObject
	{
		// Token: 0x1700C0ED RID: 49389
		// (get) Token: 0x0602CFD6 RID: 184278 RVA: 0x00626217 File Offset: 0x00624417
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CFD7 RID: 184279 RVA: 0x00626224 File Offset: 0x00624424
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CFD8 RID: 184280 RVA: 0x0062622C File Offset: 0x0062442C
		public static IAddTime GetRootAsIAddTime(ByteBuffer _bb)
		{
			return IAddTime.GetRootAsIAddTime(_bb, default(IAddTime));
		}

		// Token: 0x0602CFD9 RID: 184281 RVA: 0x00626248 File Offset: 0x00624448
		public static IAddTime GetRootAsIAddTime(ByteBuffer _bb, IAddTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CFDA RID: 184282 RVA: 0x00626265 File Offset: 0x00624465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CFDB RID: 184283 RVA: 0x00626274 File Offset: 0x00624474
		public IAddTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0EE RID: 49390
		// (get) Token: 0x0602CFDC RID: 184284 RVA: 0x00626284 File Offset: 0x00624484
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

		// Token: 0x1700C0EF RID: 49391
		// (get) Token: 0x0602CFDD RID: 184285 RVA: 0x006262C0 File Offset: 0x006244C0
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

		// Token: 0x1700C0F0 RID: 49392
		// (get) Token: 0x0602CFDE RID: 184286 RVA: 0x006262FC File Offset: 0x006244FC
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

		// Token: 0x0602CFDF RID: 184287 RVA: 0x00626338 File Offset: 0x00624538
		public TTable? VarForTime<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CFE0 RID: 184288 RVA: 0x00626380 File Offset: 0x00624580
		public IConstVarRef VarForTimeAsIConstVarRef()
		{
			return this.VarForTime<IConstVarRef>().Value;
		}

		// Token: 0x0602CFE1 RID: 184289 RVA: 0x0062639C File Offset: 0x0062459C
		public IGlobalVarRef VarForTimeAsIGlobalVarRef()
		{
			return this.VarForTime<IGlobalVarRef>().Value;
		}

		// Token: 0x0602CFE2 RID: 184290 RVA: 0x006263B8 File Offset: 0x006245B8
		public IOtherVarRef VarForTimeAsIOtherVarRef()
		{
			return this.VarForTime<IOtherVarRef>().Value;
		}

		// Token: 0x0602CFE3 RID: 184291 RVA: 0x006263D4 File Offset: 0x006245D4
		public ISelfVarRef VarForTimeAsISelfVarRef()
		{
			return this.VarForTime<ISelfVarRef>().Value;
		}

		// Token: 0x0602CFE4 RID: 184292 RVA: 0x006263F0 File Offset: 0x006245F0
		public ISystemVarRef VarForTimeAsISystemVarRef()
		{
			return this.VarForTime<ISystemVarRef>().Value;
		}

		// Token: 0x1700C0F1 RID: 49393
		// (get) Token: 0x0602CFE5 RID: 184293 RVA: 0x0062640C File Offset: 0x0062460C
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

		// Token: 0x1700C0F2 RID: 49394
		// (get) Token: 0x0602CFE6 RID: 184294 RVA: 0x00626460 File Offset: 0x00624660
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

		// Token: 0x0602CFE7 RID: 184295 RVA: 0x006264A0 File Offset: 0x006246A0
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

		// Token: 0x0602CFE8 RID: 184296 RVA: 0x006264ED File Offset: 0x006246ED
		public static void StartIAddTime(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602CFE9 RID: 184297 RVA: 0x006264F6 File Offset: 0x006246F6
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CFEA RID: 184298 RVA: 0x00626501 File Offset: 0x00624701
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x0602CFEB RID: 184299 RVA: 0x0062650C File Offset: 0x0062470C
		public static void AddVarForTimeType(FlatBufferBuilder builder, TVarRef varForTimeType)
		{
			builder.AddByte(2, (byte)varForTimeType, 0);
		}

		// Token: 0x0602CFEC RID: 184300 RVA: 0x00626517 File Offset: 0x00624717
		public static void AddVarForTime(FlatBufferBuilder builder, int varForTimeOffset)
		{
			builder.AddOffset(3, varForTimeOffset, 0);
		}

		// Token: 0x0602CFED RID: 184301 RVA: 0x00626522 File Offset: 0x00624722
		public static void AddUiConfig(FlatBufferBuilder builder, Offset<IChangeTimerUiConfig> uiConfigOffset)
		{
			builder.AddStruct(4, uiConfigOffset.Value, 0);
		}

		// Token: 0x0602CFEE RID: 184302 RVA: 0x00626532 File Offset: 0x00624732
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602CFEF RID: 184303 RVA: 0x0062653D File Offset: 0x0062473D
		public static Offset<IAddTime> EndIAddTime(FlatBufferBuilder builder)
		{
			return new Offset<IAddTime>(builder.EndTable());
		}

		// Token: 0x0602CFF0 RID: 184304 RVA: 0x0062654C File Offset: 0x0062474C
		public IAddTimeT UnPack()
		{
			IAddTimeT addTimeT = new IAddTimeT();
			this.UnPackTo(addTimeT);
			return addTimeT;
		}

		// Token: 0x0602CFF1 RID: 184305 RVA: 0x00626568 File Offset: 0x00624768
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

		// Token: 0x0602CFF2 RID: 184306 RVA: 0x0062672C File Offset: 0x0062492C
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

		// Token: 0x0401131C RID: 70428
		private Table __p;
	}
}
