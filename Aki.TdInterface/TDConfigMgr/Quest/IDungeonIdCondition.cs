using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F4A RID: 3914
	[NullableContext(1)]
	[Nullable(0)]
	public class IDungeonIdCondition : IDungeonCondition
	{
		// Token: 0x060056F6 RID: 22262 RVA: 0x000D4E2C File Offset: 0x000D302C
		private IDungeonIdCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDungeonIdCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDungeonIdCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDungeonIdCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x000D4E64 File Offset: 0x000D3064
		public static IDungeonIdCondition Create([Nullable(2)] IDungeonIdCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonIdCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x000D4E77 File Offset: 0x000D3077
		public static IDungeonIdCondition CreateFromSetValue([Nullable(2)] IDungeonIdCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDungeonIdCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x000D4E8A File Offset: 0x000D308A
		public new IDungeonIdCondition_SetValue ToSetValue()
		{
			return new IDungeonIdCondition_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				IsExitDungeon = this.IsExitDungeon,
				DungeonId = this.DungeonId
			};
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x060056FA RID: 22266 RVA: 0x000D4EC1 File Offset: 0x000D30C1
		// (set) Token: 0x060056FB RID: 22267 RVA: 0x000D4EEC File Offset: 0x000D30EC
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

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x000D4EFA File Offset: 0x000D30FA
		// (set) Token: 0x060056FD RID: 22269 RVA: 0x000D4F25 File Offset: 0x000D3125
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

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x060056FE RID: 22270 RVA: 0x000D4F34 File Offset: 0x000D3134
		// (set) Token: 0x060056FF RID: 22271 RVA: 0x000D4F6E File Offset: 0x000D316E
		public override bool? IsExitDungeon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsExitDungeon;
				}
				IDungeonIdCondition_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x000D4F7C File Offset: 0x000D317C
		// (set) Token: 0x06005701 RID: 22273 RVA: 0x000D4FA7 File Offset: 0x000D31A7
		public virtual int DungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DungeonId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonId = value;
			}
		}

		// Token: 0x040034AE RID: 13486
		[Nullable(2)]
		protected new IDungeonIdCondition FbInstance;

		// Token: 0x040034AF RID: 13487
		[Nullable(2)]
		protected new IDungeonIdCondition_SetValue PocoInterface;
	}
}
