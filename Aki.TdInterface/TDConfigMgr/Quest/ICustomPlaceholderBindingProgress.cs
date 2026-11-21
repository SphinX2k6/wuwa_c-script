using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001048 RID: 4168
	public class ICustomPlaceholderBindingProgress
	{
		// Token: 0x06005BF0 RID: 23536 RVA: 0x000DFFD8 File Offset: 0x000DE1D8
		private ICustomPlaceholderBindingProgress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomPlaceholderBindingProgress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomPlaceholderBindingProgress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomPlaceholderBindingProgress_SetValue());
			}
			return result;
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x000E0010 File Offset: 0x000DE210
		public static ICustomPlaceholderBindingProgress Create([Nullable(2)] ICustomPlaceholderBindingProgress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPlaceholderBindingProgress
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x000E0023 File Offset: 0x000DE223
		public static ICustomPlaceholderBindingProgress CreateFromSetValue([Nullable(2)] ICustomPlaceholderBindingProgress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomPlaceholderBindingProgress
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x000E0036 File Offset: 0x000DE236
		public ICustomPlaceholderBindingProgress_SetValue ToSetValue()
		{
			return new ICustomPlaceholderBindingProgress_SetValue
			{
				PlaceHolderName = this.PlaceHolderName,
				BindingProgressType = this.BindingProgressType
			};
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x000E0055 File Offset: 0x000DE255
		// (set) Token: 0x06005BF5 RID: 23541 RVA: 0x000E0080 File Offset: 0x000DE280
		public virtual string PlaceHolderName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlaceHolderName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PlaceHolderName;
			}
			set
			{
				this.GetOrCreatePoco().PlaceHolderName = value;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x000E0090 File Offset: 0x000DE290
		// (set) Token: 0x06005BF7 RID: 23543 RVA: 0x000E00F1 File Offset: 0x000DE2F1
		public virtual IPlayerHavingItemCount BindingProgressType
		{
			get
			{
				if (this._BindingProgressTypeInited)
				{
					return this._BindingProgressTypeCache;
				}
				this._BindingProgressTypeInited = true;
				if (this.FbInstance != null)
				{
					this._BindingProgressTypeCache = IPlayerHavingItemCount.Create(this.FbInstance.BindingProgressType);
				}
				else
				{
					ICustomPlaceholderBindingProgress_SetValue pocoInterface = this.PocoInterface;
					this._BindingProgressTypeCache = ((pocoInterface != null) ? pocoInterface.BindingProgressType : null);
				}
				return this._BindingProgressTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().BindingProgressType = value;
				this._BindingProgressTypeInited = false;
			}
		}

		// Token: 0x04003776 RID: 14198
		[Nullable(2)]
		protected ICustomPlaceholderBindingProgress FbInstance;

		// Token: 0x04003777 RID: 14199
		[Nullable(2)]
		protected ICustomPlaceholderBindingProgress_SetValue PocoInterface;

		// Token: 0x04003778 RID: 14200
		private IPlayerHavingItemCount _BindingProgressTypeCache;

		// Token: 0x04003779 RID: 14201
		private bool _BindingProgressTypeInited;
	}
}
