using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B53 RID: 2899
	public class IMechascoutJavelinTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x060042C2 RID: 17090 RVA: 0x000AA5F9 File Offset: 0x000A87F9
		[NullableContext(1)]
		public static IMechascoutJavelinTriggerConfig Create(IMechascoutJavelinTriggerConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechascoutJavelinTriggerConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x000AA618 File Offset: 0x000A8818
		public override ETeleCtrlTriggerType Type
		{
			get
			{
				return (ETeleCtrlTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04002598 RID: 9624
		private IMechascoutJavelinTriggerConfig Instance;
	}
}
