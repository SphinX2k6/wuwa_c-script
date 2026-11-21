using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284B RID: 10315
	public class IActorLookAtLockable : IActorLookAtData
	{
		// Token: 0x0600E62F RID: 58927 RVA: 0x00221699 File Offset: 0x0021F899
		public static IActorLookAtLockable Create(IActorLookAtLockable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtLockable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x0600E630 RID: 58928 RVA: 0x002216B8 File Offset: 0x0021F8B8
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x0600E631 RID: 58929 RVA: 0x002216C8 File Offset: 0x0021F8C8
		public virtual bool? Lock
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

		// Token: 0x04007ED9 RID: 32473
		private IActorLookAtLockable Instance;
	}
}
