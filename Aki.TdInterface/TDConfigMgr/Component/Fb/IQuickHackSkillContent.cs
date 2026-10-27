using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEF RID: 3567
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuickHackSkillContent
	{
		// Token: 0x060050D1 RID: 20689 RVA: 0x000C78D7 File Offset: 0x000C5AD7
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

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x000C78F6 File Offset: 0x000C5AF6
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x000C7904 File Offset: 0x000C5B04
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

		// Token: 0x04002E72 RID: 11890
		private IQuickHackSkillContent Instance;

		// Token: 0x04002E73 RID: 11891
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002E74 RID: 11892
		private bool _ActionsInited;
	}
}
