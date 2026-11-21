using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002894 RID: 10388
	public class ISequenceFrameEvent
	{
		// Token: 0x0600E780 RID: 59264 RVA: 0x00223E36 File Offset: 0x00222036
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

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x0600E781 RID: 59265 RVA: 0x00223E55 File Offset: 0x00222055
		public virtual string EventKey
		{
			get
			{
				return this.Instance.EventKey;
			}
		}

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x0600E782 RID: 59266 RVA: 0x00223E64 File Offset: 0x00222064
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

		// Token: 0x04007F80 RID: 32640
		private ISequenceFrameEvent Instance;

		// Token: 0x04007F81 RID: 32641
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x04007F82 RID: 32642
		private bool _EventActionsInited;
	}
}
