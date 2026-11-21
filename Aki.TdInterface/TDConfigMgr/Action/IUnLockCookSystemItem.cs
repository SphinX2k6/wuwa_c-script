using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200226C RID: 8812
	public class IUnLockCookSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600C006 RID: 49158 RVA: 0x001BAD30 File Offset: 0x001B8F30
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

		// Token: 0x0600C007 RID: 49159 RVA: 0x001BAD68 File Offset: 0x001B8F68
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

		// Token: 0x0600C008 RID: 49160 RVA: 0x001BAD7B File Offset: 0x001B8F7B
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

		// Token: 0x0600C009 RID: 49161 RVA: 0x001BAD8E File Offset: 0x001B8F8E
		public new IUnLockCookSystemItem_SetValue ToSetValue()
		{
			return new IUnLockCookSystemItem_SetValue
			{
				Type = this.Type,
				UnlockOption = this.UnlockOption
			};
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0600C00A RID: 49162 RVA: 0x001BADAD File Offset: 0x001B8FAD
		// (set) Token: 0x0600C00B RID: 49163 RVA: 0x001BADD8 File Offset: 0x001B8FD8
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

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0600C00C RID: 49164 RVA: 0x001BADE8 File Offset: 0x001B8FE8
		// (set) Token: 0x0600C00D RID: 49165 RVA: 0x001BAE49 File Offset: 0x001B9049
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

		// Token: 0x040072F8 RID: 29432
		[Nullable(2)]
		protected new IUnLockCookSystemItem FbInstance;

		// Token: 0x040072F9 RID: 29433
		[Nullable(2)]
		protected new IUnLockCookSystemItem_SetValue PocoInterface;

		// Token: 0x040072FA RID: 29434
		private IUnlockCookSystemCookBook _UnlockOptionCache;

		// Token: 0x040072FB RID: 29435
		private bool _UnlockOptionInited;
	}
}
