using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142B RID: 5163
	[NullableContext(1)]
	[Nullable(0)]
	public class IWarningPreformActivateStateRecordEntity : IWarningPreformType
	{
		// Token: 0x0600756F RID: 30063 RVA: 0x001187F2 File Offset: 0x001169F2
		public static IWarningPreformActivateStateRecordEntity Create(IWarningPreformActivateStateRecordEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformActivateStateRecordEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x06007570 RID: 30064 RVA: 0x00118811 File Offset: 0x00116A11
		public override EWarningPreformType Type
		{
			get
			{
				return (EWarningPreformType)this.Instance.Type;
			}
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x06007571 RID: 30065 RVA: 0x00118820 File Offset: 0x00116A20
		public virtual List<int> TargetEntityIds
		{
			get
			{
				if (this._TargetEntityIdsInited)
				{
					return this._TargetEntityIdsCache;
				}
				this._TargetEntityIdsInited = true;
				int targetEntityIdsLength = this.Instance.TargetEntityIdsLength;
				this._TargetEntityIdsCache = new List<int>(targetEntityIdsLength);
				for (int i = 0; i < targetEntityIdsLength; i++)
				{
					this._TargetEntityIdsCache.Add(this.Instance.TargetEntityIds(i));
				}
				return this._TargetEntityIdsCache;
			}
		}

		// Token: 0x04004405 RID: 17413
		private IWarningPreformActivateStateRecordEntity Instance;

		// Token: 0x04004406 RID: 17414
		private List<int> _TargetEntityIdsCache;

		// Token: 0x04004407 RID: 17415
		private bool _TargetEntityIdsInited;
	}
}
