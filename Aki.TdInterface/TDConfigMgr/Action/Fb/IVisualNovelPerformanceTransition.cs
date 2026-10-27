using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200258A RID: 9610
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceTransition : IVisualNovelPerformanceBase
	{
		// Token: 0x0600D7AA RID: 55210 RVA: 0x00201D15 File Offset: 0x001FFF15
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

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600D7AB RID: 55211 RVA: 0x00201D34 File Offset: 0x001FFF34
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0600D7AC RID: 55212 RVA: 0x00201D44 File Offset: 0x001FFF44
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

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x00201D7A File Offset: 0x001FFF7A
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

		// Token: 0x04007754 RID: 30548
		private IVisualNovelPerformanceTransition Instance;

		// Token: 0x04007755 RID: 30549
		[Nullable(2)]
		private IVisualNovelTransitionPerformanceSolarSchool _TransitionPerformanceConfigCache;

		// Token: 0x04007756 RID: 30550
		private bool _TransitionPerformanceConfigInited;
	}
}
