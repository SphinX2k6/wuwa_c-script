using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B78 RID: 11128
	public class ISingleAxisSpringArmSoftZoneConfig
	{
		// Token: 0x0600F47A RID: 62586 RVA: 0x0023A58A File Offset: 0x0023878A
		public static ISingleAxisSpringArmSoftZoneConfig Create(ISingleAxisSpringArmSoftZoneConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISingleAxisSpringArmSoftZoneConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x0600F47B RID: 62587 RVA: 0x0023A5AC File Offset: 0x002387AC
		public virtual float? MaxOffsetDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxOffsetDistance);
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x0600F47C RID: 62588 RVA: 0x0023A5E4 File Offset: 0x002387E4
		public virtual float? MinOffsetDistance
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MinOffsetDistance);
			}
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x0600F47D RID: 62589 RVA: 0x0023A61C File Offset: 0x0023881C
		public virtual float? MaxInterpolationSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxInterpolationSpeed);
			}
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x0600F47E RID: 62590 RVA: 0x0023A654 File Offset: 0x00238854
		public virtual float? MinInterpolationSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MinInterpolationSpeed);
			}
		}

		// Token: 0x04008612 RID: 34322
		private ISingleAxisSpringArmSoftZoneConfig Instance;
	}
}
