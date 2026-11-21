using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C36 RID: 3126
	public class IDurabilityWorn
	{
		// Token: 0x06004790 RID: 18320 RVA: 0x000B564E File Offset: 0x000B384E
		public static IDurabilityWorn Create(IDurabilityWorn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityWorn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x000B5670 File Offset: 0x000B3870
		public virtual int? SlightWear
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SlightWear);
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x000B56A8 File Offset: 0x000B38A8
		public virtual int? SevereWear
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SevereWear);
			}
		}

		// Token: 0x0400283D RID: 10301
		private IDurabilityWorn Instance;
	}
}
