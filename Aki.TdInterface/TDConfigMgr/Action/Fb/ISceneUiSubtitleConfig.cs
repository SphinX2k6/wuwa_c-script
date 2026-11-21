using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002883 RID: 10371
	public class ISceneUiSubtitleConfig
	{
		// Token: 0x0600E720 RID: 59168 RVA: 0x00223169 File Offset: 0x00221369
		public static ISceneUiSubtitleConfig Create(ISceneUiSubtitleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x0600E721 RID: 59169 RVA: 0x00223188 File Offset: 0x00221388
		public virtual ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = ActionReadHelper.ReadISceneUiSubtitleConfig_Position(this.Instance);
				return this._PositionCache;
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x0600E722 RID: 59170 RVA: 0x002231B8 File Offset: 0x002213B8
		public virtual bool? LockFacingCamera
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.LockFacingCamera);
			}
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x0600E723 RID: 59171 RVA: 0x002231F0 File Offset: 0x002213F0
		public virtual bool? IsOccluded
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOccluded);
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x0600E724 RID: 59172 RVA: 0x00223226 File Offset: 0x00221426
		[Nullable(2)]
		public virtual ISceneUiSubtitleLocalizationConfig LocalizationConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._LocalizationConfigInited)
				{
					return this._LocalizationConfigCache;
				}
				this._LocalizationConfigInited = true;
				this._LocalizationConfigCache = ISceneUiSubtitleLocalizationConfig.Create(this.Instance.LocalizationConfig);
				return this._LocalizationConfigCache;
			}
		}

		// Token: 0x04007F41 RID: 32577
		private ISceneUiSubtitleConfig Instance;

		// Token: 0x04007F42 RID: 32578
		private ISceneUiSubtitlePositionBase _PositionCache;

		// Token: 0x04007F43 RID: 32579
		private bool _PositionInited;

		// Token: 0x04007F44 RID: 32580
		[Nullable(2)]
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x04007F45 RID: 32581
		private bool _LocalizationConfigInited;
	}
}
