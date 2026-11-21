using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023C RID: 572
	public class ICaptureStrategicPoint2 : IProgressBarControl
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x00029994 File Offset: 0x00027B94
		private ICaptureStrategicPoint2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICaptureStrategicPoint2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICaptureStrategicPoint2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICaptureStrategicPoint2_SetValue());
			}
			return result;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000299CC File Offset: 0x00027BCC
		public static ICaptureStrategicPoint2 Create([Nullable(2)] ICaptureStrategicPoint2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptureStrategicPoint2
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000299DF File Offset: 0x00027BDF
		public static ICaptureStrategicPoint2 CreateFromSetValue([Nullable(2)] ICaptureStrategicPoint2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICaptureStrategicPoint2
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000299F4 File Offset: 0x00027BF4
		public new ICaptureStrategicPoint2_SetValue ToSetValue()
		{
			return new ICaptureStrategicPoint2_SetValue
			{
				Type = this.Type,
				MaxValue = this.MaxValue,
				InitValue = this.InitValue,
				ProgressPerformanceAttribute = this.ProgressPerformanceAttribute,
				EnemyEntitiyMatch = this.EnemyEntitiyMatch,
				PlayerInMonsterOutCaptureSpeed = this.PlayerInMonsterOutCaptureSpeed,
				PlayerInMonsterInCaptureSpeed = this.PlayerInMonsterInCaptureSpeed,
				PlayerOutMonsterOutCaptureSpeed = this.PlayerOutMonsterOutCaptureSpeed,
				PlayerOutMonsterInCaptureSpeed = this.PlayerOutMonsterInCaptureSpeed
			};
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00029A72 File Offset: 0x00027C72
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00029A9D File Offset: 0x00027C9D
		public override EProgressBarControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00029AAB File Offset: 0x00027CAB
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00029AD6 File Offset: 0x00027CD6
		public override int MaxValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxValue;
			}
			set
			{
				this.GetOrCreatePoco().MaxValue = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00029AE4 File Offset: 0x00027CE4
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00029B0F File Offset: 0x00027D0F
		public override int InitValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitValue;
			}
			set
			{
				this.GetOrCreatePoco().InitValue = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00029B20 File Offset: 0x00027D20
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00029B5A File Offset: 0x00027D5A
		public override int? ProgressPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressPerformanceAttribute;
				}
				ICaptureStrategicPoint2_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ProgressPerformanceAttribute = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00029B68 File Offset: 0x00027D68
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00029BC9 File Offset: 0x00027DC9
		public virtual IStaticEntitiyMatch EnemyEntitiyMatch
		{
			get
			{
				if (this._EnemyEntitiyMatchInited)
				{
					return this._EnemyEntitiyMatchCache;
				}
				this._EnemyEntitiyMatchInited = true;
				if (this.FbInstance != null)
				{
					this._EnemyEntitiyMatchCache = IStaticEntitiyMatch.Create(this.FbInstance.EnemyEntitiyMatch);
				}
				else
				{
					ICaptureStrategicPoint2_SetValue pocoInterface = this.PocoInterface;
					this._EnemyEntitiyMatchCache = ((pocoInterface != null) ? pocoInterface.EnemyEntitiyMatch : null);
				}
				return this._EnemyEntitiyMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().EnemyEntitiyMatch = value;
				this._EnemyEntitiyMatchInited = false;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00029BDE File Offset: 0x00027DDE
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00029C0D File Offset: 0x00027E0D
		public virtual float PlayerInMonsterOutCaptureSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerInMonsterOutCaptureSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PlayerInMonsterOutCaptureSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PlayerInMonsterOutCaptureSpeed = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00029C1B File Offset: 0x00027E1B
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00029C4A File Offset: 0x00027E4A
		public virtual float PlayerInMonsterInCaptureSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerInMonsterInCaptureSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PlayerInMonsterInCaptureSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PlayerInMonsterInCaptureSpeed = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00029C58 File Offset: 0x00027E58
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00029C87 File Offset: 0x00027E87
		public virtual float PlayerOutMonsterOutCaptureSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerOutMonsterOutCaptureSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PlayerOutMonsterOutCaptureSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PlayerOutMonsterOutCaptureSpeed = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00029C95 File Offset: 0x00027E95
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00029CC4 File Offset: 0x00027EC4
		public virtual float PlayerOutMonsterInCaptureSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerOutMonsterInCaptureSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PlayerOutMonsterInCaptureSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PlayerOutMonsterInCaptureSpeed = value;
			}
		}

		// Token: 0x04000A09 RID: 2569
		[Nullable(2)]
		protected new ICaptureStrategicPoint2 FbInstance;

		// Token: 0x04000A0A RID: 2570
		[Nullable(2)]
		protected new ICaptureStrategicPoint2_SetValue PocoInterface;

		// Token: 0x04000A0B RID: 2571
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04000A0C RID: 2572
		private bool _EnemyEntitiyMatchInited;
	}
}
