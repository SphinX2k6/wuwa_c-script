using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA3 RID: 3747
	public class IAnsEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06005490 RID: 21648 RVA: 0x000D03FA File Offset: 0x000CE5FA
		public static IAnsEvent Create(IAnsEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnsEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x000D0419 File Offset: 0x000CE619
		public override ESceneItemSeqEventCbType Type
		{
			get
			{
				return (ESceneItemSeqEventCbType)this.Instance.Type;
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x000D0426 File Offset: 0x000CE626
		public override string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x000D0433 File Offset: 0x000CE633
		public override ActionInfo Action
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

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x000D0467 File Offset: 0x000CE667
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04003058 RID: 12376
		private IAnsEvent Instance;

		// Token: 0x04003059 RID: 12377
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x0400305A RID: 12378
		private bool _ActionInited;
	}
}
