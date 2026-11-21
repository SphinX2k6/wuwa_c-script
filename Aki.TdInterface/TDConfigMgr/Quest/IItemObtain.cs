using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010F5 RID: 4341
	public class IItemObtain : IShowUi
	{
		// Token: 0x06005FEC RID: 24556 RVA: 0x000E7CD8 File Offset: 0x000E5ED8
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

		// Token: 0x06005FED RID: 24557 RVA: 0x000E7D10 File Offset: 0x000E5F10
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

		// Token: 0x06005FEE RID: 24558 RVA: 0x000E7D23 File Offset: 0x000E5F23
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

		// Token: 0x06005FEF RID: 24559 RVA: 0x000E7D36 File Offset: 0x000E5F36
		public new IItemObtain_SetValue ToSetValue()
		{
			return new IItemObtain_SetValue
			{
				Type = this.Type,
				ItemIds = this.ItemIds
			};
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06005FF0 RID: 24560 RVA: 0x000E7D55 File Offset: 0x000E5F55
		// (set) Token: 0x06005FF1 RID: 24561 RVA: 0x000E7D80 File Offset: 0x000E5F80
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

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x000E7D8E File Offset: 0x000E5F8E
		// (set) Token: 0x06005FF3 RID: 24563 RVA: 0x000E7DB5 File Offset: 0x000E5FB5
		[Nullable(2)]
		public virtual List<int> ItemIds
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ItemIds = value;
			}
		}

		// Token: 0x04003983 RID: 14723
		[Nullable(2)]
		protected new IItemObtain FbInstance;

		// Token: 0x04003984 RID: 14724
		[Nullable(2)]
		protected new IItemObtain_SetValue PocoInterface;
	}
}
