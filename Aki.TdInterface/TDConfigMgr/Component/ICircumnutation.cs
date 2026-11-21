using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000282 RID: 642
	[NullableContext(2)]
	[Nullable(0)]
	public class ICircumnutation : IThrowMotion
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[NullableContext(0)]
		private ICircumnutation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircumnutation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircumnutation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircumnutation_SetValue());
			}
			return result;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002DDD0 File Offset: 0x0002BFD0
		[NullableContext(0)]
		public static ICircumnutation Create([Nullable(2)] ICircumnutation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircumnutation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002DDE3 File Offset: 0x0002BFE3
		[NullableContext(0)]
		public static ICircumnutation CreateFromSetValue([Nullable(2)] ICircumnutation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircumnutation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[NullableContext(0)]
		public new ICircumnutation_SetValue ToSetValue()
		{
			return new ICircumnutation_SetValue
			{
				Type = this.Type,
				Velocity = this.Velocity,
				VelocityCurve = this.VelocityCurve,
				Direction = this.Direction,
				AngularVelocity = this.AngularVelocity,
				RotationSpeed = this.RotationSpeed,
				AngularVelocityCurve = this.AngularVelocityCurve,
				RenderTrajectoryConfig = this.RenderTrajectoryConfig
			};
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0002DE6A File Offset: 0x0002C06A
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0002DE95 File Offset: 0x0002C095
		public override EThrowMotion Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EThrowMotion.Projectile;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0002DEA3 File Offset: 0x0002C0A3
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0002DED2 File Offset: 0x0002C0D2
		public virtual float Velocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Velocity;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Velocity;
			}
			set
			{
				this.GetOrCreatePoco().Velocity = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0002DF07 File Offset: 0x0002C107
		public virtual string VelocityCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VelocityCurve;
				}
				ICircumnutation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VelocityCurve;
			}
			set
			{
				this.GetOrCreatePoco().VelocityCurve = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0002DF15 File Offset: 0x0002C115
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0002DF40 File Offset: 0x0002C140
		public virtual EDirection Direction
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Direction;
				}
				if (this.PocoInterface == null)
				{
					return EDirection.Right;
				}
				return this.PocoInterface.Direction;
			}
			set
			{
				this.GetOrCreatePoco().Direction = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0002DF4E File Offset: 0x0002C14E
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0002DF7D File Offset: 0x0002C17D
		public virtual float AngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AngularVelocity;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().AngularVelocity = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0002DF8B File Offset: 0x0002C18B
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0002DFBA File Offset: 0x0002C1BA
		public virtual float RotationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RotationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().RotationSpeed = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0002DFC8 File Offset: 0x0002C1C8
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0002DFEF File Offset: 0x0002C1EF
		public virtual string AngularVelocityCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AngularVelocityCurve;
				}
				ICircumnutation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AngularVelocityCurve;
			}
			set
			{
				this.GetOrCreatePoco().AngularVelocityCurve = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0002E000 File Offset: 0x0002C200
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0002E061 File Offset: 0x0002C261
		public virtual IRenderTrajectoryConfig RenderTrajectoryConfig
		{
			get
			{
				if (this._RenderTrajectoryConfigInited)
				{
					return this._RenderTrajectoryConfigCache;
				}
				this._RenderTrajectoryConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RenderTrajectoryConfigCache = IRenderTrajectoryConfig.Create(this.FbInstance.RenderTrajectoryConfig);
				}
				else
				{
					ICircumnutation_SetValue pocoInterface = this.PocoInterface;
					this._RenderTrajectoryConfigCache = ((pocoInterface != null) ? pocoInterface.RenderTrajectoryConfig : null);
				}
				return this._RenderTrajectoryConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RenderTrajectoryConfig = value;
				this._RenderTrajectoryConfigInited = false;
			}
		}

		// Token: 0x04000B2E RID: 2862
		protected new ICircumnutation FbInstance;

		// Token: 0x04000B2F RID: 2863
		protected new ICircumnutation_SetValue PocoInterface;

		// Token: 0x04000B30 RID: 2864
		[Nullable(0)]
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x04000B31 RID: 2865
		private bool _RenderTrajectoryConfigInited;
	}
}
