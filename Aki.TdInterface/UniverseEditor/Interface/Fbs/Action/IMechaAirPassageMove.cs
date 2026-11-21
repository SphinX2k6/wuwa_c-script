using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719B RID: 29083
	public struct IMechaAirPassageMove : IFlatbufferObject
	{
		// Token: 0x1700D4E6 RID: 54502
		// (get) Token: 0x060328FF RID: 207103 RVA: 0x006D50ED File Offset: 0x006D32ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032900 RID: 207104 RVA: 0x006D50FA File Offset: 0x006D32FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032901 RID: 207105 RVA: 0x006D5104 File Offset: 0x006D3304
		public static IMechaAirPassageMove GetRootAsIMechaAirPassageMove(ByteBuffer _bb)
		{
			return IMechaAirPassageMove.GetRootAsIMechaAirPassageMove(_bb, default(IMechaAirPassageMove));
		}

		// Token: 0x06032902 RID: 207106 RVA: 0x006D5120 File Offset: 0x006D3320
		public static IMechaAirPassageMove GetRootAsIMechaAirPassageMove(ByteBuffer _bb, IMechaAirPassageMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032903 RID: 207107 RVA: 0x006D513D File Offset: 0x006D333D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032904 RID: 207108 RVA: 0x006D514C File Offset: 0x006D334C
		public IMechaAirPassageMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4E7 RID: 54503
		// (get) Token: 0x06032905 RID: 207109 RVA: 0x006D515C File Offset: 0x006D335C
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

		// Token: 0x1700D4E8 RID: 54504
		// (get) Token: 0x06032906 RID: 207110 RVA: 0x006D5198 File Offset: 0x006D3398
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

		// Token: 0x1700D4E9 RID: 54505
		// (get) Token: 0x06032907 RID: 207111 RVA: 0x006D51D8 File Offset: 0x006D33D8
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4EA RID: 54506
		// (get) Token: 0x06032908 RID: 207112 RVA: 0x006D5218 File Offset: 0x006D3418
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

		// Token: 0x1700D4EB RID: 54507
		// (get) Token: 0x06032909 RID: 207113 RVA: 0x006D525C File Offset: 0x006D345C
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D4EC RID: 54508
		// (get) Token: 0x0603290A RID: 207114 RVA: 0x006D529C File Offset: 0x006D349C
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

		// Token: 0x1700D4ED RID: 54509
		// (get) Token: 0x0603290B RID: 207115 RVA: 0x006D52E0 File Offset: 0x006D34E0
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

		// Token: 0x1700D4EE RID: 54510
		// (get) Token: 0x0603290C RID: 207116 RVA: 0x006D5320 File Offset: 0x006D3520
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

		// Token: 0x1700D4EF RID: 54511
		// (get) Token: 0x0603290D RID: 207117 RVA: 0x006D5364 File Offset: 0x006D3564
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

		// Token: 0x0603290E RID: 207118 RVA: 0x006D539C File Offset: 0x006D359C
		public Span<byte> GetForwardAngleLimitCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0603290F RID: 207119 RVA: 0x006D53AC File Offset: 0x006D35AC
		public byte[] GetForwardAngleLimitCurveArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x1700D4F0 RID: 54512
		// (get) Token: 0x06032910 RID: 207120 RVA: 0x006D53BC File Offset: 0x006D35BC
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

		// Token: 0x06032911 RID: 207121 RVA: 0x006D53F4 File Offset: 0x006D35F4
		public Span<byte> GetInputCorrectionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06032912 RID: 207122 RVA: 0x006D5404 File Offset: 0x006D3604
		public byte[] GetInputCorrectionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700D4F1 RID: 54513
		// (get) Token: 0x06032913 RID: 207123 RVA: 0x006D5414 File Offset: 0x006D3614
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

		// Token: 0x1700D4F2 RID: 54514
		// (get) Token: 0x06032914 RID: 207124 RVA: 0x006D5458 File Offset: 0x006D3658
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

		// Token: 0x1700D4F3 RID: 54515
		// (get) Token: 0x06032915 RID: 207125 RVA: 0x006D549C File Offset: 0x006D369C
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

		// Token: 0x06032916 RID: 207126 RVA: 0x006D54DC File Offset: 0x006D36DC
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

		// Token: 0x06032917 RID: 207127 RVA: 0x006D555C File Offset: 0x006D375C
		public static void StartIMechaAirPassageMove(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06032918 RID: 207128 RVA: 0x006D5566 File Offset: 0x006D3766
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032919 RID: 207129 RVA: 0x006D5571 File Offset: 0x006D3771
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x0603291A RID: 207130 RVA: 0x006D5584 File Offset: 0x006D3784
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x0603291B RID: 207131 RVA: 0x006D558F File Offset: 0x006D378F
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x0603291C RID: 207132 RVA: 0x006D55A2 File Offset: 0x006D37A2
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x0603291D RID: 207133 RVA: 0x006D55AD File Offset: 0x006D37AD
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0603291E RID: 207134 RVA: 0x006D55C0 File Offset: 0x006D37C0
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x0603291F RID: 207135 RVA: 0x006D55CB File Offset: 0x006D37CB
		public static void AddForwardAngleLimit(FlatBufferBuilder builder, float forwardAngleLimit)
		{
			builder.AddFloat(7, forwardAngleLimit, 0.0);
		}

		// Token: 0x06032920 RID: 207136 RVA: 0x006D55DE File Offset: 0x006D37DE
		public static void AddForwardAngleLimitCurve(FlatBufferBuilder builder, StringOffset forwardAngleLimitCurveOffset)
		{
			builder.AddOffset(8, forwardAngleLimitCurveOffset.Value, 0);
		}

		// Token: 0x06032921 RID: 207137 RVA: 0x006D55EE File Offset: 0x006D37EE
		public static void AddInputCorrectionCurve(FlatBufferBuilder builder, StringOffset inputCorrectionCurveOffset)
		{
			builder.AddOffset(9, inputCorrectionCurveOffset.Value, 0);
		}

		// Token: 0x06032922 RID: 207138 RVA: 0x006D55FF File Offset: 0x006D37FF
		public static void AddInputCorrectionBaseAngle(FlatBufferBuilder builder, float inputCorrectionBaseAngle)
		{
			builder.AddFloat(10, inputCorrectionBaseAngle, 0.0);
		}

		// Token: 0x06032923 RID: 207139 RVA: 0x006D5613 File Offset: 0x006D3813
		public static void AddCorrectionPredictionDistance(FlatBufferBuilder builder, float correctionPredictionDistance)
		{
			builder.AddFloat(11, correctionPredictionDistance, 0.0);
		}

		// Token: 0x06032924 RID: 207140 RVA: 0x006D5627 File Offset: 0x006D3827
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06032925 RID: 207141 RVA: 0x006D5633 File Offset: 0x006D3833
		public static Offset<IMechaAirPassageMove> EndIMechaAirPassageMove(FlatBufferBuilder builder)
		{
			return new Offset<IMechaAirPassageMove>(builder.EndTable());
		}

		// Token: 0x06032926 RID: 207142 RVA: 0x006D5640 File Offset: 0x006D3840
		public IMechaAirPassageMoveT UnPack()
		{
			IMechaAirPassageMoveT mechaAirPassageMoveT = new IMechaAirPassageMoveT();
			this.UnPackTo(mechaAirPassageMoveT);
			return mechaAirPassageMoveT;
		}

		// Token: 0x06032927 RID: 207143 RVA: 0x006D565C File Offset: 0x006D385C
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

		// Token: 0x06032928 RID: 207144 RVA: 0x006D5708 File Offset: 0x006D3908
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

		// Token: 0x04012198 RID: 74136
		private Table __p;
	}
}
