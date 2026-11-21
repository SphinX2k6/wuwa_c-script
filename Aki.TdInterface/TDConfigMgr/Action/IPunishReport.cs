using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F79 RID: 8057
	public class IPunishReport : ICommonTipType
	{
		// Token: 0x0600AB57 RID: 43863 RVA: 0x00183F60 File Offset: 0x00182160
		private IPunishReport_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPunishReport 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPunishReport_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPunishReport_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x00183F98 File Offset: 0x00182198
		public static IPunishReport Create([Nullable(2)] IPunishReport instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPunishReport
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x00183FAB File Offset: 0x001821AB
		public static IPunishReport CreateFromSetValue([Nullable(2)] IPunishReport_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPunishReport
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x00183FBE File Offset: 0x001821BE
		public new IPunishReport_SetValue ToSetValue()
		{
			return new IPunishReport_SetValue
			{
				Type = this.Type,
				MainText = this.MainText,
				SubText = this.SubText,
				ShowType = this.ShowType
			};
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600AB5B RID: 43867 RVA: 0x00183FF5 File Offset: 0x001821F5
		// (set) Token: 0x0600AB5C RID: 43868 RVA: 0x00184020 File Offset: 0x00182220
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600AB5D RID: 43869 RVA: 0x0018402E File Offset: 0x0018222E
		// (set) Token: 0x0600AB5E RID: 43870 RVA: 0x00184059 File Offset: 0x00182259
		public virtual string MainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MainText;
			}
			set
			{
				this.GetOrCreatePoco().MainText = value;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600AB5F RID: 43871 RVA: 0x00184067 File Offset: 0x00182267
		// (set) Token: 0x0600AB60 RID: 43872 RVA: 0x00184092 File Offset: 0x00182292
		public virtual string SubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubText;
			}
			set
			{
				this.GetOrCreatePoco().SubText = value;
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600AB61 RID: 43873 RVA: 0x001840A0 File Offset: 0x001822A0
		// (set) Token: 0x0600AB62 RID: 43874 RVA: 0x001840DA File Offset: 0x001822DA
		public virtual EPunishReportShowType? ShowType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowType;
				}
				IPunishReport_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowType;
			}
			set
			{
				this.GetOrCreatePoco().ShowType = value;
			}
		}

		// Token: 0x0400669D RID: 26269
		[Nullable(2)]
		protected new IPunishReport FbInstance;

		// Token: 0x0400669E RID: 26270
		[Nullable(2)]
		protected new IPunishReport_SetValue PocoInterface;
	}
}
