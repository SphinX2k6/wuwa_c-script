using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002200 RID: 8704
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowCenterText : ActionParams
	{
		// Token: 0x0600BF19 RID: 48921 RVA: 0x001B77E4 File Offset: 0x001B59E4
		[NullableContext(1)]
		private ShowCenterText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowCenterText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowCenterText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowCenterText_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x001B781C File Offset: 0x001B5A1C
		[NullableContext(1)]
		public static ShowCenterText Create([Nullable(2)] ShowCenterText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowCenterText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF1B RID: 48923 RVA: 0x001B782F File Offset: 0x001B5A2F
		[NullableContext(1)]
		public static ShowCenterText CreateFromSetValue([Nullable(2)] ShowCenterText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowCenterText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x001B7844 File Offset: 0x001B5A44
		[NullableContext(1)]
		public ShowCenterText_SetValue ToSetValue()
		{
			return new ShowCenterText_SetValue
			{
				TextId = this.TextId,
				TidCenterText = this.TidCenterText,
				PlotLineKey = this.PlotLineKey,
				TotalTime = this.TotalTime,
				TextStyle = this.TextStyle,
				BgImageId = this.BgImageId,
				IsMulLine = this.IsMulLine,
				IsManualNext = this.IsManualNext,
				IsCancelAutoLine = this.IsCancelAutoLine
			};
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x001B78C2 File Offset: 0x001B5AC2
		// (set) Token: 0x0600BF1E RID: 48926 RVA: 0x001B78ED File Offset: 0x001B5AED
		public virtual int TextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TextId;
			}
			set
			{
				this.GetOrCreatePoco().TextId = value;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x001B78FB File Offset: 0x001B5AFB
		// (set) Token: 0x0600BF20 RID: 48928 RVA: 0x001B7922 File Offset: 0x001B5B22
		public virtual string TidCenterText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidCenterText;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidCenterText;
			}
			set
			{
				this.GetOrCreatePoco().TidCenterText = value;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x001B7930 File Offset: 0x001B5B30
		// (set) Token: 0x0600BF22 RID: 48930 RVA: 0x001B7957 File Offset: 0x001B5B57
		public virtual string PlotLineKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineKey;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineKey;
			}
			set
			{
				this.GetOrCreatePoco().PlotLineKey = value;
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600BF23 RID: 48931 RVA: 0x001B7968 File Offset: 0x001B5B68
		// (set) Token: 0x0600BF24 RID: 48932 RVA: 0x001B79A2 File Offset: 0x001B5BA2
		public virtual float? TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TotalTime;
			}
			set
			{
				this.GetOrCreatePoco().TotalTime = value;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600BF25 RID: 48933 RVA: 0x001B79B0 File Offset: 0x001B5BB0
		// (set) Token: 0x0600BF26 RID: 48934 RVA: 0x001B7A11 File Offset: 0x001B5C11
		public virtual ITextStyle TextStyle
		{
			get
			{
				if (this._TextStyleInited)
				{
					return this._TextStyleCache;
				}
				this._TextStyleInited = true;
				if (this.FbInstance != null)
				{
					this._TextStyleCache = ITextStyle.Create(this.FbInstance.TextStyle);
				}
				else
				{
					ShowCenterText_SetValue pocoInterface = this.PocoInterface;
					this._TextStyleCache = ((pocoInterface != null) ? pocoInterface.TextStyle : null);
				}
				return this._TextStyleCache;
			}
			set
			{
				this.GetOrCreatePoco().TextStyle = value;
				this._TextStyleInited = false;
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600BF27 RID: 48935 RVA: 0x001B7A26 File Offset: 0x001B5C26
		// (set) Token: 0x0600BF28 RID: 48936 RVA: 0x001B7A4D File Offset: 0x001B5C4D
		public virtual string BgImageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BgImageId;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BgImageId;
			}
			set
			{
				this.GetOrCreatePoco().BgImageId = value;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600BF29 RID: 48937 RVA: 0x001B7A5C File Offset: 0x001B5C5C
		// (set) Token: 0x0600BF2A RID: 48938 RVA: 0x001B7A96 File Offset: 0x001B5C96
		public virtual bool? IsMulLine
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsMulLine;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsMulLine;
			}
			set
			{
				this.GetOrCreatePoco().IsMulLine = value;
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600BF2B RID: 48939 RVA: 0x001B7AA4 File Offset: 0x001B5CA4
		// (set) Token: 0x0600BF2C RID: 48940 RVA: 0x001B7ADE File Offset: 0x001B5CDE
		public virtual bool? IsManualNext
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsManualNext;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsManualNext;
			}
			set
			{
				this.GetOrCreatePoco().IsManualNext = value;
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600BF2D RID: 48941 RVA: 0x001B7AEC File Offset: 0x001B5CEC
		// (set) Token: 0x0600BF2E RID: 48942 RVA: 0x001B7B26 File Offset: 0x001B5D26
		public virtual bool? IsCancelAutoLine
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCancelAutoLine;
				}
				ShowCenterText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsCancelAutoLine;
			}
			set
			{
				this.GetOrCreatePoco().IsCancelAutoLine = value;
			}
		}

		// Token: 0x040071ED RID: 29165
		protected new ShowCenterText FbInstance;

		// Token: 0x040071EE RID: 29166
		protected ShowCenterText_SetValue PocoInterface;

		// Token: 0x040071EF RID: 29167
		[Nullable(1)]
		private ITextStyle _TextStyleCache;

		// Token: 0x040071F0 RID: 29168
		private bool _TextStyleInited;
	}
}
