using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D89 RID: 3465
	public class ICaptureStrategicPoint2 : IProgressBarControl
	{
		// Token: 0x06004EBF RID: 20159 RVA: 0x000C440A File Offset: 0x000C260A
		public static ICaptureStrategicPoint2 Create(ICaptureStrategicPoint2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptureStrategicPoint2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x000C4429 File Offset: 0x000C2629
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x000C4436 File Offset: 0x000C2636
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06004EC2 RID: 20162 RVA: 0x000C4443 File Offset: 0x000C2643
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x000C4450 File Offset: 0x000C2650
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x000C4486 File Offset: 0x000C2686
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

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x000C44BA File Offset: 0x000C26BA
		public virtual float PlayerInMonsterOutCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerInMonsterOutCaptureSpeed;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x000C44C7 File Offset: 0x000C26C7
		public virtual float PlayerInMonsterInCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerInMonsterInCaptureSpeed;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06004EC7 RID: 20167 RVA: 0x000C44D4 File Offset: 0x000C26D4
		public virtual float PlayerOutMonsterOutCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerOutMonsterOutCaptureSpeed;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x000C44E1 File Offset: 0x000C26E1
		public virtual float PlayerOutMonsterInCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerOutMonsterInCaptureSpeed;
			}
		}

		// Token: 0x04002CC8 RID: 11464
		private ICaptureStrategicPoint2 Instance;

		// Token: 0x04002CC9 RID: 11465
		[Nullable(2)]
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04002CCA RID: 11466
		private bool _EnemyEntitiyMatchInited;
	}
}
