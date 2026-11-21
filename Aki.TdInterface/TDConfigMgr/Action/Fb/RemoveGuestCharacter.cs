using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A89 RID: 10889
	public class RemoveGuestCharacter : ActionParams
	{
		// Token: 0x0600F055 RID: 61525 RVA: 0x00233946 File Offset: 0x00231B46
		public static RemoveGuestCharacter Create(IRemoveGuestCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveGuestCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x0600F056 RID: 61526 RVA: 0x00233965 File Offset: 0x00231B65
		public virtual int GuestCharacterId
		{
			get
			{
				return this.Instance.GuestCharacterId;
			}
		}

		// Token: 0x0400842D RID: 33837
		private IRemoveGuestCharacter Instance;
	}
}
