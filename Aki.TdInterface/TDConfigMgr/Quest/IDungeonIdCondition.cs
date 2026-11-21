using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001074 RID: 4212
	public class IDungeonIdCondition : IDungeonCondition
	{
		// Token: 0x06005CC6 RID: 23750 RVA: 0x000E17F0 File Offset: 0x000DF9F0
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

		// Token: 0x06005CC7 RID: 23751 RVA: 0x000E1828 File Offset: 0x000DFA28
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

		// Token: 0x06005CC8 RID: 23752 RVA: 0x000E183B File Offset: 0x000DFA3B
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

		// Token: 0x06005CC9 RID: 23753 RVA: 0x000E184E File Offset: 0x000DFA4E
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

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06005CCA RID: 23754 RVA: 0x000E1885 File Offset: 0x000DFA85
		// (set) Token: 0x06005CCB RID: 23755 RVA: 0x000E18B0 File Offset: 0x000DFAB0
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

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06005CCC RID: 23756 RVA: 0x000E18BE File Offset: 0x000DFABE
		// (set) Token: 0x06005CCD RID: 23757 RVA: 0x000E18E9 File Offset: 0x000DFAE9
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

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06005CCE RID: 23758 RVA: 0x000E18F8 File Offset: 0x000DFAF8
		// (set) Token: 0x06005CCF RID: 23759 RVA: 0x000E1932 File Offset: 0x000DFB32
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

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06005CD0 RID: 23760 RVA: 0x000E1940 File Offset: 0x000DFB40
		// (set) Token: 0x06005CD1 RID: 23761 RVA: 0x000E196B File Offset: 0x000DFB6B
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

		// Token: 0x040037DD RID: 14301
		[Nullable(2)]
		protected new IDungeonIdCondition FbInstance;

		// Token: 0x040037DE RID: 14302
		[Nullable(2)]
		protected new IDungeonIdCondition_SetValue PocoInterface;
	}
}
