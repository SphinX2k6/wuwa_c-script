using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA5 RID: 3237
	public class IProgressBarControl
	{
		// Token: 0x06004A00 RID: 18944 RVA: 0x000B9835 File Offset: 0x000B7A35
		[NullableContext(1)]
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

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x000B9854 File Offset: 0x000B7A54
		public virtual EProgressBarControlType Type
		{
			get
			{
				return (EProgressBarControlType)this.Instance.Type;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x000B9861 File Offset: 0x000B7A61
		public virtual int MaxValue
		{
			get
			{
				return this.Instance.MaxValue;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x000B986E File Offset: 0x000B7A6E
		public virtual int InitValue
		{
			get
			{
				return this.Instance.InitValue;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x000B987C File Offset: 0x000B7A7C
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

		// Token: 0x04002A4A RID: 10826
		private IProgressBarControl Instance;
	}
}
