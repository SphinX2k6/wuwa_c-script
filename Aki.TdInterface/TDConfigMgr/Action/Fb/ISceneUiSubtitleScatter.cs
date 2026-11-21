using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002885 RID: 10373
	public class ISceneUiSubtitleScatter : ISceneUiSubtitleStyleBase
	{
		// Token: 0x0600E72D RID: 59181 RVA: 0x00223367 File Offset: 0x00221567
		public static ISceneUiSubtitleScatter Create(ISceneUiSubtitleScatter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleScatter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x0600E72E RID: 59182 RVA: 0x00223386 File Offset: 0x00221586
		public override ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = ActionReadHelper.ReadISceneUiSubtitleScatter_Position(this.Instance);
				return this._PositionCache;
			}
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x0600E72F RID: 59183 RVA: 0x002233B8 File Offset: 0x002215B8
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

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x0600E730 RID: 59184 RVA: 0x002233F0 File Offset: 0x002215F0
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

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x0600E731 RID: 59185 RVA: 0x00223426 File Offset: 0x00221626
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

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x0600E732 RID: 59186 RVA: 0x0022345A File Offset: 0x0022165A
		public override ESceneUiSubtitleStyleType Type
		{
			get
			{
				return (ESceneUiSubtitleStyleType)this.Instance.Type;
			}
		}

		// Token: 0x04007F4B RID: 32587
		private ISceneUiSubtitleScatter Instance;

		// Token: 0x04007F4C RID: 32588
		private ISceneUiSubtitlePositionBase _PositionCache;

		// Token: 0x04007F4D RID: 32589
		private bool _PositionInited;

		// Token: 0x04007F4E RID: 32590
		[Nullable(2)]
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x04007F4F RID: 32591
		private bool _LocalizationConfigInited;
	}
}
