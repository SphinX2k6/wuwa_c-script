using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA8 RID: 3240
	public class IChargingDevice : IProgressBarControl
	{
		// Token: 0x06004A1C RID: 18972 RVA: 0x000B9AE6 File Offset: 0x000B7CE6
		[NullableContext(1)]
		public static IChargingDevice Create(IChargingDevice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargingDevice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x000B9B05 File Offset: 0x000B7D05
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x000B9B12 File Offset: 0x000B7D12
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x000B9B1F File Offset: 0x000B7D1F
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x000B9B2C File Offset: 0x000B7D2C
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x000B9B62 File Offset: 0x000B7D62
		public virtual int IncreaseSpeed
		{
			get
			{
				return this.Instance.IncreaseSpeed;
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004A22 RID: 18978 RVA: 0x000B9B6F File Offset: 0x000B7D6F
		public virtual int HitExtraValue
		{
			get
			{
				return this.Instance.HitExtraValue;
			}
		}

		// Token: 0x04002A51 RID: 10833
		private IChargingDevice Instance;
	}
}
