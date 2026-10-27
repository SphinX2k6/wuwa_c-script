using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214E RID: 8526
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveGuestCharacter : ActionParams
	{
		// Token: 0x0600BBAA RID: 48042 RVA: 0x001B12C4 File Offset: 0x001AF4C4
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

		// Token: 0x0600BBAB RID: 48043 RVA: 0x001B12FC File Offset: 0x001AF4FC
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

		// Token: 0x0600BBAC RID: 48044 RVA: 0x001B130F File Offset: 0x001AF50F
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

		// Token: 0x0600BBAD RID: 48045 RVA: 0x001B1322 File Offset: 0x001AF522
		public RemoveGuestCharacter_SetValue ToSetValue()
		{
			return new RemoveGuestCharacter_SetValue
			{
				GuestCharacterId = this.GuestCharacterId
			};
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600BBAE RID: 48046 RVA: 0x001B1335 File Offset: 0x001AF535
		// (set) Token: 0x0600BBAF RID: 48047 RVA: 0x001B1360 File Offset: 0x001AF560
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

		// Token: 0x04007031 RID: 28721
		[Nullable(2)]
		protected new RemoveGuestCharacter FbInstance;

		// Token: 0x04007032 RID: 28722
		[Nullable(2)]
		protected RemoveGuestCharacter_SetValue PocoInterface;
	}
}
