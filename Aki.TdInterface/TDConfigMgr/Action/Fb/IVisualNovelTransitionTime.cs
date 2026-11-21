using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002835 RID: 10293
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelTransitionTime : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600E517 RID: 58647 RVA: 0x0021D907 File Offset: 0x0021BB07
		[NullableContext(0)]
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

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x0600E518 RID: 58648 RVA: 0x0021D926 File Offset: 0x0021BB26
		public override EVisualNovelTransitionType Type
		{
			get
			{
				return (EVisualNovelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x0600E519 RID: 58649 RVA: 0x0021D933 File Offset: 0x0021BB33
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

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x0021D967 File Offset: 0x0021BB67
		public virtual int EndPeriodId
		{
			get
			{
				return this.Instance.EndPeriodId;
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x0600E51B RID: 58651 RVA: 0x0021D974 File Offset: 0x0021BB74
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

		// Token: 0x04007DB3 RID: 32179
		private IVisualNovelTransitionTime Instance;

		// Token: 0x04007DB4 RID: 32180
		private IVisualNovelDate _EndDateCache;

		// Token: 0x04007DB5 RID: 32181
		private bool _EndDateInited;
	}
}
