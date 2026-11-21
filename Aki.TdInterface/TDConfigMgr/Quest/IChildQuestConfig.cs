using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001024 RID: 4132
	public class IChildQuestConfig
	{
		// Token: 0x06005AB6 RID: 23222 RVA: 0x000DD1D4 File Offset: 0x000DB3D4
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

		// Token: 0x06005AB7 RID: 23223 RVA: 0x000DD20C File Offset: 0x000DB40C
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

		// Token: 0x06005AB8 RID: 23224 RVA: 0x000DD21F File Offset: 0x000DB41F
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

		// Token: 0x06005AB9 RID: 23225 RVA: 0x000DD232 File Offset: 0x000DB432
		public IChildQuestConfig_SetValue ToSetValue()
		{
			return new IChildQuestConfig_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule
			};
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06005ABA RID: 23226 RVA: 0x000DD248 File Offset: 0x000DB448
		// (set) Token: 0x06005ABB RID: 23227 RVA: 0x000DD282 File Offset: 0x000DB482
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

		// Token: 0x040036A7 RID: 13991
		[Nullable(2)]
		protected IChildQuestConfig FbInstance;

		// Token: 0x040036A8 RID: 13992
		[Nullable(2)]
		protected IChildQuestConfig_SetValue PocoInterface;
	}
}
