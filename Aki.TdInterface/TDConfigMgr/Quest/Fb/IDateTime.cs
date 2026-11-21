using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014D5 RID: 5333
	public class IDateTime
	{
		// Token: 0x060078F8 RID: 30968 RVA: 0x00121736 File Offset: 0x0011F936
		public static IDateTime Create(IDateTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDateTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x060078F9 RID: 30969 RVA: 0x00121755 File Offset: 0x0011F955
		public virtual int Hours
		{
			get
			{
				return this.Instance.Hours;
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x060078FA RID: 30970 RVA: 0x00121762 File Offset: 0x0011F962
		public virtual int Minutes
		{
			get
			{
				return this.Instance.Minutes;
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x060078FB RID: 30971 RVA: 0x00121770 File Offset: 0x0011F970
		public virtual int? Days
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Days);
			}
		}

		// Token: 0x04004593 RID: 17811
		private IDateTime Instance;
	}
}
