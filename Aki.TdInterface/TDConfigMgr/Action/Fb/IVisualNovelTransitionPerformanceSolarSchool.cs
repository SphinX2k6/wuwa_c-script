using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002589 RID: 9609
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionPerformanceSolarSchool : IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600D7A6 RID: 55206 RVA: 0x00201CB2 File Offset: 0x001FFEB2
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

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600D7A7 RID: 55207 RVA: 0x00201CD1 File Offset: 0x001FFED1
		public override EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0600D7A8 RID: 55208 RVA: 0x00201CDE File Offset: 0x001FFEDE
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

		// Token: 0x04007751 RID: 30545
		private IVisualNovelTransitionPerformanceSolarSchool Instance;

		// Token: 0x04007752 RID: 30546
		private IVisualNovelTransitionConfigBase _TransitionConfigCache;

		// Token: 0x04007753 RID: 30547
		private bool _TransitionConfigInited;
	}
}
