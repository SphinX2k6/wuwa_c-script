using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002754 RID: 10068
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoraleAreaTip : ICommonTipType
	{
		// Token: 0x0600E04B RID: 57419 RVA: 0x00212E7A File Offset: 0x0021107A
		public static IMoraleAreaTip Create(IMoraleAreaTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoraleAreaTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x0600E04C RID: 57420 RVA: 0x00212E99 File Offset: 0x00211099
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x0600E04D RID: 57421 RVA: 0x00212EA6 File Offset: 0x002110A6
		public virtual string TidAreaNameText
		{
			get
			{
				return this.Instance.TidAreaNameText;
			}
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x0600E04E RID: 57422 RVA: 0x00212EB3 File Offset: 0x002110B3
		public virtual string TidRecommendText
		{
			get
			{
				return this.Instance.TidRecommendText;
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x0600E04F RID: 57423 RVA: 0x00212EC0 File Offset: 0x002110C0
		public virtual EMoraleAreaType AreaType
		{
			get
			{
				return (EMoraleAreaType)this.Instance.AreaType;
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x0600E050 RID: 57424 RVA: 0x00212ED0 File Offset: 0x002110D0
		public virtual EMoraleUiType? UiType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EMoraleUiType?((EMoraleUiType)this.Instance.UiType);
			}
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0600E051 RID: 57425 RVA: 0x00212F06 File Offset: 0x00211106
		[Nullable(2)]
		public virtual string EdTidAreaNameText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x0600E052 RID: 57426 RVA: 0x00212F09 File Offset: 0x00211109
		[Nullable(2)]
		public virtual string EdTidRecommendText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C52 RID: 31826
		private IMoraleAreaTip Instance;
	}
}
