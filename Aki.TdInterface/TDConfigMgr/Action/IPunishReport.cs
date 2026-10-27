using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D68 RID: 7528
	[NullableContext(1)]
	[Nullable(0)]
	public class IPunishReport : ICommonTipType
	{
		// Token: 0x0600A16B RID: 41323 RVA: 0x0016FB3C File Offset: 0x0016DD3C
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

		// Token: 0x0600A16C RID: 41324 RVA: 0x0016FB74 File Offset: 0x0016DD74
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

		// Token: 0x0600A16D RID: 41325 RVA: 0x0016FB87 File Offset: 0x0016DD87
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

		// Token: 0x0600A16E RID: 41326 RVA: 0x0016FB9A File Offset: 0x0016DD9A
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

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A16F RID: 41327 RVA: 0x0016FBD1 File Offset: 0x0016DDD1
		// (set) Token: 0x0600A170 RID: 41328 RVA: 0x0016FBFC File Offset: 0x0016DDFC
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

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A171 RID: 41329 RVA: 0x0016FC0A File Offset: 0x0016DE0A
		// (set) Token: 0x0600A172 RID: 41330 RVA: 0x0016FC35 File Offset: 0x0016DE35
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

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A173 RID: 41331 RVA: 0x0016FC43 File Offset: 0x0016DE43
		// (set) Token: 0x0600A174 RID: 41332 RVA: 0x0016FC6E File Offset: 0x0016DE6E
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

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0016FC7C File Offset: 0x0016DE7C
		// (set) Token: 0x0600A176 RID: 41334 RVA: 0x0016FCB6 File Offset: 0x0016DEB6
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

		// Token: 0x04006121 RID: 24865
		[Nullable(2)]
		protected new IPunishReport FbInstance;

		// Token: 0x04006122 RID: 24866
		[Nullable(2)]
		protected new IPunishReport_SetValue PocoInterface;
	}
}
