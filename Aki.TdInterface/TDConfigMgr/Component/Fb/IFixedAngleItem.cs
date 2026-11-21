using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D55 RID: 3413
	public class IFixedAngleItem
	{
		// Token: 0x06004DB8 RID: 19896 RVA: 0x000C1F92 File Offset: 0x000C0192
		public static IFixedAngleItem Create(IFixedAngleItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedAngleItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06004DB9 RID: 19897 RVA: 0x000C1FB1 File Offset: 0x000C01B1
		public virtual int InitAngle
		{
			get
			{
				return this.Instance.InitAngle;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x000C1FBE File Offset: 0x000C01BE
		public virtual int TargetAngle
		{
			get
			{
				return this.Instance.TargetAngle;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06004DBB RID: 19899 RVA: 0x000C1FCB File Offset: 0x000C01CB
		public virtual int RotateAngle
		{
			get
			{
				return this.Instance.RotateAngle;
			}
		}

		// Token: 0x04002C20 RID: 11296
		private IFixedAngleItem Instance;
	}
}
