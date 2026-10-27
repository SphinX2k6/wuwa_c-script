using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B5 RID: 9653
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowCenterTextParams
	{
		// Token: 0x0600D927 RID: 55591 RVA: 0x00206687 File Offset: 0x00204887
		[NullableContext(1)]
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

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x0600D928 RID: 55592 RVA: 0x002066A8 File Offset: 0x002048A8
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

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0600D929 RID: 55593 RVA: 0x002066DE File Offset: 0x002048DE
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

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x0600D92A RID: 55594 RVA: 0x00206712 File Offset: 0x00204912
		public virtual string BgImageId
		{
			get
			{
				return this.Instance.BgImageId;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0600D92B RID: 55595 RVA: 0x00206720 File Offset: 0x00204920
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

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0600D92C RID: 55596 RVA: 0x00206758 File Offset: 0x00204958
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

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0600D92D RID: 55597 RVA: 0x00206790 File Offset: 0x00204990
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

		// Token: 0x040078A5 RID: 30885
		private IShowCenterTextParams Instance;

		// Token: 0x040078A6 RID: 30886
		private ITextStyle _TextStyleCache;

		// Token: 0x040078A7 RID: 30887
		private bool _TextStyleInited;
	}
}
