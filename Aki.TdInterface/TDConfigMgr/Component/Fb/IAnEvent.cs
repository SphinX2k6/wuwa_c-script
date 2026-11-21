using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA4 RID: 3748
	public class IAnEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06005496 RID: 21654 RVA: 0x000D047C File Offset: 0x000CE67C
		public static IAnEvent Create(IAnEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x000D049B File Offset: 0x000CE69B
		public override ESceneItemSeqEventCbType Type
		{
			get
			{
				return (ESceneItemSeqEventCbType)this.Instance.Type;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x000D04A8 File Offset: 0x000CE6A8
		public override string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x000D04B5 File Offset: 0x000CE6B5
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

		// Token: 0x0400305B RID: 12379
		private IAnEvent Instance;

		// Token: 0x0400305C RID: 12380
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x0400305D RID: 12381
		private bool _ActionInited;
	}
}
