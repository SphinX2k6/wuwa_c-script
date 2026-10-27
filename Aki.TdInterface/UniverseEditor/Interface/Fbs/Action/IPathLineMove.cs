using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6F RID: 27759
	public struct IPathLineMove : IFlatbufferObject
	{
		// Token: 0x1700CEB2 RID: 52914
		// (get) Token: 0x06030E7D RID: 200317 RVA: 0x006A42E4 File Offset: 0x006A24E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E7E RID: 200318 RVA: 0x006A42F1 File Offset: 0x006A24F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E7F RID: 200319 RVA: 0x006A42F8 File Offset: 0x006A24F8
		public static IPathLineMove GetRootAsIPathLineMove(ByteBuffer _bb)
		{
			return IPathLineMove.GetRootAsIPathLineMove(_bb, default(IPathLineMove));
		}

		// Token: 0x06030E80 RID: 200320 RVA: 0x006A4314 File Offset: 0x006A2514
		public static IPathLineMove GetRootAsIPathLineMove(ByteBuffer _bb, IPathLineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E81 RID: 200321 RVA: 0x006A4331 File Offset: 0x006A2531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E82 RID: 200322 RVA: 0x006A4340 File Offset: 0x006A2540
		public IPathLineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEB3 RID: 52915
		// (get) Token: 0x06030E83 RID: 200323 RVA: 0x006A4350 File Offset: 0x006A2550
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

		// Token: 0x1700CEB4 RID: 52916
		// (get) Token: 0x06030E84 RID: 200324 RVA: 0x006A438C File Offset: 0x006A258C
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

		// Token: 0x1700CEB5 RID: 52917
		// (get) Token: 0x06030E85 RID: 200325 RVA: 0x006A43CC File Offset: 0x006A25CC
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEB6 RID: 52918
		// (get) Token: 0x06030E86 RID: 200326 RVA: 0x006A440C File Offset: 0x006A260C
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

		// Token: 0x1700CEB7 RID: 52919
		// (get) Token: 0x06030E87 RID: 200327 RVA: 0x006A4450 File Offset: 0x006A2650
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEB8 RID: 52920
		// (get) Token: 0x06030E88 RID: 200328 RVA: 0x006A4490 File Offset: 0x006A2690
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

		// Token: 0x1700CEB9 RID: 52921
		// (get) Token: 0x06030E89 RID: 200329 RVA: 0x006A44D4 File Offset: 0x006A26D4
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

		// Token: 0x1700CEBA RID: 52922
		// (get) Token: 0x06030E8A RID: 200330 RVA: 0x006A4514 File Offset: 0x006A2714
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

		// Token: 0x06030E8B RID: 200331 RVA: 0x006A4554 File Offset: 0x006A2754
		public TTable? FacingConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030E8C RID: 200332 RVA: 0x006A459C File Offset: 0x006A279C
		public IPathLineFacingCurrentDirection FacingConfigAsIPathLineFacingCurrentDirection()
		{
			return this.FacingConfig<IPathLineFacingCurrentDirection>().Value;
		}

		// Token: 0x06030E8D RID: 200333 RVA: 0x006A45B8 File Offset: 0x006A27B8
		public IPathLineFacingCustomDirection FacingConfigAsIPathLineFacingCustomDirection()
		{
			return this.FacingConfig<IPathLineFacingCustomDirection>().Value;
		}

		// Token: 0x1700CEBB RID: 52923
		// (get) Token: 0x06030E8E RID: 200334 RVA: 0x006A45D4 File Offset: 0x006A27D4
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

		// Token: 0x06030E8F RID: 200335 RVA: 0x006A460C File Offset: 0x006A280C
		public Span<byte> GetSplineMoveConfigDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06030E90 RID: 200336 RVA: 0x006A461C File Offset: 0x006A281C
		public byte[] GetSplineMoveConfigDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700CEBC RID: 52924
		// (get) Token: 0x06030E91 RID: 200337 RVA: 0x006A462C File Offset: 0x006A282C
		public bool IsAdaptiveClimbInput
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEBD RID: 52925
		// (get) Token: 0x06030E92 RID: 200338 RVA: 0x006A466C File Offset: 0x006A286C
		public bool IsDisableStopAnim
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEBE RID: 52926
		// (get) Token: 0x06030E93 RID: 200339 RVA: 0x006A46AC File Offset: 0x006A28AC
		public bool IsAllowEarlyExitClimb
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEBF RID: 52927
		// (get) Token: 0x06030E94 RID: 200340 RVA: 0x006A46EC File Offset: 0x006A28EC
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

		// Token: 0x06030E95 RID: 200341 RVA: 0x006A472C File Offset: 0x006A292C
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

		// Token: 0x06030E96 RID: 200342 RVA: 0x006A47B4 File Offset: 0x006A29B4
		public static void StartIPathLineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06030E97 RID: 200343 RVA: 0x006A47BE File Offset: 0x006A29BE
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E98 RID: 200344 RVA: 0x006A47C9 File Offset: 0x006A29C9
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06030E99 RID: 200345 RVA: 0x006A47DC File Offset: 0x006A29DC
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06030E9A RID: 200346 RVA: 0x006A47E7 File Offset: 0x006A29E7
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06030E9B RID: 200347 RVA: 0x006A47FA File Offset: 0x006A29FA
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06030E9C RID: 200348 RVA: 0x006A4805 File Offset: 0x006A2A05
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06030E9D RID: 200349 RVA: 0x006A4818 File Offset: 0x006A2A18
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06030E9E RID: 200350 RVA: 0x006A4823 File Offset: 0x006A2A23
		public static void AddFacingConfigType(FlatBufferBuilder builder, TPathLineFacingConfig facingConfigType)
		{
			builder.AddByte(7, (byte)facingConfigType, 0);
		}

		// Token: 0x06030E9F RID: 200351 RVA: 0x006A482E File Offset: 0x006A2A2E
		public static void AddFacingConfig(FlatBufferBuilder builder, int facingConfigOffset)
		{
			builder.AddOffset(8, facingConfigOffset, 0);
		}

		// Token: 0x06030EA0 RID: 200352 RVA: 0x006A4839 File Offset: 0x006A2A39
		public static void AddSplineMoveConfigDaPath(FlatBufferBuilder builder, StringOffset splineMoveConfigDaPathOffset)
		{
			builder.AddOffset(9, splineMoveConfigDaPathOffset.Value, 0);
		}

		// Token: 0x06030EA1 RID: 200353 RVA: 0x006A484A File Offset: 0x006A2A4A
		public static void AddIsAdaptiveClimbInput(FlatBufferBuilder builder, bool isAdaptiveClimbInput)
		{
			builder.AddBool(10, isAdaptiveClimbInput, false);
		}

		// Token: 0x06030EA2 RID: 200354 RVA: 0x006A4856 File Offset: 0x006A2A56
		public static void AddIsDisableStopAnim(FlatBufferBuilder builder, bool isDisableStopAnim)
		{
			builder.AddBool(11, isDisableStopAnim, false);
		}

		// Token: 0x06030EA3 RID: 200355 RVA: 0x006A4862 File Offset: 0x006A2A62
		public static void AddIsAllowEarlyExitClimb(FlatBufferBuilder builder, bool isAllowEarlyExitClimb)
		{
			builder.AddBool(12, isAllowEarlyExitClimb, false);
		}

		// Token: 0x06030EA4 RID: 200356 RVA: 0x006A486E File Offset: 0x006A2A6E
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(13, nullMask, 0);
		}

		// Token: 0x06030EA5 RID: 200357 RVA: 0x006A487A File Offset: 0x006A2A7A
		public static Offset<IPathLineMove> EndIPathLineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineMove>(builder.EndTable());
		}

		// Token: 0x06030EA6 RID: 200358 RVA: 0x006A4888 File Offset: 0x006A2A88
		public IPathLineMoveT UnPack()
		{
			IPathLineMoveT pathLineMoveT = new IPathLineMoveT();
			this.UnPackTo(pathLineMoveT);
			return pathLineMoveT;
		}

		// Token: 0x06030EA7 RID: 200359 RVA: 0x006A48A4 File Offset: 0x006A2AA4
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

		// Token: 0x06030EA8 RID: 200360 RVA: 0x006A49DC File Offset: 0x006A2BDC
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

		// Token: 0x040115B7 RID: 71095
		private Table __p;
	}
}
