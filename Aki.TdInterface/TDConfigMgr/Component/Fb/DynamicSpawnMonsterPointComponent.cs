using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA8 RID: 3752
	public class DynamicSpawnMonsterPointComponent : IComponentBase
	{
		// Token: 0x060054A9 RID: 21673 RVA: 0x000D06F5 File Offset: 0x000CE8F5
		public static DynamicSpawnMonsterPointComponent Create(IDynamicSpawnMonsterPointComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterPointComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x000D0714 File Offset: 0x000CE914
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

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x060054AB RID: 21675 RVA: 0x000D074C File Offset: 0x000CE94C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x000D0764 File Offset: 0x000CE964
		public virtual int? TagId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TagId);
			}
		}

		// Token: 0x04003067 RID: 12391
		private IDynamicSpawnMonsterPointComponent Instance;
	}
}
