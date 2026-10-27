using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004E6 RID: 1254
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechascoutExplosiveBarrelTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x0600197C RID: 6524 RVA: 0x0004B368 File Offset: 0x00049568
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

		// Token: 0x0600197D RID: 6525 RVA: 0x0004B3A0 File Offset: 0x000495A0
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

		// Token: 0x0600197E RID: 6526 RVA: 0x0004B3B3 File Offset: 0x000495B3
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

		// Token: 0x0600197F RID: 6527 RVA: 0x0004B3C6 File Offset: 0x000495C6
		public new IMechascoutExplosiveBarrelTriggerConfig_SetValue ToSetValue()
		{
			return new IMechascoutExplosiveBarrelTriggerConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0004B3D9 File Offset: 0x000495D9
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0004B404 File Offset: 0x00049604
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

		// Token: 0x040012AC RID: 4780
		[Nullable(2)]
		protected new IMechascoutExplosiveBarrelTriggerConfig FbInstance;

		// Token: 0x040012AD RID: 4781
		[Nullable(2)]
		protected new IMechascoutExplosiveBarrelTriggerConfig_SetValue PocoInterface;
	}
}
