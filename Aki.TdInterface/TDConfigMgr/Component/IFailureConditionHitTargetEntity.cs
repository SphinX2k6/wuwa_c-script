using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B5 RID: 949
	public class IFailureConditionHitTargetEntity : ITargetGearGroupFailureCondition
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x0003E0F4 File Offset: 0x0003C2F4
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

		// Token: 0x060012AA RID: 4778 RVA: 0x0003E12C File Offset: 0x0003C32C
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

		// Token: 0x060012AB RID: 4779 RVA: 0x0003E13F File Offset: 0x0003C33F
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

		// Token: 0x060012AC RID: 4780 RVA: 0x0003E152 File Offset: 0x0003C352
		public new IFailureConditionHitTargetEntity_SetValue ToSetValue()
		{
			return new IFailureConditionHitTargetEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0003E171 File Offset: 0x0003C371
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0003E19C File Offset: 0x0003C39C
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0003E1AA File Offset: 0x0003C3AA
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0003E1D1 File Offset: 0x0003C3D1
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

		// Token: 0x04000F48 RID: 3912
		[Nullable(2)]
		protected new IFailureConditionHitTargetEntity FbInstance;

		// Token: 0x04000F49 RID: 3913
		[Nullable(2)]
		protected new IFailureConditionHitTargetEntity_SetValue PocoInterface;
	}
}
