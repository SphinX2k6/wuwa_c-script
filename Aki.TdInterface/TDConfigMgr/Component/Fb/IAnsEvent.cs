using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA7 RID: 3495
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnsEvent : ISceneItemSeqEventCbType
	{
		// Token: 0x06004F6B RID: 20331 RVA: 0x000C4BAA File Offset: 0x000C2DAA
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

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06004F6C RID: 20332 RVA: 0x000C4BC9 File Offset: 0x000C2DC9
		public override ESceneItemSeqEventCbType Type
		{
			get
			{
				return (ESceneItemSeqEventCbType)this.Instance.Type;
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06004F6D RID: 20333 RVA: 0x000C4BD6 File Offset: 0x000C2DD6
		public override string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06004F6E RID: 20334 RVA: 0x000C4BE3 File Offset: 0x000C2DE3
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

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06004F6F RID: 20335 RVA: 0x000C4C17 File Offset: 0x000C2E17
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04002D92 RID: 11666
		private IAnsEvent Instance;

		// Token: 0x04002D93 RID: 11667
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x04002D94 RID: 11668
		private bool _ActionInited;
	}
}
