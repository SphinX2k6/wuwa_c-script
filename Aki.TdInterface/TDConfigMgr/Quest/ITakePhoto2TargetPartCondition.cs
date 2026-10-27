using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117E RID: 4478
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetPartCondition
	{
		// Token: 0x060065BE RID: 26046 RVA: 0x000F41D4 File Offset: 0x000F23D4
		private ITakePhoto2TargetPartCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2TargetPartCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2TargetPartCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2TargetPartCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x000F420C File Offset: 0x000F240C
		public static ITakePhoto2TargetPartCondition Create([Nullable(2)] ITakePhoto2TargetPartCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPartCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x000F421F File Offset: 0x000F241F
		public static ITakePhoto2TargetPartCondition CreateFromSetValue([Nullable(2)] ITakePhoto2TargetPartCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPartCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x000F4232 File Offset: 0x000F2432
		public ITakePhoto2TargetPartCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetPartCondition_SetValue
			{
				Tags = this.Tags
			};
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x060065C2 RID: 26050 RVA: 0x000F4245 File Offset: 0x000F2445
		// (set) Token: 0x060065C3 RID: 26051 RVA: 0x000F426C File Offset: 0x000F246C
		public virtual List<string> Tags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tags;
				}
				ITakePhoto2TargetPartCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Tags;
			}
			set
			{
				this.GetOrCreatePoco().Tags = value;
			}
		}

		// Token: 0x04003D14 RID: 15636
		[Nullable(2)]
		protected ITakePhoto2TargetPartCondition FbInstance;

		// Token: 0x04003D15 RID: 15637
		[Nullable(2)]
		protected ITakePhoto2TargetPartCondition_SetValue PocoInterface;
	}
}
