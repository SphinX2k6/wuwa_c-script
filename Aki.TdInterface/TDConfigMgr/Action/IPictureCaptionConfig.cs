using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF2 RID: 7410
	[NullableContext(1)]
	[Nullable(0)]
	public class IPictureCaptionConfig
	{
		// Token: 0x06009F05 RID: 40709 RVA: 0x0016B720 File Offset: 0x00169920
		private IPictureCaptionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPictureCaptionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPictureCaptionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPictureCaptionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x0016B758 File Offset: 0x00169958
		public static IPictureCaptionConfig Create([Nullable(2)] IPictureCaptionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPictureCaptionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x0016B76B File Offset: 0x0016996B
		public static IPictureCaptionConfig CreateFromSetValue([Nullable(2)] IPictureCaptionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPictureCaptionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x0016B77E File Offset: 0x0016997E
		public IPictureCaptionConfig_SetValue ToSetValue()
		{
			return new IPictureCaptionConfig_SetValue
			{
				PictureCaption = this.PictureCaption,
				UiPrefabId = this.UiPrefabId,
				Duration = this.Duration,
				UiAnimConfig = this.UiAnimConfig
			};
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x06009F09 RID: 40713 RVA: 0x0016B7B5 File Offset: 0x001699B5
		// (set) Token: 0x06009F0A RID: 40714 RVA: 0x0016B7E0 File Offset: 0x001699E0
		public virtual string PictureCaption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PictureCaption;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PictureCaption;
			}
			set
			{
				this.GetOrCreatePoco().PictureCaption = value;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x0016B7EE File Offset: 0x001699EE
		// (set) Token: 0x06009F0C RID: 40716 RVA: 0x0016B815 File Offset: 0x00169A15
		[Nullable(2)]
		public virtual string UiPrefabId
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiPrefabId;
				}
				IPictureCaptionConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiPrefabId;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UiPrefabId = value;
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x06009F0D RID: 40717 RVA: 0x0016B823 File Offset: 0x00169A23
		// (set) Token: 0x06009F0E RID: 40718 RVA: 0x0016B852 File Offset: 0x00169A52
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x06009F0F RID: 40719 RVA: 0x0016B860 File Offset: 0x00169A60
		// (set) Token: 0x06009F10 RID: 40720 RVA: 0x0016B8C1 File Offset: 0x00169AC1
		[Nullable(2)]
		public virtual IUiAnimConfig UiAnimConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._UiAnimConfigInited)
				{
					return this._UiAnimConfigCache;
				}
				this._UiAnimConfigInited = true;
				if (this.FbInstance != null)
				{
					this._UiAnimConfigCache = IUiAnimConfig.Create(this.FbInstance.UiAnimConfig);
				}
				else
				{
					IPictureCaptionConfig_SetValue pocoInterface = this.PocoInterface;
					this._UiAnimConfigCache = ((pocoInterface != null) ? pocoInterface.UiAnimConfig : null);
				}
				return this._UiAnimConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UiAnimConfig = value;
				this._UiAnimConfigInited = false;
			}
		}

		// Token: 0x04006009 RID: 24585
		[Nullable(2)]
		protected IPictureCaptionConfig FbInstance;

		// Token: 0x0400600A RID: 24586
		[Nullable(2)]
		protected IPictureCaptionConfig_SetValue PocoInterface;

		// Token: 0x0400600B RID: 24587
		private IUiAnimConfig _UiAnimConfigCache;

		// Token: 0x0400600C RID: 24588
		private bool _UiAnimConfigInited;
	}
}
