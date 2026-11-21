using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000705 RID: 1797
	public class IRefreshConditionBase
	{
		// Token: 0x0600261A RID: 9754 RVA: 0x00066EDC File Offset: 0x000650DC
		private IRefreshConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00066F14 File Offset: 0x00065114
		public static IRefreshConditionBase Create([Nullable(2)] IRefreshConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00066F27 File Offset: 0x00065127
		public static IRefreshConditionBase CreateFromSetValue([Nullable(2)] IRefreshConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00066F3A File Offset: 0x0006513A
		public IRefreshConditionBase_SetValue ToSetValue()
		{
			return new IRefreshConditionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x00066F4D File Offset: 0x0006514D
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x00066F78 File Offset: 0x00065178
		public virtual ERewardDropType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERewardDropType.Death;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A41 RID: 6721
		[Nullable(2)]
		protected IRefreshConditionBase FbInstance;

		// Token: 0x04001A42 RID: 6722
		[Nullable(2)]
		protected IRefreshConditionBase_SetValue PocoInterface;
	}
}
