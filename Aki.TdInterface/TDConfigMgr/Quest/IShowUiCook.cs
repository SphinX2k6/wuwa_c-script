using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113A RID: 4410
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCook : IShowUiCrafting
	{
		// Token: 0x06006422 RID: 25634 RVA: 0x000F0F3C File Offset: 0x000EF13C
		[NullableContext(1)]
		private IShowUiCook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiCook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiCook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiCook_SetValue());
			}
			return result;
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x000F0F74 File Offset: 0x000EF174
		[NullableContext(1)]
		public static IShowUiCook Create([Nullable(2)] IShowUiCook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x000F0F87 File Offset: 0x000EF187
		[NullableContext(1)]
		public static IShowUiCook CreateFromSetValue([Nullable(2)] IShowUiCook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiCook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x000F0F9A File Offset: 0x000EF19A
		[NullableContext(1)]
		public new IShowUiCook_SetValue ToSetValue()
		{
			return new IShowUiCook_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06006426 RID: 25638 RVA: 0x000F0FC5 File Offset: 0x000EF1C5
		// (set) Token: 0x06006427 RID: 25639 RVA: 0x000F0FF0 File Offset: 0x000EF1F0
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

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x000F0FFE File Offset: 0x000EF1FE
		// (set) Token: 0x06006429 RID: 25641 RVA: 0x000F1025 File Offset: 0x000EF225
		public override List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiCook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600642A RID: 25642 RVA: 0x000F1033 File Offset: 0x000EF233
		// (set) Token: 0x0600642B RID: 25643 RVA: 0x000F105A File Offset: 0x000EF25A
		public override List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiCook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003C36 RID: 15414
		protected new IShowUiCook FbInstance;

		// Token: 0x04003C37 RID: 15415
		protected new IShowUiCook_SetValue PocoInterface;
	}
}
