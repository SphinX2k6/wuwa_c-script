using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F4C RID: 3916
	[NullableContext(1)]
	[Nullable(0)]
	public class IDungeonSubTypeCondition : IDungeonCondition
	{
		// Token: 0x06005704 RID: 22276 RVA: 0x000D4FC8 File Offset: 0x000D31C8
		private IDungeonSubTypeCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDungeonSubTypeCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDungeonSubTypeCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDungeonSubTypeCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x000D5000 File Offset: 0x000D3200
		public static IDungeonSubTypeCondition Create([Nullable(2)] IDungeonSubTypeCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonSubTypeCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x000D5013 File Offset: 0x000D3213
		public static IDungeonSubTypeCondition CreateFromSetValue([Nullable(2)] IDungeonSubTypeCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDungeonSubTypeCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x000D5026 File Offset: 0x000D3226
		public new IDungeonSubTypeCondition_SetValue ToSetValue()
		{
			return new IDungeonSubTypeCondition_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				IsExitDungeon = this.IsExitDungeon,
				DungeonSubType = this.DungeonSubType
			};
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x000D505D File Offset: 0x000D325D
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x000D5088 File Offset: 0x000D3288
		public override EDungeonConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x000D5096 File Offset: 0x000D3296
		// (set) Token: 0x0600570B RID: 22283 RVA: 0x000D50C1 File Offset: 0x000D32C1
		public override int Count
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

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x000D50D0 File Offset: 0x000D32D0
		// (set) Token: 0x0600570D RID: 22285 RVA: 0x000D510A File Offset: 0x000D330A
		public override bool? IsExitDungeon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsExitDungeon;
				}
				IDungeonSubTypeCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsExitDungeon;
			}
			set
			{
				this.GetOrCreatePoco().IsExitDungeon = value;
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x000D5118 File Offset: 0x000D3318
		// (set) Token: 0x0600570F RID: 22287 RVA: 0x000D5143 File Offset: 0x000D3343
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonSubType;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonSubType.Test;
				}
				return this.PocoInterface.DungeonSubType;
			}
			set
			{
				this.GetOrCreatePoco().DungeonSubType = value;
			}
		}

		// Token: 0x040034B4 RID: 13492
		[Nullable(2)]
		protected new IDungeonSubTypeCondition FbInstance;

		// Token: 0x040034B5 RID: 13493
		[Nullable(2)]
		protected new IDungeonSubTypeCondition_SetValue PocoInterface;
	}
}
