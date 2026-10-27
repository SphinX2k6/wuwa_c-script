using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C74 RID: 3188
	public class IFreeAngleItem
	{
		// Token: 0x0600490F RID: 18703 RVA: 0x000B7696 File Offset: 0x000B5896
		[NullableContext(1)]
		public static IFreeAngleItem Create(IFreeAngleItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreeAngleItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x000B76B5 File Offset: 0x000B58B5
		public virtual int InitAngle
		{
			get
			{
				return this.Instance.InitAngle;
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x000B76C2 File Offset: 0x000B58C2
		public virtual int TargetAngle
		{
			get
			{
				return this.Instance.TargetAngle;
			}
		}

		// Token: 0x040029AF RID: 10671
		private IFreeAngleItem Instance;
	}
}
