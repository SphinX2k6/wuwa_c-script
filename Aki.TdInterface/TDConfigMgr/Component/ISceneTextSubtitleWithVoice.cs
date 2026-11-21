using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000755 RID: 1877
	public class ISceneTextSubtitleWithVoice : ISceneTextTypeBase
	{
		// Token: 0x060027EE RID: 10222 RVA: 0x0006A808 File Offset: 0x00068A08
		private ISceneTextSubtitleWithVoice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextSubtitleWithVoice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextSubtitleWithVoice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextSubtitleWithVoice_SetValue());
			}
			return result;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0006A840 File Offset: 0x00068A40
		public static ISceneTextSubtitleWithVoice Create([Nullable(2)] ISceneTextSubtitleWithVoice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextSubtitleWithVoice
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0006A853 File Offset: 0x00068A53
		public static ISceneTextSubtitleWithVoice CreateFromSetValue([Nullable(2)] ISceneTextSubtitleWithVoice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextSubtitleWithVoice
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0006A868 File Offset: 0x00068A68
		public new ISceneTextSubtitleWithVoice_SetValue ToSetValue()
		{
			return new ISceneTextSubtitleWithVoice_SetValue
			{
				Type = this.Type,
				Content = this.Content,
				FontSize = this.FontSize,
				BoxWidth = this.BoxWidth,
				BoxHeight = this.BoxHeight,
				Duration = this.Duration,
				AutoHide = this.AutoHide,
				FadeInEffect = this.FadeInEffect,
				FadeOutEffect = this.FadeOutEffect
			};
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0006A8E6 File Offset: 0x00068AE6
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x0006A911 File Offset: 0x00068B11
		public override ESceneTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x0006A920 File Offset: 0x00068B20
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x0006A981 File Offset: 0x00068B81
		public virtual PlayFlow Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				if (this.FbInstance != null)
				{
					this._ContentCache = PlayFlow.Create(this.FbInstance.Content);
				}
				else
				{
					ISceneTextSubtitleWithVoice_SetValue pocoInterface = this.PocoInterface;
					this._ContentCache = ((pocoInterface != null) ? pocoInterface.Content : null);
				}
				return this._ContentCache;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
				this._ContentInited = false;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0006A996 File Offset: 0x00068B96
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0006A9C1 File Offset: 0x00068BC1
		public virtual int FontSize
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FontSize;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FontSize;
			}
			set
			{
				this.GetOrCreatePoco().FontSize = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0006A9CF File Offset: 0x00068BCF
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x0006A9FE File Offset: 0x00068BFE
		public virtual float BoxWidth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoxWidth;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BoxWidth;
			}
			set
			{
				this.GetOrCreatePoco().BoxWidth = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x0006AA0C File Offset: 0x00068C0C
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x0006AA3B File Offset: 0x00068C3B
		public virtual float BoxHeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoxHeight;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BoxHeight;
			}
			set
			{
				this.GetOrCreatePoco().BoxHeight = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x0006AA4C File Offset: 0x00068C4C
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x0006AA86 File Offset: 0x00068C86
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				ISceneTextSubtitleWithVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x0006AA94 File Offset: 0x00068C94
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0006AACE File Offset: 0x00068CCE
		public virtual bool? AutoHide
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoHide;
				}
				ISceneTextSubtitleWithVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoHide;
			}
			set
			{
				this.GetOrCreatePoco().AutoHide = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x0006AADC File Offset: 0x00068CDC
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0006AB16 File Offset: 0x00068D16
		public virtual ESceneTextFadeInEffect? FadeInEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInEffect;
				}
				ISceneTextSubtitleWithVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeInEffect;
			}
			set
			{
				this.GetOrCreatePoco().FadeInEffect = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x0006AB24 File Offset: 0x00068D24
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0006AB5E File Offset: 0x00068D5E
		public virtual ESceneTextFadeOutEffect? FadeOutEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutEffect;
				}
				ISceneTextSubtitleWithVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutEffect;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
			}
		}

		// Token: 0x04001B37 RID: 6967
		[Nullable(2)]
		protected new ISceneTextSubtitleWithVoice FbInstance;

		// Token: 0x04001B38 RID: 6968
		[Nullable(2)]
		protected new ISceneTextSubtitleWithVoice_SetValue PocoInterface;

		// Token: 0x04001B39 RID: 6969
		private PlayFlow _ContentCache;

		// Token: 0x04001B3A RID: 6970
		private bool _ContentInited;
	}
}
