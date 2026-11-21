using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F01 RID: 7937
	public class IPictureCaptionConfig
	{
		// Token: 0x0600A8E5 RID: 43237 RVA: 0x0017F980 File Offset: 0x0017DB80
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

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x0017F9B8 File Offset: 0x0017DBB8
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

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x0017F9CB File Offset: 0x0017DBCB
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

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x0017F9DE File Offset: 0x0017DBDE
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

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600A8E9 RID: 43241 RVA: 0x0017FA15 File Offset: 0x0017DC15
		// (set) Token: 0x0600A8EA RID: 43242 RVA: 0x0017FA40 File Offset: 0x0017DC40
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

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600A8EB RID: 43243 RVA: 0x0017FA4E File Offset: 0x0017DC4E
		// (set) Token: 0x0600A8EC RID: 43244 RVA: 0x0017FA75 File Offset: 0x0017DC75
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

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600A8ED RID: 43245 RVA: 0x0017FA83 File Offset: 0x0017DC83
		// (set) Token: 0x0600A8EE RID: 43246 RVA: 0x0017FAB2 File Offset: 0x0017DCB2
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

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600A8EF RID: 43247 RVA: 0x0017FAC0 File Offset: 0x0017DCC0
		// (set) Token: 0x0600A8F0 RID: 43248 RVA: 0x0017FB21 File Offset: 0x0017DD21
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

		// Token: 0x0400657C RID: 25980
		[Nullable(2)]
		protected IPictureCaptionConfig FbInstance;

		// Token: 0x0400657D RID: 25981
		[Nullable(2)]
		protected IPictureCaptionConfig_SetValue PocoInterface;

		// Token: 0x0400657E RID: 25982
		private IUiAnimConfig _UiAnimConfigCache;

		// Token: 0x0400657F RID: 25983
		private bool _UiAnimConfigInited;
	}
}
