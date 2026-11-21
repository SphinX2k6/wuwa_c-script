using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001076 RID: 4214
	public class IDungeonSubTypeCondition : IDungeonCondition
	{
		// Token: 0x06005CD4 RID: 23764 RVA: 0x000E198C File Offset: 0x000DFB8C
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

		// Token: 0x06005CD5 RID: 23765 RVA: 0x000E19C4 File Offset: 0x000DFBC4
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

		// Token: 0x06005CD6 RID: 23766 RVA: 0x000E19D7 File Offset: 0x000DFBD7
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

		// Token: 0x06005CD7 RID: 23767 RVA: 0x000E19EA File Offset: 0x000DFBEA
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

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06005CD8 RID: 23768 RVA: 0x000E1A21 File Offset: 0x000DFC21
		// (set) Token: 0x06005CD9 RID: 23769 RVA: 0x000E1A4C File Offset: 0x000DFC4C
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06005CDA RID: 23770 RVA: 0x000E1A5A File Offset: 0x000DFC5A
		// (set) Token: 0x06005CDB RID: 23771 RVA: 0x000E1A85 File Offset: 0x000DFC85
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06005CDC RID: 23772 RVA: 0x000E1A94 File Offset: 0x000DFC94
		// (set) Token: 0x06005CDD RID: 23773 RVA: 0x000E1ACE File Offset: 0x000DFCCE
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x000E1ADC File Offset: 0x000DFCDC
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x000E1B07 File Offset: 0x000DFD07
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

		// Token: 0x040037E3 RID: 14307
		[Nullable(2)]
		protected new IDungeonSubTypeCondition FbInstance;

		// Token: 0x040037E4 RID: 14308
		[Nullable(2)]
		protected new IDungeonSubTypeCondition_SetValue PocoInterface;
	}
}
