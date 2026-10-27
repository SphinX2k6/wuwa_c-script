using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025DB RID: 9691
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4FrameEvent
	{
		// Token: 0x0600D9D5 RID: 55765 RVA: 0x00207B6C File Offset: 0x00205D6C
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

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x0600D9D6 RID: 55766 RVA: 0x00207B8B File Offset: 0x00205D8B
		public virtual float Second
		{
			get
			{
				return this.Instance.Second;
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x0600D9D7 RID: 55767 RVA: 0x00207B98 File Offset: 0x00205D98
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

		// Token: 0x040078F7 RID: 30967
		private IMp4FrameEvent Instance;

		// Token: 0x040078F8 RID: 30968
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x040078F9 RID: 30969
		private bool _EventActionsInited;
	}
}
