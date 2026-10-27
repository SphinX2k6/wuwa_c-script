using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113C RID: 4412
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCrafting : IShowUi
	{
		// Token: 0x0600642E RID: 25646 RVA: 0x000F1078 File Offset: 0x000EF278
		[NullableContext(1)]
		private IShowUiCrafting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiCrafting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiCrafting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiCrafting_SetValue());
			}
			return result;
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x000F10B0 File Offset: 0x000EF2B0
		[NullableContext(1)]
		public static IShowUiCrafting Create([Nullable(2)] IShowUiCrafting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCrafting
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x000F10C3 File Offset: 0x000EF2C3
		[NullableContext(1)]
		public static IShowUiCrafting CreateFromSetValue([Nullable(2)] IShowUiCrafting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiCrafting
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x000F10D6 File Offset: 0x000EF2D6
		[NullableContext(1)]
		public new IShowUiCrafting_SetValue ToSetValue()
		{
			return new IShowUiCrafting_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06006432 RID: 25650 RVA: 0x000F1101 File Offset: 0x000EF301
		// (set) Token: 0x06006433 RID: 25651 RVA: 0x000F112C File Offset: 0x000EF32C
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

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06006434 RID: 25652 RVA: 0x000F113A File Offset: 0x000EF33A
		// (set) Token: 0x06006435 RID: 25653 RVA: 0x000F1161 File Offset: 0x000EF361
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiCrafting_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06006436 RID: 25654 RVA: 0x000F116F File Offset: 0x000EF36F
		// (set) Token: 0x06006437 RID: 25655 RVA: 0x000F1196 File Offset: 0x000EF396
		public virtual List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiCrafting_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003C3B RID: 15419
		protected new IShowUiCrafting FbInstance;

		// Token: 0x04003C3C RID: 15420
		protected new IShowUiCrafting_SetValue PocoInterface;
	}
}
