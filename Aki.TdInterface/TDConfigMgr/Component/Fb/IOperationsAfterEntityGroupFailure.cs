using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AED RID: 2797
	public class IOperationsAfterEntityGroupFailure
	{
		// Token: 0x06004062 RID: 16482 RVA: 0x000A455F File Offset: 0x000A275F
		[NullableContext(1)]
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

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x000A4580 File Offset: 0x000A2780
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

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x000A45B8 File Offset: 0x000A27B8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x040023DC RID: 9180
		private IOperationsAfterEntityGroupFailure Instance;

		// Token: 0x040023DD RID: 9181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040023DE RID: 9182
		private bool _ActionsInited;
	}
}
