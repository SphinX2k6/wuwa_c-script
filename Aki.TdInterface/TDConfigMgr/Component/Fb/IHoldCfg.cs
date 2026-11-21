using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1F RID: 3103
	[NullableContext(2)]
	[Nullable(0)]
	public class IHoldCfg
	{
		// Token: 0x06004715 RID: 18197 RVA: 0x000B462E File Offset: 0x000B282E
		[NullableContext(0)]
		public static IHoldCfg Create(IHoldCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHoldCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06004716 RID: 18198 RVA: 0x000B464D File Offset: 0x000B284D
		public virtual IHoldingTrackTarget TrackTarget
		{
			get
			{
				if (this._TrackTargetInited)
				{
					return this._TrackTargetCache;
				}
				this._TrackTargetInited = true;
				this._TrackTargetCache = IHoldingTrackTarget.Create(this.Instance.TrackTarget);
				return this._TrackTargetCache;
			}
		}

		// Token: 0x040027DC RID: 10204
		private IHoldCfg Instance;

		// Token: 0x040027DD RID: 10205
		private IHoldingTrackTarget _TrackTargetCache;

		// Token: 0x040027DE RID: 10206
		private bool _TrackTargetInited;
	}
}
