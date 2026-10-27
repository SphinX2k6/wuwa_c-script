using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200254A RID: 9546
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemOption
	{
		// Token: 0x0600D514 RID: 54548 RVA: 0x001F95C1 File Offset: 0x001F77C1
		public static ISystemOption Create(ISystemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600D515 RID: 54549 RVA: 0x001F95E0 File Offset: 0x001F77E0
		public virtual int? OptionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OptionId);
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600D516 RID: 54550 RVA: 0x001F9618 File Offset: 0x001F7818
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

		// Token: 0x04007500 RID: 29952
		private ISystemOption Instance;

		// Token: 0x04007501 RID: 29953
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007502 RID: 29954
		private bool _ActionsInited;
	}
}
