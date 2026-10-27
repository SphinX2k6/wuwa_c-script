using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F6C RID: 8044
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionConditionSolarSchool : ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600B10C RID: 45324 RVA: 0x0019D730 File Offset: 0x0019B930
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

		// Token: 0x0600B10D RID: 45325 RVA: 0x0019D768 File Offset: 0x0019B968
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

		// Token: 0x0600B10E RID: 45326 RVA: 0x0019D77B File Offset: 0x0019B97B
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

		// Token: 0x0600B10F RID: 45327 RVA: 0x0019D78E File Offset: 0x0019B98E
		public new ITalkOptionConditionSolarSchool_SetValue ToSetValue()
		{
			return new ITalkOptionConditionSolarSchool_SetValue
			{
				Type = this.Type,
				ConditionGroupId = this.ConditionGroupId
			};
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600B110 RID: 45328 RVA: 0x0019D7AD File Offset: 0x0019B9AD
		// (set) Token: 0x0600B111 RID: 45329 RVA: 0x0019D7D8 File Offset: 0x0019B9D8
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

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600B112 RID: 45330 RVA: 0x0019D7E6 File Offset: 0x0019B9E6
		// (set) Token: 0x0600B113 RID: 45331 RVA: 0x0019D811 File Offset: 0x0019BA11
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

		// Token: 0x04006B25 RID: 27429
		[Nullable(2)]
		protected new ITalkOptionConditionSolarSchool FbInstance;

		// Token: 0x04006B26 RID: 27430
		[Nullable(2)]
		protected new ITalkOptionConditionSolarSchool_SetValue PocoInterface;
	}
}
