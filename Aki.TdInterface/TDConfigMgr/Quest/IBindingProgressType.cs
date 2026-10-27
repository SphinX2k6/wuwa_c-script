using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EDC RID: 3804
	[NullableContext(1)]
	[Nullable(0)]
	public class IBindingProgressType
	{
		// Token: 0x060053F6 RID: 21494 RVA: 0x000CE524 File Offset: 0x000CC724
		private IBindingProgressType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBindingProgressType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBindingProgressType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBindingProgressType_SetValue());
			}
			return result;
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x000CE55C File Offset: 0x000CC75C
		public static IBindingProgressType Create([Nullable(2)] IBindingProgressType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBindingProgressType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x000CE56F File Offset: 0x000CC76F
		public static IBindingProgressType CreateFromSetValue([Nullable(2)] IBindingProgressType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBindingProgressType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x000CE582 File Offset: 0x000CC782
		public IBindingProgressType_SetValue ToSetValue()
		{
			return new IBindingProgressType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x000CE595 File Offset: 0x000CC795
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x000CE5C0 File Offset: 0x000CC7C0
		public virtual EBindingProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBindingProgressType.PlayerHavingItemCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040032D4 RID: 13012
		[Nullable(2)]
		protected IBindingProgressType FbInstance;

		// Token: 0x040032D5 RID: 13013
		[Nullable(2)]
		protected IBindingProgressType_SetValue PocoInterface;
	}
}
