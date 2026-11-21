using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089C RID: 2204
	public class IWuWaGoEntityBase
	{
		// Token: 0x06002F83 RID: 12163 RVA: 0x0007A634 File Offset: 0x00078834
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

		// Token: 0x06002F84 RID: 12164 RVA: 0x0007A66C File Offset: 0x0007886C
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

		// Token: 0x06002F85 RID: 12165 RVA: 0x0007A67F File Offset: 0x0007887F
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

		// Token: 0x06002F86 RID: 12166 RVA: 0x0007A692 File Offset: 0x00078892
		public IWuWaGoEntityBase_SetValue ToSetValue()
		{
			return new IWuWaGoEntityBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x0007A6A5 File Offset: 0x000788A5
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x0007A6D0 File Offset: 0x000788D0
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

		// Token: 0x04001F69 RID: 8041
		[Nullable(2)]
		protected IWuWaGoEntityBase FbInstance;

		// Token: 0x04001F6A RID: 8042
		[Nullable(2)]
		protected IWuWaGoEntityBase_SetValue PocoInterface;
	}
}
