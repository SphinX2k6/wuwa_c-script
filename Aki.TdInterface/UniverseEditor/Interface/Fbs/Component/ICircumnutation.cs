using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA0 RID: 20384
	public struct ICircumnutation : IFlatbufferObject
	{
		// Token: 0x17009387 RID: 37767
		// (get) Token: 0x060206A9 RID: 132777 RVA: 0x00482878 File Offset: 0x00480A78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060206AA RID: 132778 RVA: 0x00482885 File Offset: 0x00480A85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060206AB RID: 132779 RVA: 0x0048288C File Offset: 0x00480A8C
		public static ICircumnutation GetRootAsICircumnutation(ByteBuffer _bb)
		{
			return ICircumnutation.GetRootAsICircumnutation(_bb, default(ICircumnutation));
		}

		// Token: 0x060206AC RID: 132780 RVA: 0x004828A8 File Offset: 0x00480AA8
		public static ICircumnutation GetRootAsICircumnutation(ByteBuffer _bb, ICircumnutation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060206AD RID: 132781 RVA: 0x004828C5 File Offset: 0x00480AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060206AE RID: 132782 RVA: 0x004828D4 File Offset: 0x00480AD4
		public ICircumnutation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009388 RID: 37768
		// (get) Token: 0x060206AF RID: 132783 RVA: 0x004828E4 File Offset: 0x00480AE4
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

		// Token: 0x17009389 RID: 37769
		// (get) Token: 0x060206B0 RID: 132784 RVA: 0x00482920 File Offset: 0x00480B20
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

		// Token: 0x1700938A RID: 37770
		// (get) Token: 0x060206B1 RID: 132785 RVA: 0x00482960 File Offset: 0x00480B60
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

		// Token: 0x060206B2 RID: 132786 RVA: 0x00482997 File Offset: 0x00480B97
		public Span<byte> GetVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060206B3 RID: 132787 RVA: 0x004829A6 File Offset: 0x00480BA6
		public byte[] GetVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700938B RID: 37771
		// (get) Token: 0x060206B4 RID: 132788 RVA: 0x004829B4 File Offset: 0x00480BB4
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

		// Token: 0x1700938C RID: 37772
		// (get) Token: 0x060206B5 RID: 132789 RVA: 0x004829F4 File Offset: 0x00480BF4
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

		// Token: 0x1700938D RID: 37773
		// (get) Token: 0x060206B6 RID: 132790 RVA: 0x00482A38 File Offset: 0x00480C38
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

		// Token: 0x1700938E RID: 37774
		// (get) Token: 0x060206B7 RID: 132791 RVA: 0x00482A7C File Offset: 0x00480C7C
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

		// Token: 0x060206B8 RID: 132792 RVA: 0x00482AB4 File Offset: 0x00480CB4
		public Span<byte> GetAngularVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060206B9 RID: 132793 RVA: 0x00482AC4 File Offset: 0x00480CC4
		public byte[] GetAngularVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700938F RID: 37775
		// (get) Token: 0x060206BA RID: 132794 RVA: 0x00482AD4 File Offset: 0x00480CD4
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

		// Token: 0x060206BB RID: 132795 RVA: 0x00482B34 File Offset: 0x00480D34
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

		// Token: 0x060206BC RID: 132796 RVA: 0x00482B8B File Offset: 0x00480D8B
		public static void StartICircumnutation(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060206BD RID: 132797 RVA: 0x00482B94 File Offset: 0x00480D94
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060206BE RID: 132798 RVA: 0x00482B9F File Offset: 0x00480D9F
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x060206BF RID: 132799 RVA: 0x00482BB2 File Offset: 0x00480DB2
		public static void AddVelocityCurve(FlatBufferBuilder builder, StringOffset velocityCurveOffset)
		{
			builder.AddOffset(2, velocityCurveOffset.Value, 0);
		}

		// Token: 0x060206C0 RID: 132800 RVA: 0x00482BC2 File Offset: 0x00480DC2
		public static void AddDirection(FlatBufferBuilder builder, EDirection direction)
		{
			builder.AddByte(3, (byte)direction, 0);
		}

		// Token: 0x060206C1 RID: 132801 RVA: 0x00482BCD File Offset: 0x00480DCD
		public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity)
		{
			builder.AddFloat(4, angularVelocity, 0.0);
		}

		// Token: 0x060206C2 RID: 132802 RVA: 0x00482BE0 File Offset: 0x00480DE0
		public static void AddRotationSpeed(FlatBufferBuilder builder, float rotationSpeed)
		{
			builder.AddFloat(5, rotationSpeed, 0.0);
		}

		// Token: 0x060206C3 RID: 132803 RVA: 0x00482BF3 File Offset: 0x00480DF3
		public static void AddAngularVelocityCurve(FlatBufferBuilder builder, StringOffset angularVelocityCurveOffset)
		{
			builder.AddOffset(6, angularVelocityCurveOffset.Value, 0);
		}

		// Token: 0x060206C4 RID: 132804 RVA: 0x00482C03 File Offset: 0x00480E03
		public static void AddRenderTrajectoryConfig(FlatBufferBuilder builder, Offset<IRenderTrajectoryConfig> renderTrajectoryConfigOffset)
		{
			builder.AddOffset(7, renderTrajectoryConfigOffset.Value, 0);
		}

		// Token: 0x060206C5 RID: 132805 RVA: 0x00482C13 File Offset: 0x00480E13
		public static Offset<ICircumnutation> EndICircumnutation(FlatBufferBuilder builder)
		{
			return new Offset<ICircumnutation>(builder.EndTable());
		}

		// Token: 0x060206C6 RID: 132806 RVA: 0x00482C20 File Offset: 0x00480E20
		public ICircumnutationT UnPack()
		{
			ICircumnutationT circumnutationT = new ICircumnutationT();
			this.UnPackTo(circumnutationT);
			return circumnutationT;
		}

		// Token: 0x060206C7 RID: 132807 RVA: 0x00482C3C File Offset: 0x00480E3C
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

		// Token: 0x060206C8 RID: 132808 RVA: 0x00482CCC File Offset: 0x00480ECC
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

		// Token: 0x0400DE6A RID: 56938
		private Table __p;
	}
}
