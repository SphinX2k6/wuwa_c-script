using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001072 RID: 4210
	public class IDungeonCondition
	{
		// Token: 0x06005CBA RID: 23738 RVA: 0x000E169C File Offset: 0x000DF89C
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

		// Token: 0x06005CBB RID: 23739 RVA: 0x000E16D4 File Offset: 0x000DF8D4
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

		// Token: 0x06005CBC RID: 23740 RVA: 0x000E16E7 File Offset: 0x000DF8E7
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

		// Token: 0x06005CBD RID: 23741 RVA: 0x000E16FA File Offset: 0x000DF8FA
		public IDungeonCondition_SetValue ToSetValue()
		{
			return new IDungeonCondition_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				IsExitDungeon = this.IsExitDungeon
			};
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x000E1725 File Offset: 0x000DF925
		// (set) Token: 0x06005CBF RID: 23743 RVA: 0x000E1750 File Offset: 0x000DF950
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

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x000E175E File Offset: 0x000DF95E
		// (set) Token: 0x06005CC1 RID: 23745 RVA: 0x000E1789 File Offset: 0x000DF989
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

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06005CC2 RID: 23746 RVA: 0x000E1798 File Offset: 0x000DF998
		// (set) Token: 0x06005CC3 RID: 23747 RVA: 0x000E17D2 File Offset: 0x000DF9D2
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

		// Token: 0x040037D8 RID: 14296
		[Nullable(2)]
		protected IDungeonCondition FbInstance;

		// Token: 0x040037D9 RID: 14297
		[Nullable(2)]
		protected IDungeonCondition_SetValue PocoInterface;
	}
}
