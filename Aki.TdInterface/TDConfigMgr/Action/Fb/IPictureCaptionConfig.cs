using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291D RID: 10525
	[NullableContext(2)]
	[Nullable(0)]
	public class IPictureCaptionConfig
	{
		// Token: 0x0600E9F0 RID: 59888 RVA: 0x00228913 File Offset: 0x00226B13
		[NullableContext(0)]
		public static IPictureCaptionConfig Create(IPictureCaptionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPictureCaptionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x00228932 File Offset: 0x00226B32
		[Nullable(0)]
		public virtual string PictureCaption
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.PictureCaption;
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x0600E9F2 RID: 59890 RVA: 0x0022893F File Offset: 0x00226B3F
		public virtual string UiPrefabId
		{
			get
			{
				return this.Instance.UiPrefabId;
			}
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x0600E9F3 RID: 59891 RVA: 0x0022894C File Offset: 0x00226B4C
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x0600E9F4 RID: 59892 RVA: 0x00228959 File Offset: 0x00226B59
		public virtual IUiAnimConfig UiAnimConfig
		{
			get
			{
				if (this._UiAnimConfigInited)
				{
					return this._UiAnimConfigCache;
				}
				this._UiAnimConfigInited = true;
				this._UiAnimConfigCache = IUiAnimConfig.Create(this.Instance.UiAnimConfig);
				return this._UiAnimConfigCache;
			}
		}

		// Token: 0x040080F7 RID: 33015
		private IPictureCaptionConfig Instance;

		// Token: 0x040080F8 RID: 33016
		private IUiAnimConfig _UiAnimConfigCache;

		// Token: 0x040080F9 RID: 33017
		private bool _UiAnimConfigInited;
	}
}
