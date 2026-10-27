using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002753 RID: 10067
	[NullableContext(1)]
	[Nullable(0)]
	public class IPunishReport : ICommonTipType
	{
		// Token: 0x0600E045 RID: 57413 RVA: 0x00212DF6 File Offset: 0x00210FF6
		public static IPunishReport Create(IPunishReport? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPunishReport
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x0600E046 RID: 57414 RVA: 0x00212E15 File Offset: 0x00211015
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x0600E047 RID: 57415 RVA: 0x00212E22 File Offset: 0x00211022
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x0600E048 RID: 57416 RVA: 0x00212E2F File Offset: 0x0021102F
		public virtual string SubText
		{
			get
			{
				return this.Instance.SubText;
			}
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x0600E049 RID: 57417 RVA: 0x00212E3C File Offset: 0x0021103C
		public virtual EPunishReportShowType? ShowType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPunishReportShowType?((EPunishReportShowType)this.Instance.ShowType);
			}
		}

		// Token: 0x04007C51 RID: 31825
		private IPunishReport Instance;
	}
}
