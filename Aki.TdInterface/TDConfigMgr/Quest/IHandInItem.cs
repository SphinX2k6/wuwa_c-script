using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D7 RID: 4311
	public class IHandInItem
	{
		// Token: 0x06005F42 RID: 24386 RVA: 0x000E68B0 File Offset: 0x000E4AB0
		private IHandInItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInItem_SetValue());
			}
			return result;
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x000E68E8 File Offset: 0x000E4AE8
		public static IHandInItem Create([Nullable(2)] IHandInItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x000E68FB File Offset: 0x000E4AFB
		public static IHandInItem CreateFromSetValue([Nullable(2)] IHandInItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x000E690E File Offset: 0x000E4B0E
		public IHandInItem_SetValue ToSetValue()
		{
			return new IHandInItem_SetValue
			{
				HandInType = this.HandInType,
				ItemIds = this.ItemIds,
				Count = this.Count
			};
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06005F46 RID: 24390 RVA: 0x000E6939 File Offset: 0x000E4B39
		// (set) Token: 0x06005F47 RID: 24391 RVA: 0x000E6964 File Offset: 0x000E4B64
		public virtual EHandInItemType HandInType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandInType;
				}
				if (this.PocoInterface == null)
				{
					return EHandInItemType.ItemIds;
				}
				return this.PocoInterface.HandInType;
			}
			set
			{
				this.GetOrCreatePoco().HandInType = value;
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x000E6972 File Offset: 0x000E4B72
		// (set) Token: 0x06005F49 RID: 24393 RVA: 0x000E6999 File Offset: 0x000E4B99
		public virtual List<int> ItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemIds;
				}
				IHandInItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemIds;
			}
			set
			{
				this.GetOrCreatePoco().ItemIds = value;
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06005F4A RID: 24394 RVA: 0x000E69A7 File Offset: 0x000E4BA7
		// (set) Token: 0x06005F4B RID: 24395 RVA: 0x000E69D2 File Offset: 0x000E4BD2
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x0400392B RID: 14635
		[Nullable(2)]
		protected IHandInItem FbInstance;

		// Token: 0x0400392C RID: 14636
		[Nullable(2)]
		protected IHandInItem_SetValue PocoInterface;
	}
}
