using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F48 RID: 3912
	[NullableContext(1)]
	[Nullable(0)]
	public class IDungeonCondition
	{
		// Token: 0x060056EA RID: 22250 RVA: 0x000D4CD8 File Offset: 0x000D2ED8
		private IDungeonCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDungeonCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDungeonCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDungeonCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x000D4D10 File Offset: 0x000D2F10
		public static IDungeonCondition Create([Nullable(2)] IDungeonCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x000D4D23 File Offset: 0x000D2F23
		public static IDungeonCondition CreateFromSetValue([Nullable(2)] IDungeonCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDungeonCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x000D4D36 File Offset: 0x000D2F36
		public IDungeonCondition_SetValue ToSetValue()
		{
			return new IDungeonCondition_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				IsExitDungeon = this.IsExitDungeon
			};
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x060056EE RID: 22254 RVA: 0x000D4D61 File Offset: 0x000D2F61
		// (set) Token: 0x060056EF RID: 22255 RVA: 0x000D4D8C File Offset: 0x000D2F8C
		public virtual EDungeonConditionType Type
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

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x060056F0 RID: 22256 RVA: 0x000D4D9A File Offset: 0x000D2F9A
		// (set) Token: 0x060056F1 RID: 22257 RVA: 0x000D4DC5 File Offset: 0x000D2FC5
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

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x000D4DD4 File Offset: 0x000D2FD4
		// (set) Token: 0x060056F3 RID: 22259 RVA: 0x000D4E0E File Offset: 0x000D300E
		public virtual bool? IsExitDungeon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsExitDungeon;
				}
				IDungeonCondition_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040034A9 RID: 13481
		[Nullable(2)]
		protected IDungeonCondition FbInstance;

		// Token: 0x040034AA RID: 13482
		[Nullable(2)]
		protected IDungeonCondition_SetValue PocoInterface;
	}
}
