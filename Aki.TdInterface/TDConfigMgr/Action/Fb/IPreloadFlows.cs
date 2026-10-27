using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E2 RID: 10722
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadFlows : IPreloadCharacterType
	{
		// Token: 0x0600ECD6 RID: 60630 RVA: 0x002291AC File Offset: 0x002273AC
		public static IPreloadFlows Create(IPreloadFlows? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadFlows
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x0600ECD7 RID: 60631 RVA: 0x002291CB File Offset: 0x002273CB
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x0600ECD8 RID: 60632 RVA: 0x002291D8 File Offset: 0x002273D8
		public virtual PlayFlow FlowData
		{
			get
			{
				if (this._FlowDataInited)
				{
					return this._FlowDataCache;
				}
				this._FlowDataInited = true;
				this._FlowDataCache = PlayFlow.Create(this.Instance.FlowData);
				return this._FlowDataCache;
			}
		}

		// Token: 0x0400826E RID: 33390
		private IPreloadFlows Instance;

		// Token: 0x0400826F RID: 33391
		[Nullable(2)]
		private PlayFlow _FlowDataCache;

		// Token: 0x04008270 RID: 33392
		private bool _FlowDataInited;
	}
}
