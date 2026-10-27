using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A79 RID: 27257
	public struct IMechaAirPassageMove : IFlatbufferObject
	{
		// Token: 0x1700CA3B RID: 51771
		// (get) Token: 0x0602FBD9 RID: 195545 RVA: 0x0067F02D File Offset: 0x0067D22D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FBDA RID: 195546 RVA: 0x0067F03A File Offset: 0x0067D23A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FBDB RID: 195547 RVA: 0x0067F044 File Offset: 0x0067D244
		public static IMechaAirPassageMove GetRootAsIMechaAirPassageMove(ByteBuffer _bb)
		{
			return IMechaAirPassageMove.GetRootAsIMechaAirPassageMove(_bb, default(IMechaAirPassageMove));
		}

		// Token: 0x0602FBDC RID: 195548 RVA: 0x0067F060 File Offset: 0x0067D260
		public static IMechaAirPassageMove GetRootAsIMechaAirPassageMove(ByteBuffer _bb, IMechaAirPassageMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FBDD RID: 195549 RVA: 0x0067F07D File Offset: 0x0067D27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FBDE RID: 195550 RVA: 0x0067F08C File Offset: 0x0067D28C
		public IMechaAirPassageMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA3C RID: 51772
		// (get) Token: 0x0602FBDF RID: 195551 RVA: 0x0067F09C File Offset: 0x0067D29C
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

		// Token: 0x1700CA3D RID: 51773
		// (get) Token: 0x0602FBE0 RID: 195552 RVA: 0x0067F0D8 File Offset: 0x0067D2D8
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

		// Token: 0x1700CA3E RID: 51774
		// (get) Token: 0x0602FBE1 RID: 195553 RVA: 0x0067F118 File Offset: 0x0067D318
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA3F RID: 51775
		// (get) Token: 0x0602FBE2 RID: 195554 RVA: 0x0067F158 File Offset: 0x0067D358
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

		// Token: 0x1700CA40 RID: 51776
		// (get) Token: 0x0602FBE3 RID: 195555 RVA: 0x0067F19C File Offset: 0x0067D39C
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA41 RID: 51777
		// (get) Token: 0x0602FBE4 RID: 195556 RVA: 0x0067F1DC File Offset: 0x0067D3DC
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

		// Token: 0x1700CA42 RID: 51778
		// (get) Token: 0x0602FBE5 RID: 195557 RVA: 0x0067F220 File Offset: 0x0067D420
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

		// Token: 0x1700CA43 RID: 51779
		// (get) Token: 0x0602FBE6 RID: 195558 RVA: 0x0067F260 File Offset: 0x0067D460
		public float ForwardAngleLimit
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA44 RID: 51780
		// (get) Token: 0x0602FBE7 RID: 195559 RVA: 0x0067F2A4 File Offset: 0x0067D4A4
		public string ForwardAngleLimitCurve
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBE8 RID: 195560 RVA: 0x0067F2DC File Offset: 0x0067D4DC
		public Span<byte> GetForwardAngleLimitCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0602FBE9 RID: 195561 RVA: 0x0067F2EC File Offset: 0x0067D4EC
		public byte[] GetForwardAngleLimitCurveArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x1700CA45 RID: 51781
		// (get) Token: 0x0602FBEA RID: 195562 RVA: 0x0067F2FC File Offset: 0x0067D4FC
		public string InputCorrectionCurve
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

		// Token: 0x0602FBEB RID: 195563 RVA: 0x0067F334 File Offset: 0x0067D534
		public Span<byte> GetInputCorrectionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0602FBEC RID: 195564 RVA: 0x0067F344 File Offset: 0x0067D544
		public byte[] GetInputCorrectionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700CA46 RID: 51782
		// (get) Token: 0x0602FBED RID: 195565 RVA: 0x0067F354 File Offset: 0x0067D554
		public float InputCorrectionBaseAngle
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA47 RID: 51783
		// (get) Token: 0x0602FBEE RID: 195566 RVA: 0x0067F398 File Offset: 0x0067D598
		public float CorrectionPredictionDistance
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA48 RID: 51784
		// (get) Token: 0x0602FBEF RID: 195567 RVA: 0x0067F3DC File Offset: 0x0067D5DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FBF0 RID: 195568 RVA: 0x0067F41C File Offset: 0x0067D61C
		public static Offset<IMechaAirPassageMove> CreateIMechaAirPassageMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, float ForwardAngleLimit = 0f, StringOffset ForwardAngleLimitCurveOffset = default(StringOffset), StringOffset InputCorrectionCurveOffset = default(StringOffset), float InputCorrectionBaseAngle = 0f, float CorrectionPredictionDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(13);
			IMechaAirPassageMove.AddCorrectionPredictionDistance(builder, CorrectionPredictionDistance);
			IMechaAirPassageMove.AddInputCorrectionBaseAngle(builder, InputCorrectionBaseAngle);
			IMechaAirPassageMove.AddInputCorrectionCurve(builder, InputCorrectionCurveOffset);
			IMechaAirPassageMove.AddForwardAngleLimitCurve(builder, ForwardAngleLimitCurveOffset);
			IMechaAirPassageMove.AddForwardAngleLimit(builder, ForwardAngleLimit);
			IMechaAirPassageMove.AddAutoExitDistance(builder, AutoExitDistance);
			IMechaAirPassageMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IMechaAirPassageMove.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			IMechaAirPassageMove.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			IMechaAirPassageMove.AddNullMask(builder, NullMask);
			IMechaAirPassageMove.AddDynamicGravity(builder, DynamicGravity);
			IMechaAirPassageMove.AddIsOneWay(builder, IsOneWay);
			IMechaAirPassageMove.AddType(builder, Type);
			return IMechaAirPassageMove.EndIMechaAirPassageMove(builder);
		}

		// Token: 0x0602FBF1 RID: 195569 RVA: 0x0067F49C File Offset: 0x0067D69C
		public static void StartIMechaAirPassageMove(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602FBF2 RID: 195570 RVA: 0x0067F4A6 File Offset: 0x0067D6A6
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FBF3 RID: 195571 RVA: 0x0067F4B1 File Offset: 0x0067D6B1
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x0602FBF4 RID: 195572 RVA: 0x0067F4C4 File Offset: 0x0067D6C4
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x0602FBF5 RID: 195573 RVA: 0x0067F4CF File Offset: 0x0067D6CF
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x0602FBF6 RID: 195574 RVA: 0x0067F4E2 File Offset: 0x0067D6E2
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x0602FBF7 RID: 195575 RVA: 0x0067F4ED File Offset: 0x0067D6ED
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602FBF8 RID: 195576 RVA: 0x0067F500 File Offset: 0x0067D700
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x0602FBF9 RID: 195577 RVA: 0x0067F50B File Offset: 0x0067D70B
		public static void AddForwardAngleLimit(FlatBufferBuilder builder, float forwardAngleLimit)
		{
			builder.AddFloat(7, forwardAngleLimit, 0.0);
		}

		// Token: 0x0602FBFA RID: 195578 RVA: 0x0067F51E File Offset: 0x0067D71E
		public static void AddForwardAngleLimitCurve(FlatBufferBuilder builder, StringOffset forwardAngleLimitCurveOffset)
		{
			builder.AddOffset(8, forwardAngleLimitCurveOffset.Value, 0);
		}

		// Token: 0x0602FBFB RID: 195579 RVA: 0x0067F52E File Offset: 0x0067D72E
		public static void AddInputCorrectionCurve(FlatBufferBuilder builder, StringOffset inputCorrectionCurveOffset)
		{
			builder.AddOffset(9, inputCorrectionCurveOffset.Value, 0);
		}

		// Token: 0x0602FBFC RID: 195580 RVA: 0x0067F53F File Offset: 0x0067D73F
		public static void AddInputCorrectionBaseAngle(FlatBufferBuilder builder, float inputCorrectionBaseAngle)
		{
			builder.AddFloat(10, inputCorrectionBaseAngle, 0.0);
		}

		// Token: 0x0602FBFD RID: 195581 RVA: 0x0067F553 File Offset: 0x0067D753
		public static void AddCorrectionPredictionDistance(FlatBufferBuilder builder, float correctionPredictionDistance)
		{
			builder.AddFloat(11, correctionPredictionDistance, 0.0);
		}

		// Token: 0x0602FBFE RID: 195582 RVA: 0x0067F567 File Offset: 0x0067D767
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0602FBFF RID: 195583 RVA: 0x0067F573 File Offset: 0x0067D773
		public static Offset<IMechaAirPassageMove> EndIMechaAirPassageMove(FlatBufferBuilder builder)
		{
			return new Offset<IMechaAirPassageMove>(builder.EndTable());
		}

		// Token: 0x0602FC00 RID: 195584 RVA: 0x0067F580 File Offset: 0x0067D780
		public IMechaAirPassageMoveT UnPack()
		{
			IMechaAirPassageMoveT mechaAirPassageMoveT = new IMechaAirPassageMoveT();
			this.UnPackTo(mechaAirPassageMoveT);
			return mechaAirPassageMoveT;
		}

		// Token: 0x0602FC01 RID: 195585 RVA: 0x0067F59C File Offset: 0x0067D79C
		public void UnPackTo(IMechaAirPassageMoveT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.ForwardAngleLimit = this.ForwardAngleLimit;
			_o.ForwardAngleLimitCurve = this.ForwardAngleLimitCurve;
			_o.InputCorrectionCurve = this.InputCorrectionCurve;
			_o.InputCorrectionBaseAngle = this.InputCorrectionBaseAngle;
			_o.CorrectionPredictionDistance = this.CorrectionPredictionDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FC02 RID: 195586 RVA: 0x0067F648 File Offset: 0x0067D848
		public static Offset<IMechaAirPassageMove> Pack(FlatBufferBuilder builder, IMechaAirPassageMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechaAirPassageMove>);
			}
			StringOffset forwardAngleLimitCurveOffset = (_o.ForwardAngleLimitCurve == null) ? default(StringOffset) : builder.CreateString(_o.ForwardAngleLimitCurve);
			StringOffset inputCorrectionCurveOffset = (_o.InputCorrectionCurve == null) ? default(StringOffset) : builder.CreateString(_o.InputCorrectionCurve);
			return IMechaAirPassageMove.CreateIMechaAirPassageMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.ForwardAngleLimit, forwardAngleLimitCurveOffset, inputCorrectionCurveOffset, _o.InputCorrectionBaseAngle, _o.CorrectionPredictionDistance, _o.NullMask);
		}

		// Token: 0x040112A0 RID: 70304
		private Table __p;
	}
}
