using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E88 RID: 3720
	public class IGroupDestroyListenConfig
	{
		// Token: 0x06005400 RID: 21504 RVA: 0x000CF04E File Offset: 0x000CD24E
		public static IGroupDestroyListenConfig Create(IGroupDestroyListenConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupDestroyListenConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06005401 RID: 21505 RVA: 0x000CF06D File Offset: 0x000CD26D
		public virtual ETemplateEntityGroupType GroupType
		{
			get
			{
				return (ETemplateEntityGroupType)this.Instance.GroupType;
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x000CF07C File Offset: 0x000CD27C
		public virtual List<ActionInfo> OnTriggerActions
		{
			get
			{
				if (this._OnTriggerActionsInited)
				{
					return this._OnTriggerActionsCache;
				}
				this._OnTriggerActionsInited = true;
				int onTriggerActionsLength = this.Instance.OnTriggerActionsLength;
				this._OnTriggerActionsCache = new List<ActionInfo>(onTriggerActionsLength);
				for (int i = 0; i < onTriggerActionsLength; i++)
				{
					this._OnTriggerActionsCache.Add(ActionInfo.Create(this.Instance.OnTriggerActions(i)));
				}
				return this._OnTriggerActionsCache;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06005403 RID: 21507 RVA: 0x000CF0E5 File Offset: 0x000CD2E5
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
				this._ChangeInstanceStateConfigCache = IChangeTemplateInstanceStateConfig.Create(this.Instance.ChangeInstanceStateConfig);
				return this._ChangeInstanceStateConfigCache;
			}
		}

		// Token: 0x0400300D RID: 12301
		private IGroupDestroyListenConfig Instance;

		// Token: 0x0400300E RID: 12302
		private List<ActionInfo> _OnTriggerActionsCache;

		// Token: 0x0400300F RID: 12303
		private bool _OnTriggerActionsInited;

		// Token: 0x04003010 RID: 12304
		[Nullable(2)]
		private IChangeTemplateInstanceStateConfig _ChangeInstanceStateConfigCache;

		// Token: 0x04003011 RID: 12305
		private bool _ChangeInstanceStateConfigInited;
	}
}
