using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DF RID: 4319
	public class IHardBattleModeSetting
	{
		// Token: 0x06005F7C RID: 24444 RVA: 0x000E7068 File Offset: 0x000E5268
		private IHardBattleModeSetting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHardBattleModeSetting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHardBattleModeSetting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHardBattleModeSetting_SetValue());
			}
			return result;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x000E70A0 File Offset: 0x000E52A0
		public static IHardBattleModeSetting Create([Nullable(2)] IHardBattleModeSetting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHardBattleModeSetting
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x000E70B3 File Offset: 0x000E52B3
		public static IHardBattleModeSetting CreateFromSetValue([Nullable(2)] IHardBattleModeSetting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHardBattleModeSetting
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x000E70C6 File Offset: 0x000E52C6
		public IHardBattleModeSetting_SetValue ToSetValue()
		{
			return new IHardBattleModeSetting_SetValue
			{
				CanOpenHardBattleMode = this.CanOpenHardBattleMode
			};
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x000E70DC File Offset: 0x000E52DC
		// (set) Token: 0x06005F81 RID: 24449 RVA: 0x000E7116 File Offset: 0x000E5316
		public virtual bool? CanOpenHardBattleMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanOpenHardBattleMode;
				}
				IHardBattleModeSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanOpenHardBattleMode;
			}
			set
			{
				this.GetOrCreatePoco().CanOpenHardBattleMode = value;
			}
		}

		// Token: 0x0400394E RID: 14670
		[Nullable(2)]
		protected IHardBattleModeSetting FbInstance;

		// Token: 0x0400394F RID: 14671
		[Nullable(2)]
		protected IHardBattleModeSetting_SetValue PocoInterface;
	}
}
