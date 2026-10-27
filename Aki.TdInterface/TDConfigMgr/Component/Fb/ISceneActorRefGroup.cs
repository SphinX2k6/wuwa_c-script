using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C69 RID: 3177
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneActorRefGroup
	{
		// Token: 0x060048D6 RID: 18646 RVA: 0x000B6DED File Offset: 0x000B4FED
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

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x000B6E0C File Offset: 0x000B500C
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x000B6E1C File Offset: 0x000B501C
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

		// Token: 0x04002986 RID: 10630
		private ISceneActorRefGroup Instance;

		// Token: 0x04002987 RID: 10631
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002988 RID: 10632
		private bool _ActionsInited;
	}
}
