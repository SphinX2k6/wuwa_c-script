using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FC9 RID: 4041
	[NullableContext(2)]
	[Nullable(0)]
	public class IItemObtain : IShowUi
	{
		// Token: 0x06005A0E RID: 23054 RVA: 0x000DB14C File Offset: 0x000D934C
		[NullableContext(1)]
		private IItemObtain_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemObtain 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemObtain_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemObtain_SetValue());
			}
			return result;
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x000DB184 File Offset: 0x000D9384
		[NullableContext(1)]
		public static IItemObtain Create([Nullable(2)] IItemObtain instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemObtain
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x000DB197 File Offset: 0x000D9397
		[NullableContext(1)]
		public static IItemObtain CreateFromSetValue([Nullable(2)] IItemObtain_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemObtain
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x000DB1AA File Offset: 0x000D93AA
		[NullableContext(1)]
		public new IItemObtain_SetValue ToSetValue()
		{
			return new IItemObtain_SetValue
			{
				Type = this.Type,
				ItemIds = this.ItemIds
			};
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06005A12 RID: 23058 RVA: 0x000DB1C9 File Offset: 0x000D93C9
		// (set) Token: 0x06005A13 RID: 23059 RVA: 0x000DB1F4 File Offset: 0x000D93F4
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06005A14 RID: 23060 RVA: 0x000DB202 File Offset: 0x000D9402
		// (set) Token: 0x06005A15 RID: 23061 RVA: 0x000DB229 File Offset: 0x000D9429
		public virtual List<int> ItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemIds;
				}
				IItemObtain_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400364E RID: 13902
		protected new IItemObtain FbInstance;

		// Token: 0x0400364F RID: 13903
		protected new IItemObtain_SetValue PocoInterface;
	}
}
