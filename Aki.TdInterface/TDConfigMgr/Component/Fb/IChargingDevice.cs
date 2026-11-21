using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8A RID: 3466
	public class IChargingDevice : IProgressBarControl
	{
		// Token: 0x06004ECA RID: 20170 RVA: 0x000C44F6 File Offset: 0x000C26F6
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

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x000C4515 File Offset: 0x000C2715
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x000C4522 File Offset: 0x000C2722
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x000C452F File Offset: 0x000C272F
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x000C453C File Offset: 0x000C273C
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

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x000C4572 File Offset: 0x000C2772
		public virtual int IncreaseSpeed
		{
			get
			{
				return this.Instance.IncreaseSpeed;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x000C457F File Offset: 0x000C277F
		public virtual int HitExtraValue
		{
			get
			{
				return this.Instance.HitExtraValue;
			}
		}

		// Token: 0x04002CCB RID: 11467
		private IChargingDevice Instance;
	}
}
