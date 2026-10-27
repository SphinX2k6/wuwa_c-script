using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D0 RID: 9936
	[NullableContext(1)]
	[Nullable(0)]
	public class ITextStyle
	{
		// Token: 0x0600DE1D RID: 56861 RVA: 0x0020F65D File Offset: 0x0020D85D
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

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x0600DE1E RID: 56862 RVA: 0x0020F67C File Offset: 0x0020D87C
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

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x0600DE1F RID: 56863 RVA: 0x0020F6AC File Offset: 0x0020D8AC
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

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x0020F6E4 File Offset: 0x0020D8E4
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

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x0020F71C File Offset: 0x0020D91C
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

		// Token: 0x04007B4E RID: 31566
		private ITextStyle Instance;

		// Token: 0x04007B4F RID: 31567
		private ICenterTextShowType _ShowAnimCache;

		// Token: 0x04007B50 RID: 31568
		private bool _ShowAnimInited;
	}
}
