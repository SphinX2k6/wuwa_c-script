using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC0 RID: 7616
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoadNetworkNavigationTarget
	{
		// Token: 0x0600A321 RID: 41761 RVA: 0x00172978 File Offset: 0x00170B78
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

		// Token: 0x0600A322 RID: 41762 RVA: 0x001729B0 File Offset: 0x00170BB0
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

		// Token: 0x0600A323 RID: 41763 RVA: 0x001729C3 File Offset: 0x00170BC3
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

		// Token: 0x0600A324 RID: 41764 RVA: 0x001729D6 File Offset: 0x00170BD6
		public IRoadNetworkNavigationTarget_SetValue ToSetValue()
		{
			return new IRoadNetworkNavigationTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A325 RID: 41765 RVA: 0x001729E9 File Offset: 0x00170BE9
		// (set) Token: 0x0600A326 RID: 41766 RVA: 0x00172A14 File Offset: 0x00170C14
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

		// Token: 0x040061DC RID: 25052
		[Nullable(2)]
		protected IRoadNetworkNavigationTarget FbInstance;

		// Token: 0x040061DD RID: 25053
		[Nullable(2)]
		protected IRoadNetworkNavigationTarget_SetValue PocoInterface;
	}
}
