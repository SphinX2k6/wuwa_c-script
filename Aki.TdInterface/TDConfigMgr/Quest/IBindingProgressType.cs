using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF2 RID: 4082
	public class IBindingProgressType
	{
		// Token: 0x06005972 RID: 22898 RVA: 0x000DA6CC File Offset: 0x000D88CC
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

		// Token: 0x06005973 RID: 22899 RVA: 0x000DA704 File Offset: 0x000D8904
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

		// Token: 0x06005974 RID: 22900 RVA: 0x000DA717 File Offset: 0x000D8917
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

		// Token: 0x06005975 RID: 22901 RVA: 0x000DA72A File Offset: 0x000D892A
		public IBindingProgressType_SetValue ToSetValue()
		{
			return new IBindingProgressType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06005976 RID: 22902 RVA: 0x000DA73D File Offset: 0x000D893D
		// (set) Token: 0x06005977 RID: 22903 RVA: 0x000DA768 File Offset: 0x000D8968
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

		// Token: 0x040035E1 RID: 13793
		[Nullable(2)]
		protected IBindingProgressType FbInstance;

		// Token: 0x040035E2 RID: 13794
		[Nullable(2)]
		protected IBindingProgressType_SetValue PocoInterface;
	}
}
