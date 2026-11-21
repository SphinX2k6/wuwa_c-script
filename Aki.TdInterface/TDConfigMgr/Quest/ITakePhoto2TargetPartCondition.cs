using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B8 RID: 4792
	public class ITakePhoto2TargetPartCondition
	{
		// Token: 0x06006BF5 RID: 27637 RVA: 0x001019A0 File Offset: 0x000FFBA0
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

		// Token: 0x06006BF6 RID: 27638 RVA: 0x001019D8 File Offset: 0x000FFBD8
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

		// Token: 0x06006BF7 RID: 27639 RVA: 0x001019EB File Offset: 0x000FFBEB
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

		// Token: 0x06006BF8 RID: 27640 RVA: 0x001019FE File Offset: 0x000FFBFE
		public ITakePhoto2TargetPartCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetPartCondition_SetValue
			{
				Tags = this.Tags
			};
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x00101A11 File Offset: 0x000FFC11
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x00101A38 File Offset: 0x000FFC38
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

		// Token: 0x0400407C RID: 16508
		[Nullable(2)]
		protected ITakePhoto2TargetPartCondition FbInstance;

		// Token: 0x0400407D RID: 16509
		[Nullable(2)]
		protected ITakePhoto2TargetPartCondition_SetValue PocoInterface;
	}
}
