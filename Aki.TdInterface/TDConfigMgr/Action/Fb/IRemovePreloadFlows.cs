using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E7 RID: 10727
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadFlows : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600ECE8 RID: 60648 RVA: 0x00229378 File Offset: 0x00227578
		public static IRemovePreloadFlows Create(IRemovePreloadFlows? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadFlows
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x0600ECE9 RID: 60649 RVA: 0x00229397 File Offset: 0x00227597
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x0600ECEA RID: 60650 RVA: 0x002293A4 File Offset: 0x002275A4
		public virtual PlayFlow FlowId
		{
			get
			{
				if (this._FlowIdInited)
				{
					return this._FlowIdCache;
				}
				this._FlowIdInited = true;
				this._FlowIdCache = PlayFlow.Create(this.Instance.FlowId);
				return this._FlowIdCache;
			}
		}

		// Token: 0x04008279 RID: 33401
		private IRemovePreloadFlows Instance;

		// Token: 0x0400827A RID: 33402
		[Nullable(2)]
		private PlayFlow _FlowIdCache;

		// Token: 0x0400827B RID: 33403
		private bool _FlowIdInited;
	}
}
