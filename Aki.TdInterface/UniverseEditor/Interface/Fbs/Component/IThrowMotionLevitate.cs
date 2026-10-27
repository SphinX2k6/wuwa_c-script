using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6D RID: 23149
	public struct IThrowMotionLevitate : IFlatbufferObject
	{
		// Token: 0x1700AE33 RID: 44595
		// (get) Token: 0x0602764F RID: 161359 RVA: 0x0056BC96 File Offset: 0x00569E96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027650 RID: 161360 RVA: 0x0056BCA3 File Offset: 0x00569EA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027651 RID: 161361 RVA: 0x0056BCAC File Offset: 0x00569EAC
		public static IThrowMotionLevitate GetRootAsIThrowMotionLevitate(ByteBuffer _bb)
		{
			return IThrowMotionLevitate.GetRootAsIThrowMotionLevitate(_bb, default(IThrowMotionLevitate));
		}

		// Token: 0x06027652 RID: 161362 RVA: 0x0056BCC8 File Offset: 0x00569EC8
		public static IThrowMotionLevitate GetRootAsIThrowMotionLevitate(ByteBuffer _bb, IThrowMotionLevitate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027653 RID: 161363 RVA: 0x0056BCE5 File Offset: 0x00569EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027654 RID: 161364 RVA: 0x0056BCF4 File Offset: 0x00569EF4
		public IThrowMotionLevitate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE34 RID: 44596
		// (get) Token: 0x06027655 RID: 161365 RVA: 0x0056BD04 File Offset: 0x00569F04
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

		// Token: 0x1700AE35 RID: 44597
		// (get) Token: 0x06027656 RID: 161366 RVA: 0x0056BD40 File Offset: 0x00569F40
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

		// Token: 0x1700AE36 RID: 44598
		// (get) Token: 0x06027657 RID: 161367 RVA: 0x0056BD80 File Offset: 0x00569F80
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

		// Token: 0x06027658 RID: 161368 RVA: 0x0056BDB7 File Offset: 0x00569FB7
		public Span<byte> GetVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027659 RID: 161369 RVA: 0x0056BDC6 File Offset: 0x00569FC6
		public byte[] GetVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AE37 RID: 44599
		// (get) Token: 0x0602765A RID: 161370 RVA: 0x0056BDD4 File Offset: 0x00569FD4
		public float MoveTime
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

		// Token: 0x1700AE38 RID: 44600
		// (get) Token: 0x0602765B RID: 161371 RVA: 0x0056BE18 File Offset: 0x0056A018
		public float RayRadius
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

		// Token: 0x1700AE39 RID: 44601
		// (get) Token: 0x0602765C RID: 161372 RVA: 0x0056BE5C File Offset: 0x0056A05C
		public IRenderTrajectoryConfig? RenderTrajectoryConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IRenderTrajectoryConfig?(default(IRenderTrajectoryConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE3A RID: 44602
		// (get) Token: 0x0602765D RID: 161373 RVA: 0x0056BEBC File Offset: 0x0056A0BC
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

		// Token: 0x0602765E RID: 161374 RVA: 0x0056BEFC File Offset: 0x0056A0FC
		public static Offset<IThrowMotionLevitate> CreateIThrowMotionLevitate(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, float Velocity = 0f, StringOffset VelocityCurveOffset = default(StringOffset), float MoveTime = 0f, float RayRadius = 0f, Offset<IRenderTrajectoryConfig> RenderTrajectoryConfigOffset = default(Offset<IRenderTrajectoryConfig>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IThrowMotionLevitate.AddRenderTrajectoryConfig(builder, RenderTrajectoryConfigOffset);
			IThrowMotionLevitate.AddRayRadius(builder, RayRadius);
			IThrowMotionLevitate.AddMoveTime(builder, MoveTime);
			IThrowMotionLevitate.AddVelocityCurve(builder, VelocityCurveOffset);
			IThrowMotionLevitate.AddVelocity(builder, Velocity);
			IThrowMotionLevitate.AddNullMask(builder, NullMask);
			IThrowMotionLevitate.AddType(builder, Type);
			return IThrowMotionLevitate.EndIThrowMotionLevitate(builder);
		}

		// Token: 0x0602765F RID: 161375 RVA: 0x0056BF4B File Offset: 0x0056A14B
		public static void StartIThrowMotionLevitate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06027660 RID: 161376 RVA: 0x0056BF54 File Offset: 0x0056A154
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027661 RID: 161377 RVA: 0x0056BF5F File Offset: 0x0056A15F
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x06027662 RID: 161378 RVA: 0x0056BF72 File Offset: 0x0056A172
		public static void AddVelocityCurve(FlatBufferBuilder builder, StringOffset velocityCurveOffset)
		{
			builder.AddOffset(2, velocityCurveOffset.Value, 0);
		}

		// Token: 0x06027663 RID: 161379 RVA: 0x0056BF82 File Offset: 0x0056A182
		public static void AddMoveTime(FlatBufferBuilder builder, float moveTime)
		{
			builder.AddFloat(3, moveTime, 0.0);
		}

		// Token: 0x06027664 RID: 161380 RVA: 0x0056BF95 File Offset: 0x0056A195
		public static void AddRayRadius(FlatBufferBuilder builder, float rayRadius)
		{
			builder.AddFloat(4, rayRadius, 0.0);
		}

		// Token: 0x06027665 RID: 161381 RVA: 0x0056BFA8 File Offset: 0x0056A1A8
		public static void AddRenderTrajectoryConfig(FlatBufferBuilder builder, Offset<IRenderTrajectoryConfig> renderTrajectoryConfigOffset)
		{
			builder.AddOffset(5, renderTrajectoryConfigOffset.Value, 0);
		}

		// Token: 0x06027666 RID: 161382 RVA: 0x0056BFB8 File Offset: 0x0056A1B8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06027667 RID: 161383 RVA: 0x0056BFC3 File Offset: 0x0056A1C3
		public static Offset<IThrowMotionLevitate> EndIThrowMotionLevitate(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotionLevitate>(builder.EndTable());
		}

		// Token: 0x06027668 RID: 161384 RVA: 0x0056BFD0 File Offset: 0x0056A1D0
		public IThrowMotionLevitateT UnPack()
		{
			IThrowMotionLevitateT throwMotionLevitateT = new IThrowMotionLevitateT();
			this.UnPackTo(throwMotionLevitateT);
			return throwMotionLevitateT;
		}

		// Token: 0x06027669 RID: 161385 RVA: 0x0056BFEC File Offset: 0x0056A1EC
		public void UnPackTo(IThrowMotionLevitateT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = this.Velocity;
			_o.VelocityCurve = this.VelocityCurve;
			_o.MoveTime = this.MoveTime;
			_o.RayRadius = this.RayRadius;
			_o.RenderTrajectoryConfig = ((this.RenderTrajectoryConfig != null) ? this.RenderTrajectoryConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602766A RID: 161386 RVA: 0x0056C070 File Offset: 0x0056A270
		public static Offset<IThrowMotionLevitate> Pack(FlatBufferBuilder builder, IThrowMotionLevitateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowMotionLevitate>);
			}
			StringOffset velocityCurveOffset = (_o.VelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.VelocityCurve);
			Offset<IRenderTrajectoryConfig> renderTrajectoryConfigOffset = (_o.RenderTrajectoryConfig == null) ? default(Offset<IRenderTrajectoryConfig>) : IRenderTrajectoryConfig.Pack(builder, _o.RenderTrajectoryConfig);
			return IThrowMotionLevitate.CreateIThrowMotionLevitate(builder, _o.Type, _o.Velocity, velocityCurveOffset, _o.MoveTime, _o.RayRadius, renderTrajectoryConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F0FF RID: 61695
		private Table __p;
	}
}
