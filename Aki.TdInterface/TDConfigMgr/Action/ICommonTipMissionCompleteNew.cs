using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA9 RID: 6825
	public class ICommonTipMissionCompleteNew : ICommonTipType
	{
		// Token: 0x06009111 RID: 37137 RVA: 0x00154C68 File Offset: 0x00152E68
		private ICommonTipMissionCompleteNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipMissionCompleteNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipMissionCompleteNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipMissionCompleteNew_SetValue());
			}
			return result;
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x00154CA0 File Offset: 0x00152EA0
		public static ICommonTipMissionCompleteNew Create([Nullable(2)] ICommonTipMissionCompleteNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipMissionCompleteNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x00154CB3 File Offset: 0x00152EB3
		public static ICommonTipMissionCompleteNew CreateFromSetValue([Nullable(2)] ICommonTipMissionCompleteNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipMissionCompleteNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x00154CC6 File Offset: 0x00152EC6
		public new ICommonTipMissionCompleteNew_SetValue ToSetValue()
		{
			return new ICommonTipMissionCompleteNew_SetValue
			{
				Type = this.Type,
				QuestType = this.QuestType,
				TipTextKey = this.TipTextKey
			};
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x06009115 RID: 37141 RVA: 0x00154CF1 File Offset: 0x00152EF1
		// (set) Token: 0x06009116 RID: 37142 RVA: 0x00154D1C File Offset: 0x00152F1C
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

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x00154D2A File Offset: 0x00152F2A
		// (set) Token: 0x06009118 RID: 37144 RVA: 0x00154D55 File Offset: 0x00152F55
		public virtual EQuestCommonTipType QuestType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestType;
				}
				if (this.PocoInterface == null)
				{
					return EQuestCommonTipType.Branch;
				}
				return this.PocoInterface.QuestType;
			}
			set
			{
				this.GetOrCreatePoco().QuestType = value;
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x06009119 RID: 37145 RVA: 0x00154D63 File Offset: 0x00152F63
		// (set) Token: 0x0600911A RID: 37146 RVA: 0x00154D8E File Offset: 0x00152F8E
		public virtual string TipTextKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TipTextKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TipTextKey;
			}
			set
			{
				this.GetOrCreatePoco().TipTextKey = value;
			}
		}

		// Token: 0x04005A9E RID: 23198
		[Nullable(2)]
		protected new ICommonTipMissionCompleteNew FbInstance;

		// Token: 0x04005A9F RID: 23199
		[Nullable(2)]
		protected new ICommonTipMissionCompleteNew_SetValue PocoInterface;
	}
}
