using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D48 RID: 3400
	public class ISceneActorRefGroup
	{
		// Token: 0x06004D75 RID: 19829 RVA: 0x000C15F1 File Offset: 0x000BF7F1
		public static ISceneActorRefGroup Create(ISceneActorRefGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorRefGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x000C1610 File Offset: 0x000BF810
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06004D77 RID: 19831 RVA: 0x000C1620 File Offset: 0x000BF820
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

		// Token: 0x04002BF3 RID: 11251
		private ISceneActorRefGroup Instance;

		// Token: 0x04002BF4 RID: 11252
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002BF5 RID: 11253
		private bool _ActionsInited;
	}
}
