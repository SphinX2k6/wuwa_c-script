using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002881 RID: 10369
	public class ISceneUiSubtitleLanguageOverride
	{
		// Token: 0x0600E718 RID: 59160 RVA: 0x0022303B File Offset: 0x0022123B
		public static ISceneUiSubtitleLanguageOverride Create(ISceneUiSubtitleLanguageOverride? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleLanguageOverride
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0600E719 RID: 59161 RVA: 0x0022305A File Offset: 0x0022125A
		public virtual string Language
		{
			get
			{
				return this.Instance.Language;
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0600E71A RID: 59162 RVA: 0x00223067 File Offset: 0x00221267
		public virtual ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = ActionReadHelper.ReadISceneUiSubtitleLanguageOverride_Position(this.Instance);
				return this._PositionCache;
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0600E71B RID: 59163 RVA: 0x00223098 File Offset: 0x00221298
		public virtual float? Scale
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Scale);
			}
		}

		// Token: 0x04007F3B RID: 32571
		private ISceneUiSubtitleLanguageOverride Instance;

		// Token: 0x04007F3C RID: 32572
		private ISceneUiSubtitlePositionBase _PositionCache;

		// Token: 0x04007F3D RID: 32573
		private bool _PositionInited;
	}
}
