using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200226E RID: 8814
	public class IUnlockCookSystemType
	{
		// Token: 0x0600C010 RID: 49168 RVA: 0x001BAE70 File Offset: 0x001B9070
		private IUnlockCookSystemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockCookSystemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockCookSystemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockCookSystemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600C011 RID: 49169 RVA: 0x001BAEA8 File Offset: 0x001B90A8
		public static IUnlockCookSystemType Create([Nullable(2)] IUnlockCookSystemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C012 RID: 49170 RVA: 0x001BAEBB File Offset: 0x001B90BB
		public static IUnlockCookSystemType CreateFromSetValue([Nullable(2)] IUnlockCookSystemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockCookSystemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C013 RID: 49171 RVA: 0x001BAECE File Offset: 0x001B90CE
		public IUnlockCookSystemType_SetValue ToSetValue()
		{
			return new IUnlockCookSystemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600C014 RID: 49172 RVA: 0x001BAEE1 File Offset: 0x001B90E1
		// (set) Token: 0x0600C015 RID: 49173 RVA: 0x001BAF0C File Offset: 0x001B910C
		public virtual EUnlockCookSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockCookSystemType.UnlockCookBook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040072FE RID: 29438
		[Nullable(2)]
		protected IUnlockCookSystemType FbInstance;

		// Token: 0x040072FF RID: 29439
		[Nullable(2)]
		protected IUnlockCookSystemType_SetValue PocoInterface;
	}
}
