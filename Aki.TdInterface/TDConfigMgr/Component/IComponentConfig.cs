using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200029F RID: 671
	public class IComponentConfig
	{
		// Token: 0x06000C12 RID: 3090 RVA: 0x0002F7E4 File Offset: 0x0002D9E4
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

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002F81C File Offset: 0x0002DA1C
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

		// Token: 0x06000C14 RID: 3092 RVA: 0x0002F82F File Offset: 0x0002DA2F
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

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002F842 File Offset: 0x0002DA42
		public IComponentConfig_SetValue ToSetValue()
		{
			return new IComponentConfig_SetValue
			{
				BaseActions = this.BaseActions,
				ActionsByComponent = this.ActionsByComponent
			};
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0002F861 File Offset: 0x0002DA61
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0002F888 File Offset: 0x0002DA88
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0002F896 File Offset: 0x0002DA96
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0002F8C1 File Offset: 0x0002DAC1
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

		// Token: 0x04000B95 RID: 2965
		[Nullable(2)]
		protected IComponentConfig FbInstance;

		// Token: 0x04000B96 RID: 2966
		[Nullable(2)]
		protected IComponentConfig_SetValue PocoInterface;
	}
}
