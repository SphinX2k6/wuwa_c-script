using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007DC RID: 2012
	public class ISunSpiritGearPerformConfig
	{
		// Token: 0x06002B15 RID: 11029 RVA: 0x00071210 File Offset: 0x0006F410
		private ISunSpiritGearPerformConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritGearPerformConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritGearPerformConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritGearPerformConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00071248 File Offset: 0x0006F448
		public static ISunSpiritGearPerformConfig Create([Nullable(2)] ISunSpiritGearPerformConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0007125B File Offset: 0x0006F45B
		public static ISunSpiritGearPerformConfig CreateFromSetValue([Nullable(2)] ISunSpiritGearPerformConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0007126E File Offset: 0x0006F46E
		public ISunSpiritGearPerformConfig_SetValue ToSetValue()
		{
			return new ISunSpiritGearPerformConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x00071281 File Offset: 0x0006F481
		// (set) Token: 0x06002B1A RID: 11034 RVA: 0x000712AC File Offset: 0x0006F4AC
		public virtual ESunSpiritGearPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESunSpiritGearPerformType.ToGearRelativePos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001CED RID: 7405
		[Nullable(2)]
		protected ISunSpiritGearPerformConfig FbInstance;

		// Token: 0x04001CEE RID: 7406
		[Nullable(2)]
		protected ISunSpiritGearPerformConfig_SetValue PocoInterface;
	}
}
