using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DC RID: 10460
	public class RemoveFlowInteractOption : ActionParams
	{
		// Token: 0x0600E8DA RID: 59610 RVA: 0x00226867 File Offset: 0x00224A67
		public static RemoveFlowInteractOption Create(IRemoveFlowInteractOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveFlowInteractOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x00226886 File Offset: 0x00224A86
		public virtual IFlowIndex Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = IFlowIndex.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x002268BA File Offset: 0x00224ABA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x0600E8DD RID: 59613 RVA: 0x002268C7 File Offset: 0x00224AC7
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.InteractToken;
			}
		}

		// Token: 0x04008050 RID: 32848
		private IRemoveFlowInteractOption Instance;

		// Token: 0x04008051 RID: 32849
		[Nullable(2)]
		private IFlowIndex _FlowCache;

		// Token: 0x04008052 RID: 32850
		private bool _FlowInited;
	}
}
