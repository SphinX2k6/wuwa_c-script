using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089E RID: 2206
	public class IWuWaGoGear : IWuWaGoEntityBase
	{
		// Token: 0x06002F8B RID: 12171 RVA: 0x0007A6F0 File Offset: 0x000788F0
		private IWuWaGoGear_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoGear 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoGear_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoGear_SetValue());
			}
			return result;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x0007A728 File Offset: 0x00078928
		public static IWuWaGoGear Create([Nullable(2)] IWuWaGoGear instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGear
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x0007A73B File Offset: 0x0007893B
		public static IWuWaGoGear CreateFromSetValue([Nullable(2)] IWuWaGoGear_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoGear
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x0007A74E File Offset: 0x0007894E
		public new IWuWaGoGear_SetValue ToSetValue()
		{
			return new IWuWaGoGear_SetValue
			{
				Type = this.Type,
				GridEntityIds = this.GridEntityIds
			};
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x0007A76D File Offset: 0x0007896D
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x0007A798 File Offset: 0x00078998
		public override EWuWaGoEntityType Type
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x0007A7A6 File Offset: 0x000789A6
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x0007A7CD File Offset: 0x000789CD
		public virtual List<int> GridEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GridEntityIds;
				}
				IWuWaGoGear_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GridEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().GridEntityIds = value;
			}
		}

		// Token: 0x04001F6C RID: 8044
		[Nullable(2)]
		protected new IWuWaGoGear FbInstance;

		// Token: 0x04001F6D RID: 8045
		[Nullable(2)]
		protected new IWuWaGoGear_SetValue PocoInterface;
	}
}
