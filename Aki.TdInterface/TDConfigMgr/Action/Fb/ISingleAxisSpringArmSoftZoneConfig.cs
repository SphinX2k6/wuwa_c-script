using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A3 RID: 10403
	public class ISingleAxisSpringArmSoftZoneConfig
	{
		// Token: 0x0600E64B RID: 58955 RVA: 0x0021D60A File Offset: 0x0021B80A
		[NullableContext(1)]
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

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x0600E64C RID: 58956 RVA: 0x0021D62C File Offset: 0x0021B82C
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

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x0600E64D RID: 58957 RVA: 0x0021D664 File Offset: 0x0021B864
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

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x0600E64E RID: 58958 RVA: 0x0021D69C File Offset: 0x0021B89C
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

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x0600E64F RID: 58959 RVA: 0x0021D6D4 File Offset: 0x0021B8D4
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

		// Token: 0x04007F53 RID: 32595
		private ISingleAxisSpringArmSoftZoneConfig Instance;
	}
}
