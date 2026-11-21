using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284D RID: 10317
	public class IActorLookAtEmptyData : IActorLookAtLockable
	{
		// Token: 0x0600E637 RID: 58935 RVA: 0x00221772 File Offset: 0x0021F972
		public static IActorLookAtEmptyData Create(IActorLookAtEmptyData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtEmptyData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x0600E638 RID: 58936 RVA: 0x00221791 File Offset: 0x0021F991
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x0600E639 RID: 58937 RVA: 0x002217A0 File Offset: 0x0021F9A0
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

		// Token: 0x04007EDB RID: 32475
		private IActorLookAtEmptyData Instance;
	}
}
