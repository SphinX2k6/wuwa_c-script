using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7B RID: 3451
	public class IInteractBehaviourActions : ILevelAIBehaviourBase
	{
		// Token: 0x06004E6B RID: 20075 RVA: 0x000C377A File Offset: 0x000C197A
		public static IInteractBehaviourActions Create(IInteractBehaviourActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractBehaviourActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x000C3799 File Offset: 0x000C1999
		public override ELevelAIBehaviourType Type
		{
			get
			{
				return (ELevelAIBehaviourType)this.Instance.Type;
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x000C37A8 File Offset: 0x000C19A8
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

		// Token: 0x04002C96 RID: 11414
		private IInteractBehaviourActions Instance;

		// Token: 0x04002C97 RID: 11415
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002C98 RID: 11416
		private bool _ActionsInited;
	}
}
