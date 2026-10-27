using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A5 RID: 22437
	public struct IProjectileMotion : IFlatbufferObject
	{
		// Token: 0x1700A76C RID: 42860
		// (get) Token: 0x06025A40 RID: 154176 RVA: 0x00531402 File Offset: 0x0052F602
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A41 RID: 154177 RVA: 0x0053140F File Offset: 0x0052F60F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A42 RID: 154178 RVA: 0x00531418 File Offset: 0x0052F618
		public static IProjectileMotion GetRootAsIProjectileMotion(ByteBuffer _bb)
		{
			return IProjectileMotion.GetRootAsIProjectileMotion(_bb, default(IProjectileMotion));
		}

		// Token: 0x06025A43 RID: 154179 RVA: 0x00531434 File Offset: 0x0052F634
		public static IProjectileMotion GetRootAsIProjectileMotion(ByteBuffer _bb, IProjectileMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A44 RID: 154180 RVA: 0x00531451 File Offset: 0x0052F651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A45 RID: 154181 RVA: 0x00531460 File Offset: 0x0052F660
		public IProjectileMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A76D RID: 42861
		// (get) Token: 0x06025A46 RID: 154182 RVA: 0x00531470 File Offset: 0x0052F670
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

		// Token: 0x1700A76E RID: 42862
		// (get) Token: 0x06025A47 RID: 154183 RVA: 0x005314AC File Offset: 0x0052F6AC
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

		// Token: 0x1700A76F RID: 42863
		// (get) Token: 0x06025A48 RID: 154184 RVA: 0x005314EC File Offset: 0x0052F6EC
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

		// Token: 0x1700A770 RID: 42864
		// (get) Token: 0x06025A49 RID: 154185 RVA: 0x0053152C File Offset: 0x0052F72C
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

		// Token: 0x06025A4A RID: 154186 RVA: 0x00531564 File Offset: 0x0052F764
		public Span<byte> GetCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06025A4B RID: 154187 RVA: 0x00531574 File Offset: 0x0052F774
		public byte[] GetCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A771 RID: 42865
		// (get) Token: 0x06025A4C RID: 154188 RVA: 0x00531584 File Offset: 0x0052F784
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

		// Token: 0x06025A4D RID: 154189 RVA: 0x005315E2 File Offset: 0x0052F7E2
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

		// Token: 0x06025A4E RID: 154190 RVA: 0x00531616 File Offset: 0x0052F816
		public static void StartIProjectileMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025A4F RID: 154191 RVA: 0x0053161F File Offset: 0x0052F81F
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025A50 RID: 154192 RVA: 0x0053162A File Offset: 0x0052F82A
		public static void AddVelocity(FlatBufferBuilder builder, float velocity)
		{
			builder.AddFloat(1, velocity, 0.0);
		}

		// Token: 0x06025A51 RID: 154193 RVA: 0x0053163D File Offset: 0x0052F83D
		public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity)
		{
			builder.AddFloat(2, angularVelocity, 0.0);
		}

		// Token: 0x06025A52 RID: 154194 RVA: 0x00531650 File Offset: 0x0052F850
		public static void AddCameraShake(FlatBufferBuilder builder, StringOffset cameraShakeOffset)
		{
			builder.AddOffset(3, cameraShakeOffset.Value, 0);
		}

		// Token: 0x06025A53 RID: 154195 RVA: 0x00531660 File Offset: 0x0052F860
		public static void AddMatchSpeedCurve(FlatBufferBuilder builder, Offset<ISpeedCurveMotion> matchSpeedCurveOffset)
		{
			builder.AddOffset(4, matchSpeedCurveOffset.Value, 0);
		}

		// Token: 0x06025A54 RID: 154196 RVA: 0x00531670 File Offset: 0x0052F870
		public static Offset<IProjectileMotion> EndIProjectileMotion(FlatBufferBuilder builder)
		{
			return new Offset<IProjectileMotion>(builder.EndTable());
		}

		// Token: 0x06025A55 RID: 154197 RVA: 0x00531680 File Offset: 0x0052F880
		public IProjectileMotionT UnPack()
		{
			IProjectileMotionT projectileMotionT = new IProjectileMotionT();
			this.UnPackTo(projectileMotionT);
			return projectileMotionT;
		}

		// Token: 0x06025A56 RID: 154198 RVA: 0x0053169C File Offset: 0x0052F89C
		public void UnPackTo(IProjectileMotionT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = this.Velocity;
			_o.AngularVelocity = this.AngularVelocity;
			_o.CameraShake = this.CameraShake;
			_o.MatchSpeedCurve = ((this.MatchSpeedCurve != null) ? this.MatchSpeedCurve.Value.UnPack() : null);
		}

		// Token: 0x06025A57 RID: 154199 RVA: 0x00531708 File Offset: 0x0052F908
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

		// Token: 0x0400EC71 RID: 60529
		private Table __p;
	}
}
