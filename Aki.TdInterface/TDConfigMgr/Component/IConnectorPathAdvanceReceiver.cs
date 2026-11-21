using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BA RID: 698
	public class IConnectorPathAdvanceReceiver
	{
		// Token: 0x06000CAB RID: 3243 RVA: 0x00031038 File Offset: 0x0002F238
		private IConnectorPathAdvanceReceiver_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPathAdvanceReceiver 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPathAdvanceReceiver_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPathAdvanceReceiver_SetValue());
			}
			return result;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00031070 File Offset: 0x0002F270
		public static IConnectorPathAdvanceReceiver Create([Nullable(2)] IConnectorPathAdvanceReceiver instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceReceiver
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00031083 File Offset: 0x0002F283
		public static IConnectorPathAdvanceReceiver CreateFromSetValue([Nullable(2)] IConnectorPathAdvanceReceiver_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceReceiver
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00031096 File Offset: 0x0002F296
		public IConnectorPathAdvanceReceiver_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceReceiver_SetValue
			{
				ConnectedState = this.ConnectedState,
				DisconnectedState = this.DisconnectedState
			};
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000310B5 File Offset: 0x0002F2B5
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000310E0 File Offset: 0x0002F2E0
		public virtual string ConnectedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConnectedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ConnectedState;
			}
			set
			{
				this.GetOrCreatePoco().ConnectedState = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000310EE File Offset: 0x0002F2EE
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00031119 File Offset: 0x0002F319
		public virtual string DisconnectedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisconnectedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DisconnectedState;
			}
			set
			{
				this.GetOrCreatePoco().DisconnectedState = value;
			}
		}

		// Token: 0x04000C05 RID: 3077
		[Nullable(2)]
		protected IConnectorPathAdvanceReceiver FbInstance;

		// Token: 0x04000C06 RID: 3078
		[Nullable(2)]
		protected IConnectorPathAdvanceReceiver_SetValue PocoInterface;
	}
}
