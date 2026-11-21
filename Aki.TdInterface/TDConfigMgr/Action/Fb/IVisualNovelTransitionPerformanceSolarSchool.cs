using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002837 RID: 10295
	public class IVisualNovelTransitionPerformanceSolarSchool : IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600E520 RID: 58656 RVA: 0x0021D9E6 File Offset: 0x0021BBE6
		public static IVisualNovelTransitionPerformanceSolarSchool Create(IVisualNovelTransitionPerformanceSolarSchool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceSolarSchool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x0600E521 RID: 58657 RVA: 0x0021DA05 File Offset: 0x0021BC05
		public override EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x0600E522 RID: 58658 RVA: 0x0021DA12 File Offset: 0x0021BC12
		public virtual IVisualNovelTransitionConfigBase TransitionConfig
		{
			get
			{
				if (this._TransitionConfigInited)
				{
					return this._TransitionConfigCache;
				}
				this._TransitionConfigInited = true;
				this._TransitionConfigCache = ActionReadHelper.ReadIVisualNovelTransitionPerformanceSolarSchool_TransitionConfig(this.Instance);
				return this._TransitionConfigCache;
			}
		}

		// Token: 0x04007DB7 RID: 32183
		private IVisualNovelTransitionPerformanceSolarSchool Instance;

		// Token: 0x04007DB8 RID: 32184
		private IVisualNovelTransitionConfigBase _TransitionConfigCache;

		// Token: 0x04007DB9 RID: 32185
		private bool _TransitionConfigInited;
	}
}
