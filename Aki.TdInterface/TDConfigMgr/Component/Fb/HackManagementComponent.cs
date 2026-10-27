using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D83 RID: 3459
	public class HackManagementComponent : IComponentBase
	{
		// Token: 0x06004EB1 RID: 20145 RVA: 0x000C321A File Offset: 0x000C141A
		[NullableContext(1)]
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

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x000C323C File Offset: 0x000C143C
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

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x000C3274 File Offset: 0x000C1474
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x000C328A File Offset: 0x000C148A
		public virtual int MaxHackingCount
		{
			get
			{
				return this.Instance.MaxHackingCount;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x000C3297 File Offset: 0x000C1497
		public virtual float ValidDistance
		{
			get
			{
				return this.Instance.ValidDistance;
			}
		}

		// Token: 0x04002D2A RID: 11562
		private IHackManagementComponent Instance;
	}
}
