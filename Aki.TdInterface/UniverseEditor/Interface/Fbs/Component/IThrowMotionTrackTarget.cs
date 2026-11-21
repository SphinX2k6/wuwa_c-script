using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200607D RID: 24701
	public struct IThrowMotionTrackTarget : IFlatbufferObject
	{
		// Token: 0x1700B77A RID: 46970
		// (get) Token: 0x06029BF3 RID: 170995 RVA: 0x005B3266 File Offset: 0x005B1466
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BF4 RID: 170996 RVA: 0x005B3273 File Offset: 0x005B1473
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BF5 RID: 170997 RVA: 0x005B327C File Offset: 0x005B147C
		public static IThrowMotionTrackTarget GetRootAsIThrowMotionTrackTarget(ByteBuffer _bb)
		{
			return IThrowMotionTrackTarget.GetRootAsIThrowMotionTrackTarget(_bb, default(IThrowMotionTrackTarget));
		}

		// Token: 0x06029BF6 RID: 170998 RVA: 0x005B3298 File Offset: 0x005B1498
		public static IThrowMotionTrackTarget GetRootAsIThrowMotionTrackTarget(ByteBuffer _bb, IThrowMotionTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BF7 RID: 170999 RVA: 0x005B32B5 File Offset: 0x005B14B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BF8 RID: 171000 RVA: 0x005B32C4 File Offset: 0x005B14C4
		public IThrowMotionTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B77B RID: 46971
		// (get) Token: 0x06029BF9 RID: 171001 RVA: 0x005B32D4 File Offset: 0x005B14D4
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

		// Token: 0x1700B77C RID: 46972
		// (get) Token: 0x06029BFA RID: 171002 RVA: 0x005B3310 File Offset: 0x005B1510
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

		// Token: 0x1700B77D RID: 46973
		// (get) Token: 0x06029BFB RID: 171003 RVA: 0x005B3350 File Offset: 0x005B1550
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

		// Token: 0x06029BFC RID: 171004 RVA: 0x005B3387 File Offset: 0x005B1587
		public Span<byte> GetVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029BFD RID: 171005 RVA: 0x005B3396 File Offset: 0x005B1596
		public byte[] GetVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B77E RID: 46974
		// (get) Token: 0x06029BFE RID: 171006 RVA: 0x005B33A4 File Offset: 0x005B15A4
		public IVectorInfo? VelocityOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B77F RID: 46975
		// (get) Token: 0x06029BFF RID: 171007 RVA: 0x005B3404 File Offset: 0x005B1604
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

		// Token: 0x1700B780 RID: 46976
		// (get) Token: 0x06029C00 RID: 171008 RVA: 0x005B3448 File Offset: 0x005B1648
		public string AngularVelocityCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C01 RID: 171009 RVA: 0x005B3480 File Offset: 0x005B1680
		public Span<byte> GetAngularVelocityCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06029C02 RID: 171010 RVA: 0x005B3490 File Offset: 0x005B1690
		public byte[] GetAngularVelocityCurveArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x06029C03 RID: 171011 RVA: 0x005B349F File Offset: 0x005B169F
		public static Offset<IThrowMotionTrackTarget> CreateIThrowMotionTrackTarget(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, float Velocity = 0f, StringOffset VelocityCurveOffset = default(StringOffset), Offset<IVectorInfo> VelocityOffsetOffset = default(Offset<IVectorInfo>), float AngularVelocity = 0f, StringOffset AngularVelocityCurveOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IThrowMotionTrackTarget.AddAngularVelocityCurve(builder, AngularVelocityCurveOffset);
			IThrowMotionTrackTarget.AddAngularVelocity(builder, AngularVelocity);
			IThrowMotionTrackTarget.AddVelocityOffset(builder, VelocityOffsetOffset);
			IThrowMotionTrackTarget.AddVelocityCurve(builder, VelocityCurveOffset);
			IThrowMotionTrackTarget.AddVelocity(builder, Velocity);
			IThrowMotionTrackTarget.AddType(builder, Type);
			return IThrowMotionTrackTarget.EndIThrowMotionTrackTarget(builder);
		}

		// Token: 0x06029C04 RID: 171012 RVA: 0x005B34DB File Offset: 0x005B16DB
		public static void StartIThrowMotionTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029C05 RID: 171013 RVA: 0x005B34E4 File Offset: 0x005B16E4
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029C06 RID: 171014 RVA: 0x005B34EF File Offset: 0x005B16EF
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x06029C07 RID: 171015 RVA: 0x005B3502 File Offset: 0x005B1702
		public static void AddVelocityCurve(FlatBufferBuilder builder, StringOffset velocityCurveOffset)
		{
			builder.AddOffset(2, velocityCurveOffset.Value, 0);
		}

		// Token: 0x06029C08 RID: 171016 RVA: 0x005B3512 File Offset: 0x005B1712
		public static void AddVelocityOffset(FlatBufferBuilder builder, Offset<IVectorInfo> velocityOffsetOffset)
		{
			builder.AddOffset(3, velocityOffsetOffset.Value, 0);
		}

		// Token: 0x06029C09 RID: 171017 RVA: 0x005B3522 File Offset: 0x005B1722
		public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity)
		{
			builder.AddFloat(4, angularVelocity, 0.0);
		}

		// Token: 0x06029C0A RID: 171018 RVA: 0x005B3535 File Offset: 0x005B1735
		public static void AddAngularVelocityCurve(FlatBufferBuilder builder, StringOffset angularVelocityCurveOffset)
		{
			builder.AddOffset(5, angularVelocityCurveOffset.Value, 0);
		}

		// Token: 0x06029C0B RID: 171019 RVA: 0x005B3545 File Offset: 0x005B1745
		public static Offset<IThrowMotionTrackTarget> EndIThrowMotionTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotionTrackTarget>(builder.EndTable());
		}

		// Token: 0x06029C0C RID: 171020 RVA: 0x005B3554 File Offset: 0x005B1754
		public IThrowMotionTrackTargetT UnPack()
		{
			IThrowMotionTrackTargetT throwMotionTrackTargetT = new IThrowMotionTrackTargetT();
			this.UnPackTo(throwMotionTrackTargetT);
			return throwMotionTrackTargetT;
		}

		// Token: 0x06029C0D RID: 171021 RVA: 0x005B3570 File Offset: 0x005B1770
		public void UnPackTo(IThrowMotionTrackTargetT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = this.Velocity;
			_o.VelocityCurve = this.VelocityCurve;
			_o.VelocityOffset = ((this.VelocityOffset != null) ? this.VelocityOffset.Value.UnPack() : null);
			_o.AngularVelocity = this.AngularVelocity;
			_o.AngularVelocityCurve = this.AngularVelocityCurve;
		}

		// Token: 0x06029C0E RID: 171022 RVA: 0x005B35E8 File Offset: 0x005B17E8
		public static Offset<IThrowMotionTrackTarget> Pack(FlatBufferBuilder builder, IThrowMotionTrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowMotionTrackTarget>);
			}
			StringOffset velocityCurveOffset = (_o.VelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.VelocityCurve);
			Offset<IVectorInfo> velocityOffsetOffset = (_o.VelocityOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.VelocityOffset);
			StringOffset angularVelocityCurveOffset = (_o.AngularVelocityCurve == null) ? default(StringOffset) : builder.CreateString(_o.AngularVelocityCurve);
			return IThrowMotionTrackTarget.CreateIThrowMotionTrackTarget(builder, _o.Type, _o.Velocity, velocityCurveOffset, velocityOffsetOffset, _o.AngularVelocity, angularVelocityCurveOffset);
		}

		// Token: 0x0400FDFE RID: 65022
		private Table __p;
	}
}
