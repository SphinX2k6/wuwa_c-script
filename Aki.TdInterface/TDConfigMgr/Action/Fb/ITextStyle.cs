using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002994 RID: 10644
	public class ITextStyle
	{
		// Token: 0x0600EBF9 RID: 60409 RVA: 0x0022BE9D File Offset: 0x0022A09D
		public static ITextStyle Create(ITextStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITextStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x0600EBFA RID: 60410 RVA: 0x0022BEBC File Offset: 0x0022A0BC
		public virtual ICenterTextShowType ShowAnim
		{
			get
			{
				if (this._ShowAnimInited)
				{
					return this._ShowAnimCache;
				}
				this._ShowAnimInited = true;
				this._ShowAnimCache = ActionReadHelper.ReadITextStyle_ShowAnim(this.Instance);
				return this._ShowAnimCache;
			}
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x0600EBFB RID: 60411 RVA: 0x0022BEEC File Offset: 0x0022A0EC
		public virtual EFontSize? FontSize
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EFontSize?((EFontSize)this.Instance.FontSize);
			}
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x0600EBFC RID: 60412 RVA: 0x0022BF24 File Offset: 0x0022A124
		public virtual ETextAlign? TextAlign
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new ETextAlign?((ETextAlign)this.Instance.TextAlign);
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x0600EBFD RID: 60413 RVA: 0x0022BF5C File Offset: 0x0022A15C
		public virtual ETextHorizontal? TextHorizontal
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new ETextHorizontal?((ETextHorizontal)this.Instance.TextHorizontal);
			}
		}

		// Token: 0x040081EE RID: 33262
		private ITextStyle Instance;

		// Token: 0x040081EF RID: 33263
		private ICenterTextShowType _ShowAnimCache;

		// Token: 0x040081F0 RID: 33264
		private bool _ShowAnimInited;
	}
}
