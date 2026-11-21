using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A75 RID: 10869
	public class ISetSubScreenData
	{
		// Token: 0x0600EFE5 RID: 61413 RVA: 0x0023286A File Offset: 0x00230A6A
		public static ISetSubScreenData Create(ISetSubScreenData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetSubScreenData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x00232889 File Offset: 0x00230A89
		public virtual IScreenType TargetScreen
		{
			get
			{
				if (this._TargetScreenInited)
				{
					return this._TargetScreenCache;
				}
				this._TargetScreenInited = true;
				this._TargetScreenCache = ActionReadHelper.ReadISetSubScreenData_TargetScreen(this.Instance);
				return this._TargetScreenCache;
			}
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x0600EFE7 RID: 61415 RVA: 0x002328B8 File Offset: 0x00230AB8
		public virtual ISubScreenConfig TargetSubScreenConfig
		{
			get
			{
				if (this._TargetSubScreenConfigInited)
				{
					return this._TargetSubScreenConfigCache;
				}
				this._TargetSubScreenConfigInited = true;
				this._TargetSubScreenConfigCache = ISubScreenConfig.Create(this.Instance.TargetSubScreenConfig);
				return this._TargetSubScreenConfigCache;
			}
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x0600EFE8 RID: 61416 RVA: 0x002328EC File Offset: 0x00230AEC
		public virtual ISubScreenTransition Transition
		{
			get
			{
				if (this._TransitionInited)
				{
					return this._TransitionCache;
				}
				this._TransitionInited = true;
				this._TransitionCache = ISubScreenTransition.Create(this.Instance.Transition);
				return this._TransitionCache;
			}
		}

		// Token: 0x040083E5 RID: 33765
		private ISetSubScreenData Instance;

		// Token: 0x040083E6 RID: 33766
		private IScreenType _TargetScreenCache;

		// Token: 0x040083E7 RID: 33767
		private bool _TargetScreenInited;

		// Token: 0x040083E8 RID: 33768
		[Nullable(2)]
		private ISubScreenConfig _TargetSubScreenConfigCache;

		// Token: 0x040083E9 RID: 33769
		private bool _TargetSubScreenConfigInited;

		// Token: 0x040083EA RID: 33770
		[Nullable(2)]
		private ISubScreenTransition _TransitionCache;

		// Token: 0x040083EB RID: 33771
		private bool _TransitionInited;
	}
}
