using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E58 RID: 7768
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowCenterTextParams
	{
		// Token: 0x0600A635 RID: 42549 RVA: 0x00178278 File Offset: 0x00176478
		[NullableContext(1)]
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

		// Token: 0x0600A636 RID: 42550 RVA: 0x001782B0 File Offset: 0x001764B0
		[NullableContext(1)]
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

		// Token: 0x0600A637 RID: 42551 RVA: 0x001782C3 File Offset: 0x001764C3
		[NullableContext(1)]
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

		// Token: 0x0600A638 RID: 42552 RVA: 0x001782D8 File Offset: 0x001764D8
		[NullableContext(1)]
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

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600A639 RID: 42553 RVA: 0x00178334 File Offset: 0x00176534
		// (set) Token: 0x0600A63A RID: 42554 RVA: 0x0017836E File Offset: 0x0017656E
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

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x0017837C File Offset: 0x0017657C
		// (set) Token: 0x0600A63C RID: 42556 RVA: 0x001783DD File Offset: 0x001765DD
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

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x001783F2 File Offset: 0x001765F2
		// (set) Token: 0x0600A63E RID: 42558 RVA: 0x00178419 File Offset: 0x00176619
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

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x00178428 File Offset: 0x00176628
		// (set) Token: 0x0600A640 RID: 42560 RVA: 0x00178462 File Offset: 0x00176662
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

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600A641 RID: 42561 RVA: 0x00178470 File Offset: 0x00176670
		// (set) Token: 0x0600A642 RID: 42562 RVA: 0x001784AA File Offset: 0x001766AA
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

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600A643 RID: 42563 RVA: 0x001784B8 File Offset: 0x001766B8
		// (set) Token: 0x0600A644 RID: 42564 RVA: 0x001784F2 File Offset: 0x001766F2
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

		// Token: 0x0400634A RID: 25418
		protected IShowCenterTextParams FbInstance;

		// Token: 0x0400634B RID: 25419
		protected IShowCenterTextParams_SetValue PocoInterface;

		// Token: 0x0400634C RID: 25420
		[Nullable(1)]
		private ITextStyle _TextStyleCache;

		// Token: 0x0400634D RID: 25421
		private bool _TextStyleInited;
	}
}
