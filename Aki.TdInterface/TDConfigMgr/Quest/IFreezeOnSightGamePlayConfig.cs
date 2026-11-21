using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010C7 RID: 4295
	public class IFreezeOnSightGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06005EE6 RID: 24294 RVA: 0x000E5D30 File Offset: 0x000E3F30
		private IFreezeOnSightGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFreezeOnSightGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFreezeOnSightGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFreezeOnSightGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x000E5D68 File Offset: 0x000E3F68
		public static IFreezeOnSightGamePlayConfig Create([Nullable(2)] IFreezeOnSightGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreezeOnSightGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x000E5D7B File Offset: 0x000E3F7B
		public static IFreezeOnSightGamePlayConfig CreateFromSetValue([Nullable(2)] IFreezeOnSightGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFreezeOnSightGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x000E5D8E File Offset: 0x000E3F8E
		public new IFreezeOnSightGamePlayConfig_SetValue ToSetValue()
		{
			return new IFreezeOnSightGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06005EEA RID: 24298 RVA: 0x000E5DA1 File Offset: 0x000E3FA1
		// (set) Token: 0x06005EEB RID: 24299 RVA: 0x000E5DCC File Offset: 0x000E3FCC
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040038F9 RID: 14585
		[Nullable(2)]
		protected new IFreezeOnSightGamePlayConfig FbInstance;

		// Token: 0x040038FA RID: 14586
		[Nullable(2)]
		protected new IFreezeOnSightGamePlayConfig_SetValue PocoInterface;
	}
}
