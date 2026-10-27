using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B33 RID: 2867
	public class IPhysHandleConfig
	{
		// Token: 0x06004231 RID: 16945 RVA: 0x000A992E File Offset: 0x000A7B2E
		[NullableContext(1)]
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

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x000A994D File Offset: 0x000A7B4D
		public virtual int PhysHandleLinearDamping
		{
			get
			{
				return this.Instance.PhysHandleLinearDamping;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x000A995A File Offset: 0x000A7B5A
		public virtual int PhysHandleAngularStiffness
		{
			get
			{
				return this.Instance.PhysHandleAngularStiffness;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x000A9967 File Offset: 0x000A7B67
		public virtual int PhysHandleLinearStiffness
		{
			get
			{
				return this.Instance.PhysHandleLinearStiffness;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06004235 RID: 16949 RVA: 0x000A9974 File Offset: 0x000A7B74
		public virtual int PhysHandleAngularDamping
		{
			get
			{
				return this.Instance.PhysHandleAngularDamping;
			}
		}

		// Token: 0x04002556 RID: 9558
		private IPhysHandleConfig Instance;
	}
}
