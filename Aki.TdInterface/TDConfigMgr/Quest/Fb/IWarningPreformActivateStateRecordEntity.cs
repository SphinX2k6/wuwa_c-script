using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001583 RID: 5507
	public class IWarningPreformActivateStateRecordEntity : IWarningPreformType
	{
		// Token: 0x06007C34 RID: 31796 RVA: 0x0012723E File Offset: 0x0012543E
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

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x06007C35 RID: 31797 RVA: 0x0012725D File Offset: 0x0012545D
		public override EWarningPreformType Type
		{
			get
			{
				return (EWarningPreformType)this.Instance.Type;
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x06007C36 RID: 31798 RVA: 0x0012726C File Offset: 0x0012546C
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

		// Token: 0x04004799 RID: 18329
		private IWarningPreformActivateStateRecordEntity Instance;

		// Token: 0x0400479A RID: 18330
		private List<int> _TargetEntityIdsCache;

		// Token: 0x0400479B RID: 18331
		private bool _TargetEntityIdsInited;
	}
}
