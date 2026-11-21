using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002865 RID: 10341
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowCenterText : ActionParams
	{
		// Token: 0x0600E6A9 RID: 59049 RVA: 0x002224A2 File Offset: 0x002206A2
		[NullableContext(0)]
		public static ShowCenterText Create(IShowCenterText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowCenterText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x0600E6AA RID: 59050 RVA: 0x002224C1 File Offset: 0x002206C1
		public virtual int TextId
		{
			get
			{
				return this.Instance.TextId;
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x002224CE File Offset: 0x002206CE
		public virtual string TidCenterText
		{
			get
			{
				return this.Instance.TidCenterText;
			}
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x002224DB File Offset: 0x002206DB
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x0600E6AD RID: 59053 RVA: 0x002224E8 File Offset: 0x002206E8
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

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0022251E File Offset: 0x0022071E
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

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x0600E6AF RID: 59055 RVA: 0x00222552 File Offset: 0x00220752
		public virtual string BgImageId
		{
			get
			{
				return this.Instance.BgImageId;
			}
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x00222560 File Offset: 0x00220760
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

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x00222598 File Offset: 0x00220798
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

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x0600E6B2 RID: 59058 RVA: 0x002225D0 File Offset: 0x002207D0
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

		// Token: 0x04007F0F RID: 32527
		private IShowCenterText Instance;

		// Token: 0x04007F10 RID: 32528
		private ITextStyle _TextStyleCache;

		// Token: 0x04007F11 RID: 32529
		private bool _TextStyleInited;
	}
}
