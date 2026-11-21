using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E9B RID: 3739
	public class SimpleCombatComponent : IComponentBase
	{
		// Token: 0x06005468 RID: 21608 RVA: 0x000CFFBA File Offset: 0x000CE1BA
		public static SimpleCombatComponent Create(ISimpleCombatComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SimpleCombatComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x000CFFDC File Offset: 0x000CE1DC
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

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x000D0014 File Offset: 0x000CE214
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x000D002A File Offset: 0x000CE22A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04003048 RID: 12360
		private ISimpleCombatComponent Instance;
	}
}
