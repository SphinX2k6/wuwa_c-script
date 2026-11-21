using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA2 RID: 3746
	public class ISceneItemSeqEventCbType
	{
		// Token: 0x0600548B RID: 21643 RVA: 0x000D0385 File Offset: 0x000CE585
		public static ISceneItemSeqEventCbType Create(ISceneItemSeqEventCbType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSeqEventCbType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x000D03A4 File Offset: 0x000CE5A4
		public virtual ESceneItemSeqEventCbType Type
		{
			get
			{
				return (ESceneItemSeqEventCbType)this.Instance.Type;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x000D03B1 File Offset: 0x000CE5B1
		public virtual string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x000D03BE File Offset: 0x000CE5BE
		public virtual ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				this._ActionCache = ActionInfo.Create(this.Instance.Action);
				return this._ActionCache;
			}
		}

		// Token: 0x04003055 RID: 12373
		private ISceneItemSeqEventCbType Instance;

		// Token: 0x04003056 RID: 12374
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x04003057 RID: 12375
		private bool _ActionInited;
	}
}
