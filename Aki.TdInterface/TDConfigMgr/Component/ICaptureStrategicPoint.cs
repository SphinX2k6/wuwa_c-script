using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023A RID: 570
	public class ICaptureStrategicPoint : IProgressBarControl
	{
		// Token: 0x0600095E RID: 2398 RVA: 0x00029634 File Offset: 0x00027834
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

		// Token: 0x0600095F RID: 2399 RVA: 0x0002966C File Offset: 0x0002786C
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

		// Token: 0x06000960 RID: 2400 RVA: 0x0002967F File Offset: 0x0002787F
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

		// Token: 0x06000961 RID: 2401 RVA: 0x00029694 File Offset: 0x00027894
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00029712 File Offset: 0x00027912
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x0002973D File Offset: 0x0002793D
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0002974B File Offset: 0x0002794B
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00029776 File Offset: 0x00027976
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00029784 File Offset: 0x00027984
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x000297AF File Offset: 0x000279AF
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x000297C0 File Offset: 0x000279C0
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x000297FA File Offset: 0x000279FA
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00029808 File Offset: 0x00027A08
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00029833 File Offset: 0x00027A33
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00029841 File Offset: 0x00027A41
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0002986C File Offset: 0x00027A6C
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002987C File Offset: 0x00027A7C
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000298B6 File Offset: 0x00027AB6
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x000298C4 File Offset: 0x00027AC4
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00029925 File Offset: 0x00027B25
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002993C File Offset: 0x00027B3C
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00029976 File Offset: 0x00027B76
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

		// Token: 0x040009FC RID: 2556
		[Nullable(2)]
		protected new ICaptureStrategicPoint FbInstance;

		// Token: 0x040009FD RID: 2557
		[Nullable(2)]
		protected new ICaptureStrategicPoint_SetValue PocoInterface;

		// Token: 0x040009FE RID: 2558
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x040009FF RID: 2559
		private bool _EnemyEntitiyMatchInited;
	}
}
