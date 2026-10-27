using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001140 RID: 4416
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiSynthetic : IShowUiCrafting
	{
		// Token: 0x06006446 RID: 25670 RVA: 0x000F12F0 File Offset: 0x000EF4F0
		[NullableContext(1)]
		private IShowUiSynthetic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiSynthetic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiSynthetic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiSynthetic_SetValue());
			}
			return result;
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x000F1328 File Offset: 0x000EF528
		[NullableContext(1)]
		public static IShowUiSynthetic Create([Nullable(2)] IShowUiSynthetic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiSynthetic
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x000F133B File Offset: 0x000EF53B
		[NullableContext(1)]
		public static IShowUiSynthetic CreateFromSetValue([Nullable(2)] IShowUiSynthetic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiSynthetic
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x000F134E File Offset: 0x000EF54E
		[NullableContext(1)]
		public new IShowUiSynthetic_SetValue ToSetValue()
		{
			return new IShowUiSynthetic_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x000F1379 File Offset: 0x000EF579
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x000F13A4 File Offset: 0x000EF5A4
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

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x000F13B2 File Offset: 0x000EF5B2
		// (set) Token: 0x0600644D RID: 25677 RVA: 0x000F13D9 File Offset: 0x000EF5D9
		public override List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiSynthetic_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x000F13E7 File Offset: 0x000EF5E7
		// (set) Token: 0x0600644F RID: 25679 RVA: 0x000F140E File Offset: 0x000EF60E
		public override List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiSynthetic_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003C45 RID: 15429
		protected new IShowUiSynthetic FbInstance;

		// Token: 0x04003C46 RID: 15430
		protected new IShowUiSynthetic_SetValue PocoInterface;
	}
}
