using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D6 RID: 29654
	public struct IPathLineMove : IFlatbufferObject
	{
		// Token: 0x1700D9CD RID: 55757
		// (get) Token: 0x06033DD8 RID: 212440 RVA: 0x006FE7E4 File Offset: 0x006FC9E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DD9 RID: 212441 RVA: 0x006FE7F1 File Offset: 0x006FC9F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DDA RID: 212442 RVA: 0x006FE7F8 File Offset: 0x006FC9F8
		public static IPathLineMove GetRootAsIPathLineMove(ByteBuffer _bb)
		{
			return IPathLineMove.GetRootAsIPathLineMove(_bb, default(IPathLineMove));
		}

		// Token: 0x06033DDB RID: 212443 RVA: 0x006FE814 File Offset: 0x006FCA14
		public static IPathLineMove GetRootAsIPathLineMove(ByteBuffer _bb, IPathLineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DDC RID: 212444 RVA: 0x006FE831 File Offset: 0x006FCA31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DDD RID: 212445 RVA: 0x006FE840 File Offset: 0x006FCA40
		public IPathLineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9CE RID: 55758
		// (get) Token: 0x06033DDE RID: 212446 RVA: 0x006FE850 File Offset: 0x006FCA50
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9CF RID: 55759
		// (get) Token: 0x06033DDF RID: 212447 RVA: 0x006FE88C File Offset: 0x006FCA8C
		public float MaxOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9D0 RID: 55760
		// (get) Token: 0x06033DE0 RID: 212448 RVA: 0x006FE8CC File Offset: 0x006FCACC
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9D1 RID: 55761
		// (get) Token: 0x06033DE1 RID: 212449 RVA: 0x006FE90C File Offset: 0x006FCB0C
		public float LayerVerticalLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9D2 RID: 55762
		// (get) Token: 0x06033DE2 RID: 212450 RVA: 0x006FE950 File Offset: 0x006FCB50
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9D3 RID: 55763
		// (get) Token: 0x06033DE3 RID: 212451 RVA: 0x006FE990 File Offset: 0x006FCB90
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9D4 RID: 55764
		// (get) Token: 0x06033DE4 RID: 212452 RVA: 0x006FE9D4 File Offset: 0x006FCBD4
		public int AutoExitDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9D5 RID: 55765
		// (get) Token: 0x06033DE5 RID: 212453 RVA: 0x006FEA14 File Offset: 0x006FCC14
		public TPathLineFacingConfig FacingConfigType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return TPathLineFacingConfig.NONE;
				}
				return (TPathLineFacingConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033DE6 RID: 212454 RVA: 0x006FEA54 File Offset: 0x006FCC54
		public TTable? FacingConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033DE7 RID: 212455 RVA: 0x006FEA9C File Offset: 0x006FCC9C
		public IPathLineFacingCurrentDirection FacingConfigAsIPathLineFacingCurrentDirection()
		{
			return this.FacingConfig<IPathLineFacingCurrentDirection>().Value;
		}

		// Token: 0x06033DE8 RID: 212456 RVA: 0x006FEAB8 File Offset: 0x006FCCB8
		public IPathLineFacingCustomDirection FacingConfigAsIPathLineFacingCustomDirection()
		{
			return this.FacingConfig<IPathLineFacingCustomDirection>().Value;
		}

		// Token: 0x1700D9D6 RID: 55766
		// (get) Token: 0x06033DE9 RID: 212457 RVA: 0x006FEAD4 File Offset: 0x006FCCD4
		public string SplineMoveConfigDaPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033DEA RID: 212458 RVA: 0x006FEB0C File Offset: 0x006FCD0C
		public Span<byte> GetSplineMoveConfigDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06033DEB RID: 212459 RVA: 0x006FEB1C File Offset: 0x006FCD1C
		public byte[] GetSplineMoveConfigDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700D9D7 RID: 55767
		// (get) Token: 0x06033DEC RID: 212460 RVA: 0x006FEB2C File Offset: 0x006FCD2C
		public bool IsAdaptiveClimbInput
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9D8 RID: 55768
		// (get) Token: 0x06033DED RID: 212461 RVA: 0x006FEB6C File Offset: 0x006FCD6C
		public bool IsDisableStopAnim
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9D9 RID: 55769
		// (get) Token: 0x06033DEE RID: 212462 RVA: 0x006FEBAC File Offset: 0x006FCDAC
		public bool IsAllowEarlyExitClimb
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9DA RID: 55770
		// (get) Token: 0x06033DEF RID: 212463 RVA: 0x006FEBEC File Offset: 0x006FCDEC
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033DF0 RID: 212464 RVA: 0x006FEC2C File Offset: 0x006FCE2C
		public static Offset<IPathLineMove> CreateIPathLineMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, TPathLineFacingConfig FacingConfig_type = TPathLineFacingConfig.NONE, int FacingConfigOffset = 0, StringOffset SplineMoveConfigDaPathOffset = default(StringOffset), bool IsAdaptiveClimbInput = false, bool IsDisableStopAnim = false, bool IsAllowEarlyExitClimb = false, ushort NullMask = 0)
		{
			builder.StartTable(14);
			IPathLineMove.AddSplineMoveConfigDaPath(builder, SplineMoveConfigDaPathOffset);
			IPathLineMove.AddFacingConfig(builder, FacingConfigOffset);
			IPathLineMove.AddAutoExitDistance(builder, AutoExitDistance);
			IPathLineMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IPathLineMove.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IPathLineMove.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IPathLineMove.AddNullMask(builder, NullMask);
			IPathLineMove.AddIsAllowEarlyExitClimb(builder, IsAllowEarlyExitClimb);
			IPathLineMove.AddIsDisableStopAnim(builder, IsDisableStopAnim);
			IPathLineMove.AddIsAdaptiveClimbInput(builder, IsAdaptiveClimbInput);
			IPathLineMove.AddFacingConfigType(builder, FacingConfig_type);
			IPathLineMove.AddDynamicGravity(builder, DynamicGravity);
			IPathLineMove.AddIsOneWay(builder, IsOneWay);
			IPathLineMove.AddType(builder, Type);
			return IPathLineMove.EndIPathLineMove(builder);
		}

		// Token: 0x06033DF1 RID: 212465 RVA: 0x006FECB4 File Offset: 0x006FCEB4
		public static void StartIPathLineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06033DF2 RID: 212466 RVA: 0x006FECBE File Offset: 0x006FCEBE
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DF3 RID: 212467 RVA: 0x006FECC9 File Offset: 0x006FCEC9
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06033DF4 RID: 212468 RVA: 0x006FECDC File Offset: 0x006FCEDC
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06033DF5 RID: 212469 RVA: 0x006FECE7 File Offset: 0x006FCEE7
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06033DF6 RID: 212470 RVA: 0x006FECFA File Offset: 0x006FCEFA
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06033DF7 RID: 212471 RVA: 0x006FED05 File Offset: 0x006FCF05
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06033DF8 RID: 212472 RVA: 0x006FED18 File Offset: 0x006FCF18
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06033DF9 RID: 212473 RVA: 0x006FED23 File Offset: 0x006FCF23
		public static void AddFacingConfigType(FlatBufferBuilder builder, TPathLineFacingConfig facingConfigType)
		{
			builder.AddByte(7, (byte)facingConfigType, 0);
		}

		// Token: 0x06033DFA RID: 212474 RVA: 0x006FED2E File Offset: 0x006FCF2E
		public static void AddFacingConfig(FlatBufferBuilder builder, int facingConfigOffset)
		{
			builder.AddOffset(8, facingConfigOffset, 0);
		}

		// Token: 0x06033DFB RID: 212475 RVA: 0x006FED39 File Offset: 0x006FCF39
		public static void AddSplineMoveConfigDaPath(FlatBufferBuilder builder, StringOffset splineMoveConfigDaPathOffset)
		{
			builder.AddOffset(9, splineMoveConfigDaPathOffset.Value, 0);
		}

		// Token: 0x06033DFC RID: 212476 RVA: 0x006FED4A File Offset: 0x006FCF4A
		public static void AddIsAdaptiveClimbInput(FlatBufferBuilder builder, bool isAdaptiveClimbInput)
		{
			builder.AddBool(10, isAdaptiveClimbInput, false);
		}

		// Token: 0x06033DFD RID: 212477 RVA: 0x006FED56 File Offset: 0x006FCF56
		public static void AddIsDisableStopAnim(FlatBufferBuilder builder, bool isDisableStopAnim)
		{
			builder.AddBool(11, isDisableStopAnim, false);
		}

		// Token: 0x06033DFE RID: 212478 RVA: 0x006FED62 File Offset: 0x006FCF62
		public static void AddIsAllowEarlyExitClimb(FlatBufferBuilder builder, bool isAllowEarlyExitClimb)
		{
			builder.AddBool(12, isAllowEarlyExitClimb, false);
		}

		// Token: 0x06033DFF RID: 212479 RVA: 0x006FED6E File Offset: 0x006FCF6E
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(13, nullMask, 0);
		}

		// Token: 0x06033E00 RID: 212480 RVA: 0x006FED7A File Offset: 0x006FCF7A
		public static Offset<IPathLineMove> EndIPathLineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineMove>(builder.EndTable());
		}

		// Token: 0x06033E01 RID: 212481 RVA: 0x006FED88 File Offset: 0x006FCF88
		public IPathLineMoveT UnPack()
		{
			IPathLineMoveT pathLineMoveT = new IPathLineMoveT();
			this.UnPackTo(pathLineMoveT);
			return pathLineMoveT;
		}

		// Token: 0x06033E02 RID: 212482 RVA: 0x006FEDA4 File Offset: 0x006FCFA4
		public void UnPackTo(IPathLineMoveT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.FacingConfig = new TPathLineFacingConfigUnion();
			_o.FacingConfig.Type = this.FacingConfigType;
			TPathLineFacingConfig facingConfigType = this.FacingConfigType;
			if (facingConfigType != TPathLineFacingConfig.IPathLineFacingCurrentDirection)
			{
				if (facingConfigType == TPathLineFacingConfig.IPathLineFacingCustomDirection)
				{
					_o.FacingConfig.Value = ((this.FacingConfig<IPathLineFacingCustomDirection>() != null) ? this.FacingConfig<IPathLineFacingCustomDirection>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.FacingConfig.Value = ((this.FacingConfig<IPathLineFacingCurrentDirection>() != null) ? this.FacingConfig<IPathLineFacingCurrentDirection>().Value.UnPack() : null);
			}
			_o.SplineMoveConfigDaPath = this.SplineMoveConfigDaPath;
			_o.IsAdaptiveClimbInput = this.IsAdaptiveClimbInput;
			_o.IsDisableStopAnim = this.IsDisableStopAnim;
			_o.IsAllowEarlyExitClimb = this.IsAllowEarlyExitClimb;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033E03 RID: 212483 RVA: 0x006FEEDC File Offset: 0x006FD0DC
		public static Offset<IPathLineMove> Pack(FlatBufferBuilder builder, IPathLineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineMove>);
			}
			TPathLineFacingConfig facingConfig_type = (_o.FacingConfig == null) ? TPathLineFacingConfig.NONE : _o.FacingConfig.Type;
			int facingConfigOffset = (_o.FacingConfig == null) ? 0 : TPathLineFacingConfigUnion.Pack(builder, _o.FacingConfig);
			StringOffset splineMoveConfigDaPathOffset = (_o.SplineMoveConfigDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SplineMoveConfigDaPath);
			return IPathLineMove.CreateIPathLineMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, facingConfig_type, facingConfigOffset, splineMoveConfigDaPathOffset, _o.IsAdaptiveClimbInput, _o.IsDisableStopAnim, _o.IsAllowEarlyExitClimb, _o.NullMask);
		}

		// Token: 0x0401250F RID: 75023
		private Table __p;
	}
}
