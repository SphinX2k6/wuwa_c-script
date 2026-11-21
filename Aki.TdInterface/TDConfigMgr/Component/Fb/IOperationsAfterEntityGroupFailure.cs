using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB8 RID: 3000
	public class IOperationsAfterEntityGroupFailure
	{
		// Token: 0x06004491 RID: 17553 RVA: 0x000ADB93 File Offset: 0x000ABD93
		public static IOperationsAfterEntityGroupFailure Create(IOperationsAfterEntityGroupFailure? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperationsAfterEntityGroupFailure
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x000ADBB4 File Offset: 0x000ABDB4
		public virtual bool? IsResetState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsResetState);
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x000ADBEC File Offset: 0x000ABDEC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x040025F9 RID: 9721
		private IOperationsAfterEntityGroupFailure Instance;

		// Token: 0x040025FA RID: 9722
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040025FB RID: 9723
		private bool _ActionsInited;
	}
}
