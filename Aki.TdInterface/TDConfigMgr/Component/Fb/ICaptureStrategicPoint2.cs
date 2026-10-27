using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA7 RID: 3239
	[NullableContext(1)]
	[Nullable(0)]
	public class ICaptureStrategicPoint2 : IProgressBarControl
	{
		// Token: 0x06004A11 RID: 18961 RVA: 0x000B99FA File Offset: 0x000B7BFA
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

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004A12 RID: 18962 RVA: 0x000B9A19 File Offset: 0x000B7C19
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x000B9A26 File Offset: 0x000B7C26
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004A14 RID: 18964 RVA: 0x000B9A33 File Offset: 0x000B7C33
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x000B9A40 File Offset: 0x000B7C40
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

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06004A16 RID: 18966 RVA: 0x000B9A76 File Offset: 0x000B7C76
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

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x000B9AAA File Offset: 0x000B7CAA
		public virtual float PlayerInMonsterOutCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerInMonsterOutCaptureSpeed;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004A18 RID: 18968 RVA: 0x000B9AB7 File Offset: 0x000B7CB7
		public virtual float PlayerInMonsterInCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerInMonsterInCaptureSpeed;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x000B9AC4 File Offset: 0x000B7CC4
		public virtual float PlayerOutMonsterOutCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerOutMonsterOutCaptureSpeed;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004A1A RID: 18970 RVA: 0x000B9AD1 File Offset: 0x000B7CD1
		public virtual float PlayerOutMonsterInCaptureSpeed
		{
			get
			{
				return this.Instance.PlayerOutMonsterInCaptureSpeed;
			}
		}

		// Token: 0x04002A4E RID: 10830
		private ICaptureStrategicPoint2 Instance;

		// Token: 0x04002A4F RID: 10831
		[Nullable(2)]
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04002A50 RID: 10832
		private bool _EnemyEntitiyMatchInited;
	}
}
