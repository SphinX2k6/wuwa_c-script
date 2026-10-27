using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000215 RID: 533
	[NullableContext(1)]
	[Nullable(0)]
	public class ICaptureStrategicPoint2 : IProgressBarControl
	{
		// Token: 0x06000902 RID: 2306 RVA: 0x000281D4 File Offset: 0x000263D4
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

		// Token: 0x06000903 RID: 2307 RVA: 0x0002820C File Offset: 0x0002640C
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

		// Token: 0x06000904 RID: 2308 RVA: 0x0002821F File Offset: 0x0002641F
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

		// Token: 0x06000905 RID: 2309 RVA: 0x00028234 File Offset: 0x00026434
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000282B2 File Offset: 0x000264B2
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000282DD File Offset: 0x000264DD
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x000282EB File Offset: 0x000264EB
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00028316 File Offset: 0x00026516
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00028324 File Offset: 0x00026524
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x0002834F File Offset: 0x0002654F
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00028360 File Offset: 0x00026560
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0002839A File Offset: 0x0002659A
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000283A8 File Offset: 0x000265A8
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00028409 File Offset: 0x00026609
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0002841E File Offset: 0x0002661E
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0002844D File Offset: 0x0002664D
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0002845B File Offset: 0x0002665B
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0002848A File Offset: 0x0002668A
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00028498 File Offset: 0x00026698
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x000284C7 File Offset: 0x000266C7
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x000284D5 File Offset: 0x000266D5
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00028504 File Offset: 0x00026704
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

		// Token: 0x0400097F RID: 2431
		[Nullable(2)]
		protected new ICaptureStrategicPoint2 FbInstance;

		// Token: 0x04000980 RID: 2432
		[Nullable(2)]
		protected new ICaptureStrategicPoint2_SetValue PocoInterface;

		// Token: 0x04000981 RID: 2433
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04000982 RID: 2434
		private bool _EnemyEntitiyMatchInited;
	}
}
