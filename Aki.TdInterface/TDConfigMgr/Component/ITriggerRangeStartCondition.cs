using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AA RID: 1962
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerRangeStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x06002A8E RID: 10894 RVA: 0x0006F954 File Offset: 0x0006DB54
		private ITriggerRangeStartCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerRangeStartCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerRangeStartCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerRangeStartCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0006F98C File Offset: 0x0006DB8C
		public static ITriggerRangeStartCondition Create([Nullable(2)] ITriggerRangeStartCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerRangeStartCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0006F99F File Offset: 0x0006DB9F
		public static ITriggerRangeStartCondition CreateFromSetValue([Nullable(2)] ITriggerRangeStartCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerRangeStartCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0006F9B2 File Offset: 0x0006DBB2
		public new ITriggerRangeStartCondition_SetValue ToSetValue()
		{
			return new ITriggerRangeStartCondition_SetValue
			{
				Type = this.Type,
				Range = this.Range
			};
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x0006F9D1 File Offset: 0x0006DBD1
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x0006F9FC File Offset: 0x0006DBFC
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x0006FA0A File Offset: 0x0006DC0A
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x0006FA35 File Offset: 0x0006DC35
		public virtual int Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x04001C66 RID: 7270
		[Nullable(2)]
		protected new ITriggerRangeStartCondition FbInstance;

		// Token: 0x04001C67 RID: 7271
		[Nullable(2)]
		protected new ITriggerRangeStartCondition_SetValue PocoInterface;
	}
}
