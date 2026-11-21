using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200607A RID: 24698
	public struct IThrowMotionLevitate : IFlatbufferObject
	{
		// Token: 0x1700B76B RID: 46955
		// (get) Token: 0x06029BC7 RID: 170951 RVA: 0x005B2CA2 File Offset: 0x005B0EA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BC8 RID: 170952 RVA: 0x005B2CAF File Offset: 0x005B0EAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BC9 RID: 170953 RVA: 0x005B2CB8 File Offset: 0x005B0EB8
		public static IThrowMotionLevitate GetRootAsIThrowMotionLevitate(ByteBuffer _bb)
		{
			return IThrowMotionLevitate.GetRootAsIThrowMotionLevitate(_bb, default(IThrowMotionLevitate));
		}

		// Token: 0x06029BCA RID: 170954 RVA: 0x005B2CD4 File Offset: 0x005B0ED4
		public static IThrowMotionLevitate GetRootAsIThrowMotionLevitate(ByteBuffer _bb, IThrowMotionLevitate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BCB RID: 170955 RVA: 0x005B2CF1 File Offset: 0x005B0EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BCC RID: 170956 RVA: 0x005B2D00 File Offset: 0x005B0F00
		public IThrowMotionLevitate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B76C RID: 46956
		// (get) Token: 0x06029BCD RID: 170957 RVA: 0x005B2D10 File Offset: 0x005B0F10
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

		// Token: 0x1700B76D RID: 46957
		// (get) Token: 0x06029BCE RID: 170958 RVA: 0x005B2D4C File Offset: 0x005B0F4C
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

		// Token: 0x1700B76E RID: 46958
		// (get) Token: 0x06029BCF RID: 170959 RVA: 0x005B2D8C File Offset: 0x005B0F8C
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

		// Token: 0x06029BD0 RID: 170960 RVA: 0x005B2DC3 File Offset: 0x005B0FC3
		public Span<byte> GetVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029BD1 RID: 170961 RVA: 0x005B2DD2 File Offset: 0x005B0FD2
		public byte[] GetVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B76F RID: 46959
		// (get) Token: 0x06029BD2 RID: 170962 RVA: 0x005B2DE0 File Offset: 0x005B0FE0
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

		// Token: 0x1700B770 RID: 46960
		// (get) Token: 0x06029BD3 RID: 170963 RVA: 0x005B2E24 File Offset: 0x005B1024
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

		// Token: 0x1700B771 RID: 46961
		// (get) Token: 0x06029BD4 RID: 170964 RVA: 0x005B2E68 File Offset: 0x005B1068
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

		// Token: 0x1700B772 RID: 46962
		// (get) Token: 0x06029BD5 RID: 170965 RVA: 0x005B2EC8 File Offset: 0x005B10C8
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

		// Token: 0x06029BD6 RID: 170966 RVA: 0x005B2F08 File Offset: 0x005B1108
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

		// Token: 0x06029BD7 RID: 170967 RVA: 0x005B2F57 File Offset: 0x005B1157
		public static void StartIThrowMotionLevitate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06029BD8 RID: 170968 RVA: 0x005B2F60 File Offset: 0x005B1160
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029BD9 RID: 170969 RVA: 0x005B2F6B File Offset: 0x005B116B
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x06029BDA RID: 170970 RVA: 0x005B2F7E File Offset: 0x005B117E
		public static void AddVelocityCurve(FlatBufferBuilder builder, StringOffset velocityCurveOffset)
		{
			builder.AddOffset(2, velocityCurveOffset.Value, 0);
		}

		// Token: 0x06029BDB RID: 170971 RVA: 0x005B2F8E File Offset: 0x005B118E
		public static void AddMoveTime(FlatBufferBuilder builder, float moveTime)
		{
			builder.AddFloat(3, moveTime, 0.0);
		}

		// Token: 0x06029BDC RID: 170972 RVA: 0x005B2FA1 File Offset: 0x005B11A1
		public static void AddRayRadius(FlatBufferBuilder builder, float rayRadius)
		{
			builder.AddFloat(4, rayRadius, 0.0);
		}

		// Token: 0x06029BDD RID: 170973 RVA: 0x005B2FB4 File Offset: 0x005B11B4
		public static void AddRenderTrajectoryConfig(FlatBufferBuilder builder, Offset<IRenderTrajectoryConfig> renderTrajectoryConfigOffset)
		{
			builder.AddOffset(5, renderTrajectoryConfigOffset.Value, 0);
		}

		// Token: 0x06029BDE RID: 170974 RVA: 0x005B2FC4 File Offset: 0x005B11C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06029BDF RID: 170975 RVA: 0x005B2FCF File Offset: 0x005B11CF
		public static Offset<IThrowMotionLevitate> EndIThrowMotionLevitate(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotionLevitate>(builder.EndTable());
		}

		// Token: 0x06029BE0 RID: 170976 RVA: 0x005B2FDC File Offset: 0x005B11DC
		public IThrowMotionLevitateT UnPack()
		{
			IThrowMotionLevitateT throwMotionLevitateT = new IThrowMotionLevitateT();
			this.UnPackTo(throwMotionLevitateT);
			return throwMotionLevitateT;
		}

		// Token: 0x06029BE1 RID: 170977 RVA: 0x005B2FF8 File Offset: 0x005B11F8
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

		// Token: 0x06029BE2 RID: 170978 RVA: 0x005B307C File Offset: 0x005B127C
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

		// Token: 0x0400FDF6 RID: 65014
		private Table __p;
	}
}
