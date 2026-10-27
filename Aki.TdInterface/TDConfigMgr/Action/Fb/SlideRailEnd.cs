using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1A RID: 10778
	[NullableContext(1)]
	[Nullable(0)]
	public class SlideRailEnd : ActionParams
	{
		// Token: 0x0600ED9C RID: 60828 RVA: 0x0022A137 File Offset: 0x00228337
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

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x0600ED9D RID: 60829 RVA: 0x0022A156 File Offset: 0x00228356
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

		// Token: 0x040082C8 RID: 33480
		private ISlideRailEnd Instance;

		// Token: 0x040082C9 RID: 33481
		private ISlideRailEndType _EndTargetCache;

		// Token: 0x040082CA RID: 33482
		private bool _EndTargetInited;
	}
}
