using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF4 RID: 11764
	public class SheriffChangeCriminalIdentity : ActionParams
	{
		// Token: 0x0600FFCF RID: 65487 RVA: 0x0024D742 File Offset: 0x0024B942
		public static SheriffChangeCriminalIdentity Create(ISheriffChangeCriminalIdentity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffChangeCriminalIdentity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x0600FFD0 RID: 65488 RVA: 0x0024D761 File Offset: 0x0024B961
		public virtual int CriminalId
		{
			get
			{
				return this.Instance.CriminalId;
			}
		}

		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x0600FFD1 RID: 65489 RVA: 0x0024D76E File Offset: 0x0024B96E
		public virtual int IdentityId
		{
			get
			{
				return this.Instance.IdentityId;
			}
		}

		// Token: 0x04008BA2 RID: 35746
		private ISheriffChangeCriminalIdentity Instance;
	}
}
