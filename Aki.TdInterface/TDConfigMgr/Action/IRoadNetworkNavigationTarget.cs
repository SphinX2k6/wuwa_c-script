using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD7 RID: 8151
	public class IRoadNetworkNavigationTarget
	{
		// Token: 0x0600AD2B RID: 44331 RVA: 0x001870A0 File Offset: 0x001852A0
		private IRoadNetworkNavigationTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoadNetworkNavigationTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoadNetworkNavigationTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoadNetworkNavigationTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD2C RID: 44332 RVA: 0x001870D8 File Offset: 0x001852D8
		public static IRoadNetworkNavigationTarget Create([Nullable(2)] IRoadNetworkNavigationTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x001870EB File Offset: 0x001852EB
		public static IRoadNetworkNavigationTarget CreateFromSetValue([Nullable(2)] IRoadNetworkNavigationTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x001870FE File Offset: 0x001852FE
		public IRoadNetworkNavigationTarget_SetValue ToSetValue()
		{
			return new IRoadNetworkNavigationTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600AD2F RID: 44335 RVA: 0x00187111 File Offset: 0x00185311
		// (set) Token: 0x0600AD30 RID: 44336 RVA: 0x0018713C File Offset: 0x0018533C
		public virtual ERoadNetworkNavigationTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoadNetworkNavigationTarget.SceneItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006764 RID: 26468
		[Nullable(2)]
		protected IRoadNetworkNavigationTarget FbInstance;

		// Token: 0x04006765 RID: 26469
		[Nullable(2)]
		protected IRoadNetworkNavigationTarget_SetValue PocoInterface;
	}
}
