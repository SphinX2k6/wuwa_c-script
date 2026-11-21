using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D87 RID: 3463
	public class IProgressBarControl
	{
		// Token: 0x06004EAE RID: 20142 RVA: 0x000C4245 File Offset: 0x000C2445
		public static IProgressBarControl Create(IProgressBarControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBarControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x000C4264 File Offset: 0x000C2464
		public virtual EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x000C4271 File Offset: 0x000C2471
		public virtual int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06004EB1 RID: 20145 RVA: 0x000C427E File Offset: 0x000C247E
		public virtual int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x000C428C File Offset: 0x000C248C
		public virtual int? ProgressPerformanceAttribute
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

		// Token: 0x04002CC4 RID: 11460
		private IProgressBarControl Instance;
	}
}
