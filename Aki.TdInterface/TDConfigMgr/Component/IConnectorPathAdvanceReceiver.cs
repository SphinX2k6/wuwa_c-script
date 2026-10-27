using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000277 RID: 631
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceReceiver
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x0002E348 File Offset: 0x0002C548
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

		// Token: 0x06000B92 RID: 2962 RVA: 0x0002E380 File Offset: 0x0002C580
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

		// Token: 0x06000B93 RID: 2963 RVA: 0x0002E393 File Offset: 0x0002C593
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

		// Token: 0x06000B94 RID: 2964 RVA: 0x0002E3A6 File Offset: 0x0002C5A6
		public IConnectorPathAdvanceReceiver_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceReceiver_SetValue
			{
				ConnectedState = this.ConnectedState,
				DisconnectedState = this.DisconnectedState
			};
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0002E3C5 File Offset: 0x0002C5C5
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0002E3FE File Offset: 0x0002C5FE
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0002E429 File Offset: 0x0002C629
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

		// Token: 0x04000B24 RID: 2852
		[Nullable(2)]
		protected IConnectorPathAdvanceReceiver FbInstance;

		// Token: 0x04000B25 RID: 2853
		[Nullable(2)]
		protected IConnectorPathAdvanceReceiver_SetValue PocoInterface;
	}
}
