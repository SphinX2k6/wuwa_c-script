using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EEB RID: 3819
	public class IQuickHackSkillContent
	{
		// Token: 0x060055F8 RID: 22008 RVA: 0x000D319F File Offset: 0x000D139F
		public static IQuickHackSkillContent Create(IQuickHackSkillContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuickHackSkillContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x060055F9 RID: 22009 RVA: 0x000D31BE File Offset: 0x000D13BE
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x060055FA RID: 22010 RVA: 0x000D31CC File Offset: 0x000D13CC
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x0400313A RID: 12602
		private IQuickHackSkillContent Instance;

		// Token: 0x0400313B RID: 12603
		private List<ActionInfo> _ActionsCache;

		// Token: 0x0400313C RID: 12604
		private bool _ActionsInited;
	}
}
