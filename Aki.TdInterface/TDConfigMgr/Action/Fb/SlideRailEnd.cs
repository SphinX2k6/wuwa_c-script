using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D07 RID: 11527
	public class SlideRailEnd : ActionParams
	{
		// Token: 0x0600FC33 RID: 64563 RVA: 0x00247ABB File Offset: 0x00245CBB
		public static SlideRailEnd Create(ISlideRailEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SlideRailEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x0600FC34 RID: 64564 RVA: 0x00247ADA File Offset: 0x00245CDA
		public virtual ISlideRailEndType EndTarget
		{
			get
			{
				if (this._EndTargetInited)
				{
					return this._EndTargetCache;
				}
				this._EndTargetInited = true;
				this._EndTargetCache = ActionReadHelper.ReadSlideRailEnd_EndTarget(this.Instance);
				return this._EndTargetCache;
			}
		}

		// Token: 0x040089B9 RID: 35257
		private ISlideRailEnd Instance;

		// Token: 0x040089BA RID: 35258
		private ISlideRailEndType _EndTargetCache;

		// Token: 0x040089BB RID: 35259
		private bool _EndTargetInited;
	}
}
