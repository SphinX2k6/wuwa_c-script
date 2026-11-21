using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DAC RID: 23980
	public struct IProjectileMotion : IFlatbufferObject
	{
		// Token: 0x1700B090 RID: 45200
		// (get) Token: 0x06027F60 RID: 163680 RVA: 0x0057758E File Offset: 0x0057578E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F61 RID: 163681 RVA: 0x0057759B File Offset: 0x0057579B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F62 RID: 163682 RVA: 0x005775A4 File Offset: 0x005757A4
		public static IProjectileMotion GetRootAsIProjectileMotion(ByteBuffer _bb)
		{
			return IProjectileMotion.GetRootAsIProjectileMotion(_bb, default(IProjectileMotion));
		}

		// Token: 0x06027F63 RID: 163683 RVA: 0x005775C0 File Offset: 0x005757C0
		public static IProjectileMotion GetRootAsIProjectileMotion(ByteBuffer _bb, IProjectileMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F64 RID: 163684 RVA: 0x005775DD File Offset: 0x005757DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F65 RID: 163685 RVA: 0x005775EC File Offset: 0x005757EC
		public IProjectileMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B091 RID: 45201
		// (get) Token: 0x06027F66 RID: 163686 RVA: 0x005775FC File Offset: 0x005757FC
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

		// Token: 0x1700B092 RID: 45202
		// (get) Token: 0x06027F67 RID: 163687 RVA: 0x00577638 File Offset: 0x00575838
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

		// Token: 0x1700B093 RID: 45203
		// (get) Token: 0x06027F68 RID: 163688 RVA: 0x00577678 File Offset: 0x00575878
		public float AngularVelocity
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

		// Token: 0x1700B094 RID: 45204
		// (get) Token: 0x06027F69 RID: 163689 RVA: 0x005776B8 File Offset: 0x005758B8
		public string CameraShake
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

		// Token: 0x06027F6A RID: 163690 RVA: 0x005776F0 File Offset: 0x005758F0
		public Span<byte> GetCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06027F6B RID: 163691 RVA: 0x00577700 File Offset: 0x00575900
		public byte[] GetCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B095 RID: 45205
		// (get) Token: 0x06027F6C RID: 163692 RVA: 0x00577710 File Offset: 0x00575910
		public ISpeedCurveMotion? MatchSpeedCurve
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ISpeedCurveMotion?(default(ISpeedCurveMotion).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027F6D RID: 163693 RVA: 0x0057776E File Offset: 0x0057596E
		public static Offset<IProjectileMotion> CreateIProjectileMotion(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, float Velocity = 0f, float AngularVelocity = 0f, StringOffset CameraShakeOffset = default(StringOffset), Offset<ISpeedCurveMotion> MatchSpeedCurveOffset = default(Offset<ISpeedCurveMotion>))
		{
			builder.StartTable(5);
			IProjectileMotion.AddMatchSpeedCurve(builder, MatchSpeedCurveOffset);
			IProjectileMotion.AddCameraShake(builder, CameraShakeOffset);
			IProjectileMotion.AddAngularVelocity(builder, AngularVelocity);
			IProjectileMotion.AddVelocity(builder, Velocity);
			IProjectileMotion.AddType(builder, Type);
			return IProjectileMotion.EndIProjectileMotion(builder);
		}

		// Token: 0x06027F6E RID: 163694 RVA: 0x005777A2 File Offset: 0x005759A2
		public static void StartIProjectileMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027F6F RID: 163695 RVA: 0x005777AB File Offset: 0x005759AB
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027F70 RID: 163696 RVA: 0x005777B6 File Offset: 0x005759B6
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x06027F71 RID: 163697 RVA: 0x005777C9 File Offset: 0x005759C9
		public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity)
		{
			builder.AddFloat(2, angularVelocity, 0.0);
		}

		// Token: 0x06027F72 RID: 163698 RVA: 0x005777DC File Offset: 0x005759DC
		public static void AddCameraShake(FlatBufferBuilder builder, StringOffset cameraShakeOffset)
		{
			builder.AddOffset(3, cameraShakeOffset.Value, 0);
		}

		// Token: 0x06027F73 RID: 163699 RVA: 0x005777EC File Offset: 0x005759EC
		public static void AddMatchSpeedCurve(FlatBufferBuilder builder, Offset<ISpeedCurveMotion> matchSpeedCurveOffset)
		{
			builder.AddOffset(4, matchSpeedCurveOffset.Value, 0);
		}

		// Token: 0x06027F74 RID: 163700 RVA: 0x005777FC File Offset: 0x005759FC
		public static Offset<IProjectileMotion> EndIProjectileMotion(FlatBufferBuilder builder)
		{
			return new Offset<IProjectileMotion>(builder.EndTable());
		}

		// Token: 0x06027F75 RID: 163701 RVA: 0x0057780C File Offset: 0x00575A0C
		public IProjectileMotionT UnPack()
		{
			IProjectileMotionT projectileMotionT = new IProjectileMotionT();
			this.UnPackTo(projectileMotionT);
			return projectileMotionT;
		}

		// Token: 0x06027F76 RID: 163702 RVA: 0x00577828 File Offset: 0x00575A28
		public void UnPackTo(IProjectileMotionT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = this.Velocity;
			_o.AngularVelocity = this.AngularVelocity;
			_o.CameraShake = this.CameraShake;
			_o.MatchSpeedCurve = ((this.MatchSpeedCurve != null) ? this.MatchSpeedCurve.Value.UnPack() : null);
		}

		// Token: 0x06027F77 RID: 163703 RVA: 0x00577894 File Offset: 0x00575A94
		public static Offset<IProjectileMotion> Pack(FlatBufferBuilder builder, IProjectileMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectileMotion>);
			}
			StringOffset cameraShakeOffset = (_o.CameraShake == null) ? default(StringOffset) : builder.CreateString(_o.CameraShake);
			Offset<ISpeedCurveMotion> matchSpeedCurveOffset = (_o.MatchSpeedCurve == null) ? default(Offset<ISpeedCurveMotion>) : ISpeedCurveMotion.Pack(builder, _o.MatchSpeedCurve);
			return IProjectileMotion.CreateIProjectileMotion(builder, _o.Type, _o.Velocity, _o.AngularVelocity, cameraShakeOffset, matchSpeedCurveOffset);
		}

		// Token: 0x0400F95C RID: 63836
		private Table __p;
	}
}
