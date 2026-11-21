using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011AD RID: 4525
	public class IQuestFailedConfig
	{
		// Token: 0x0600651F RID: 25887 RVA: 0x000F3910 File Offset: 0x000F1B10
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

		// Token: 0x06006520 RID: 25888 RVA: 0x000F3948 File Offset: 0x000F1B48
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

		// Token: 0x06006521 RID: 25889 RVA: 0x000F395B File Offset: 0x000F1B5B
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

		// Token: 0x06006522 RID: 25890 RVA: 0x000F396E File Offset: 0x000F1B6E
		public IQuestFailedConfig_SetValue ToSetValue()
		{
			return new IQuestFailedConfig_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule
			};
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006523 RID: 25891 RVA: 0x000F3984 File Offset: 0x000F1B84
		// (set) Token: 0x06006524 RID: 25892 RVA: 0x000F39BE File Offset: 0x000F1BBE
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

		// Token: 0x04003CB8 RID: 15544
		[Nullable(2)]
		protected IQuestFailedConfig FbInstance;

		// Token: 0x04003CB9 RID: 15545
		[Nullable(2)]
		protected IQuestFailedConfig_SetValue PocoInterface;
	}
}
