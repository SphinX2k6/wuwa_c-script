using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1F RID: 10783
	public class IPunishReport : ICommonTipType
	{
		// Token: 0x0600EE45 RID: 60997 RVA: 0x0022F92E File Offset: 0x0022DB2E
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

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x0600EE46 RID: 60998 RVA: 0x0022F94D File Offset: 0x0022DB4D
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x0600EE47 RID: 60999 RVA: 0x0022F95A File Offset: 0x0022DB5A
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x0600EE48 RID: 61000 RVA: 0x0022F967 File Offset: 0x0022DB67
		public virtual string SubText
		{
			get
			{
				return this.Instance.SubText;
			}
		}

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x0600EE49 RID: 61001 RVA: 0x0022F974 File Offset: 0x0022DB74
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

		// Token: 0x040082FF RID: 33535
		private IPunishReport Instance;
	}
}
