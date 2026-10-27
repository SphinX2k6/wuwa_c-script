using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001142 RID: 4418
	[NullableContext(1)]
	[Nullable(0)]
	public class ISneakPlayCondition
	{
		// Token: 0x06006452 RID: 25682 RVA: 0x000F142C File Offset: 0x000EF62C
		private ISneakPlayCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISneakPlayCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISneakPlayCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISneakPlayCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x000F1464 File Offset: 0x000EF664
		public static ISneakPlayCondition Create([Nullable(2)] ISneakPlayCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISneakPlayCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x000F1477 File Offset: 0x000EF677
		public static ISneakPlayCondition CreateFromSetValue([Nullable(2)] ISneakPlayCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISneakPlayCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x000F148A File Offset: 0x000EF68A
		public ISneakPlayCondition_SetValue ToSetValue()
		{
			return new ISneakPlayCondition_SetValue
			{
				Time = this.Time
			};
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x000F149D File Offset: 0x000EF69D
		// (set) Token: 0x06006457 RID: 25687 RVA: 0x000F14C8 File Offset: 0x000EF6C8
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x04003C4A RID: 15434
		[Nullable(2)]
		protected ISneakPlayCondition FbInstance;

		// Token: 0x04003C4B RID: 15435
		[Nullable(2)]
		protected ISneakPlayCondition_SetValue PocoInterface;
	}
}
