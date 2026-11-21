using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FC RID: 21756
	public struct ICircumnutation : IFlatbufferObject
	{
		// Token: 0x17009B5F RID: 39775
		// (get) Token: 0x0602259D RID: 140701 RVA: 0x004BBD59 File Offset: 0x004B9F59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602259E RID: 140702 RVA: 0x004BBD66 File Offset: 0x004B9F66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602259F RID: 140703 RVA: 0x004BBD70 File Offset: 0x004B9F70
		public static ICircumnutation GetRootAsICircumnutation(ByteBuffer _bb)
		{
			return ICircumnutation.GetRootAsICircumnutation(_bb, default(ICircumnutation));
		}

		// Token: 0x060225A0 RID: 140704 RVA: 0x004BBD8C File Offset: 0x004B9F8C
		public static ICircumnutation GetRootAsICircumnutation(ByteBuffer _bb, ICircumnutation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060225A1 RID: 140705 RVA: 0x004BBDA9 File Offset: 0x004B9FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060225A2 RID: 140706 RVA: 0x004BBDB8 File Offset: 0x004B9FB8
		public ICircumnutation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B60 RID: 39776
		// (get) Token: 0x060225A3 RID: 140707 RVA: 0x004BBDC8 File Offset: 0x004B9FC8
		public EThrowMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EThrowMotion.Projectile;
				}
				return (EThrowMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B61 RID: 39777
		// (get) Token: 0x060225A4 RID: 140708 RVA: 0x004BBE04 File Offset: 0x004BA004
		public float Velocity
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

		// Token: 0x17009B62 RID: 39778
		// (get) Token: 0x060225A5 RID: 140709 RVA: 0x004BBE44 File Offset: 0x004BA044
		public string VelocityCurve
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060225A6 RID: 140710 RVA: 0x004BBE7B File Offset: 0x004BA07B
		public Span<byte> GetVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060225A7 RID: 140711 RVA: 0x004BBE8A File Offset: 0x004BA08A
		public byte[] GetVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009B63 RID: 39779
		// (get) Token: 0x060225A8 RID: 140712 RVA: 0x004BBE98 File Offset: 0x004BA098
		public EDirection Direction
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDirection.Right;
				}
				return (EDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B64 RID: 39780
		// (get) Token: 0x060225A9 RID: 140713 RVA: 0x004BBED8 File Offset: 0x004BA0D8
		public float AngularVelocity
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B65 RID: 39781
		// (get) Token: 0x060225AA RID: 140714 RVA: 0x004BBF1C File Offset: 0x004BA11C
		public float RotationSpeed
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

		// Token: 0x17009B66 RID: 39782
		// (get) Token: 0x060225AB RID: 140715 RVA: 0x004BBF60 File Offset: 0x004BA160
		public string AngularVelocityCurve
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

		// Token: 0x060225AC RID: 140716 RVA: 0x004BBF98 File Offset: 0x004BA198
		public Span<byte> GetAngularVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060225AD RID: 140717 RVA: 0x004BBFA8 File Offset: 0x004BA1A8
		public byte[] GetAngularVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17009B67 RID: 39783
		// (get) Token: 0x060225AE RID: 140718 RVA: 0x004BBFB8 File Offset: 0x004BA1B8
		public IRenderTrajectoryConfig? RenderTrajectoryConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IRenderTrajectoryConfig?(default(IRenderTrajectoryConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060225AF RID: 140719 RVA: 0x004BC018 File Offset: 0x004BA218
		public static Offset<ICircumnutation> CreateICircumnutation(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, float Velocity = 0f, StringOffset VelocityCurveOffset = default(StringOffset), EDirection Direction = EDirection.Right, float AngularVelocity = 0f, float RotationSpeed = 0f, StringOffset AngularVelocityCurveOffset = default(StringOffset), Offset<IRenderTrajectoryConfig> RenderTrajectoryConfigOffset = default(Offset<IRenderTrajectoryConfig>))
		{
			builder.StartTable(8);
			ICircumnutation.AddRenderTrajectoryConfig(builder, RenderTrajectoryConfigOffset);
			ICircumnutation.AddAngularVelocityCurve(builder, AngularVelocityCurveOffset);
			ICircumnutation.AddRotationSpeed(builder, RotationSpeed);
			ICircumnutation.AddAngularVelocity(builder, AngularVelocity);
			ICircumnutation.AddVelocityCurve(builder, VelocityCurveOffset);
			ICircumnutation.AddVelocity(builder, Velocity);
			ICircumnutation.AddDirection(builder, Direction);
			ICircumnutation.AddType(builder, Type);
			return ICircumnutation.EndICircumnutation(builder);
		}

		// Token: 0x060225B0 RID: 140720 RVA: 0x004BC06F File Offset: 0x004BA26F
		public static void StartICircumnutation(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060225B1 RID: 140721 RVA: 0x004BC078 File Offset: 0x004BA278
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060225B2 RID: 140722 RVA: 0x004BC083 File Offset: 0x004BA283
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x060225B3 RID: 140723 RVA: 0x004BC096 File Offset: 0x004BA296
		public static void AddVelocityCurve(FlatBufferBuilder builder, StringOffset velocityCurveOffset)
		{
			builder.AddOffset(2, velocityCurveOffset.Value, 0);
		}

		// Token: 0x060225B4 RID: 140724 RVA: 0x004BC0A6 File Offset: 0x004BA2A6
		public static void AddDirection(FlatBufferBuilder builder, EDirection direction)
		{
			builder.AddByte(3, (byte)direction, 0);
		}

		// Token: 0x060225B5 RID: 140725 RVA: 0x004BC0B1 File Offset: 0x004BA2B1
		public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity)
		{
			builder.AddFloat(4, angularVelocity, 0.0);
		}

		// Token: 0x060225B6 RID: 140726 RVA: 0x004BC0C4 File Offset: 0x004BA2C4
		public static void AddRotationSpeed(FlatBufferBuilder builder, float rotationSpeed)
		{
			builder.AddFloat(5, rotationSpeed, 0.0);
		}

		// Token: 0x060225B7 RID: 140727 RVA: 0x004BC0D7 File Offset: 0x004BA2D7
		public static void AddAngularVelocityCurve(FlatBufferBuilder builder, StringOffset angularVelocityCurveOffset)
		{
			builder.AddOffset(6, angularVelocityCurveOffset.Value, 0);
		}

		// Token: 0x060225B8 RID: 140728 RVA: 0x004BC0E7 File Offset: 0x004BA2E7
		public static void AddRenderTrajectoryConfig(FlatBufferBuilder builder, Offset<IRenderTrajectoryConfig> renderTrajectoryConfigOffset)
		{
			builder.AddOffset(7, renderTrajectoryConfigOffset.Value, 0);
		}

		// Token: 0x060225B9 RID: 140729 RVA: 0x004BC0F7 File Offset: 0x004BA2F7
		public static Offset<ICircumnutation> EndICircumnutation(FlatBufferBuilder builder)
		{
			return new Offset<ICircumnutation>(builder.EndTable());
		}

		// Token: 0x060225BA RID: 140730 RVA: 0x004BC104 File Offset: 0x004BA304
		public ICircumnutationT UnPack()
		{
			ICircumnutationT circumnutationT = new ICircumnutationT();
			this.UnPackTo(circumnutationT);
			return circumnutationT;
		}

		// Token: 0x060225BB RID: 140731 RVA: 0x004BC120 File Offset: 0x004BA320
		public void UnPackTo(ICircumnutationT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = this.Velocity;
			_o.VelocityCurve = this.VelocityCurve;
			_o.Direction = this.Direction;
			_o.AngularVelocity = this.AngularVelocity;
			_o.RotationSpeed = this.RotationSpeed;
			_o.AngularVelocityCurve = this.AngularVelocityCurve;
			_o.RenderTrajectoryConfig = ((this.RenderTrajectoryConfig != null) ? this.RenderTrajectoryConfig.Value.UnPack() : null);
		}

		// Token: 0x060225BC RID: 140732 RVA: 0x004BC1B0 File Offset: 0x004BA3B0
		public static Offset<ICircumnutation> Pack(FlatBufferBuilder builder, ICircumnutationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircumnutation>);
			}
			StringOffset velocityCurveOffset = (_o.VelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.VelocityCurve);
			StringOffset angularVelocityCurveOffset = (_o.AngularVelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.AngularVelocityCurve);
			Offset<IRenderTrajectoryConfig> renderTrajectoryConfigOffset = (_o.RenderTrajectoryConfig == null) ? default(Offset<IRenderTrajectoryConfig>) : IRenderTrajectoryConfig.Pack(builder, _o.RenderTrajectoryConfig);
			return ICircumnutation.CreateICircumnutation(builder, _o.Type, _o.Velocity, velocityCurveOffset, _o.Direction, _o.AngularVelocity, _o.RotationSpeed, angularVelocityCurveOffset, renderTrajectoryConfigOffset);
		}

		// Token: 0x0400EA58 RID: 59992
		private Table __p;
	}
}
