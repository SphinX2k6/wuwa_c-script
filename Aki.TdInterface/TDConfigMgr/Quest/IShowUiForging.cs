using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113E RID: 4414
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiForging : IShowUiCrafting
	{
		// Token: 0x0600643A RID: 25658 RVA: 0x000F11B4 File Offset: 0x000EF3B4
		[NullableContext(1)]
		private IShowUiForging_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiForging 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiForging_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiForging_SetValue());
			}
			return result;
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x000F11EC File Offset: 0x000EF3EC
		[NullableContext(1)]
		public static IShowUiForging Create([Nullable(2)] IShowUiForging instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiForging
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x000F11FF File Offset: 0x000EF3FF
		[NullableContext(1)]
		public static IShowUiForging CreateFromSetValue([Nullable(2)] IShowUiForging_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiForging
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x000F1212 File Offset: 0x000EF412
		[NullableContext(1)]
		public new IShowUiForging_SetValue ToSetValue()
		{
			return new IShowUiForging_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x000F123D File Offset: 0x000EF43D
		// (set) Token: 0x0600643F RID: 25663 RVA: 0x000F1268 File Offset: 0x000EF468
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

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x000F1276 File Offset: 0x000EF476
		// (set) Token: 0x06006441 RID: 25665 RVA: 0x000F129D File Offset: 0x000EF49D
		public override List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiForging_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x000F12AB File Offset: 0x000EF4AB
		// (set) Token: 0x06006443 RID: 25667 RVA: 0x000F12D2 File Offset: 0x000EF4D2
		public override List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiForging_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProductIds;
			}
			set
			{
				this.GetOrCreatePoco().ProductIds = value;
			}
		}

		// Token: 0x04003C40 RID: 15424
		protected new IShowUiForging FbInstance;

		// Token: 0x04003C41 RID: 15425
		protected new IShowUiForging_SetValue PocoInterface;
	}
}
