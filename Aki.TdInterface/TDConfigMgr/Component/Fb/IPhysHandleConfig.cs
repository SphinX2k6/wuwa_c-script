using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C01 RID: 3073
	public class IPhysHandleConfig
	{
		// Token: 0x0600468A RID: 18058 RVA: 0x000B39F2 File Offset: 0x000B1BF2
		public static IPhysHandleConfig Create(IPhysHandleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhysHandleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x000B3A11 File Offset: 0x000B1C11
		public virtual int PhysHandleLinearDamping
		{
			get
			{
				return this.Instance.PhysHandleLinearDamping;
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x000B3A1E File Offset: 0x000B1C1E
		public virtual int PhysHandleAngularStiffness
		{
			get
			{
				return this.Instance.PhysHandleAngularStiffness;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x000B3A2B File Offset: 0x000B1C2B
		public virtual int PhysHandleLinearStiffness
		{
			get
			{
				return this.Instance.PhysHandleLinearStiffness;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x000B3A38 File Offset: 0x000B1C38
		public virtual int PhysHandleAngularDamping
		{
			get
			{
				return this.Instance.PhysHandleAngularDamping;
			}
		}

		// Token: 0x0400279E RID: 10142
		private IPhysHandleConfig Instance;
	}
}
