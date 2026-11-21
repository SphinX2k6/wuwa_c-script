using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289A RID: 10394
	public class IMp4FrameEvent
	{
		// Token: 0x0600E79D RID: 59293 RVA: 0x00224220 File Offset: 0x00222420
		public static IMp4FrameEvent Create(IMp4FrameEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4FrameEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x0022423F File Offset: 0x0022243F
		public virtual float Second
		{
			get
			{
				return this.Instance.Second;
			}
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x0600E79F RID: 59295 RVA: 0x0022424C File Offset: 0x0022244C
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

		// Token: 0x04007F8E RID: 32654
		private IMp4FrameEvent Instance;

		// Token: 0x04007F8F RID: 32655
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x04007F90 RID: 32656
		private bool _EventActionsInited;
	}
}
