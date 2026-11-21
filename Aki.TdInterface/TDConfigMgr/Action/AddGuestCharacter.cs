using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015EC RID: 5612
	public class AddGuestCharacter : ActionParams
	{
		// Token: 0x06007E9D RID: 32413 RVA: 0x0012E360 File Offset: 0x0012C560
		private AddGuestCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddGuestCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddGuestCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddGuestCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x0012E398 File Offset: 0x0012C598
		public static AddGuestCharacter Create([Nullable(2)] AddGuestCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddGuestCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x0012E3AB File Offset: 0x0012C5AB
		public static AddGuestCharacter CreateFromSetValue([Nullable(2)] AddGuestCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddGuestCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x0012E3BE File Offset: 0x0012C5BE
		public AddGuestCharacter_SetValue ToSetValue()
		{
			return new AddGuestCharacter_SetValue
			{
				GuestCharacterId = this.GuestCharacterId,
				ActiveRange = this.ActiveRange
			};
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06007EA1 RID: 32417 RVA: 0x0012E3DD File Offset: 0x0012C5DD
		// (set) Token: 0x06007EA2 RID: 32418 RVA: 0x0012E408 File Offset: 0x0012C608
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

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06007EA3 RID: 32419 RVA: 0x0012E418 File Offset: 0x0012C618
		// (set) Token: 0x06007EA4 RID: 32420 RVA: 0x0012E479 File Offset: 0x0012C679
		[Nullable(2)]
		public virtual IActiveRange ActiveRange
		{
			[NullableContext(2)]
			get
			{
				if (this._ActiveRangeInited)
				{
					return this._ActiveRangeCache;
				}
				this._ActiveRangeInited = true;
				if (this.FbInstance != null)
				{
					this._ActiveRangeCache = IActiveRange.Create(this.FbInstance.ActiveRange);
				}
				else
				{
					AddGuestCharacter_SetValue pocoInterface = this.PocoInterface;
					this._ActiveRangeCache = ((pocoInterface != null) ? pocoInterface.ActiveRange : null);
				}
				return this._ActiveRangeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ActiveRange = value;
				this._ActiveRangeInited = false;
			}
		}

		// Token: 0x04004944 RID: 18756
		[Nullable(2)]
		protected new AddGuestCharacter FbInstance;

		// Token: 0x04004945 RID: 18757
		[Nullable(2)]
		protected AddGuestCharacter_SetValue PocoInterface;

		// Token: 0x04004946 RID: 18758
		private IActiveRange _ActiveRangeCache;

		// Token: 0x04004947 RID: 18759
		private bool _ActiveRangeInited;
	}
}
