using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B18 RID: 27416
	public struct IMotorcycleTrack : IFlatbufferObject
	{
		// Token: 0x1700CBA7 RID: 52135
		// (get) Token: 0x060301A6 RID: 197030 RVA: 0x00689F97 File Offset: 0x00688197
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060301A7 RID: 197031 RVA: 0x00689FA4 File Offset: 0x006881A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060301A8 RID: 197032 RVA: 0x00689FAC File Offset: 0x006881AC
		public static IMotorcycleTrack GetRootAsIMotorcycleTrack(ByteBuffer _bb)
		{
			return IMotorcycleTrack.GetRootAsIMotorcycleTrack(_bb, default(IMotorcycleTrack));
		}

		// Token: 0x060301A9 RID: 197033 RVA: 0x00689FC8 File Offset: 0x006881C8
		public static IMotorcycleTrack GetRootAsIMotorcycleTrack(ByteBuffer _bb, IMotorcycleTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060301AA RID: 197034 RVA: 0x00689FE5 File Offset: 0x006881E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060301AB RID: 197035 RVA: 0x00689FF4 File Offset: 0x006881F4
		public IMotorcycleTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBA8 RID: 52136
		// (get) Token: 0x060301AC RID: 197036 RVA: 0x0068A004 File Offset: 0x00688204
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

		// Token: 0x1700CBA9 RID: 52137
		// (get) Token: 0x060301AD RID: 197037 RVA: 0x0068A040 File Offset: 0x00688240
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

		// Token: 0x1700CBAA RID: 52138
		// (get) Token: 0x060301AE RID: 197038 RVA: 0x0068A080 File Offset: 0x00688280
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CBAB RID: 52139
		// (get) Token: 0x060301AF RID: 197039 RVA: 0x0068A0C0 File Offset: 0x006882C0
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

		// Token: 0x1700CBAC RID: 52140
		// (get) Token: 0x060301B0 RID: 197040 RVA: 0x0068A104 File Offset: 0x00688304
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CBAD RID: 52141
		// (get) Token: 0x060301B1 RID: 197041 RVA: 0x0068A144 File Offset: 0x00688344
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

		// Token: 0x1700CBAE RID: 52142
		// (get) Token: 0x060301B2 RID: 197042 RVA: 0x0068A188 File Offset: 0x00688388
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

		// Token: 0x1700CBAF RID: 52143
		// (get) Token: 0x060301B3 RID: 197043 RVA: 0x0068A1C8 File Offset: 0x006883C8
		public bool DisableAutoForward
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CBB0 RID: 52144
		// (get) Token: 0x060301B4 RID: 197044 RVA: 0x0068A208 File Offset: 0x00688408
		public float LongitudinalAngleLimit
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBB1 RID: 52145
		// (get) Token: 0x060301B5 RID: 197045 RVA: 0x0068A24C File Offset: 0x0068844C
		public float ForwardAngleLimit
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBB2 RID: 52146
		// (get) Token: 0x060301B6 RID: 197046 RVA: 0x0068A290 File Offset: 0x00688490
		public string ForwardAngleLimitCurve
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060301B7 RID: 197047 RVA: 0x0068A2C8 File Offset: 0x006884C8
		public Span<byte> GetForwardAngleLimitCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060301B8 RID: 197048 RVA: 0x0068A2D8 File Offset: 0x006884D8
		public byte[] GetForwardAngleLimitCurveArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x1700CBB3 RID: 52147
		// (get) Token: 0x060301B9 RID: 197049 RVA: 0x0068A2E8 File Offset: 0x006884E8
		public string InputCorrectionCurve
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060301BA RID: 197050 RVA: 0x0068A320 File Offset: 0x00688520
		public Span<byte> GetInputCorrectionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060301BB RID: 197051 RVA: 0x0068A330 File Offset: 0x00688530
		public byte[] GetInputCorrectionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x1700CBB4 RID: 52148
		// (get) Token: 0x060301BC RID: 197052 RVA: 0x0068A340 File Offset: 0x00688540
		public float InputCorrectionBaseAngle
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBB5 RID: 52149
		// (get) Token: 0x060301BD RID: 197053 RVA: 0x0068A384 File Offset: 0x00688584
		public float CorrectionPredictionDistance
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBB6 RID: 52150
		// (get) Token: 0x060301BE RID: 197054 RVA: 0x0068A3C8 File Offset: 0x006885C8
		public string AccelerationCorrectionCurve
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060301BF RID: 197055 RVA: 0x0068A400 File Offset: 0x00688600
		public Span<byte> GetAccelerationCorrectionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060301C0 RID: 197056 RVA: 0x0068A410 File Offset: 0x00688610
		public byte[] GetAccelerationCorrectionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x1700CBB7 RID: 52151
		// (get) Token: 0x060301C1 RID: 197057 RVA: 0x0068A420 File Offset: 0x00688620
		public IAutomaticDrive? AutomaticDrive
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new IAutomaticDrive?(default(IAutomaticDrive).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CBB8 RID: 52152
		// (get) Token: 0x060301C2 RID: 197058 RVA: 0x0068A480 File Offset: 0x00688680
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060301C3 RID: 197059 RVA: 0x0068A4C0 File Offset: 0x006886C0
		public static Offset<IMotorcycleTrack> CreateIMotorcycleTrack(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, bool DisableAutoForward = false, float LongitudinalAngleLimit = 0f, float ForwardAngleLimit = 0f, StringOffset ForwardAngleLimitCurveOffset = default(StringOffset), StringOffset InputCorrectionCurveOffset = default(StringOffset), float InputCorrectionBaseAngle = 0f, float CorrectionPredictionDistance = 0f, StringOffset AccelerationCorrectionCurveOffset = default(StringOffset), Offset<IAutomaticDrive> AutomaticDriveOffset = default(Offset<IAutomaticDrive>), ushort NullMask = 0)
		{
			builder.StartTable(17);
			IMotorcycleTrack.AddAutomaticDrive(builder, AutomaticDriveOffset);
			IMotorcycleTrack.AddAccelerationCorrectionCurve(builder, AccelerationCorrectionCurveOffset);
			IMotorcycleTrack.AddCorrectionPredictionDistance(builder, CorrectionPredictionDistance);
			IMotorcycleTrack.AddInputCorrectionBaseAngle(builder, InputCorrectionBaseAngle);
			IMotorcycleTrack.AddInputCorrectionCurve(builder, InputCorrectionCurveOffset);
			IMotorcycleTrack.AddForwardAngleLimitCurve(builder, ForwardAngleLimitCurveOffset);
			IMotorcycleTrack.AddForwardAngleLimit(builder, ForwardAngleLimit);
			IMotorcycleTrack.AddLongitudinalAngleLimit(builder, LongitudinalAngleLimit);
			IMotorcycleTrack.AddAutoExitDistance(builder, AutoExitDistance);
			IMotorcycleTrack.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IMotorcycleTrack.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IMotorcycleTrack.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IMotorcycleTrack.AddNullMask(builder, NullMask);
			IMotorcycleTrack.AddDisableAutoForward(builder, DisableAutoForward);
			IMotorcycleTrack.AddDynamicGravity(builder, DynamicGravity);
			IMotorcycleTrack.AddIsOneWay(builder, IsOneWay);
			IMotorcycleTrack.AddType(builder, Type);
			return IMotorcycleTrack.EndIMotorcycleTrack(builder);
		}

		// Token: 0x060301C4 RID: 197060 RVA: 0x0068A560 File Offset: 0x00688760
		public static void StartIMotorcycleTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x060301C5 RID: 197061 RVA: 0x0068A56A File Offset: 0x0068876A
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060301C6 RID: 197062 RVA: 0x0068A575 File Offset: 0x00688775
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x060301C7 RID: 197063 RVA: 0x0068A588 File Offset: 0x00688788
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x060301C8 RID: 197064 RVA: 0x0068A593 File Offset: 0x00688793
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x060301C9 RID: 197065 RVA: 0x0068A5A6 File Offset: 0x006887A6
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x060301CA RID: 197066 RVA: 0x0068A5B1 File Offset: 0x006887B1
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x060301CB RID: 197067 RVA: 0x0068A5C4 File Offset: 0x006887C4
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x060301CC RID: 197068 RVA: 0x0068A5CF File Offset: 0x006887CF
		public static void AddDisableAutoForward(FlatBufferBuilder builder, bool disableAutoForward)
		{
			builder.AddBool(7, disableAutoForward, false);
		}

		// Token: 0x060301CD RID: 197069 RVA: 0x0068A5DA File Offset: 0x006887DA
		public static void AddLongitudinalAngleLimit(FlatBufferBuilder builder, float longitudinalAngleLimit)
		{
			builder.AddFloat(8, longitudinalAngleLimit, 0.0);
		}

		// Token: 0x060301CE RID: 197070 RVA: 0x0068A5ED File Offset: 0x006887ED
		public static void AddForwardAngleLimit(FlatBufferBuilder builder, float forwardAngleLimit)
		{
			builder.AddFloat(9, forwardAngleLimit, 0.0);
		}

		// Token: 0x060301CF RID: 197071 RVA: 0x0068A601 File Offset: 0x00688801
		public static void AddForwardAngleLimitCurve(FlatBufferBuilder builder, StringOffset forwardAngleLimitCurveOffset)
		{
			builder.AddOffset(10, forwardAngleLimitCurveOffset.Value, 0);
		}

		// Token: 0x060301D0 RID: 197072 RVA: 0x0068A612 File Offset: 0x00688812
		public static void AddInputCorrectionCurve(FlatBufferBuilder builder, StringOffset inputCorrectionCurveOffset)
		{
			builder.AddOffset(11, inputCorrectionCurveOffset.Value, 0);
		}

		// Token: 0x060301D1 RID: 197073 RVA: 0x0068A623 File Offset: 0x00688823
		public static void AddInputCorrectionBaseAngle(FlatBufferBuilder builder, float inputCorrectionBaseAngle)
		{
			builder.AddFloat(12, inputCorrectionBaseAngle, 0.0);
		}

		// Token: 0x060301D2 RID: 197074 RVA: 0x0068A637 File Offset: 0x00688837
		public static void AddCorrectionPredictionDistance(FlatBufferBuilder builder, float correctionPredictionDistance)
		{
			builder.AddFloat(13, correctionPredictionDistance, 0.0);
		}

		// Token: 0x060301D3 RID: 197075 RVA: 0x0068A64B File Offset: 0x0068884B
		public static void AddAccelerationCorrectionCurve(FlatBufferBuilder builder, StringOffset accelerationCorrectionCurveOffset)
		{
			builder.AddOffset(14, accelerationCorrectionCurveOffset.Value, 0);
		}

		// Token: 0x060301D4 RID: 197076 RVA: 0x0068A65C File Offset: 0x0068885C
		public static void AddAutomaticDrive(FlatBufferBuilder builder, Offset<IAutomaticDrive> automaticDriveOffset)
		{
			builder.AddOffset(15, automaticDriveOffset.Value, 0);
		}

		// Token: 0x060301D5 RID: 197077 RVA: 0x0068A66D File Offset: 0x0068886D
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x060301D6 RID: 197078 RVA: 0x0068A679 File Offset: 0x00688879
		public static Offset<IMotorcycleTrack> EndIMotorcycleTrack(FlatBufferBuilder builder)
		{
			return new Offset<IMotorcycleTrack>(builder.EndTable());
		}

		// Token: 0x060301D7 RID: 197079 RVA: 0x0068A688 File Offset: 0x00688888
		public IMotorcycleTrackT UnPack()
		{
			IMotorcycleTrackT motorcycleTrackT = new IMotorcycleTrackT();
			this.UnPackTo(motorcycleTrackT);
			return motorcycleTrackT;
		}

		// Token: 0x060301D8 RID: 197080 RVA: 0x0068A6A4 File Offset: 0x006888A4
		public void UnPackTo(IMotorcycleTrackT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.DisableAutoForward = this.DisableAutoForward;
			_o.LongitudinalAngleLimit = this.LongitudinalAngleLimit;
			_o.ForwardAngleLimit = this.ForwardAngleLimit;
			_o.ForwardAngleLimitCurve = this.ForwardAngleLimitCurve;
			_o.InputCorrectionCurve = this.InputCorrectionCurve;
			_o.InputCorrectionBaseAngle = this.InputCorrectionBaseAngle;
			_o.CorrectionPredictionDistance = this.CorrectionPredictionDistance;
			_o.AccelerationCorrectionCurve = this.AccelerationCorrectionCurve;
			_o.AutomaticDrive = ((this.AutomaticDrive != null) ? this.AutomaticDrive.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060301D9 RID: 197081 RVA: 0x0068A7A0 File Offset: 0x006889A0
		public static Offset<IMotorcycleTrack> Pack(FlatBufferBuilder builder, IMotorcycleTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorcycleTrack>);
			}
			StringOffset forwardAngleLimitCurveOffset = (_o.ForwardAngleLimitCurve == null) ? default(StringOffset) : builder.CreateString(_o.ForwardAngleLimitCurve);
			StringOffset inputCorrectionCurveOffset = (_o.InputCorrectionCurve == null) ? default(StringOffset) : builder.CreateString(_o.InputCorrectionCurve);
			StringOffset accelerationCorrectionCurveOffset = (_o.AccelerationCorrectionCurve == null) ? default(StringOffset) : builder.CreateString(_o.AccelerationCorrectionCurve);
			Offset<IAutomaticDrive> automaticDriveOffset = (_o.AutomaticDrive == null) ? default(Offset<IAutomaticDrive>) : IAutomaticDrive.Pack(builder, _o.AutomaticDrive);
			return IMotorcycleTrack.CreateIMotorcycleTrack(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.DisableAutoForward, _o.LongitudinalAngleLimit, _o.ForwardAngleLimit, forwardAngleLimitCurveOffset, inputCorrectionCurveOffset, _o.InputCorrectionBaseAngle, _o.CorrectionPredictionDistance, accelerationCorrectionCurveOffset, automaticDriveOffset, _o.NullMask);
		}

		// Token: 0x04011399 RID: 70553
		private Table __p;
	}
}
