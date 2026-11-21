using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001208 RID: 4616
	public class IRecallConditionByGroup : IRecallConditionBase
	{
		// Token: 0x0600678B RID: 26507 RVA: 0x000F8988 File Offset: 0x000F6B88
		private IRecallConditionByGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConditionByGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConditionByGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConditionByGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x000F89C0 File Offset: 0x000F6BC0
		public static IRecallConditionByGroup Create([Nullable(2)] IRecallConditionByGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x000F89D3 File Offset: 0x000F6BD3
		public static IRecallConditionByGroup CreateFromSetValue([Nullable(2)] IRecallConditionByGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConditionByGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x000F89E6 File Offset: 0x000F6BE6
		public new IRecallConditionByGroup_SetValue ToSetValue()
		{
			return new IRecallConditionByGroup_SetValue
			{
				Type = this.Type,
				Operation = this.Operation,
				GroupIds = this.GroupIds
			};
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x0600678F RID: 26511 RVA: 0x000F8A11 File Offset: 0x000F6C11
		// (set) Token: 0x06006790 RID: 26512 RVA: 0x000F8A3C File Offset: 0x000F6C3C
		public override ERecallConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERecallConditionType.ByEntityType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x000F8A4A File Offset: 0x000F6C4A
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x000F8A75 File Offset: 0x000F6C75
		public override ERecallOperation Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				if (this.PocoInterface == null)
				{
					return ERecallOperation.Include;
				}
				return this.PocoInterface.Operation;
			}
			set
			{
				this.GetOrCreatePoco().Operation = value;
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x000F8A83 File Offset: 0x000F6C83
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x000F8AAA File Offset: 0x000F6CAA
		public virtual List<int> GroupIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupIds;
				}
				IRecallConditionByGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GroupIds;
			}
			set
			{
				this.GetOrCreatePoco().GroupIds = value;
			}
		}

		// Token: 0x04003E04 RID: 15876
		[Nullable(2)]
		protected new IRecallConditionByGroup FbInstance;

		// Token: 0x04003E05 RID: 15877
		[Nullable(2)]
		protected new IRecallConditionByGroup_SetValue PocoInterface;
	}
}
