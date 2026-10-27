using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010AF RID: 4271
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleRoleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x0600605C RID: 24668 RVA: 0x000E9054 File Offset: 0x000E7254
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

		// Token: 0x0600605D RID: 24669 RVA: 0x000E908C File Offset: 0x000E728C
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

		// Token: 0x0600605E RID: 24670 RVA: 0x000E909F File Offset: 0x000E729F
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

		// Token: 0x0600605F RID: 24671 RVA: 0x000E90B2 File Offset: 0x000E72B2
		public new IQuestScheduleRoleTowerChallengeTitle_SetValue ToSetValue()
		{
			return new IQuestScheduleRoleTowerChallengeTitle_SetValue
			{
				Type = this.Type,
				TitleType = this.TitleType
			};
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x000E90D1 File Offset: 0x000E72D1
		// (set) Token: 0x06006061 RID: 24673 RVA: 0x000E90FC File Offset: 0x000E72FC
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

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x000E910A File Offset: 0x000E730A
		// (set) Token: 0x06006063 RID: 24675 RVA: 0x000E9131 File Offset: 0x000E7331
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

		// Token: 0x04003A14 RID: 14868
		[Nullable(2)]
		protected new IQuestScheduleRoleTowerChallengeTitle FbInstance;

		// Token: 0x04003A15 RID: 14869
		[Nullable(2)]
		protected new IQuestScheduleRoleTowerChallengeTitle_SetValue PocoInterface;
	}
}
