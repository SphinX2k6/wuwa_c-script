using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD4 RID: 11476
	public class IRemovePreloadFlows : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600FB7F RID: 64383 RVA: 0x00246CFC File Offset: 0x00244EFC
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

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x0600FB80 RID: 64384 RVA: 0x00246D1B File Offset: 0x00244F1B
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x0600FB81 RID: 64385 RVA: 0x00246D28 File Offset: 0x00244F28
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

		// Token: 0x0400896A RID: 35178
		private IRemovePreloadFlows Instance;

		// Token: 0x0400896B RID: 35179
		[Nullable(2)]
		private PlayFlow _FlowIdCache;

		// Token: 0x0400896C RID: 35180
		private bool _FlowIdInited;
	}
}
