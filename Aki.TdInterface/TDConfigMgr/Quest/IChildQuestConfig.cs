using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F0E RID: 3854
	[NullableContext(1)]
	[Nullable(0)]
	public class IChildQuestConfig
	{
		// Token: 0x0600553A RID: 21818 RVA: 0x000D102C File Offset: 0x000CF22C
		private IChildQuestConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChildQuestConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChildQuestConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChildQuestConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x000D1064 File Offset: 0x000CF264
		public static IChildQuestConfig Create([Nullable(2)] IChildQuestConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChildQuestConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x000D1077 File Offset: 0x000CF277
		public static IChildQuestConfig CreateFromSetValue([Nullable(2)] IChildQuestConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChildQuestConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x000D108A File Offset: 0x000CF28A
		public IChildQuestConfig_SetValue ToSetValue()
		{
			return new IChildQuestConfig_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule
			};
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x000D10A0 File Offset: 0x000CF2A0
		// (set) Token: 0x0600553F RID: 21823 RVA: 0x000D10DA File Offset: 0x000CF2DA
		public virtual EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlineParticipateRule;
				}
				IChildQuestConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400339A RID: 13210
		[Nullable(2)]
		protected IChildQuestConfig FbInstance;

		// Token: 0x0400339B RID: 13211
		[Nullable(2)]
		protected IChildQuestConfig_SetValue PocoInterface;
	}
}
