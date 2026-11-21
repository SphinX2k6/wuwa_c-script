using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007249 RID: 29257
	public struct IMotorCatapultParam : IFlatbufferObject
	{
		// Token: 0x1700D660 RID: 54880
		// (get) Token: 0x06032F2A RID: 208682 RVA: 0x006E0B43 File Offset: 0x006DED43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F2B RID: 208683 RVA: 0x006E0B50 File Offset: 0x006DED50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F2C RID: 208684 RVA: 0x006E0B58 File Offset: 0x006DED58
		public static IMotorCatapultParam GetRootAsIMotorCatapultParam(ByteBuffer _bb)
		{
			return IMotorCatapultParam.GetRootAsIMotorCatapultParam(_bb, default(IMotorCatapultParam));
		}

		// Token: 0x06032F2D RID: 208685 RVA: 0x006E0B74 File Offset: 0x006DED74
		public static IMotorCatapultParam GetRootAsIMotorCatapultParam(ByteBuffer _bb, IMotorCatapultParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F2E RID: 208686 RVA: 0x006E0B91 File Offset: 0x006DED91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F2F RID: 208687 RVA: 0x006E0BA0 File Offset: 0x006DEDA0
		public IMotorCatapultParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D661 RID: 54881
		// (get) Token: 0x06032F30 RID: 208688 RVA: 0x006E0BB0 File Offset: 0x006DEDB0
		public IVectorInfo? P1
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D662 RID: 54882
		// (get) Token: 0x06032F31 RID: 208689 RVA: 0x006E0C10 File Offset: 0x006DEE10
		public IVectorInfo? P2
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D663 RID: 54883
		// (get) Token: 0x06032F32 RID: 208690 RVA: 0x006E0C70 File Offset: 0x006DEE70
		public float Gravity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D664 RID: 54884
		// (get) Token: 0x06032F33 RID: 208691 RVA: 0x006E0CB0 File Offset: 0x006DEEB0
		public float Time
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

		// Token: 0x1700D665 RID: 54885
		// (get) Token: 0x06032F34 RID: 208692 RVA: 0x006E0CF4 File Offset: 0x006DEEF4
		public string MotionCurve
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F35 RID: 208693 RVA: 0x006E0D2C File Offset: 0x006DEF2C
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06032F36 RID: 208694 RVA: 0x006E0D3C File Offset: 0x006DEF3C
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700D666 RID: 54886
		// (get) Token: 0x06032F37 RID: 208695 RVA: 0x006E0D4C File Offset: 0x006DEF4C
		public IVectorInfo? P2Rot
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D667 RID: 54887
		// (get) Token: 0x06032F38 RID: 208696 RVA: 0x006E0DAC File Offset: 0x006DEFAC
		public string P2RotCurve
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F39 RID: 208697 RVA: 0x006E0DE4 File Offset: 0x006DEFE4
		public Span<byte> GetP2RotCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06032F3A RID: 208698 RVA: 0x006E0DF4 File Offset: 0x006DEFF4
		public byte[] GetP2RotCurveArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700D668 RID: 54888
		// (get) Token: 0x06032F3B RID: 208699 RVA: 0x006E0E04 File Offset: 0x006DF004
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032F3C RID: 208700 RVA: 0x006E0E44 File Offset: 0x006DF044
		public static Offset<IMotorCatapultParam> CreateIMotorCatapultParam(FlatBufferBuilder builder, Offset<IVectorInfo> P1Offset = default(Offset<IVectorInfo>), Offset<IVectorInfo> P2Offset = default(Offset<IVectorInfo>), float Gravity = 0f, float Time = 0f, StringOffset MotionCurveOffset = default(StringOffset), Offset<IVectorInfo> P2RotOffset = default(Offset<IVectorInfo>), StringOffset P2RotCurveOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IMotorCatapultParam.AddP2RotCurve(builder, P2RotCurveOffset);
			IMotorCatapultParam.AddP2Rot(builder, P2RotOffset);
			IMotorCatapultParam.AddMotionCurve(builder, MotionCurveOffset);
			IMotorCatapultParam.AddTime(builder, Time);
			IMotorCatapultParam.AddGravity(builder, Gravity);
			IMotorCatapultParam.AddP2(builder, P2Offset);
			IMotorCatapultParam.AddP1(builder, P1Offset);
			IMotorCatapultParam.AddNullMask(builder, NullMask);
			return IMotorCatapultParam.EndIMotorCatapultParam(builder);
		}

		// Token: 0x06032F3D RID: 208701 RVA: 0x006E0E9B File Offset: 0x006DF09B
		public static void StartIMotorCatapultParam(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06032F3E RID: 208702 RVA: 0x006E0EA4 File Offset: 0x006DF0A4
		public static void AddP1(FlatBufferBuilder builder, Offset<IVectorInfo> p1Offset)
		{
			builder.AddOffset(0, p1Offset.Value, 0);
		}

		// Token: 0x06032F3F RID: 208703 RVA: 0x006E0EB4 File Offset: 0x006DF0B4
		public static void AddP2(FlatBufferBuilder builder, Offset<IVectorInfo> p2Offset)
		{
			builder.AddOffset(1, p2Offset.Value, 0);
		}

		// Token: 0x06032F40 RID: 208704 RVA: 0x006E0EC4 File Offset: 0x006DF0C4
		public static void AddGravity(FlatBufferBuilder builder, float gravity)
		{
			builder.AddFloat(2, gravity, 0.0);
		}

		// Token: 0x06032F41 RID: 208705 RVA: 0x006E0ED7 File Offset: 0x006DF0D7
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(3, time, 0.0);
		}

		// Token: 0x06032F42 RID: 208706 RVA: 0x006E0EEA File Offset: 0x006DF0EA
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(4, motionCurveOffset.Value, 0);
		}

		// Token: 0x06032F43 RID: 208707 RVA: 0x006E0EFA File Offset: 0x006DF0FA
		public static void AddP2Rot(FlatBufferBuilder builder, Offset<IVectorInfo> p2RotOffset)
		{
			builder.AddOffset(5, p2RotOffset.Value, 0);
		}

		// Token: 0x06032F44 RID: 208708 RVA: 0x006E0F0A File Offset: 0x006DF10A
		public static void AddP2RotCurve(FlatBufferBuilder builder, StringOffset p2RotCurveOffset)
		{
			builder.AddOffset(6, p2RotCurveOffset.Value, 0);
		}

		// Token: 0x06032F45 RID: 208709 RVA: 0x006E0F1A File Offset: 0x006DF11A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06032F46 RID: 208710 RVA: 0x006E0F25 File Offset: 0x006DF125
		public static Offset<IMotorCatapultParam> EndIMotorCatapultParam(FlatBufferBuilder builder)
		{
			return new Offset<IMotorCatapultParam>(builder.EndTable());
		}

		// Token: 0x06032F47 RID: 208711 RVA: 0x006E0F34 File Offset: 0x006DF134
		public IMotorCatapultParamT UnPack()
		{
			IMotorCatapultParamT motorCatapultParamT = new IMotorCatapultParamT();
			this.UnPackTo(motorCatapultParamT);
			return motorCatapultParamT;
		}

		// Token: 0x06032F48 RID: 208712 RVA: 0x006E0F50 File Offset: 0x006DF150
		public void UnPackTo(IMotorCatapultParamT _o)
		{
			_o.P1 = ((this.P1 != null) ? this.P1.Value.UnPack() : null);
			_o.P2 = ((this.P2 != null) ? this.P2.Value.UnPack() : null);
			_o.Gravity = this.Gravity;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.P2Rot = ((this.P2Rot != null) ? this.P2Rot.Value.UnPack() : null);
			_o.P2RotCurve = this.P2RotCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032F49 RID: 208713 RVA: 0x006E1028 File Offset: 0x006DF228
		public static Offset<IMotorCatapultParam> Pack(FlatBufferBuilder builder, IMotorCatapultParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorCatapultParam>);
			}
			Offset<IVectorInfo> p1Offset = (_o.P1 == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.P1);
			Offset<IVectorInfo> p2Offset = (_o.P2 == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.P2);
			StringOffset motionCurveOffset = (_o.MotionCurve == null) ? default(StringOffset) : builder.CreateString(_o.MotionCurve);
			Offset<IVectorInfo> p2RotOffset = (_o.P2Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.P2Rot);
			StringOffset p2RotCurveOffset = (_o.P2RotCurve == null) ? default(StringOffset) : builder.CreateString(_o.P2RotCurve);
			return IMotorCatapultParam.CreateIMotorCatapultParam(builder, p1Offset, p2Offset, _o.Gravity, _o.Time, motionCurveOffset, p2RotOffset, p2RotCurveOffset, _o.NullMask);
		}

		// Token: 0x040122A0 RID: 74400
		private Table __p;
	}
}
