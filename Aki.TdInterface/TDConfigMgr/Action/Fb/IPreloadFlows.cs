using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CCF RID: 11471
	public class IPreloadFlows : IPreloadCharacterType
	{
		// Token: 0x0600FB6D RID: 64365 RVA: 0x00246B30 File Offset: 0x00244D30
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

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x0600FB6E RID: 64366 RVA: 0x00246B4F File Offset: 0x00244D4F
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x0600FB6F RID: 64367 RVA: 0x00246B5C File Offset: 0x00244D5C
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

		// Token: 0x0400895F RID: 35167
		private IPreloadFlows Instance;

		// Token: 0x04008960 RID: 35168
		[Nullable(2)]
		private PlayFlow _FlowDataCache;

		// Token: 0x04008961 RID: 35169
		private bool _FlowDataInited;
	}
}
