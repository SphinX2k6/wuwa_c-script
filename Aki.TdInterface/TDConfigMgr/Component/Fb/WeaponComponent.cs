using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD0 RID: 3280
	public class WeaponComponent : IComponentBase
	{
		// Token: 0x06004AF3 RID: 19187 RVA: 0x000BC558 File Offset: 0x000BA758
		public static WeaponComponent Create(IWeaponComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WeaponComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x000BC578 File Offset: 0x000BA778
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x000BC5B0 File Offset: 0x000BA7B0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x000BC5C6 File Offset: 0x000BA7C6
		public virtual int WeaponId
		{
			get
			{
				return this.Instance.WeaponId;
			}
		}

		// Token: 0x04002A71 RID: 10865
		private IWeaponComponent Instance;
	}
}
