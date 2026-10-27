using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002023 RID: 8227
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnLockCookSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600B4E0 RID: 46304 RVA: 0x001A45C4 File Offset: 0x001A27C4
		private IUnLockCookSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnLockCookSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnLockCookSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnLockCookSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x001A45FC File Offset: 0x001A27FC
		public static IUnLockCookSystemItem Create([Nullable(2)] IUnLockCookSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnLockCookSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x001A460F File Offset: 0x001A280F
		public static IUnLockCookSystemItem CreateFromSetValue([Nullable(2)] IUnLockCookSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnLockCookSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x001A4622 File Offset: 0x001A2822
		public new IUnLockCookSystemItem_SetValue ToSetValue()
		{
			return new IUnLockCookSystemItem_SetValue
			{
				Type = this.Type,
				UnlockOption = this.UnlockOption
			};
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600B4E4 RID: 46308 RVA: 0x001A4641 File Offset: 0x001A2841
		// (set) Token: 0x0600B4E5 RID: 46309 RVA: 0x001A466C File Offset: 0x001A286C
		public override EUnlockSystemItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600B4E6 RID: 46310 RVA: 0x001A467C File Offset: 0x001A287C
		// (set) Token: 0x0600B4E7 RID: 46311 RVA: 0x001A46DD File Offset: 0x001A28DD
		public virtual IUnlockCookSystemCookBook UnlockOption
		{
			get
			{
				if (this._UnlockOptionInited)
				{
					return this._UnlockOptionCache;
				}
				this._UnlockOptionInited = true;
				if (this.FbInstance != null)
				{
					this._UnlockOptionCache = IUnlockCookSystemCookBook.Create(this.FbInstance.UnlockOption);
				}
				else
				{
					IUnLockCookSystemItem_SetValue pocoInterface = this.PocoInterface;
					this._UnlockOptionCache = ((pocoInterface != null) ? pocoInterface.UnlockOption : null);
				}
				return this._UnlockOptionCache;
			}
			set
			{
				this.GetOrCreatePoco().UnlockOption = value;
				this._UnlockOptionInited = false;
			}
		}

		// Token: 0x04006CEF RID: 27887
		[Nullable(2)]
		protected new IUnLockCookSystemItem FbInstance;

		// Token: 0x04006CF0 RID: 27888
		[Nullable(2)]
		protected new IUnLockCookSystemItem_SetValue PocoInterface;

		// Token: 0x04006CF1 RID: 27889
		private IUnlockCookSystemCookBook _UnlockOptionCache;

		// Token: 0x04006CF2 RID: 27890
		private bool _UnlockOptionInited;
	}
}
