using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200025C RID: 604
	[NullableContext(1)]
	[Nullable(0)]
	public class IComponentConfig
	{
		// Token: 0x06000AF8 RID: 2808 RVA: 0x0002CAF4 File Offset: 0x0002ACF4
		private IComponentConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IComponentConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IComponentConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IComponentConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0002CB2C File Offset: 0x0002AD2C
		public static IComponentConfig Create([Nullable(2)] IComponentConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002CB3F File Offset: 0x0002AD3F
		public static IComponentConfig CreateFromSetValue([Nullable(2)] IComponentConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IComponentConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002CB52 File Offset: 0x0002AD52
		public IComponentConfig_SetValue ToSetValue()
		{
			return new IComponentConfig_SetValue
			{
				BaseActions = this.BaseActions,
				ActionsByComponent = this.ActionsByComponent
			};
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0002CB71 File Offset: 0x0002AD71
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x0002CB98 File Offset: 0x0002AD98
		public virtual List<EAction> BaseActions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BaseActions;
				}
				IComponentConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BaseActions;
			}
			set
			{
				this.GetOrCreatePoco().BaseActions = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0002CBA6 File Offset: 0x0002ADA6
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x0002CBD1 File Offset: 0x0002ADD1
		public virtual string ActionsByComponent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionsByComponent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActionsByComponent;
			}
			set
			{
				this.GetOrCreatePoco().ActionsByComponent = value;
			}
		}

		// Token: 0x04000AB4 RID: 2740
		[Nullable(2)]
		protected IComponentConfig FbInstance;

		// Token: 0x04000AB5 RID: 2741
		[Nullable(2)]
		protected IComponentConfig_SetValue PocoInterface;
	}
}
