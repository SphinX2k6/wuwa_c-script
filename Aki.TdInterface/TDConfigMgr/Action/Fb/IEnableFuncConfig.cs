using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC1 RID: 11713
	public class IEnableFuncConfig
	{
		// Token: 0x0600FF0E RID: 65294 RVA: 0x0024C3C1 File Offset: 0x0024A5C1
		public static IEnableFuncConfig Create(IEnableFuncConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableFuncConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x0600FF0F RID: 65295 RVA: 0x0024C3E0 File Offset: 0x0024A5E0
		public virtual float? DelayDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayDuration);
			}
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x0600FF10 RID: 65296 RVA: 0x0024C418 File Offset: 0x0024A618
		public virtual bool? IsEnableEsc
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnableEsc);
			}
		}

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x0600FF11 RID: 65297 RVA: 0x0024C450 File Offset: 0x0024A650
		public virtual bool? IsEnablePhoto
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnablePhoto);
			}
		}

		// Token: 0x04008B39 RID: 35641
		private IEnableFuncConfig Instance;
	}
}
