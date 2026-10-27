using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B12 RID: 27410
	public struct IMotorCatapultParam : IFlatbufferObject
	{
		// Token: 0x1700CB91 RID: 52113
		// (get) Token: 0x06030156 RID: 196950 RVA: 0x0068948B File Offset: 0x0068768B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030157 RID: 196951 RVA: 0x00689498 File Offset: 0x00687698
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030158 RID: 196952 RVA: 0x006894A0 File Offset: 0x006876A0
		public static IMotorCatapultParam GetRootAsIMotorCatapultParam(ByteBuffer _bb)
		{
			return IMotorCatapultParam.GetRootAsIMotorCatapultParam(_bb, default(IMotorCatapultParam));
		}

		// Token: 0x06030159 RID: 196953 RVA: 0x006894BC File Offset: 0x006876BC
		public static IMotorCatapultParam GetRootAsIMotorCatapultParam(ByteBuffer _bb, IMotorCatapultParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603015A RID: 196954 RVA: 0x006894D9 File Offset: 0x006876D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603015B RID: 196955 RVA: 0x006894E8 File Offset: 0x006876E8
		public IMotorCatapultParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB92 RID: 52114
		// (get) Token: 0x0603015C RID: 196956 RVA: 0x006894F8 File Offset: 0x006876F8
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

		// Token: 0x1700CB93 RID: 52115
		// (get) Token: 0x0603015D RID: 196957 RVA: 0x00689558 File Offset: 0x00687758
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

		// Token: 0x1700CB94 RID: 52116
		// (get) Token: 0x0603015E RID: 196958 RVA: 0x006895B8 File Offset: 0x006877B8
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

		// Token: 0x1700CB95 RID: 52117
		// (get) Token: 0x0603015F RID: 196959 RVA: 0x006895F8 File Offset: 0x006877F8
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

		// Token: 0x1700CB96 RID: 52118
		// (get) Token: 0x06030160 RID: 196960 RVA: 0x0068963C File Offset: 0x0068783C
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

		// Token: 0x06030161 RID: 196961 RVA: 0x00689674 File Offset: 0x00687874
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06030162 RID: 196962 RVA: 0x00689684 File Offset: 0x00687884
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700CB97 RID: 52119
		// (get) Token: 0x06030163 RID: 196963 RVA: 0x00689694 File Offset: 0x00687894
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

		// Token: 0x1700CB98 RID: 52120
		// (get) Token: 0x06030164 RID: 196964 RVA: 0x006896F4 File Offset: 0x006878F4
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

		// Token: 0x06030165 RID: 196965 RVA: 0x0068972C File Offset: 0x0068792C
		public Span<byte> GetP2RotCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06030166 RID: 196966 RVA: 0x0068973C File Offset: 0x0068793C
		public byte[] GetP2RotCurveArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700CB99 RID: 52121
		// (get) Token: 0x06030167 RID: 196967 RVA: 0x0068974C File Offset: 0x0068794C
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

		// Token: 0x06030168 RID: 196968 RVA: 0x0068978C File Offset: 0x0068798C
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

		// Token: 0x06030169 RID: 196969 RVA: 0x006897E3 File Offset: 0x006879E3
		public static void StartIMotorCatapultParam(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0603016A RID: 196970 RVA: 0x006897EC File Offset: 0x006879EC
		public static void AddP1(FlatBufferBuilder builder, Offset<IVectorInfo> p1Offset)
		{
			builder.AddOffset(0, p1Offset.Value, 0);
		}

		// Token: 0x0603016B RID: 196971 RVA: 0x006897FC File Offset: 0x006879FC
		public static void AddP2(FlatBufferBuilder builder, Offset<IVectorInfo> p2Offset)
		{
			builder.AddOffset(1, p2Offset.Value, 0);
		}

		// Token: 0x0603016C RID: 196972 RVA: 0x0068980C File Offset: 0x00687A0C
		public static void AddGravity(FlatBufferBuilder builder, float gravity)
		{
			builder.AddFloat(2, gravity, 0.0);
		}

		// Token: 0x0603016D RID: 196973 RVA: 0x0068981F File Offset: 0x00687A1F
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(3, time, 0.0);
		}

		// Token: 0x0603016E RID: 196974 RVA: 0x00689832 File Offset: 0x00687A32
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(4, motionCurveOffset.Value, 0);
		}

		// Token: 0x0603016F RID: 196975 RVA: 0x00689842 File Offset: 0x00687A42
		public static void AddP2Rot(FlatBufferBuilder builder, Offset<IVectorInfo> p2RotOffset)
		{
			builder.AddOffset(5, p2RotOffset.Value, 0);
		}

		// Token: 0x06030170 RID: 196976 RVA: 0x00689852 File Offset: 0x00687A52
		public static void AddP2RotCurve(FlatBufferBuilder builder, StringOffset p2RotCurveOffset)
		{
			builder.AddOffset(6, p2RotCurveOffset.Value, 0);
		}

		// Token: 0x06030171 RID: 196977 RVA: 0x00689862 File Offset: 0x00687A62
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06030172 RID: 196978 RVA: 0x0068986D File Offset: 0x00687A6D
		public static Offset<IMotorCatapultParam> EndIMotorCatapultParam(FlatBufferBuilder builder)
		{
			return new Offset<IMotorCatapultParam>(builder.EndTable());
		}

		// Token: 0x06030173 RID: 196979 RVA: 0x0068987C File Offset: 0x00687A7C
		public IMotorCatapultParamT UnPack()
		{
			IMotorCatapultParamT motorCatapultParamT = new IMotorCatapultParamT();
			this.UnPackTo(motorCatapultParamT);
			return motorCatapultParamT;
		}

		// Token: 0x06030174 RID: 196980 RVA: 0x00689898 File Offset: 0x00687A98
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

		// Token: 0x06030175 RID: 196981 RVA: 0x00689970 File Offset: 0x00687B70
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

		// Token: 0x0401138D RID: 70541
		private Table __p;
	}
}
