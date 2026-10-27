using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B54 RID: 2900
	public class IMechascoutExplosiveBarrelTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x060042C5 RID: 17093 RVA: 0x000AA62D File Offset: 0x000A882D
		[NullableContext(1)]
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x000AA64C File Offset: 0x000A884C
		public override ETeleCtrlTriggerType Type
		{
			get
			{
				return (ETeleCtrlTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04002599 RID: 9625
		private IMechascoutExplosiveBarrelTriggerConfig Instance;
	}
}
