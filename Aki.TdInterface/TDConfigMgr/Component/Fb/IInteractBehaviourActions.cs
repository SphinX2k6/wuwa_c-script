using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C99 RID: 3225
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractBehaviourActions : ILevelAIBehaviourBase
	{
		// Token: 0x060049BD RID: 18877 RVA: 0x000B8D6A File Offset: 0x000B6F6A
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

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x000B8D89 File Offset: 0x000B6F89
		public override ELevelAIBehaviourType Type
		{
			get
			{
				return (ELevelAIBehaviourType)this.Instance.Type;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x000B8D98 File Offset: 0x000B6F98
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

		// Token: 0x04002A1C RID: 10780
		private IInteractBehaviourActions Instance;

		// Token: 0x04002A1D RID: 10781
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002A1E RID: 10782
		private bool _ActionsInited;
	}
}
