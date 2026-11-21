using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A7 RID: 8615
	public class ITalkOptionConditionSolarSchool : ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600BBE6 RID: 48102 RVA: 0x001B3684 File Offset: 0x001B1884
		private ITalkOptionConditionSolarSchool_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionConditionSolarSchool 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionConditionSolarSchool_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionConditionSolarSchool_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x001B36BC File Offset: 0x001B18BC
		public static ITalkOptionConditionSolarSchool Create([Nullable(2)] ITalkOptionConditionSolarSchool instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionConditionSolarSchool
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBE8 RID: 48104 RVA: 0x001B36CF File Offset: 0x001B18CF
		public static ITalkOptionConditionSolarSchool CreateFromSetValue([Nullable(2)] ITalkOptionConditionSolarSchool_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionConditionSolarSchool
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x001B36E2 File Offset: 0x001B18E2
		public new ITalkOptionConditionSolarSchool_SetValue ToSetValue()
		{
			return new ITalkOptionConditionSolarSchool_SetValue
			{
				Type = this.Type,
				ConditionGroupId = this.ConditionGroupId
			};
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x001B3701 File Offset: 0x001B1901
		// (set) Token: 0x0600BBEB RID: 48107 RVA: 0x001B372C File Offset: 0x001B192C
		public override ETalkOptionConditionSystem Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionConditionSystem.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x001B373A File Offset: 0x001B193A
		// (set) Token: 0x0600BBED RID: 48109 RVA: 0x001B3765 File Offset: 0x001B1965
		public virtual int ConditionGroupId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConditionGroupId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConditionGroupId;
			}
			set
			{
				this.GetOrCreatePoco().ConditionGroupId = value;
			}
		}

		// Token: 0x0400710D RID: 28941
		[Nullable(2)]
		protected new ITalkOptionConditionSolarSchool FbInstance;

		// Token: 0x0400710E RID: 28942
		[Nullable(2)]
		protected new ITalkOptionConditionSolarSchool_SetValue PocoInterface;
	}
}
