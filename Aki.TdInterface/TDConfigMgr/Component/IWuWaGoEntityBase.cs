using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F9 RID: 2041
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoEntityBase
	{
		// Token: 0x06002C53 RID: 11347 RVA: 0x000732D0 File Offset: 0x000714D0
		private IWuWaGoEntityBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoEntityBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoEntityBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoEntityBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00073308 File Offset: 0x00071508
		public static IWuWaGoEntityBase Create([Nullable(2)] IWuWaGoEntityBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoEntityBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0007331B File Offset: 0x0007151B
		public static IWuWaGoEntityBase CreateFromSetValue([Nullable(2)] IWuWaGoEntityBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoEntityBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0007332E File Offset: 0x0007152E
		public IWuWaGoEntityBase_SetValue ToSetValue()
		{
			return new IWuWaGoEntityBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x00073341 File Offset: 0x00071541
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x0007336C File Offset: 0x0007156C
		public virtual EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001D5D RID: 7517
		[Nullable(2)]
		protected IWuWaGoEntityBase FbInstance;

		// Token: 0x04001D5E RID: 7518
		[Nullable(2)]
		protected IWuWaGoEntityBase_SetValue PocoInterface;
	}
}
