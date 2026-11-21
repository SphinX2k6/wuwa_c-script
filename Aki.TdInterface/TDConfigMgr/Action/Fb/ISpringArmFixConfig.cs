using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B7A RID: 11130
	public class ISpringArmFixConfig
	{
		// Token: 0x0600F485 RID: 62597 RVA: 0x0023A755 File Offset: 0x00238955
		public static ISpringArmFixConfig Create(ISpringArmFixConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpringArmFixConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x0600F486 RID: 62598 RVA: 0x0023A774 File Offset: 0x00238974
		public virtual bool? LeftRightFix
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.LeftRightFix);
			}
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x0600F487 RID: 62599 RVA: 0x0023A7AC File Offset: 0x002389AC
		public virtual bool? ForwardBackFix
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForwardBackFix);
			}
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x0600F488 RID: 62600 RVA: 0x0023A7E4 File Offset: 0x002389E4
		public virtual bool? UpDownFix
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UpDownFix);
			}
		}

		// Token: 0x0400861A RID: 34330
		private ISpringArmFixConfig Instance;
	}
}
