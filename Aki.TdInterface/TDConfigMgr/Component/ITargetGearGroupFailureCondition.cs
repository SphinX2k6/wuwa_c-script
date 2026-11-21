using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007EF RID: 2031
	public class ITargetGearGroupFailureCondition
	{
		// Token: 0x06002B89 RID: 11145 RVA: 0x000722B8 File Offset: 0x000704B8
		private ITargetGearGroupFailureCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetGearGroupFailureCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetGearGroupFailureCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetGearGroupFailureCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000722F0 File Offset: 0x000704F0
		public static ITargetGearGroupFailureCondition Create([Nullable(2)] ITargetGearGroupFailureCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupFailureCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00072303 File Offset: 0x00070503
		public static ITargetGearGroupFailureCondition CreateFromSetValue([Nullable(2)] ITargetGearGroupFailureCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetGearGroupFailureCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00072316 File Offset: 0x00070516
		public ITargetGearGroupFailureCondition_SetValue ToSetValue()
		{
			return new ITargetGearGroupFailureCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x00072329 File Offset: 0x00070529
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x00072354 File Offset: 0x00070554
		public virtual ETargetGearGroupFailureCondition Type
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

		// Token: 0x04001D36 RID: 7478
		[Nullable(2)]
		protected ITargetGearGroupFailureCondition FbInstance;

		// Token: 0x04001D37 RID: 7479
		[Nullable(2)]
		protected ITargetGearGroupFailureCondition_SetValue PocoInterface;
	}
}
