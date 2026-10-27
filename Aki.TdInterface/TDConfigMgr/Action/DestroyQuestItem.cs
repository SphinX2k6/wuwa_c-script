using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001565 RID: 5477
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyQuestItem : ActionParams
	{
		// Token: 0x06007BAF RID: 31663 RVA: 0x00129DC0 File Offset: 0x00127FC0
		private DestroyQuestItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroyQuestItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroyQuestItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroyQuestItem_SetValue());
			}
			return result;
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x00129DF8 File Offset: 0x00127FF8
		public static DestroyQuestItem Create([Nullable(2)] DestroyQuestItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuestItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x00129E0B File Offset: 0x0012800B
		public static DestroyQuestItem CreateFromSetValue([Nullable(2)] DestroyQuestItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroyQuestItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x00129E1E File Offset: 0x0012801E
		public DestroyQuestItem_SetValue ToSetValue()
		{
			return new DestroyQuestItem_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count,
				IsAll = this.IsAll
			};
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x00129E49 File Offset: 0x00128049
		// (set) Token: 0x06007BB4 RID: 31668 RVA: 0x00129E74 File Offset: 0x00128074
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x00129E82 File Offset: 0x00128082
		// (set) Token: 0x06007BB6 RID: 31670 RVA: 0x00129EAD File Offset: 0x001280AD
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

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x06007BB7 RID: 31671 RVA: 0x00129EBB File Offset: 0x001280BB
		// (set) Token: 0x06007BB8 RID: 31672 RVA: 0x00129EE6 File Offset: 0x001280E6
		public virtual bool IsAll
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAll;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAll;
			}
			set
			{
				this.GetOrCreatePoco().IsAll = value;
			}
		}

		// Token: 0x04004736 RID: 18230
		[Nullable(2)]
		protected new DestroyQuestItem FbInstance;

		// Token: 0x04004737 RID: 18231
		[Nullable(2)]
		protected DestroyQuestItem_SetValue PocoInterface;
	}
}
