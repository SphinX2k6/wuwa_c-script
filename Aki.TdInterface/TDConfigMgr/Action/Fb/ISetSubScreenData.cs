using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A3 RID: 10147
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetSubScreenData
	{
		// Token: 0x0600E1C7 RID: 57799 RVA: 0x00215AD6 File Offset: 0x00213CD6
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

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x0600E1C8 RID: 57800 RVA: 0x00215AF5 File Offset: 0x00213CF5
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

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x00215B24 File Offset: 0x00213D24
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

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x0600E1CA RID: 57802 RVA: 0x00215B58 File Offset: 0x00213D58
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

		// Token: 0x04007D2F RID: 32047
		private ISetSubScreenData Instance;

		// Token: 0x04007D30 RID: 32048
		private IScreenType _TargetScreenCache;

		// Token: 0x04007D31 RID: 32049
		private bool _TargetScreenInited;

		// Token: 0x04007D32 RID: 32050
		[Nullable(2)]
		private ISubScreenConfig _TargetSubScreenConfigCache;

		// Token: 0x04007D33 RID: 32051
		private bool _TargetSubScreenConfigInited;

		// Token: 0x04007D34 RID: 32052
		[Nullable(2)]
		private ISubScreenTransition _TransitionCache;

		// Token: 0x04007D35 RID: 32053
		private bool _TransitionInited;
	}
}
