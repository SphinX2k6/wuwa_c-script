using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D20 RID: 3360
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextSubtitleWithVoice : ISceneTextTypeBase
	{
		// Token: 0x06004CAD RID: 19629 RVA: 0x000BEF35 File Offset: 0x000BD135
		public static ISceneTextSubtitleWithVoice Create(ISceneTextSubtitleWithVoice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextSubtitleWithVoice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x000BEF54 File Offset: 0x000BD154
		public override ESceneTextType Type
		{
			get
			{
				return (ESceneTextType)this.Instance.Type;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06004CAF RID: 19631 RVA: 0x000BEF61 File Offset: 0x000BD161
		public virtual PlayFlow Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				this._ContentCache = PlayFlow.Create(this.Instance.Content);
				return this._ContentCache;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x000BEF95 File Offset: 0x000BD195
		public virtual int FontSize
		{
			get
			{
				return this.Instance.FontSize;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x000BEFA2 File Offset: 0x000BD1A2
		public virtual float BoxWidth
		{
			get
			{
				return this.Instance.BoxWidth;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x000BEFAF File Offset: 0x000BD1AF
		public virtual float BoxHeight
		{
			get
			{
				return this.Instance.BoxHeight;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x000BEFBC File Offset: 0x000BD1BC
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x000BEFF4 File Offset: 0x000BD1F4
		public virtual bool? AutoHide
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AutoHide);
			}
		}

		// Token: 0x04002BE5 RID: 11237
		private ISceneTextSubtitleWithVoice Instance;

		// Token: 0x04002BE6 RID: 11238
		[Nullable(2)]
		private PlayFlow _ContentCache;

		// Token: 0x04002BE7 RID: 11239
		private bool _ContentInited;
	}
}
