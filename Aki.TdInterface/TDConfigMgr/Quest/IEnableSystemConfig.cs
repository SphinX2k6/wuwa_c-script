using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200107A RID: 4218
	public class IEnableSystemConfig
	{
		// Token: 0x06005CFE RID: 23806 RVA: 0x000E1EC0 File Offset: 0x000E00C0
		private IEnableSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x000E1EF8 File Offset: 0x000E00F8
		public static IEnableSystemConfig Create([Nullable(2)] IEnableSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x000E1F0B File Offset: 0x000E010B
		public static IEnableSystemConfig CreateFromSetValue([Nullable(2)] IEnableSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D01 RID: 23809 RVA: 0x000E1F1E File Offset: 0x000E011E
		public IEnableSystemConfig_SetValue ToSetValue()
		{
			return new IEnableSystemConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06005D02 RID: 23810 RVA: 0x000E1F31 File Offset: 0x000E0131
		// (set) Token: 0x06005D03 RID: 23811 RVA: 0x000E1F5C File Offset: 0x000E015C
		public virtual EEnableSystemType Type
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

		// Token: 0x040037F6 RID: 14326
		[Nullable(2)]
		protected IEnableSystemConfig FbInstance;

		// Token: 0x040037F7 RID: 14327
		[Nullable(2)]
		protected IEnableSystemConfig_SetValue PocoInterface;
	}
}
