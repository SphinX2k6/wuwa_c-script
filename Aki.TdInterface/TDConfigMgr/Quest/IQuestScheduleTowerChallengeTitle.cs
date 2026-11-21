using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E5 RID: 4581
	public class IQuestScheduleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x0600668F RID: 26255 RVA: 0x000F696C File Offset: 0x000F4B6C
		private IQuestScheduleTowerChallengeTitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleTowerChallengeTitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleTowerChallengeTitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleTowerChallengeTitle_SetValue());
			}
			return result;
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x000F69A4 File Offset: 0x000F4BA4
		public static IQuestScheduleTowerChallengeTitle Create([Nullable(2)] IQuestScheduleTowerChallengeTitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleTowerChallengeTitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x000F69B7 File Offset: 0x000F4BB7
		public static IQuestScheduleTowerChallengeTitle CreateFromSetValue([Nullable(2)] IQuestScheduleTowerChallengeTitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleTowerChallengeTitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x000F69CA File Offset: 0x000F4BCA
		public new IQuestScheduleTowerChallengeTitle_SetValue ToSetValue()
		{
			return new IQuestScheduleTowerChallengeTitle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006693 RID: 26259 RVA: 0x000F69DD File Offset: 0x000F4BDD
		// (set) Token: 0x06006694 RID: 26260 RVA: 0x000F6A08 File Offset: 0x000F4C08
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

		// Token: 0x04003D82 RID: 15746
		[Nullable(2)]
		protected new IQuestScheduleTowerChallengeTitle FbInstance;

		// Token: 0x04003D83 RID: 15747
		[Nullable(2)]
		protected new IQuestScheduleTowerChallengeTitle_SetValue PocoInterface;
	}
}
