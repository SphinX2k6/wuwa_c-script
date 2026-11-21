using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C21 RID: 3105
	public class IMechascoutJavelinTriggerConfig : ITeleCtrlTriggerConfig
	{
		// Token: 0x0600471B RID: 18203 RVA: 0x000B46BD File Offset: 0x000B28BD
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

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x0600471C RID: 18204 RVA: 0x000B46DC File Offset: 0x000B28DC
		public override ETeleCtrlTriggerType Type
		{
			get
			{
				return (ETeleCtrlTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x040027E0 RID: 10208
		private IMechascoutJavelinTriggerConfig Instance;
	}
}
