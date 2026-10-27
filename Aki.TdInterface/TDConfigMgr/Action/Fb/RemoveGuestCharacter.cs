using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B6 RID: 10166
	public class RemoveGuestCharacter : ActionParams
	{
		// Token: 0x0600E233 RID: 57907 RVA: 0x00216B72 File Offset: 0x00214D72
		[NullableContext(1)]
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

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x0600E234 RID: 57908 RVA: 0x00216B91 File Offset: 0x00214D91
		public virtual int GuestCharacterId
		{
			get
			{
				return this.Instance.GuestCharacterId;
			}
		}

		// Token: 0x04007D76 RID: 32118
		private IRemoveGuestCharacter Instance;
	}
}
