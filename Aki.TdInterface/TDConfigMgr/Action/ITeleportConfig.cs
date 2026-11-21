using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D9 RID: 8665
	public class ITeleportConfig
	{
		// Token: 0x0600BCD6 RID: 48342 RVA: 0x001B4EE0 File Offset: 0x001B30E0
		private ITeleportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCD7 RID: 48343 RVA: 0x001B4F18 File Offset: 0x001B3118
		public static ITeleportConfig Create([Nullable(2)] ITeleportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x001B4F2B File Offset: 0x001B312B
		public static ITeleportConfig CreateFromSetValue([Nullable(2)] ITeleportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x001B4F3E File Offset: 0x001B313E
		public ITeleportConfig_SetValue ToSetValue()
		{
			return new ITeleportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600BCDA RID: 48346 RVA: 0x001B4F51 File Offset: 0x001B3151
		// (set) Token: 0x0600BCDB RID: 48347 RVA: 0x001B4F7C File Offset: 0x001B317C
		public virtual ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007170 RID: 29040
		[Nullable(2)]
		protected ITeleportConfig FbInstance;

		// Token: 0x04007171 RID: 29041
		[Nullable(2)]
		protected ITeleportConfig_SetValue PocoInterface;
	}
}
