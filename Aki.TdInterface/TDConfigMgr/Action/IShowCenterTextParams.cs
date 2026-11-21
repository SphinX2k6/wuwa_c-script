using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208D RID: 8333
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowCenterTextParams
	{
		// Token: 0x0600B0ED RID: 45293 RVA: 0x0018DF78 File Offset: 0x0018C178
		[NullableContext(0)]
		private IShowCenterTextParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowCenterTextParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowCenterTextParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowCenterTextParams_SetValue());
			}
			return result;
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x0018DFB0 File Offset: 0x0018C1B0
		[NullableContext(0)]
		public static IShowCenterTextParams Create([Nullable(2)] IShowCenterTextParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowCenterTextParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x0018DFC3 File Offset: 0x0018C1C3
		[NullableContext(0)]
		public static IShowCenterTextParams CreateFromSetValue([Nullable(2)] IShowCenterTextParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowCenterTextParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B0F0 RID: 45296 RVA: 0x0018DFD8 File Offset: 0x0018C1D8
		[NullableContext(0)]
		public IShowCenterTextParams_SetValue ToSetValue()
		{
			return new IShowCenterTextParams_SetValue
			{
				TotalTime = this.TotalTime,
				TextStyle = this.TextStyle,
				BgImageId = this.BgImageId,
				IsMulLine = this.IsMulLine,
				IsManualNext = this.IsManualNext,
				IsCancelAutoLine = this.IsCancelAutoLine
			};
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600B0F1 RID: 45297 RVA: 0x0018E034 File Offset: 0x0018C234
		// (set) Token: 0x0600B0F2 RID: 45298 RVA: 0x0018E06E File Offset: 0x0018C26E
		public virtual float? TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				IShowCenterTextParams_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x0018E07C File Offset: 0x0018C27C
		// (set) Token: 0x0600B0F4 RID: 45300 RVA: 0x0018E0DD File Offset: 0x0018C2DD
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
					IShowCenterTextParams_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600B0F5 RID: 45301 RVA: 0x0018E0F2 File Offset: 0x0018C2F2
		// (set) Token: 0x0600B0F6 RID: 45302 RVA: 0x0018E119 File Offset: 0x0018C319
		public virtual string BgImageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BgImageId;
				}
				IShowCenterTextParams_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x0018E128 File Offset: 0x0018C328
		// (set) Token: 0x0600B0F8 RID: 45304 RVA: 0x0018E162 File Offset: 0x0018C362
		public virtual bool? IsMulLine
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsMulLine;
				}
				IShowCenterTextParams_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600B0F9 RID: 45305 RVA: 0x0018E170 File Offset: 0x0018C370
		// (set) Token: 0x0600B0FA RID: 45306 RVA: 0x0018E1AA File Offset: 0x0018C3AA
		public virtual bool? IsManualNext
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsManualNext;
				}
				IShowCenterTextParams_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600B0FB RID: 45307 RVA: 0x0018E1B8 File Offset: 0x0018C3B8
		// (set) Token: 0x0600B0FC RID: 45308 RVA: 0x0018E1F2 File Offset: 0x0018C3F2
		public virtual bool? IsCancelAutoLine
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCancelAutoLine;
				}
				IShowCenterTextParams_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400692E RID: 26926
		protected IShowCenterTextParams FbInstance;

		// Token: 0x0400692F RID: 26927
		protected IShowCenterTextParams_SetValue PocoInterface;

		// Token: 0x04006930 RID: 26928
		[Nullable(0)]
		private ITextStyle _TextStyleCache;

		// Token: 0x04006931 RID: 26929
		private bool _TextStyleInited;
	}
}
