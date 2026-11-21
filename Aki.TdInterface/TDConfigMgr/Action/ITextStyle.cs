using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FF RID: 8703
	public class ITextStyle
	{
		// Token: 0x0600BDB2 RID: 48562 RVA: 0x001B6930 File Offset: 0x001B4B30
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

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x001B6968 File Offset: 0x001B4B68
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

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x001B697B File Offset: 0x001B4B7B
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

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x001B698E File Offset: 0x001B4B8E
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

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600BDB6 RID: 48566 RVA: 0x001B69C5 File Offset: 0x001B4BC5
		// (set) Token: 0x0600BDB7 RID: 48567 RVA: 0x001B69EC File Offset: 0x001B4BEC
		[Nullable(2)]
		public virtual ICenterTextShowType ShowAnim
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ShowAnim = value;
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600BDB8 RID: 48568 RVA: 0x001B69FC File Offset: 0x001B4BFC
		// (set) Token: 0x0600BDB9 RID: 48569 RVA: 0x001B6A36 File Offset: 0x001B4C36
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

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600BDBA RID: 48570 RVA: 0x001B6A44 File Offset: 0x001B4C44
		// (set) Token: 0x0600BDBB RID: 48571 RVA: 0x001B6A7E File Offset: 0x001B4C7E
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

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x001B6A8C File Offset: 0x001B4C8C
		// (set) Token: 0x0600BDBD RID: 48573 RVA: 0x001B6AC6 File Offset: 0x001B4CC6
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

		// Token: 0x040071E1 RID: 29153
		[Nullable(2)]
		protected ITextStyle FbInstance;

		// Token: 0x040071E2 RID: 29154
		[Nullable(2)]
		protected ITextStyle_SetValue PocoInterface;
	}
}
