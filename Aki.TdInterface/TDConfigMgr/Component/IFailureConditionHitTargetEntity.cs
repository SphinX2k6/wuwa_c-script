using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036C RID: 876
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureConditionHitTargetEntity : ITargetGearGroupFailureCondition
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x0003AE10 File Offset: 0x00039010
		private IFailureConditionHitTargetEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFailureConditionHitTargetEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFailureConditionHitTargetEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFailureConditionHitTargetEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0003AE48 File Offset: 0x00039048
		public static IFailureConditionHitTargetEntity Create([Nullable(2)] IFailureConditionHitTargetEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureConditionHitTargetEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0003AE5B File Offset: 0x0003905B
		public static IFailureConditionHitTargetEntity CreateFromSetValue([Nullable(2)] IFailureConditionHitTargetEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFailureConditionHitTargetEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0003AE6E File Offset: 0x0003906E
		public new IFailureConditionHitTargetEntity_SetValue ToSetValue()
		{
			return new IFailureConditionHitTargetEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0003AE8D File Offset: 0x0003908D
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0003AEB8 File Offset: 0x000390B8
		public override ETargetGearGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0003AEC6 File Offset: 0x000390C6
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0003AEED File Offset: 0x000390ED
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IFailureConditionHitTargetEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04000E51 RID: 3665
		[Nullable(2)]
		protected new IFailureConditionHitTargetEntity FbInstance;

		// Token: 0x04000E52 RID: 3666
		[Nullable(2)]
		protected new IFailureConditionHitTargetEntity_SetValue PocoInterface;
	}
}
