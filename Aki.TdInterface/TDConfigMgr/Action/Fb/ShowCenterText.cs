using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B6 RID: 9654
	[NullableContext(2)]
	[Nullable(0)]
	public class ShowCenterText : ActionParams
	{
		// Token: 0x0600D92F RID: 55599 RVA: 0x002067CE File Offset: 0x002049CE
		[NullableContext(1)]
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

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x0600D930 RID: 55600 RVA: 0x002067ED File Offset: 0x002049ED
		public virtual int TextId
		{
			get
			{
				return this.Instance.TextId;
			}
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0600D931 RID: 55601 RVA: 0x002067FA File Offset: 0x002049FA
		public virtual string TidCenterText
		{
			get
			{
				return this.Instance.TidCenterText;
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x0600D932 RID: 55602 RVA: 0x00206807 File Offset: 0x00204A07
		public virtual string PlotLineKey
		{
			get
			{
				return this.Instance.PlotLineKey;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x0600D933 RID: 55603 RVA: 0x00206814 File Offset: 0x00204A14
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

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x0600D934 RID: 55604 RVA: 0x0020684A File Offset: 0x00204A4A
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

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x0600D935 RID: 55605 RVA: 0x0020687E File Offset: 0x00204A7E
		public virtual string BgImageId
		{
			get
			{
				return this.Instance.BgImageId;
			}
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x0600D936 RID: 55606 RVA: 0x0020688C File Offset: 0x00204A8C
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

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x0600D937 RID: 55607 RVA: 0x002068C4 File Offset: 0x00204AC4
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

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x0600D938 RID: 55608 RVA: 0x002068FC File Offset: 0x00204AFC
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

		// Token: 0x040078A8 RID: 30888
		private IShowCenterText Instance;

		// Token: 0x040078A9 RID: 30889
		private ITextStyle _TextStyleCache;

		// Token: 0x040078AA RID: 30890
		private bool _TextStyleInited;
	}
}
