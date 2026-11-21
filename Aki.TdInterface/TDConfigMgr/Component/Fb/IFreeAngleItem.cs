using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D53 RID: 3411
	public class IFreeAngleItem
	{
		// Token: 0x06004DAE RID: 19886 RVA: 0x000C1E9A File Offset: 0x000C009A
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

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06004DAF RID: 19887 RVA: 0x000C1EB9 File Offset: 0x000C00B9
		public virtual int InitAngle
		{
			get
			{
				return this.Instance.InitAngle;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06004DB0 RID: 19888 RVA: 0x000C1EC6 File Offset: 0x000C00C6
		public virtual int TargetAngle
		{
			get
			{
				return this.Instance.TargetAngle;
			}
		}

		// Token: 0x04002C1C RID: 11292
		private IFreeAngleItem Instance;
	}
}
