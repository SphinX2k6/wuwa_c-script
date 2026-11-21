using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002864 RID: 10340
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowCenterTextParams
	{
		// Token: 0x0600E6A1 RID: 59041 RVA: 0x0022235B File Offset: 0x0022055B
		[NullableContext(0)]
		public static IShowCenterTextParams Create(IShowCenterTextParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowCenterTextParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x0600E6A2 RID: 59042 RVA: 0x0022237C File Offset: 0x0022057C
		public virtual float? TotalTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TotalTime);
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x0600E6A3 RID: 59043 RVA: 0x002223B2 File Offset: 0x002205B2
		public virtual ITextStyle TextStyle
		{
			get
			{
				if (this._TextStyleInited)
				{
					return this._TextStyleCache;
				}
				this._TextStyleInited = true;
				this._TextStyleCache = ITextStyle.Create(this.Instance.TextStyle);
				return this._TextStyleCache;
			}
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x0600E6A4 RID: 59044 RVA: 0x002223E6 File Offset: 0x002205E6
		public virtual string BgImageId
		{
			get
			{
				return this.Instance.BgImageId;
			}
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x0600E6A5 RID: 59045 RVA: 0x002223F4 File Offset: 0x002205F4
		public virtual bool? IsMulLine
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsMulLine);
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x0600E6A6 RID: 59046 RVA: 0x0022242C File Offset: 0x0022062C
		public virtual bool? IsManualNext
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsManualNext);
			}
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x0600E6A7 RID: 59047 RVA: 0x00222464 File Offset: 0x00220664
		public virtual bool? IsCancelAutoLine
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsCancelAutoLine);
			}
		}

		// Token: 0x04007F0C RID: 32524
		private IShowCenterTextParams Instance;

		// Token: 0x04007F0D RID: 32525
		private ITextStyle _TextStyleCache;

		// Token: 0x04007F0E RID: 32526
		private bool _TextStyleInited;
	}
}
