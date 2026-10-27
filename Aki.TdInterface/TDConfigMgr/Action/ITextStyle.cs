using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBC RID: 8124
	[NullableContext(2)]
	[Nullable(0)]
	public class ITextStyle
	{
		// Token: 0x0600B2AE RID: 45742 RVA: 0x001A0580 File Offset: 0x0019E780
		[NullableContext(1)]
		private ITextStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITextStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITextStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITextStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x001A05B8 File Offset: 0x0019E7B8
		[NullableContext(1)]
		public static ITextStyle Create([Nullable(2)] ITextStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITextStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x001A05CB File Offset: 0x0019E7CB
		[NullableContext(1)]
		public static ITextStyle CreateFromSetValue([Nullable(2)] ITextStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITextStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x001A05DE File Offset: 0x0019E7DE
		[NullableContext(1)]
		public ITextStyle_SetValue ToSetValue()
		{
			return new ITextStyle_SetValue
			{
				ShowAnim = this.ShowAnim,
				FontSize = this.FontSize,
				TextAlign = this.TextAlign,
				TextHorizontal = this.TextHorizontal
			};
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600B2B2 RID: 45746 RVA: 0x001A0615 File Offset: 0x0019E815
		// (set) Token: 0x0600B2B3 RID: 45747 RVA: 0x001A063C File Offset: 0x0019E83C
		public virtual ICenterTextShowType ShowAnim
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowAnim;
				}
				ITextStyle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowAnim;
			}
			set
			{
				this.GetOrCreatePoco().ShowAnim = value;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600B2B4 RID: 45748 RVA: 0x001A064C File Offset: 0x0019E84C
		// (set) Token: 0x0600B2B5 RID: 45749 RVA: 0x001A0686 File Offset: 0x0019E886
		public virtual EFontSize? FontSize
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FontSize;
				}
				ITextStyle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FontSize;
			}
			set
			{
				this.GetOrCreatePoco().FontSize = value;
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600B2B6 RID: 45750 RVA: 0x001A0694 File Offset: 0x0019E894
		// (set) Token: 0x0600B2B7 RID: 45751 RVA: 0x001A06CE File Offset: 0x0019E8CE
		public virtual ETextAlign? TextAlign
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextAlign;
				}
				ITextStyle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextAlign;
			}
			set
			{
				this.GetOrCreatePoco().TextAlign = value;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600B2B8 RID: 45752 RVA: 0x001A06DC File Offset: 0x0019E8DC
		// (set) Token: 0x0600B2B9 RID: 45753 RVA: 0x001A0716 File Offset: 0x0019E916
		public virtual ETextHorizontal? TextHorizontal
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextHorizontal;
				}
				ITextStyle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextHorizontal;
			}
			set
			{
				this.GetOrCreatePoco().TextHorizontal = value;
			}
		}

		// Token: 0x04006BE6 RID: 27622
		protected ITextStyle FbInstance;

		// Token: 0x04006BE7 RID: 27623
		protected ITextStyle_SetValue PocoInterface;
	}
}
