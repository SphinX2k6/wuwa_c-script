using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA9 RID: 3241
	public class ITimedStrikeDevice : IProgressBarControl
	{
		// Token: 0x06004A24 RID: 18980 RVA: 0x000B9B84 File Offset: 0x000B7D84
		[NullableContext(1)]
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

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x000B9BA3 File Offset: 0x000B7DA3
		public override EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06004A26 RID: 18982 RVA: 0x000B9BB0 File Offset: 0x000B7DB0
		public override int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x000B9BBD File Offset: 0x000B7DBD
		public override int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x000B9BCC File Offset: 0x000B7DCC
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

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x000B9C02 File Offset: 0x000B7E02
		public virtual int AddValue
		{
			get
			{
				return this.Instance.AddValue;
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004A2A RID: 18986 RVA: 0x000B9C0F File Offset: 0x000B7E0F
		public virtual int Timeout
		{
			get
			{
				return this.Instance.Timeout;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x000B9C1C File Offset: 0x000B7E1C
		public virtual int FallbackValue
		{
			get
			{
				return this.Instance.FallbackValue;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06004A2C RID: 18988 RVA: 0x000B9C29 File Offset: 0x000B7E29
		public virtual int FallbackInterval
		{
			get
			{
				return this.Instance.FallbackInterval;
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x000B9C38 File Offset: 0x000B7E38
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004A2E RID: 18990 RVA: 0x000B9C70 File Offset: 0x000B7E70
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x000B9CA8 File Offset: 0x000B7EA8
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

		// Token: 0x04002A52 RID: 10834
		private ITimedStrikeDevice Instance;
	}
}
