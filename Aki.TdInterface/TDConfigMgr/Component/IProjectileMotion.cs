using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CB RID: 1739
	[NullableContext(2)]
	[Nullable(0)]
	public class IProjectileMotion : IThrowMotion
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x00064118 File Offset: 0x00062318
		[NullableContext(0)]
		private IProjectileMotion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProjectileMotion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProjectileMotion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProjectileMotion_SetValue());
			}
			return result;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00064150 File Offset: 0x00062350
		[NullableContext(0)]
		public static IProjectileMotion Create([Nullable(2)] IProjectileMotion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectileMotion
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00064163 File Offset: 0x00062363
		[NullableContext(0)]
		public static IProjectileMotion CreateFromSetValue([Nullable(2)] IProjectileMotion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProjectileMotion
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00064178 File Offset: 0x00062378
		[NullableContext(0)]
		public new IProjectileMotion_SetValue ToSetValue()
		{
			return new IProjectileMotion_SetValue
			{
				Type = this.Type,
				Velocity = this.Velocity,
				AngularVelocity = this.AngularVelocity,
				CameraShake = this.CameraShake,
				MatchSpeedCurve = this.MatchSpeedCurve
			};
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000641C6 File Offset: 0x000623C6
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x000641F1 File Offset: 0x000623F1
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000641FF File Offset: 0x000623FF
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0006422E File Offset: 0x0006242E
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x0006423C File Offset: 0x0006243C
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x0006426B File Offset: 0x0006246B
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x00064279 File Offset: 0x00062479
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x000642A0 File Offset: 0x000624A0
		public virtual string CameraShake
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraShake;
				}
				IProjectileMotion_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraShake;
			}
			set
			{
				this.GetOrCreatePoco().CameraShake = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000642B0 File Offset: 0x000624B0
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x00064311 File Offset: 0x00062511
		public virtual ISpeedCurveMotion MatchSpeedCurve
		{
			get
			{
				if (this._MatchSpeedCurveInited)
				{
					return this._MatchSpeedCurveCache;
				}
				this._MatchSpeedCurveInited = true;
				if (this.FbInstance != null)
				{
					this._MatchSpeedCurveCache = ISpeedCurveMotion.Create(this.FbInstance.MatchSpeedCurve);
				}
				else
				{
					IProjectileMotion_SetValue pocoInterface = this.PocoInterface;
					this._MatchSpeedCurveCache = ((pocoInterface != null) ? pocoInterface.MatchSpeedCurve : null);
				}
				return this._MatchSpeedCurveCache;
			}
			set
			{
				this.GetOrCreatePoco().MatchSpeedCurve = value;
				this._MatchSpeedCurveInited = false;
			}
		}

		// Token: 0x0400197D RID: 6525
		protected new IProjectileMotion FbInstance;

		// Token: 0x0400197E RID: 6526
		protected new IProjectileMotion_SetValue PocoInterface;

		// Token: 0x0400197F RID: 6527
		[Nullable(0)]
		private ISpeedCurveMotion _MatchSpeedCurveCache;

		// Token: 0x04001980 RID: 6528
		private bool _MatchSpeedCurveInited;
	}
}
