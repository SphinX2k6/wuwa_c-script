using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1E RID: 3614
	public class ISceneTextGuideUi : ISceneTextTypeBase
	{
		// Token: 0x060051E3 RID: 20963 RVA: 0x000CA927 File Offset: 0x000C8B27
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x000CA946 File Offset: 0x000C8B46
		public override ESceneTextType Type
		{
			get
			{
				return (ESceneTextType)this.Instance.Type;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x000CA953 File Offset: 0x000C8B53
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

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x000CA987 File Offset: 0x000C8B87
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

		// Token: 0x04002EAF RID: 11951
		private ISceneTextGuideUi Instance;

		// Token: 0x04002EB0 RID: 11952
		[Nullable(2)]
		private ISceneTextGuideUiScaleConfig _ScaleConfigCache;

		// Token: 0x04002EB1 RID: 11953
		private bool _ScaleConfigInited;

		// Token: 0x04002EB2 RID: 11954
		[Nullable(2)]
		private ISceneTextGuideUiContent _ContentCache;

		// Token: 0x04002EB3 RID: 11955
		private bool _ContentInited;
	}
}
