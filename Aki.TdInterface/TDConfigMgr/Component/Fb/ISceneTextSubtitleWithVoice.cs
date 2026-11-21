using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1A RID: 3610
	public class ISceneTextSubtitleWithVoice : ISceneTextTypeBase
	{
		// Token: 0x060051C7 RID: 20935 RVA: 0x000CA609 File Offset: 0x000C8809
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

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x000CA628 File Offset: 0x000C8828
		public override ESceneTextType Type
		{
			get
			{
				return (ESceneTextType)this.Instance.Type;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x000CA635 File Offset: 0x000C8835
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

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x000CA669 File Offset: 0x000C8869
		public virtual int FontSize
		{
			get
			{
				return this.Instance.FontSize;
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x000CA676 File Offset: 0x000C8876
		public virtual float BoxWidth
		{
			get
			{
				return this.Instance.BoxWidth;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x000CA683 File Offset: 0x000C8883
		public virtual float BoxHeight
		{
			get
			{
				return this.Instance.BoxHeight;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x000CA690 File Offset: 0x000C8890
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

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x000CA6C8 File Offset: 0x000C88C8
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

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x000CA700 File Offset: 0x000C8900
		public virtual ESceneTextFadeInEffect? FadeInEffect
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new ESceneTextFadeInEffect?((ESceneTextFadeInEffect)this.Instance.FadeInEffect);
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x000CA738 File Offset: 0x000C8938
		public virtual ESceneTextFadeOutEffect? FadeOutEffect
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new ESceneTextFadeOutEffect?((ESceneTextFadeOutEffect)this.Instance.FadeOutEffect);
			}
		}

		// Token: 0x04002EA5 RID: 11941
		private ISceneTextSubtitleWithVoice Instance;

		// Token: 0x04002EA6 RID: 11942
		[Nullable(2)]
		private PlayFlow _ContentCache;

		// Token: 0x04002EA7 RID: 11943
		private bool _ContentInited;
	}
}
