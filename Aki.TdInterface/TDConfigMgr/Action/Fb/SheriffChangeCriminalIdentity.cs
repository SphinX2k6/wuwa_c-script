using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B00 RID: 11008
	public class SheriffChangeCriminalIdentity : ActionParams
	{
		// Token: 0x0600F119 RID: 61721 RVA: 0x0022FA36 File Offset: 0x0022DC36
		[NullableContext(1)]
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

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x0600F11A RID: 61722 RVA: 0x0022FA55 File Offset: 0x0022DC55
		public virtual int CriminalId
		{
			get
			{
				return this.Instance.CriminalId;
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x0600F11B RID: 61723 RVA: 0x0022FA62 File Offset: 0x0022DC62
		public virtual int IdentityId
		{
			get
			{
				return this.Instance.IdentityId;
			}
		}

		// Token: 0x0400849E RID: 33950
		private ISheriffChangeCriminalIdentity Instance;
	}
}
