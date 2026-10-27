using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000213 RID: 531
	[NullableContext(1)]
	[Nullable(0)]
	public class ICaptureStrategicPoint : IProgressBarControl
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00027E74 File Offset: 0x00026074
		private ICaptureStrategicPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICaptureStrategicPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICaptureStrategicPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICaptureStrategicPoint_SetValue());
			}
			return result;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00027EAC File Offset: 0x000260AC
		public static ICaptureStrategicPoint Create([Nullable(2)] ICaptureStrategicPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptureStrategicPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00027EBF File Offset: 0x000260BF
		public static ICaptureStrategicPoint CreateFromSetValue([Nullable(2)] ICaptureStrategicPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICaptureStrategicPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00027ED4 File Offset: 0x000260D4
		public new ICaptureStrategicPoint_SetValue ToSetValue()
		{
			return new ICaptureStrategicPoint_SetValue
			{
				Type = this.Type,
				MaxValue = this.MaxValue,
				InitValue = this.InitValue,
				ProgressPerformanceAttribute = this.ProgressPerformanceAttribute,
				IncreaseSpeed = this.IncreaseSpeed,
				DecreaseSpeed = this.DecreaseSpeed,
				UnoccupiedDecreaseSpeed = this.UnoccupiedDecreaseSpeed,
				EnemyEntitiyMatch = this.EnemyEntitiyMatch,
				CaptureType = this.CaptureType
			};
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00027F52 File Offset: 0x00026152
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00027F7D File Offset: 0x0002617D
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

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00027F8B File Offset: 0x0002618B
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00027FB6 File Offset: 0x000261B6
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00027FC4 File Offset: 0x000261C4
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00027FEF File Offset: 0x000261EF
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00028000 File Offset: 0x00026200
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0002803A File Offset: 0x0002623A
		public override int? ProgressPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressPerformanceAttribute;
				}
				ICaptureStrategicPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00028048 File Offset: 0x00026248
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00028073 File Offset: 0x00026273
		public virtual int IncreaseSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IncreaseSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.IncreaseSpeed;
			}
			set
			{
				this.GetOrCreatePoco().IncreaseSpeed = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00028081 File Offset: 0x00026281
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x000280AC File Offset: 0x000262AC
		public virtual int DecreaseSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DecreaseSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DecreaseSpeed;
			}
			set
			{
				this.GetOrCreatePoco().DecreaseSpeed = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x000280BC File Offset: 0x000262BC
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x000280F6 File Offset: 0x000262F6
		public virtual int? UnoccupiedDecreaseSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UnoccupiedDecreaseSpeed;
				}
				ICaptureStrategicPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UnoccupiedDecreaseSpeed;
			}
			set
			{
				this.GetOrCreatePoco().UnoccupiedDecreaseSpeed = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00028104 File Offset: 0x00026304
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00028165 File Offset: 0x00026365
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
					ICaptureStrategicPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0002817C File Offset: 0x0002637C
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000281B6 File Offset: 0x000263B6
		public virtual ECaptureStateType? CaptureType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CaptureType;
				}
				ICaptureStrategicPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CaptureType;
			}
			set
			{
				this.GetOrCreatePoco().CaptureType = value;
			}
		}

		// Token: 0x04000972 RID: 2418
		[Nullable(2)]
		protected new ICaptureStrategicPoint FbInstance;

		// Token: 0x04000973 RID: 2419
		[Nullable(2)]
		protected new ICaptureStrategicPoint_SetValue PocoInterface;

		// Token: 0x04000974 RID: 2420
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04000975 RID: 2421
		private bool _EnemyEntitiyMatchInited;
	}
}
