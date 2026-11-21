using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011DD RID: 4573
	public class IQuestScheduleRoleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x06006655 RID: 26197 RVA: 0x000F6174 File Offset: 0x000F4374
		private IQuestScheduleRoleTowerChallengeTitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleRoleTowerChallengeTitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleRoleTowerChallengeTitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleRoleTowerChallengeTitle_SetValue());
			}
			return result;
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x000F61AC File Offset: 0x000F43AC
		public static IQuestScheduleRoleTowerChallengeTitle Create([Nullable(2)] IQuestScheduleRoleTowerChallengeTitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleRoleTowerChallengeTitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x000F61BF File Offset: 0x000F43BF
		public static IQuestScheduleRoleTowerChallengeTitle CreateFromSetValue([Nullable(2)] IQuestScheduleRoleTowerChallengeTitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleRoleTowerChallengeTitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x000F61D2 File Offset: 0x000F43D2
		public new IQuestScheduleRoleTowerChallengeTitle_SetValue ToSetValue()
		{
			return new IQuestScheduleRoleTowerChallengeTitle_SetValue
			{
				Type = this.Type,
				TitleType = this.TitleType
			};
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x000F61F1 File Offset: 0x000F43F1
		// (set) Token: 0x0600665A RID: 26202 RVA: 0x000F621C File Offset: 0x000F441C
		public override EQuestScheduleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EQuestScheduleType.None;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x000F622A File Offset: 0x000F442A
		// (set) Token: 0x0600665C RID: 26204 RVA: 0x000F6251 File Offset: 0x000F4451
		public virtual IRoleTowerChallengeTitleTypeBase TitleType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TitleType;
				}
				IQuestScheduleRoleTowerChallengeTitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TitleType;
			}
			set
			{
				this.GetOrCreatePoco().TitleType = value;
			}
		}

		// Token: 0x04003D61 RID: 15713
		[Nullable(2)]
		protected new IQuestScheduleRoleTowerChallengeTitle FbInstance;

		// Token: 0x04003D62 RID: 15714
		[Nullable(2)]
		protected new IQuestScheduleRoleTowerChallengeTitle_SetValue PocoInterface;
	}
}
