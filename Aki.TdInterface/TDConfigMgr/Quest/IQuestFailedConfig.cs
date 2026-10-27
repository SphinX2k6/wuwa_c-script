using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200107F RID: 4223
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConfig
	{
		// Token: 0x06005F26 RID: 24358 RVA: 0x000E67F0 File Offset: 0x000E49F0
		private IQuestFailedConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestFailedConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestFailedConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestFailedConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x000E6828 File Offset: 0x000E4A28
		public static IQuestFailedConfig Create([Nullable(2)] IQuestFailedConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x000E683B File Offset: 0x000E4A3B
		public static IQuestFailedConfig CreateFromSetValue([Nullable(2)] IQuestFailedConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestFailedConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x000E684E File Offset: 0x000E4A4E
		public IQuestFailedConfig_SetValue ToSetValue()
		{
			return new IQuestFailedConfig_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule
			};
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x000E6864 File Offset: 0x000E4A64
		// (set) Token: 0x06005F2B RID: 24363 RVA: 0x000E689E File Offset: 0x000E4A9E
		public virtual EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlineParticipateRule;
				}
				IQuestFailedConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlineParticipateRule;
			}
			set
			{
				this.GetOrCreatePoco().OnlineParticipateRule = value;
			}
		}

		// Token: 0x0400396B RID: 14699
		[Nullable(2)]
		protected IQuestFailedConfig FbInstance;

		// Token: 0x0400396C RID: 14700
		[Nullable(2)]
		protected IQuestFailedConfig_SetValue PocoInterface;
	}
}
