using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8C RID: 3468
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupDestroyListenConfig
	{
		// Token: 0x06004EDB RID: 20187 RVA: 0x000C37FE File Offset: 0x000C19FE
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

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06004EDC RID: 20188 RVA: 0x000C381D File Offset: 0x000C1A1D
		public virtual ETemplateEntityGroupType GroupType
		{
			get
			{
				return (ETemplateEntityGroupType)this.Instance.GroupType;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x000C382C File Offset: 0x000C1A2C
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

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06004EDE RID: 20190 RVA: 0x000C3895 File Offset: 0x000C1A95
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

		// Token: 0x04002D47 RID: 11591
		private IGroupDestroyListenConfig Instance;

		// Token: 0x04002D48 RID: 11592
		private List<ActionInfo> _OnTriggerActionsCache;

		// Token: 0x04002D49 RID: 11593
		private bool _OnTriggerActionsInited;

		// Token: 0x04002D4A RID: 11594
		[Nullable(2)]
		private IChangeTemplateInstanceStateConfig _ChangeInstanceStateConfigCache;

		// Token: 0x04002D4B RID: 11595
		private bool _ChangeInstanceStateConfigInited;
	}
}
