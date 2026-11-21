using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF7 RID: 11767
	public class ToggleEntityElementalAbility : ActionParams
	{
		// Token: 0x0600FFDC RID: 65500 RVA: 0x0024D834 File Offset: 0x0024BA34
		public static ToggleEntityElementalAbility Create(IToggleEntityElementalAbility? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleEntityElementalAbility
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x0600FFDD RID: 65501 RVA: 0x0024D853 File Offset: 0x0024BA53
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x0600FFDE RID: 65502 RVA: 0x0024D860 File Offset: 0x0024BA60
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x04008BA7 RID: 35751
		private IToggleEntityElementalAbility Instance;
	}
}
