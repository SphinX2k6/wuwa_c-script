using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010C9 RID: 4297
	public class IGameDifficultySystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005EEE RID: 24302 RVA: 0x000E5DEC File Offset: 0x000E3FEC
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

		// Token: 0x06005EEF RID: 24303 RVA: 0x000E5E24 File Offset: 0x000E4024
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

		// Token: 0x06005EF0 RID: 24304 RVA: 0x000E5E37 File Offset: 0x000E4037
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

		// Token: 0x06005EF1 RID: 24305 RVA: 0x000E5E4A File Offset: 0x000E404A
		public new IGameDifficultySystemConfig_SetValue ToSetValue()
		{
			return new IGameDifficultySystemConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x000E5E5D File Offset: 0x000E405D
		// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x000E5E88 File Offset: 0x000E4088
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

		// Token: 0x040038FC RID: 14588
		[Nullable(2)]
		protected new IGameDifficultySystemConfig FbInstance;

		// Token: 0x040038FD RID: 14589
		[Nullable(2)]
		protected new IGameDifficultySystemConfig_SetValue PocoInterface;
	}
}
