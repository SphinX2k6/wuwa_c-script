using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C22 RID: 3106
	public class IMechascoutExplosiveBarrelTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x0600471E RID: 18206 RVA: 0x000B46F1 File Offset: 0x000B28F1
		public static IMechascoutExplosiveBarrelTriggerConfig Create(IMechascoutExplosiveBarrelTriggerConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutExplosiveBarrelTriggerConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x000B4710 File Offset: 0x000B2910
		public override ETeleCtrlTriggerType Type
		{
			get
			{
				return (ETeleCtrlTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x040027E1 RID: 10209
		private IMechascoutExplosiveBarrelTriggerConfig Instance;
	}
}
