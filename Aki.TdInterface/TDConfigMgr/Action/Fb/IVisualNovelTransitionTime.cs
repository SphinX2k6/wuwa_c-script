using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002587 RID: 9607
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionTime : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600D79D RID: 55197 RVA: 0x00201BD3 File Offset: 0x001FFDD3
		public static IVisualNovelTransitionTime Create(IVisualNovelTransitionTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0600D79E RID: 55198 RVA: 0x00201BF2 File Offset: 0x001FFDF2
		public override EVisualNovelTransitionType Type
		{
			get
			{
				return (EVisualNovelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600D79F RID: 55199 RVA: 0x00201BFF File Offset: 0x001FFDFF
		public virtual IVisualNovelDate EndDate
		{
			get
			{
				if (this._EndDateInited)
				{
					return this._EndDateCache;
				}
				this._EndDateInited = true;
				this._EndDateCache = IVisualNovelDate.Create(this.Instance.EndDate);
				return this._EndDateCache;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600D7A0 RID: 55200 RVA: 0x00201C33 File Offset: 0x001FFE33
		public virtual int EndPeriodId
		{
			get
			{
				return this.Instance.EndPeriodId;
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600D7A1 RID: 55201 RVA: 0x00201C40 File Offset: 0x001FFE40
		public virtual bool? IsFullScreen
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFullScreen);
			}
		}

		// Token: 0x0400774D RID: 30541
		private IVisualNovelTransitionTime Instance;

		// Token: 0x0400774E RID: 30542
		[Nullable(2)]
		private IVisualNovelDate _EndDateCache;

		// Token: 0x0400774F RID: 30543
		private bool _EndDateInited;
	}
}
