using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D88 RID: 3464
	public class ICaptureStrategicPoint : IProgressBarControl
	{
		// Token: 0x06004EB4 RID: 20148 RVA: 0x000C42CA File Offset: 0x000C24CA
		public static ICaptureStrategicPoint Create(ICaptureStrategicPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptureStrategicPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x000C42E9 File Offset: 0x000C24E9
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x000C42F6 File Offset: 0x000C24F6
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x000C4303 File Offset: 0x000C2503
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x000C4310 File Offset: 0x000C2510
		public override int? ProgressPerformanceAttribute
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ProgressPerformanceAttribute);
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x000C4346 File Offset: 0x000C2546
		public virtual int IncreaseSpeed
		{
			get
			{
				return this.Instance.IncreaseSpeed;
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x000C4353 File Offset: 0x000C2553
		public virtual int DecreaseSpeed
		{
			get
			{
				return this.Instance.DecreaseSpeed;
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x000C4360 File Offset: 0x000C2560
		public virtual int? UnoccupiedDecreaseSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.UnoccupiedDecreaseSpeed);
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x000C4396 File Offset: 0x000C2596
		public virtual IStaticEntitiyMatch EnemyEntitiyMatch
		{
			get
			{
				if (this._EnemyEntitiyMatchInited)
				{
					return this._EnemyEntitiyMatchCache;
				}
				this._EnemyEntitiyMatchInited = true;
				this._EnemyEntitiyMatchCache = IStaticEntitiyMatch.Create(this.Instance.EnemyEntitiyMatch);
				return this._EnemyEntitiyMatchCache;
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x000C43CC File Offset: 0x000C25CC
		public virtual ECaptureStateType? CaptureType
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new ECaptureStateType?((ECaptureStateType)this.Instance.CaptureType);
			}
		}

		// Token: 0x04002CC5 RID: 11461
		private ICaptureStrategicPoint Instance;

		// Token: 0x04002CC6 RID: 11462
		[Nullable(2)]
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04002CC7 RID: 11463
		private bool _EnemyEntitiyMatchInited;
	}
}
