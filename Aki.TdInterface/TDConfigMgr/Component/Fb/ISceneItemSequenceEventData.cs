using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA5 RID: 3749
	public class ISceneItemSequenceEventData
	{
		// Token: 0x0600549B RID: 21659 RVA: 0x000D04F1 File Offset: 0x000CE6F1
		public static ISceneItemSequenceEventData Create(ISceneItemSequenceEventData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSequenceEventData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x000D0510 File Offset: 0x000CE710
		public virtual string SeqGuid
		{
			get
			{
				return this.Instance.SeqGuid;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x0600549D RID: 21661 RVA: 0x000D051D File Offset: 0x000CE71D
		public virtual string SeqPath
		{
			get
			{
				return this.Instance.SeqPath;
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x0600549E RID: 21662 RVA: 0x000D052A File Offset: 0x000CE72A
		public virtual List<ISceneItemSeqEventCbType> EventCallbacks
		{
			get
			{
				if (this._EventCallbacksInited)
				{
					return this._EventCallbacksCache;
				}
				this._EventCallbacksInited = true;
				this._EventCallbacksCache = ComponentReadHelper.ReadISceneItemSequenceEventData_EventCallbacks(this.Instance);
				return this._EventCallbacksCache;
			}
		}

		// Token: 0x0400305E RID: 12382
		private ISceneItemSequenceEventData Instance;

		// Token: 0x0400305F RID: 12383
		private List<ISceneItemSeqEventCbType> _EventCallbacksCache;

		// Token: 0x04003060 RID: 12384
		private bool _EventCallbacksInited;
	}
}
