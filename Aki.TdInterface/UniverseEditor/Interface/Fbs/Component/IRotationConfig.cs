using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588B RID: 22667
	public struct IRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700A981 RID: 43393
		// (get) Token: 0x06026312 RID: 156434 RVA: 0x00543B3E File Offset: 0x00541D3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026313 RID: 156435 RVA: 0x00543B4B File Offset: 0x00541D4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026314 RID: 156436 RVA: 0x00543B54 File Offset: 0x00541D54
		public static IRotationConfig GetRootAsIRotationConfig(ByteBuffer _bb)
		{
			return IRotationConfig.GetRootAsIRotationConfig(_bb, default(IRotationConfig));
		}

		// Token: 0x06026315 RID: 156437 RVA: 0x00543B70 File Offset: 0x00541D70
		public static IRotationConfig GetRootAsIRotationConfig(ByteBuffer _bb, IRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026316 RID: 156438 RVA: 0x00543B8D File Offset: 0x00541D8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026317 RID: 156439 RVA: 0x00543B9C File Offset: 0x00541D9C
		public IRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A982 RID: 43394
		// (get) Token: 0x06026318 RID: 156440 RVA: 0x00543BAC File Offset: 0x00541DAC
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

		// Token: 0x1700A983 RID: 43395
		// (get) Token: 0x06026319 RID: 156441 RVA: 0x00543BE8 File Offset: 0x00541DE8
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

		// Token: 0x1700A984 RID: 43396
		// (get) Token: 0x0602631A RID: 156442 RVA: 0x00543C28 File Offset: 0x00541E28
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

		// Token: 0x1700A985 RID: 43397
		// (get) Token: 0x0602631B RID: 156443 RVA: 0x00543C68 File Offset: 0x00541E68
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

		// Token: 0x0602631C RID: 156444 RVA: 0x00543CA0 File Offset: 0x00541EA0
		public Span<byte> GetCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602631D RID: 156445 RVA: 0x00543CB0 File Offset: 0x00541EB0
		public byte[] GetCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A986 RID: 43398
		// (get) Token: 0x0602631E RID: 156446 RVA: 0x00543CC0 File Offset: 0x00541EC0
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

		// Token: 0x1700A987 RID: 43399
		// (get) Token: 0x0602631F RID: 156447 RVA: 0x00543D20 File Offset: 0x00541F20
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

		// Token: 0x1700A988 RID: 43400
		// (get) Token: 0x06026320 RID: 156448 RVA: 0x00543D64 File Offset: 0x00541F64
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

		// Token: 0x06026321 RID: 156449 RVA: 0x00543DA4 File Offset: 0x00541FA4
		public static Offset<IRotationConfig> CreateIRotationConfig(FlatBufferBuilder builder, ERotationType Type = ERotationType.Relative, float Time = 0f, float Cd = 0f, StringOffset CurveOffset = default(StringOffset), Offset<IVectorInfo> AxisOffset = default(Offset<IVectorInfo>), float Angle = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IRotationConfig.AddAngle(builder, Angle);
			IRotationConfig.AddAxis(builder, AxisOffset);
			IRotationConfig.AddCurve(builder, CurveOffset);
			IRotationConfig.AddCd(builder, Cd);
			IRotationConfig.AddTime(builder, Time);
			IRotationConfig.AddNullMask(builder, NullMask);
			IRotationConfig.AddType(builder, Type);
			return IRotationConfig.EndIRotationConfig(builder);
		}

		// Token: 0x06026322 RID: 156450 RVA: 0x00543DF3 File Offset: 0x00541FF3
		public static void StartIRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026323 RID: 156451 RVA: 0x00543DFC File Offset: 0x00541FFC
		public static void AddType(FlatBufferBuilder builder, ERotationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026324 RID: 156452 RVA: 0x00543E07 File Offset: 0x00542007
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06026325 RID: 156453 RVA: 0x00543E1A File Offset: 0x0054201A
		public static void AddCd(FlatBufferBuilder builder, float cd)
		{
			builder.AddFloat(2, cd, 0.0);
		}

		// Token: 0x06026326 RID: 156454 RVA: 0x00543E2D File Offset: 0x0054202D
		public static void AddCurve(FlatBufferBuilder builder, StringOffset curveOffset)
		{
			builder.AddOffset(3, curveOffset.Value, 0);
		}

		// Token: 0x06026327 RID: 156455 RVA: 0x00543E3D File Offset: 0x0054203D
		public static void AddAxis(FlatBufferBuilder builder, Offset<IVectorInfo> axisOffset)
		{
			builder.AddOffset(4, axisOffset.Value, 0);
		}

		// Token: 0x06026328 RID: 156456 RVA: 0x00543E4D File Offset: 0x0054204D
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(5, angle, 0.0);
		}

		// Token: 0x06026329 RID: 156457 RVA: 0x00543E60 File Offset: 0x00542060
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602632A RID: 156458 RVA: 0x00543E6B File Offset: 0x0054206B
		public static Offset<IRotationConfig> EndIRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRotationConfig>(builder.EndTable());
		}

		// Token: 0x0602632B RID: 156459 RVA: 0x00543E78 File Offset: 0x00542078
		public IRotationConfigT UnPack()
		{
			IRotationConfigT rotationConfigT = new IRotationConfigT();
			this.UnPackTo(rotationConfigT);
			return rotationConfigT;
		}

		// Token: 0x0602632C RID: 156460 RVA: 0x00543E94 File Offset: 0x00542094
		public void UnPackTo(IRotationConfigT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
			_o.Cd = this.Cd;
			_o.Curve = this.Curve;
			_o.Axis = ((this.Axis != null) ? this.Axis.Value.UnPack() : null);
			_o.Angle = this.Angle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602632D RID: 156461 RVA: 0x00543F18 File Offset: 0x00542118
		public static Offset<IRotationConfig> Pack(FlatBufferBuilder builder, IRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRotationConfig>);
			}
			StringOffset curveOffset = (_o.Curve == null) ? default(StringOffset) : builder.CreateString(_o.Curve);
			Offset<IVectorInfo> axisOffset = (_o.Axis == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Axis);
			return IRotationConfig.CreateIRotationConfig(builder, _o.Type, _o.Time, _o.Cd, curveOffset, axisOffset, _o.Angle, _o.NullMask);
		}

		// Token: 0x0400EDD6 RID: 60886
		private Table __p;
	}
}
