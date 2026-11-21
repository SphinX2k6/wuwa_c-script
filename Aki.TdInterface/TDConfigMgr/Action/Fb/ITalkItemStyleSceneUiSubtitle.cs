using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EF RID: 10223
	public class ITalkItemStyleSceneUiSubtitle : ITalkItemStyle
	{
		// Token: 0x0600E227 RID: 57895 RVA: 0x00213BEE File Offset: 0x00211DEE
		public static ITalkItemStyleSceneUiSubtitle Create(ITalkItemStyleSceneUiSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyleSceneUiSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x0600E228 RID: 57896 RVA: 0x00213C0D File Offset: 0x00211E0D
		public override ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x0600E229 RID: 57897 RVA: 0x00213C1A File Offset: 0x00211E1A
		public virtual ISceneUiSubtitleStyleBase Style
		{
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				this._StyleCache = ActionReadHelper.ReadITalkItemStyleSceneUiSubtitle_Style(this.Instance);
				return this._StyleCache;
			}
		}

		// Token: 0x04007AF5 RID: 31477
		private ITalkItemStyleSceneUiSubtitle Instance;

		// Token: 0x04007AF6 RID: 31478
		private ISceneUiSubtitleStyleBase _StyleCache;

		// Token: 0x04007AF7 RID: 31479
		private bool _StyleInited;
	}
}
