using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200073B RID: 1851
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunSpiritGearPerformConfig
	{
		// Token: 0x060027F1 RID: 10225 RVA: 0x0006A068 File Offset: 0x00068268
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

		// Token: 0x060027F2 RID: 10226 RVA: 0x0006A0A0 File Offset: 0x000682A0
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

		// Token: 0x060027F3 RID: 10227 RVA: 0x0006A0B3 File Offset: 0x000682B3
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

		// Token: 0x060027F4 RID: 10228 RVA: 0x0006A0C6 File Offset: 0x000682C6
		public ISunSpiritGearPerformConfig_SetValue ToSetValue()
		{
			return new ISunSpiritGearPerformConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0006A0D9 File Offset: 0x000682D9
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x0006A104 File Offset: 0x00068304
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

		// Token: 0x04001AE8 RID: 6888
		[Nullable(2)]
		protected ISunSpiritGearPerformConfig FbInstance;

		// Token: 0x04001AE9 RID: 6889
		[Nullable(2)]
		protected ISunSpiritGearPerformConfig_SetValue PocoInterface;
	}
}
