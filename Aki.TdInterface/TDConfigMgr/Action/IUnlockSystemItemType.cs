using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002274 RID: 8820
	public class IUnlockSystemItemType
	{
		// Token: 0x0600C02C RID: 49196 RVA: 0x001BB12C File Offset: 0x001B932C
		private IUnlockSystemItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockSystemItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockSystemItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockSystemItemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600C02D RID: 49197 RVA: 0x001BB164 File Offset: 0x001B9364
		public static IUnlockSystemItemType Create([Nullable(2)] IUnlockSystemItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockSystemItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x001BB177 File Offset: 0x001B9377
		public static IUnlockSystemItemType CreateFromSetValue([Nullable(2)] IUnlockSystemItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockSystemItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C02F RID: 49199 RVA: 0x001BB18A File Offset: 0x001B938A
		public IUnlockSystemItemType_SetValue ToSetValue()
		{
			return new IUnlockSystemItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600C030 RID: 49200 RVA: 0x001BB19D File Offset: 0x001B939D
		// (set) Token: 0x0600C031 RID: 49201 RVA: 0x001BB1C8 File Offset: 0x001B93C8
		public virtual EUnlockSystemItemType Type
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

		// Token: 0x04007309 RID: 29449
		[Nullable(2)]
		protected IUnlockSystemItemType FbInstance;

		// Token: 0x0400730A RID: 29450
		[Nullable(2)]
		protected IUnlockSystemItemType_SetValue PocoInterface;
	}
}
