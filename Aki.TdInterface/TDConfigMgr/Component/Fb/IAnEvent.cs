using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA8 RID: 3496
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06004F71 RID: 20337 RVA: 0x000C4C2C File Offset: 0x000C2E2C
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

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06004F72 RID: 20338 RVA: 0x000C4C4B File Offset: 0x000C2E4B
		public override ESceneItemSeqEventCbType Type
		{
			get
			{
				return (ESceneItemSeqEventCbType)this.Instance.Type;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x000C4C58 File Offset: 0x000C2E58
		public override string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06004F74 RID: 20340 RVA: 0x000C4C65 File Offset: 0x000C2E65
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

		// Token: 0x04002D95 RID: 11669
		private IAnEvent Instance;

		// Token: 0x04002D96 RID: 11670
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x04002D97 RID: 11671
		private bool _ActionInited;
	}
}
