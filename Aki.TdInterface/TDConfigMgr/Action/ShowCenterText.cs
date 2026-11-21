using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246B RID: 9323
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowCenterText : ActionParams
	{
		// Token: 0x0600CAD5 RID: 51925 RVA: 0x001CEE70 File Offset: 0x001CD070
		[NullableContext(0)]
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

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x001CEEA8 File Offset: 0x001CD0A8
		[NullableContext(0)]
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

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x001CEEBB File Offset: 0x001CD0BB
		[NullableContext(0)]
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

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x001CEED0 File Offset: 0x001CD0D0
		[NullableContext(0)]
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

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0600CAD9 RID: 51929 RVA: 0x001CEF4E File Offset: 0x001CD14E
		// (set) Token: 0x0600CADA RID: 51930 RVA: 0x001CEF79 File Offset: 0x001CD179
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

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600CADB RID: 51931 RVA: 0x001CEF87 File Offset: 0x001CD187
		// (set) Token: 0x0600CADC RID: 51932 RVA: 0x001CEFAE File Offset: 0x001CD1AE
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

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600CADD RID: 51933 RVA: 0x001CEFBC File Offset: 0x001CD1BC
		// (set) Token: 0x0600CADE RID: 51934 RVA: 0x001CEFE3 File Offset: 0x001CD1E3
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

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600CADF RID: 51935 RVA: 0x001CEFF4 File Offset: 0x001CD1F4
		// (set) Token: 0x0600CAE0 RID: 51936 RVA: 0x001CF02E File Offset: 0x001CD22E
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

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600CAE1 RID: 51937 RVA: 0x001CF03C File Offset: 0x001CD23C
		// (set) Token: 0x0600CAE2 RID: 51938 RVA: 0x001CF09D File Offset: 0x001CD29D
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

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600CAE3 RID: 51939 RVA: 0x001CF0B2 File Offset: 0x001CD2B2
		// (set) Token: 0x0600CAE4 RID: 51940 RVA: 0x001CF0D9 File Offset: 0x001CD2D9
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

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600CAE5 RID: 51941 RVA: 0x001CF0E8 File Offset: 0x001CD2E8
		// (set) Token: 0x0600CAE6 RID: 51942 RVA: 0x001CF122 File Offset: 0x001CD322
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

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600CAE7 RID: 51943 RVA: 0x001CF130 File Offset: 0x001CD330
		// (set) Token: 0x0600CAE8 RID: 51944 RVA: 0x001CF16A File Offset: 0x001CD36A
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

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600CAE9 RID: 51945 RVA: 0x001CF178 File Offset: 0x001CD378
		// (set) Token: 0x0600CAEA RID: 51946 RVA: 0x001CF1B2 File Offset: 0x001CD3B2
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

		// Token: 0x04007836 RID: 30774
		protected new ShowCenterText FbInstance;

		// Token: 0x04007837 RID: 30775
		protected ShowCenterText_SetValue PocoInterface;

		// Token: 0x04007838 RID: 30776
		[Nullable(0)]
		private ITextStyle _TextStyleCache;

		// Token: 0x04007839 RID: 30777
		private bool _TextStyleInited;
	}
}
