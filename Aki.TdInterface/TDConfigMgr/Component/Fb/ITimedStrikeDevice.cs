using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8B RID: 3467
	public class ITimedStrikeDevice : IProgressBarControl
	{
		// Token: 0x06004ED2 RID: 20178 RVA: 0x000C4594 File Offset: 0x000C2794
		public static ITimedStrikeDevice Create(ITimedStrikeDevice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimedStrikeDevice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x000C45B3 File Offset: 0x000C27B3
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x000C45C0 File Offset: 0x000C27C0
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x000C45CD File Offset: 0x000C27CD
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x000C45DC File Offset: 0x000C27DC
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

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x000C4612 File Offset: 0x000C2812
		public virtual int AddValue
		{
			get
			{
				return this.Instance.AddValue;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x000C461F File Offset: 0x000C281F
		public virtual int Timeout
		{
			get
			{
				return this.Instance.Timeout;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x000C462C File Offset: 0x000C282C
		public virtual int FallbackValue
		{
			get
			{
				return this.Instance.FallbackValue;
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06004EDA RID: 20186 RVA: 0x000C4639 File Offset: 0x000C2839
		public virtual int FallbackInterval
		{
			get
			{
				return this.Instance.FallbackInterval;
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x000C4648 File Offset: 0x000C2848
		public virtual int? ZeroValuePerformanceAttribute
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ZeroValuePerformanceAttribute);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06004EDC RID: 20188 RVA: 0x000C4680 File Offset: 0x000C2880
		public virtual int? AscendPerformanceAttribute
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AscendPerformanceAttribute);
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x000C46B8 File Offset: 0x000C28B8
		public virtual int? DescendPerformanceAttribute
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DescendPerformanceAttribute);
			}
		}

		// Token: 0x04002CCC RID: 11468
		private ITimedStrikeDevice Instance;
	}
}
