using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002838 RID: 10296
	public class IVisualNovelPerformanceTransition : IVisualNovelPerformanceBase
	{
		// Token: 0x0600E524 RID: 58660 RVA: 0x0021DA49 File Offset: 0x0021BC49
		public static IVisualNovelPerformanceTransition Create(IVisualNovelPerformanceTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x0600E525 RID: 58661 RVA: 0x0021DA68 File Offset: 0x0021BC68
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x0600E526 RID: 58662 RVA: 0x0021DA78 File Offset: 0x0021BC78
		public override float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x0600E527 RID: 58663 RVA: 0x0021DAAE File Offset: 0x0021BCAE
		public virtual IVisualNovelTransitionPerformanceSolarSchool TransitionPerformanceConfig
		{
			get
			{
				if (this._TransitionPerformanceConfigInited)
				{
					return this._TransitionPerformanceConfigCache;
				}
				this._TransitionPerformanceConfigInited = true;
				this._TransitionPerformanceConfigCache = IVisualNovelTransitionPerformanceSolarSchool.Create(this.Instance.TransitionPerformanceConfig);
				return this._TransitionPerformanceConfigCache;
			}
		}

		// Token: 0x04007DBA RID: 32186
		private IVisualNovelPerformanceTransition Instance;

		// Token: 0x04007DBB RID: 32187
		[Nullable(2)]
		private IVisualNovelTransitionPerformanceSolarSchool _TransitionPerformanceConfigCache;

		// Token: 0x04007DBC RID: 32188
		private bool _TransitionPerformanceConfigInited;
	}
}
