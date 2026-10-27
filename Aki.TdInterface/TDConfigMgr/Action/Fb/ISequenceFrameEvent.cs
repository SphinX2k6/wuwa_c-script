using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D5 RID: 9685
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceFrameEvent
	{
		// Token: 0x0600D9B8 RID: 55736 RVA: 0x00207782 File Offset: 0x00205982
		public static ISequenceFrameEvent Create(ISequenceFrameEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceFrameEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x0600D9B9 RID: 55737 RVA: 0x002077A1 File Offset: 0x002059A1
		public virtual string EventKey
		{
			get
			{
				return this.Instance.EventKey;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x002077B0 File Offset: 0x002059B0
		public virtual List<ActionInfo> EventActions
		{
			get
			{
				if (this._EventActionsInited)
				{
					return this._EventActionsCache;
				}
				this._EventActionsInited = true;
				int eventActionsLength = this.Instance.EventActionsLength;
				this._EventActionsCache = new List<ActionInfo>(eventActionsLength);
				for (int i = 0; i < eventActionsLength; i++)
				{
					this._EventActionsCache.Add(ActionInfo.Create(this.Instance.EventActions(i)));
				}
				return this._EventActionsCache;
			}
		}

		// Token: 0x040078E9 RID: 30953
		private ISequenceFrameEvent Instance;

		// Token: 0x040078EA RID: 30954
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x040078EB RID: 30955
		private bool _EventActionsInited;
	}
}
