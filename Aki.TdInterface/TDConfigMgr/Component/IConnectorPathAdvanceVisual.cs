using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BE RID: 702
	public class IConnectorPathAdvanceVisual
	{
		// Token: 0x06000CC7 RID: 3271 RVA: 0x00031394 File Offset: 0x0002F594
		private IConnectorPathAdvanceVisual_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPathAdvanceVisual 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPathAdvanceVisual_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPathAdvanceVisual_SetValue());
			}
			return result;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000313CC File Offset: 0x0002F5CC
		public static IConnectorPathAdvanceVisual Create([Nullable(2)] IConnectorPathAdvanceVisual instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVisual
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000313DF File Offset: 0x0002F5DF
		public static IConnectorPathAdvanceVisual CreateFromSetValue([Nullable(2)] IConnectorPathAdvanceVisual_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVisual
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000313F2 File Offset: 0x0002F5F2
		public IConnectorPathAdvanceVisual_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceVisual_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00031405 File Offset: 0x0002F605
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00031430 File Offset: 0x0002F630
		public virtual EConnectorPathAdvanceVisualType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C11 RID: 3089
		[Nullable(2)]
		protected IConnectorPathAdvanceVisual FbInstance;

		// Token: 0x04000C12 RID: 3090
		[Nullable(2)]
		protected IConnectorPathAdvanceVisual_SetValue PocoInterface;
	}
}
