using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053F RID: 1343
	public class IMechascoutExplosiveBarrelTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x06001B16 RID: 6934 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		private IMechascoutExplosiveBarrelTriggerConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechascoutExplosiveBarrelTriggerConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechascoutExplosiveBarrelTriggerConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechascoutExplosiveBarrelTriggerConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0004F0E8 File Offset: 0x0004D2E8
		public static IMechascoutExplosiveBarrelTriggerConfig Create([Nullable(2)] IMechascoutExplosiveBarrelTriggerConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutExplosiveBarrelTriggerConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0004F0FB File Offset: 0x0004D2FB
		public static IMechascoutExplosiveBarrelTriggerConfig CreateFromSetValue([Nullable(2)] IMechascoutExplosiveBarrelTriggerConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechascoutExplosiveBarrelTriggerConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0004F10E File Offset: 0x0004D30E
		public new IMechascoutExplosiveBarrelTriggerConfig_SetValue ToSetValue()
		{
			return new IMechascoutExplosiveBarrelTriggerConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0004F121 File Offset: 0x0004D321
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x0004F14C File Offset: 0x0004D34C
		public override ETeleCtrlTriggerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleCtrlTriggerType.MechascoutJavelin;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040013CE RID: 5070
		[Nullable(2)]
		protected new IMechascoutExplosiveBarrelTriggerConfig FbInstance;

		// Token: 0x040013CF RID: 5071
		[Nullable(2)]
		protected new IMechascoutExplosiveBarrelTriggerConfig_SetValue PocoInterface;
	}
}
