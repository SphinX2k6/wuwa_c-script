using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062E RID: 1582
	[NullableContext(2)]
	[Nullable(0)]
	public class IProjectileMotion : IThrowMotion
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x0005D404 File Offset: 0x0005B604
		[NullableContext(1)]
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

		// Token: 0x060021CB RID: 8651 RVA: 0x0005D43C File Offset: 0x0005B63C
		[NullableContext(1)]
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

		// Token: 0x060021CC RID: 8652 RVA: 0x0005D44F File Offset: 0x0005B64F
		[NullableContext(1)]
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

		// Token: 0x060021CD RID: 8653 RVA: 0x0005D464 File Offset: 0x0005B664
		[NullableContext(1)]
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

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0005D4B2 File Offset: 0x0005B6B2
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x0005D4DD File Offset: 0x0005B6DD
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

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0005D4EB File Offset: 0x0005B6EB
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0005D51A File Offset: 0x0005B71A
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

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0005D528 File Offset: 0x0005B728
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x0005D557 File Offset: 0x0005B757
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

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x0005D565 File Offset: 0x0005B765
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x0005D58C File Offset: 0x0005B78C
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0005D59C File Offset: 0x0005B79C
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x0005D5FD File Offset: 0x0005B7FD
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

		// Token: 0x0400178B RID: 6027
		protected new IProjectileMotion FbInstance;

		// Token: 0x0400178C RID: 6028
		protected new IProjectileMotion_SetValue PocoInterface;

		// Token: 0x0400178D RID: 6029
		[Nullable(1)]
		private ISpeedCurveMotion _MatchSpeedCurveCache;

		// Token: 0x0400178E RID: 6030
		private bool _MatchSpeedCurveInited;
	}
}
