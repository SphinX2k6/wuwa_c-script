using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002886 RID: 10374
	public class ISceneUiSubtitleAppear : ISceneUiSubtitleStyleBase
	{
		// Token: 0x0600E734 RID: 59188 RVA: 0x0022346F File Offset: 0x0022166F
		public static ISceneUiSubtitleAppear Create(ISceneUiSubtitleAppear? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleAppear
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x0600E735 RID: 59189 RVA: 0x0022348E File Offset: 0x0022168E
		public override ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = ActionReadHelper.ReadISceneUiSubtitleAppear_Position(this.Instance);
				return this._PositionCache;
			}
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x0600E736 RID: 59190 RVA: 0x002234C0 File Offset: 0x002216C0
		public override bool? LockFacingCamera
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

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x0600E737 RID: 59191 RVA: 0x002234F8 File Offset: 0x002216F8
		public override bool? IsOccluded
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

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x0600E738 RID: 59192 RVA: 0x0022352E File Offset: 0x0022172E
		[Nullable(2)]
		public override ISceneUiSubtitleLocalizationConfig LocalizationConfig
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

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x0600E739 RID: 59193 RVA: 0x00223562 File Offset: 0x00221762
		public override ESceneUiSubtitleStyleType Type
		{
			get
			{
				return (ESceneUiSubtitleStyleType)this.Instance.Type;
			}
		}

		// Token: 0x04007F50 RID: 32592
		private ISceneUiSubtitleAppear Instance;

		// Token: 0x04007F51 RID: 32593
		private ISceneUiSubtitlePositionBase _PositionCache;

		// Token: 0x04007F52 RID: 32594
		private bool _PositionInited;

		// Token: 0x04007F53 RID: 32595
		[Nullable(2)]
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x04007F54 RID: 32596
		private bool _LocalizationConfigInited;
	}
}
