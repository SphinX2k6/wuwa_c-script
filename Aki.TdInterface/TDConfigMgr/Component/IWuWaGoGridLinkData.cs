using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A2 RID: 2210
	public class IWuWaGoGridLinkData
	{
		// Token: 0x06002FA5 RID: 12197 RVA: 0x0007AAC4 File Offset: 0x00078CC4
		private IWuWaGoGridLinkData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoGridLinkData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoGridLinkData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoGridLinkData_SetValue());
			}
			return result;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x0007AAFC File Offset: 0x00078CFC
		public static IWuWaGoGridLinkData Create([Nullable(2)] IWuWaGoGridLinkData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGridLinkData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0007AB0F File Offset: 0x00078D0F
		public static IWuWaGoGridLinkData CreateFromSetValue([Nullable(2)] IWuWaGoGridLinkData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoGridLinkData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0007AB22 File Offset: 0x00078D22
		public IWuWaGoGridLinkData_SetValue ToSetValue()
		{
			return new IWuWaGoGridLinkData_SetValue
			{
				GridLinkType = this.GridLinkType,
				RotationType = this.RotationType
			};
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x0007AB41 File Offset: 0x00078D41
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x0007AB6C File Offset: 0x00078D6C
		public virtual EWuWaGoGridLinkType GridLinkType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GridLinkType;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoGridLinkType.EmptyGrid;
				}
				return this.PocoInterface.GridLinkType;
			}
			set
			{
				this.GetOrCreatePoco().GridLinkType = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x0007AB7A File Offset: 0x00078D7A
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0007ABA5 File Offset: 0x00078DA5
		public virtual EWuWaGoGridRotationType RotationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationType;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoGridRotationType.Front;
				}
				return this.PocoInterface.RotationType;
			}
			set
			{
				this.GetOrCreatePoco().RotationType = value;
			}
		}

		// Token: 0x04001F7F RID: 8063
		[Nullable(2)]
		protected IWuWaGoGridLinkData FbInstance;

		// Token: 0x04001F80 RID: 8064
		[Nullable(2)]
		protected IWuWaGoGridLinkData_SetValue PocoInterface;
	}
}
