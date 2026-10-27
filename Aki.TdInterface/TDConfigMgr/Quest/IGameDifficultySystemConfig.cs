using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F9F RID: 3999
	[NullableContext(1)]
	[Nullable(0)]
	public class IGameDifficultySystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005918 RID: 22808 RVA: 0x000D932C File Offset: 0x000D752C
		private IGameDifficultySystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGameDifficultySystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGameDifficultySystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGameDifficultySystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x000D9364 File Offset: 0x000D7564
		public static IGameDifficultySystemConfig Create([Nullable(2)] IGameDifficultySystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameDifficultySystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x000D9377 File Offset: 0x000D7577
		public static IGameDifficultySystemConfig CreateFromSetValue([Nullable(2)] IGameDifficultySystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGameDifficultySystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x000D938A File Offset: 0x000D758A
		public new IGameDifficultySystemConfig_SetValue ToSetValue()
		{
			return new IGameDifficultySystemConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x0600591C RID: 22812 RVA: 0x000D939D File Offset: 0x000D759D
		// (set) Token: 0x0600591D RID: 22813 RVA: 0x000D93C8 File Offset: 0x000D75C8
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040035CA RID: 13770
		[Nullable(2)]
		protected new IGameDifficultySystemConfig FbInstance;

		// Token: 0x040035CB RID: 13771
		[Nullable(2)]
		protected new IGameDifficultySystemConfig_SetValue PocoInterface;
	}
}
