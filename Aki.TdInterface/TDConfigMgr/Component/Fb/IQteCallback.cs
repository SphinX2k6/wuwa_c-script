using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7D RID: 3453
	[NullableContext(1)]
	[Nullable(0)]
	public class IQteCallback
	{
		// Token: 0x06004E90 RID: 20112 RVA: 0x000C2E36 File Offset: 0x000C1036
		public static IQteCallback Create(IQteCallback? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteCallback
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x000C2E58 File Offset: 0x000C1058
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

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06004E92 RID: 20114 RVA: 0x000C2EC1 File Offset: 0x000C10C1
		[Nullable(2)]
		public virtual string SendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SendSelfEvent;
			}
		}

		// Token: 0x04002D18 RID: 11544
		private IQteCallback Instance;

		// Token: 0x04002D19 RID: 11545
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002D1A RID: 11546
		private bool _ActionsInited;
	}
}
