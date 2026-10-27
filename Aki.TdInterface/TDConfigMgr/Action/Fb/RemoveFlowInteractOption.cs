using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200261C RID: 9756
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveFlowInteractOption : ActionParams
	{
		// Token: 0x0600DB0C RID: 56076 RVA: 0x0020A09B File Offset: 0x0020829B
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

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x0600DB0D RID: 56077 RVA: 0x0020A0BA File Offset: 0x002082BA
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

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x0600DB0E RID: 56078 RVA: 0x0020A0EE File Offset: 0x002082EE
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x0600DB0F RID: 56079 RVA: 0x0020A0FB File Offset: 0x002082FB
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.InteractToken;
			}
		}

		// Token: 0x040079B4 RID: 31156
		private IRemoveFlowInteractOption Instance;

		// Token: 0x040079B5 RID: 31157
		[Nullable(2)]
		private IFlowIndex _FlowCache;

		// Token: 0x040079B6 RID: 31158
		private bool _FlowInited;
	}
}
