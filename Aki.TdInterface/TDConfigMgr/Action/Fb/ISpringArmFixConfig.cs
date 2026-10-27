using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A5 RID: 10405
	public class ISpringArmFixConfig
	{
		// Token: 0x0600E656 RID: 58966 RVA: 0x0021D7D5 File Offset: 0x0021B9D5
		[NullableContext(1)]
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

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x0600E657 RID: 58967 RVA: 0x0021D7F4 File Offset: 0x0021B9F4
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

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x0600E658 RID: 58968 RVA: 0x0021D82C File Offset: 0x0021BA2C
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

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x0600E659 RID: 58969 RVA: 0x0021D864 File Offset: 0x0021BA64
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

		// Token: 0x04007F5B RID: 32603
		private ISpringArmFixConfig Instance;
	}
}
