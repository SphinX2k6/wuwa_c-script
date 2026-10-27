using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F32 RID: 3890
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomPlaceholderBindingProgress
	{
		// Token: 0x06005674 RID: 22132 RVA: 0x000D3E30 File Offset: 0x000D2030
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

		// Token: 0x06005675 RID: 22133 RVA: 0x000D3E68 File Offset: 0x000D2068
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

		// Token: 0x06005676 RID: 22134 RVA: 0x000D3E7B File Offset: 0x000D207B
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

		// Token: 0x06005677 RID: 22135 RVA: 0x000D3E8E File Offset: 0x000D208E
		public ICustomPlaceholderBindingProgress_SetValue ToSetValue()
		{
			return new ICustomPlaceholderBindingProgress_SetValue
			{
				PlaceHolderName = this.PlaceHolderName,
				BindingProgressType = this.BindingProgressType
			};
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x000D3EAD File Offset: 0x000D20AD
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x000D3ED8 File Offset: 0x000D20D8
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

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x000D3EE8 File Offset: 0x000D20E8
		// (set) Token: 0x0600567B RID: 22139 RVA: 0x000D3F49 File Offset: 0x000D2149
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

		// Token: 0x04003469 RID: 13417
		[Nullable(2)]
		protected ICustomPlaceholderBindingProgress FbInstance;

		// Token: 0x0400346A RID: 13418
		[Nullable(2)]
		protected ICustomPlaceholderBindingProgress_SetValue PocoInterface;

		// Token: 0x0400346B RID: 13419
		private IPlayerHavingItemCount _BindingProgressTypeCache;

		// Token: 0x0400346C RID: 13420
		private bool _BindingProgressTypeInited;
	}
}
