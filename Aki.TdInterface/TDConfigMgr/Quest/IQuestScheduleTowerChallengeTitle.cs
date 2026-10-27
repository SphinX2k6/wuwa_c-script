using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B7 RID: 4279
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x06006096 RID: 24726 RVA: 0x000E984C File Offset: 0x000E7A4C
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

		// Token: 0x06006097 RID: 24727 RVA: 0x000E9884 File Offset: 0x000E7A84
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

		// Token: 0x06006098 RID: 24728 RVA: 0x000E9897 File Offset: 0x000E7A97
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

		// Token: 0x06006099 RID: 24729 RVA: 0x000E98AA File Offset: 0x000E7AAA
		public new IQuestScheduleTowerChallengeTitle_SetValue ToSetValue()
		{
			return new IQuestScheduleTowerChallengeTitle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x000E98BD File Offset: 0x000E7ABD
		// (set) Token: 0x0600609B RID: 24731 RVA: 0x000E98E8 File Offset: 0x000E7AE8
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

		// Token: 0x04003A35 RID: 14901
		[Nullable(2)]
		protected new IQuestScheduleTowerChallengeTitle FbInstance;

		// Token: 0x04003A36 RID: 14902
		[Nullable(2)]
		protected new IQuestScheduleTowerChallengeTitle_SetValue PocoInterface;
	}
}
