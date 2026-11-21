using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002884 RID: 10372
	public class ISceneUiSubtitleStyleBase : ISceneUiSubtitleConfig
	{
		// Token: 0x0600E726 RID: 59174 RVA: 0x00223262 File Offset: 0x00221462
		public static ISceneUiSubtitleStyleBase Create(ISceneUiSubtitleStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x0600E727 RID: 59175 RVA: 0x00223281 File Offset: 0x00221481
		public override ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = ActionReadHelper.ReadISceneUiSubtitleStyleBase_Position(this.Instance);
				return this._PositionCache;
			}
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x002232B0 File Offset: 0x002214B0
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

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x0600E729 RID: 59177 RVA: 0x002232E8 File Offset: 0x002214E8
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

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x0600E72A RID: 59178 RVA: 0x0022331E File Offset: 0x0022151E
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

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x0600E72B RID: 59179 RVA: 0x00223352 File Offset: 0x00221552
		public virtual ESceneUiSubtitleStyleType Type
		{
			get
			{
				return (ESceneUiSubtitleStyleType)this.Instance.Type;
			}
		}

		// Token: 0x04007F46 RID: 32582
		private ISceneUiSubtitleStyleBase Instance;

		// Token: 0x04007F47 RID: 32583
		private ISceneUiSubtitlePositionBase _PositionCache;

		// Token: 0x04007F48 RID: 32584
		private bool _PositionInited;

		// Token: 0x04007F49 RID: 32585
		[Nullable(2)]
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x04007F4A RID: 32586
		private bool _LocalizationConfigInited;
	}
}
