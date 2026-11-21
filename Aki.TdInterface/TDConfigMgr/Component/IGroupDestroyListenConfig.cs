using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000455 RID: 1109
	public class IGroupDestroyListenConfig
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x00045680 File Offset: 0x00043880
		private IGroupDestroyListenConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupDestroyListenConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupDestroyListenConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupDestroyListenConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000456B8 File Offset: 0x000438B8
		public static IGroupDestroyListenConfig Create([Nullable(2)] IGroupDestroyListenConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupDestroyListenConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000456CB File Offset: 0x000438CB
		public static IGroupDestroyListenConfig CreateFromSetValue([Nullable(2)] IGroupDestroyListenConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupDestroyListenConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000456DE File Offset: 0x000438DE
		public IGroupDestroyListenConfig_SetValue ToSetValue()
		{
			return new IGroupDestroyListenConfig_SetValue
			{
				GroupType = this.GroupType,
				OnTriggerActions = this.OnTriggerActions,
				ChangeInstanceStateConfig = this.ChangeInstanceStateConfig
			};
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00045709 File Offset: 0x00043909
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00045734 File Offset: 0x00043934
		public virtual ETemplateEntityGroupType GroupType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupType;
				}
				if (this.PocoInterface == null)
				{
					return (ETemplateEntityGroupType)0;
				}
				return this.PocoInterface.GroupType;
			}
			set
			{
				this.GetOrCreatePoco().GroupType = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00045744 File Offset: 0x00043944
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x000457D7 File Offset: 0x000439D7
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OnTriggerActions
		{
			get
			{
				if (this._OnTriggerActionsInited)
				{
					return this._OnTriggerActionsCache;
				}
				this._OnTriggerActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> onTriggerActions = this.FbInstance.OnTriggerActions;
					if (onTriggerActions != null)
					{
						this._OnTriggerActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(onTriggerActions.Count);
						for (int i = 0; i < onTriggerActions.Count; i++)
						{
							this._OnTriggerActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(onTriggerActions[i]));
						}
					}
				}
				else
				{
					IGroupDestroyListenConfig_SetValue pocoInterface = this.PocoInterface;
					this._OnTriggerActionsCache = ((pocoInterface != null) ? pocoInterface.OnTriggerActions : null);
				}
				return this._OnTriggerActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().OnTriggerActions = value;
				this._OnTriggerActionsInited = false;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x000457EC File Offset: 0x000439EC
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x0004584D File Offset: 0x00043A4D
		[Nullable(2)]
		public virtual IChangeTemplateInstanceStateConfig ChangeInstanceStateConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._ChangeInstanceStateConfigInited)
				{
					return this._ChangeInstanceStateConfigCache;
				}
				this._ChangeInstanceStateConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ChangeInstanceStateConfigCache = IChangeTemplateInstanceStateConfig.Create(this.FbInstance.ChangeInstanceStateConfig);
				}
				else
				{
					IGroupDestroyListenConfig_SetValue pocoInterface = this.PocoInterface;
					this._ChangeInstanceStateConfigCache = ((pocoInterface != null) ? pocoInterface.ChangeInstanceStateConfig : null);
				}
				return this._ChangeInstanceStateConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ChangeInstanceStateConfig = value;
				this._ChangeInstanceStateConfigInited = false;
			}
		}

		// Token: 0x04001146 RID: 4422
		[Nullable(2)]
		protected IGroupDestroyListenConfig FbInstance;

		// Token: 0x04001147 RID: 4423
		[Nullable(2)]
		protected IGroupDestroyListenConfig_SetValue PocoInterface;

		// Token: 0x04001148 RID: 4424
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnTriggerActionsCache;

		// Token: 0x04001149 RID: 4425
		private bool _OnTriggerActionsInited;

		// Token: 0x0400114A RID: 4426
		private IChangeTemplateInstanceStateConfig _ChangeInstanceStateConfigCache;

		// Token: 0x0400114B RID: 4427
		private bool _ChangeInstanceStateConfigInited;
	}
}
