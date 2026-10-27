using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002659 RID: 9817
	[NullableContext(2)]
	[Nullable(0)]
	public class IPictureCaptionConfig
	{
		// Token: 0x0600DC14 RID: 56340 RVA: 0x0020C03B File Offset: 0x0020A23B
		[NullableContext(1)]
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

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x0600DC15 RID: 56341 RVA: 0x0020C05A File Offset: 0x0020A25A
		[Nullable(1)]
		public virtual string PictureCaption
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.PictureCaption;
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x0600DC16 RID: 56342 RVA: 0x0020C067 File Offset: 0x0020A267
		public virtual string UiPrefabId
		{
			get
			{
				return this.Instance.UiPrefabId;
			}
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x0600DC17 RID: 56343 RVA: 0x0020C074 File Offset: 0x0020A274
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x0600DC18 RID: 56344 RVA: 0x0020C081 File Offset: 0x0020A281
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

		// Token: 0x04007A55 RID: 31317
		private IPictureCaptionConfig Instance;

		// Token: 0x04007A56 RID: 31318
		private IUiAnimConfig _UiAnimConfigCache;

		// Token: 0x04007A57 RID: 31319
		private bool _UiAnimConfigInited;
	}
}
