using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AF RID: 9135
	public class RemoveGuestCharacter : ActionParams
	{
		// Token: 0x0600C738 RID: 51000 RVA: 0x001C8478 File Offset: 0x001C6678
		private RemoveGuestCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveGuestCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveGuestCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveGuestCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x0600C739 RID: 51001 RVA: 0x001C84B0 File Offset: 0x001C66B0
		public static RemoveGuestCharacter Create([Nullable(2)] RemoveGuestCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveGuestCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C73A RID: 51002 RVA: 0x001C84C3 File Offset: 0x001C66C3
		public static RemoveGuestCharacter CreateFromSetValue([Nullable(2)] RemoveGuestCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveGuestCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x001C84D6 File Offset: 0x001C66D6
		public RemoveGuestCharacter_SetValue ToSetValue()
		{
			return new RemoveGuestCharacter_SetValue
			{
				GuestCharacterId = this.GuestCharacterId
			};
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600C73C RID: 51004 RVA: 0x001C84E9 File Offset: 0x001C66E9
		// (set) Token: 0x0600C73D RID: 51005 RVA: 0x001C8514 File Offset: 0x001C6714
		public virtual int GuestCharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GuestCharacterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GuestCharacterId;
			}
			set
			{
				this.GetOrCreatePoco().GuestCharacterId = value;
			}
		}

		// Token: 0x04007666 RID: 30310
		[Nullable(2)]
		protected new RemoveGuestCharacter FbInstance;

		// Token: 0x04007667 RID: 30311
		[Nullable(2)]
		protected RemoveGuestCharacter_SetValue PocoInterface;
	}
}
