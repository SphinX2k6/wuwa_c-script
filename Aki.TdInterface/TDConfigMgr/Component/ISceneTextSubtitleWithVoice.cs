using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B4 RID: 1716
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextSubtitleWithVoice : ISceneTextTypeBase
	{
		// Token: 0x060024D2 RID: 9426 RVA: 0x00063840 File Offset: 0x00061A40
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

		// Token: 0x060024D3 RID: 9427 RVA: 0x00063878 File Offset: 0x00061A78
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

		// Token: 0x060024D4 RID: 9428 RVA: 0x0006388B File Offset: 0x00061A8B
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

		// Token: 0x060024D5 RID: 9429 RVA: 0x000638A0 File Offset: 0x00061AA0
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
				AutoHide = this.AutoHide
			};
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00063906 File Offset: 0x00061B06
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00063931 File Offset: 0x00061B31
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

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00063940 File Offset: 0x00061B40
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x000639A1 File Offset: 0x00061BA1
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

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x000639B6 File Offset: 0x00061BB6
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x000639E1 File Offset: 0x00061BE1
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000639EF File Offset: 0x00061BEF
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x00063A1E File Offset: 0x00061C1E
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x00063A2C File Offset: 0x00061C2C
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x00063A5B File Offset: 0x00061C5B
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

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x00063A6C File Offset: 0x00061C6C
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x00063AA6 File Offset: 0x00061CA6
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x00063AB4 File Offset: 0x00061CB4
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x00063AEE File Offset: 0x00061CEE
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

		// Token: 0x0400193A RID: 6458
		[Nullable(2)]
		protected new ISceneTextSubtitleWithVoice FbInstance;

		// Token: 0x0400193B RID: 6459
		[Nullable(2)]
		protected new ISceneTextSubtitleWithVoice_SetValue PocoInterface;

		// Token: 0x0400193C RID: 6460
		private PlayFlow _ContentCache;

		// Token: 0x0400193D RID: 6461
		private bool _ContentInited;
	}
}
