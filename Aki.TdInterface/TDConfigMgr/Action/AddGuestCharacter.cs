using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001493 RID: 5267
	[NullableContext(1)]
	[Nullable(0)]
	public class AddGuestCharacter : ActionParams
	{
		// Token: 0x060077D0 RID: 30672 RVA: 0x0011F714 File Offset: 0x0011D914
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

		// Token: 0x060077D1 RID: 30673 RVA: 0x0011F74C File Offset: 0x0011D94C
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

		// Token: 0x060077D2 RID: 30674 RVA: 0x0011F75F File Offset: 0x0011D95F
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

		// Token: 0x060077D3 RID: 30675 RVA: 0x0011F772 File Offset: 0x0011D972
		public AddGuestCharacter_SetValue ToSetValue()
		{
			return new AddGuestCharacter_SetValue
			{
				GuestCharacterId = this.GuestCharacterId,
				ActiveRange = this.ActiveRange
			};
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x0011F791 File Offset: 0x0011D991
		// (set) Token: 0x060077D5 RID: 30677 RVA: 0x0011F7BC File Offset: 0x0011D9BC
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

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x060077D6 RID: 30678 RVA: 0x0011F7CC File Offset: 0x0011D9CC
		// (set) Token: 0x060077D7 RID: 30679 RVA: 0x0011F82D File Offset: 0x0011DA2D
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

		// Token: 0x040045A9 RID: 17833
		[Nullable(2)]
		protected new AddGuestCharacter FbInstance;

		// Token: 0x040045AA RID: 17834
		[Nullable(2)]
		protected AddGuestCharacter_SetValue PocoInterface;

		// Token: 0x040045AB RID: 17835
		private IActiveRange _ActiveRangeCache;

		// Token: 0x040045AC RID: 17836
		private bool _ActiveRangeInited;
	}
}
