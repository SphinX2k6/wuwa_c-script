using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E7F RID: 3711
	public class HackManagementComponent : IComponentBase
	{
		// Token: 0x060053D6 RID: 21462 RVA: 0x000CEA6A File Offset: 0x000CCC6A
		public static HackManagementComponent Create(IHackManagementComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HackManagementComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x000CEA8C File Offset: 0x000CCC8C
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x000CEAC4 File Offset: 0x000CCCC4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x000CEADA File Offset: 0x000CCCDA
		public virtual int MaxHackingCount
		{
			get
			{
				return this.Instance.MaxHackingCount;
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x000CEAE7 File Offset: 0x000CCCE7
		public virtual float ValidDistance
		{
			get
			{
				return this.Instance.ValidDistance;
			}
		}

		// Token: 0x04002FF0 RID: 12272
		private IHackManagementComponent Instance;
	}
}
