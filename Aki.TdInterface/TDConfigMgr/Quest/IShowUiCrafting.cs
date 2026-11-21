using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126A RID: 4714
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCrafting : IShowUi
	{
		// Token: 0x06006A29 RID: 27177 RVA: 0x000FE1EC File Offset: 0x000FC3EC
		[NullableContext(0)]
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

		// Token: 0x06006A2A RID: 27178 RVA: 0x000FE224 File Offset: 0x000FC424
		[NullableContext(0)]
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

		// Token: 0x06006A2B RID: 27179 RVA: 0x000FE237 File Offset: 0x000FC437
		[NullableContext(0)]
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

		// Token: 0x06006A2C RID: 27180 RVA: 0x000FE24A File Offset: 0x000FC44A
		[NullableContext(0)]
		public new IShowUiCrafting_SetValue ToSetValue()
		{
			return new IShowUiCrafting_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x000FE275 File Offset: 0x000FC475
		// (set) Token: 0x06006A2E RID: 27182 RVA: 0x000FE2A0 File Offset: 0x000FC4A0
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

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06006A2F RID: 27183 RVA: 0x000FE2AE File Offset: 0x000FC4AE
		// (set) Token: 0x06006A30 RID: 27184 RVA: 0x000FE2D5 File Offset: 0x000FC4D5
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

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06006A31 RID: 27185 RVA: 0x000FE2E3 File Offset: 0x000FC4E3
		// (set) Token: 0x06006A32 RID: 27186 RVA: 0x000FE30A File Offset: 0x000FC50A
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

		// Token: 0x04003F89 RID: 16265
		protected new IShowUiCrafting FbInstance;

		// Token: 0x04003F8A RID: 16266
		protected new IShowUiCrafting_SetValue PocoInterface;
	}
}
