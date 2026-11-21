using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB5 RID: 3765
	public class SunSpiritLauncherComponent : IComponentBase
	{
		// Token: 0x060054E5 RID: 21733 RVA: 0x000D0E6A File Offset: 0x000CF06A
		public static SunSpiritLauncherComponent Create(ISunSpiritLauncherComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritLauncherComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x000D0E8C File Offset: 0x000CF08C
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

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x000D0EC4 File Offset: 0x000CF0C4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x060054E8 RID: 21736 RVA: 0x000D0EDA File Offset: 0x000CF0DA
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x000D0EE7 File Offset: 0x000CF0E7
		public virtual int NeedsCount
		{
			get
			{
				return this.Instance.NeedsCount;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x060054EA RID: 21738 RVA: 0x000D0EF4 File Offset: 0x000CF0F4
		public virtual int SunSpiritGearId
		{
			get
			{
				return this.Instance.SunSpiritGearId;
			}
		}

		// Token: 0x0400308A RID: 12426
		private ISunSpiritLauncherComponent Instance;
	}
}
