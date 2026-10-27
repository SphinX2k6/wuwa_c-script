using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D24 RID: 3364
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUi : ISceneTextTypeBase
	{
		// Token: 0x06004CC7 RID: 19655 RVA: 0x000BF1E3 File Offset: 0x000BD3E3
		public static ISceneTextGuideUi Create(ISceneTextGuideUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x000BF202 File Offset: 0x000BD402
		public override ESceneTextType Type
		{
			get
			{
				return (ESceneTextType)this.Instance.Type;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06004CC9 RID: 19657 RVA: 0x000BF20F File Offset: 0x000BD40F
		public virtual ISceneTextGuideUiScaleConfig ScaleConfig
		{
			get
			{
				if (this._ScaleConfigInited)
				{
					return this._ScaleConfigCache;
				}
				this._ScaleConfigInited = true;
				this._ScaleConfigCache = ISceneTextGuideUiScaleConfig.Create(this.Instance.ScaleConfig);
				return this._ScaleConfigCache;
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06004CCA RID: 19658 RVA: 0x000BF243 File Offset: 0x000BD443
		public virtual ISceneTextGuideUiContent Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				this._ContentCache = ISceneTextGuideUiContent.Create(this.Instance.Content);
				return this._ContentCache;
			}
		}

		// Token: 0x04002BEF RID: 11247
		private ISceneTextGuideUi Instance;

		// Token: 0x04002BF0 RID: 11248
		[Nullable(2)]
		private ISceneTextGuideUiScaleConfig _ScaleConfigCache;

		// Token: 0x04002BF1 RID: 11249
		private bool _ScaleConfigInited;

		// Token: 0x04002BF2 RID: 11250
		[Nullable(2)]
		private ISceneTextGuideUiContent _ContentCache;

		// Token: 0x04002BF3 RID: 11251
		private bool _ContentInited;
	}
}
