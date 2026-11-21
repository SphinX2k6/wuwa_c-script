using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070D RID: 1805
	public class IRefreshOnHostInteract : IRefreshConditionBase
	{
		// Token: 0x06002644 RID: 9796 RVA: 0x0006737C File Offset: 0x0006557C
		private IRefreshOnHostInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshOnHostInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshOnHostInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshOnHostInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000673B4 File Offset: 0x000655B4
		public static IRefreshOnHostInteract Create([Nullable(2)] IRefreshOnHostInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnHostInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000673C7 File Offset: 0x000655C7
		public static IRefreshOnHostInteract CreateFromSetValue([Nullable(2)] IRefreshOnHostInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshOnHostInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000673DA File Offset: 0x000655DA
		public new IRefreshOnHostInteract_SetValue ToSetValue()
		{
			return new IRefreshOnHostInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x000673ED File Offset: 0x000655ED
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x00067418 File Offset: 0x00065618
		public override ERewardDropType Type
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

		// Token: 0x04001A54 RID: 6740
		[Nullable(2)]
		protected new IRefreshOnHostInteract FbInstance;

		// Token: 0x04001A55 RID: 6741
		[Nullable(2)]
		protected new IRefreshOnHostInteract_SetValue PocoInterface;
	}
}
