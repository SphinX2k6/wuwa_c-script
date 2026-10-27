using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FC RID: 1020
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupDestroyListenConfig
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x00041938 File Offset: 0x0003FB38
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

		// Token: 0x06001494 RID: 5268 RVA: 0x00041970 File Offset: 0x0003FB70
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

		// Token: 0x06001495 RID: 5269 RVA: 0x00041983 File Offset: 0x0003FB83
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

		// Token: 0x06001496 RID: 5270 RVA: 0x00041996 File Offset: 0x0003FB96
		public IGroupDestroyListenConfig_SetValue ToSetValue()
		{
			return new IGroupDestroyListenConfig_SetValue
			{
				GroupType = this.GroupType,
				OnTriggerActions = this.OnTriggerActions,
				ChangeInstanceStateConfig = this.ChangeInstanceStateConfig
			};
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x000419C1 File Offset: 0x0003FBC1
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x000419EC File Offset: 0x0003FBEC
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000419FC File Offset: 0x0003FBFC
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00041A8F File Offset: 0x0003FC8F
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00041AA4 File Offset: 0x0003FCA4
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x00041B05 File Offset: 0x0003FD05
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

		// Token: 0x04001024 RID: 4132
		[Nullable(2)]
		protected IGroupDestroyListenConfig FbInstance;

		// Token: 0x04001025 RID: 4133
		[Nullable(2)]
		protected IGroupDestroyListenConfig_SetValue PocoInterface;

		// Token: 0x04001026 RID: 4134
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnTriggerActionsCache;

		// Token: 0x04001027 RID: 4135
		private bool _OnTriggerActionsInited;

		// Token: 0x04001028 RID: 4136
		private IChangeTemplateInstanceStateConfig _ChangeInstanceStateConfigCache;

		// Token: 0x04001029 RID: 4137
		private bool _ChangeInstanceStateConfigInited;
	}
}
