using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA6 RID: 3238
	[NullableContext(1)]
	[Nullable(0)]
	public class ICaptureStrategicPoint : IProgressBarControl
	{
		// Token: 0x06004A06 RID: 18950 RVA: 0x000B98BA File Offset: 0x000B7ABA
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

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x000B98D9 File Offset: 0x000B7AD9
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004A08 RID: 18952 RVA: 0x000B98E6 File Offset: 0x000B7AE6
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x000B98F3 File Offset: 0x000B7AF3
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004A0A RID: 18954 RVA: 0x000B9900 File Offset: 0x000B7B00
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

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x000B9936 File Offset: 0x000B7B36
		public virtual int IncreaseSpeed
		{
			get
			{
				return this.Instance.IncreaseSpeed;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004A0C RID: 18956 RVA: 0x000B9943 File Offset: 0x000B7B43
		public virtual int DecreaseSpeed
		{
			get
			{
				return this.Instance.DecreaseSpeed;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x000B9950 File Offset: 0x000B7B50
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

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004A0E RID: 18958 RVA: 0x000B9986 File Offset: 0x000B7B86
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

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x000B99BC File Offset: 0x000B7BBC
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

		// Token: 0x04002A4B RID: 10827
		private ICaptureStrategicPoint Instance;

		// Token: 0x04002A4C RID: 10828
		[Nullable(2)]
		private IStaticEntitiyMatch _EnemyEntitiyMatchCache;

		// Token: 0x04002A4D RID: 10829
		private bool _EnemyEntitiyMatchInited;
	}
}
