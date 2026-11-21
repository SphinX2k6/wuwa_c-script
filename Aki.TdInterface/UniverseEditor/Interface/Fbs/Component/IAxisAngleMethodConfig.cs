using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005418 RID: 21528
	public struct IAxisAngleMethodConfig : IFlatbufferObject
	{
		// Token: 0x17009872 RID: 39026
		// (get) Token: 0x06021AC1 RID: 137921 RVA: 0x004A412F File Offset: 0x004A232F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021AC2 RID: 137922 RVA: 0x004A413C File Offset: 0x004A233C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021AC3 RID: 137923 RVA: 0x004A4144 File Offset: 0x004A2344
		public static IAxisAngleMethodConfig GetRootAsIAxisAngleMethodConfig(ByteBuffer _bb)
		{
			return IAxisAngleMethodConfig.GetRootAsIAxisAngleMethodConfig(_bb, default(IAxisAngleMethodConfig));
		}

		// Token: 0x06021AC4 RID: 137924 RVA: 0x004A4160 File Offset: 0x004A2360
		public static IAxisAngleMethodConfig GetRootAsIAxisAngleMethodConfig(ByteBuffer _bb, IAxisAngleMethodConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021AC5 RID: 137925 RVA: 0x004A417D File Offset: 0x004A237D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021AC6 RID: 137926 RVA: 0x004A418C File Offset: 0x004A238C
		public IAxisAngleMethodConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009873 RID: 39027
		// (get) Token: 0x06021AC7 RID: 137927 RVA: 0x004A419C File Offset: 0x004A239C
		public ERotationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERotationType.Relative;
				}
				return (ERotationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009874 RID: 39028
		// (get) Token: 0x06021AC8 RID: 137928 RVA: 0x004A41D8 File Offset: 0x004A23D8
		public float Time
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

		// Token: 0x17009875 RID: 39029
		// (get) Token: 0x06021AC9 RID: 137929 RVA: 0x004A4218 File Offset: 0x004A2418
		public float Cd
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

		// Token: 0x17009876 RID: 39030
		// (get) Token: 0x06021ACA RID: 137930 RVA: 0x004A4258 File Offset: 0x004A2458
		public string Curve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021ACB RID: 137931 RVA: 0x004A4290 File Offset: 0x004A2490
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06021ACC RID: 137932 RVA: 0x004A42A0 File Offset: 0x004A24A0
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009877 RID: 39031
		// (get) Token: 0x06021ACD RID: 137933 RVA: 0x004A42B0 File Offset: 0x004A24B0
		public IVectorInfo? Axis
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009878 RID: 39032
		// (get) Token: 0x06021ACE RID: 137934 RVA: 0x004A4310 File Offset: 0x004A2510
		public float Angle
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

		// Token: 0x17009879 RID: 39033
		// (get) Token: 0x06021ACF RID: 137935 RVA: 0x004A4354 File Offset: 0x004A2554
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021AD0 RID: 137936 RVA: 0x004A4394 File Offset: 0x004A2594
		public static Offset<IAxisAngleMethodConfig> CreateIAxisAngleMethodConfig(FlatBufferBuilder builder, ERotationType Type = ERotationType.Relative, float Time = 0f, float Cd = 0f, StringOffset CurveOffset = default(StringOffset), Offset<IVectorInfo> AxisOffset = default(Offset<IVectorInfo>), float Angle = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IAxisAngleMethodConfig.AddAngle(builder, Angle);
			IAxisAngleMethodConfig.AddAxis(builder, AxisOffset);
			IAxisAngleMethodConfig.AddCurve(builder, CurveOffset);
			IAxisAngleMethodConfig.AddCd(builder, Cd);
			IAxisAngleMethodConfig.AddTime(builder, Time);
			IAxisAngleMethodConfig.AddNullMask(builder, NullMask);
			IAxisAngleMethodConfig.AddType(builder, Type);
			return IAxisAngleMethodConfig.EndIAxisAngleMethodConfig(builder);
		}

		// Token: 0x06021AD1 RID: 137937 RVA: 0x004A43E3 File Offset: 0x004A25E3
		public static void StartIAxisAngleMethodConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06021AD2 RID: 137938 RVA: 0x004A43EC File Offset: 0x004A25EC
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021AD3 RID: 137939 RVA: 0x004A43F7 File Offset: 0x004A25F7
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06021AD4 RID: 137940 RVA: 0x004A440A File Offset: 0x004A260A
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06021AD5 RID: 137941 RVA: 0x004A441D File Offset: 0x004A261D
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06021AD6 RID: 137942 RVA: 0x004A442D File Offset: 0x004A262D
		public static void AddAxis(FlatBufferBuilder builder, Offset<IVectorInfo> axisOffset)
		{
			builder.AddOffset(4, axisOffset.Value, 0);
		}

		// Token: 0x06021AD7 RID: 137943 RVA: 0x004A443D File Offset: 0x004A263D
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(5, angle, 0.0);
		}

		// Token: 0x06021AD8 RID: 137944 RVA: 0x004A4450 File Offset: 0x004A2650
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06021AD9 RID: 137945 RVA: 0x004A445B File Offset: 0x004A265B
		public static Offset<IAxisAngleMethodConfig> EndIAxisAngleMethodConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAxisAngleMethodConfig>(builder.EndTable());
		}

		// Token: 0x06021ADA RID: 137946 RVA: 0x004A4468 File Offset: 0x004A2668
		public IAxisAngleMethodConfigT UnPack()
		{
			IAxisAngleMethodConfigT axisAngleMethodConfigT = new IAxisAngleMethodConfigT();
			this.UnPackTo(axisAngleMethodConfigT);
			return axisAngleMethodConfigT;
		}

		// Token: 0x06021ADB RID: 137947 RVA: 0x004A4484 File Offset: 0x004A2684
		public void UnPackTo(IAxisAngleMethodConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.Axis = ((this.Axis != null) ? this.Axis.Value.UnPack() : null);
			_o.Angle = this.Angle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021ADC RID: 137948 RVA: 0x004A4508 File Offset: 0x004A2708
		public static Offset<IAxisAngleMethodConfig> Pack(FlatBufferBuilder builder, IAxisAngleMethodConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAxisAngleMethodConfig>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			Offset<IVectorInfo> axisOffset = (_o.Axis == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Axis);
			return IAxisAngleMethodConfig.CreateIAxisAngleMethodConfig(builder, _o.Type, _o.Time, _o.Cd, curveOffset, axisOffset, _o.Angle, _o.NullMask);
		}

		// Token: 0x0400E899 RID: 59545
		private Table __p;
	}
}
