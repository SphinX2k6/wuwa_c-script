using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002850 RID: 10320
	public class IActorLookAtPlayerData : IActorLookAtLockable
	{
		// Token: 0x0600E645 RID: 58949 RVA: 0x002218F6 File Offset: 0x0021FAF6
		public static IActorLookAtPlayerData Create(IActorLookAtPlayerData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtPlayerData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x0600E646 RID: 58950 RVA: 0x00221915 File Offset: 0x0021FB15
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x0600E647 RID: 58951 RVA: 0x00221924 File Offset: 0x0021FB24
		public override bool? Lock
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Lock);
			}
		}

		// Token: 0x04007EE0 RID: 32480
		private IActorLookAtPlayerData Instance;
	}
}
