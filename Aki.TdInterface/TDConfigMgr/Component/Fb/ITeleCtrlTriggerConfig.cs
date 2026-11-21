using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C20 RID: 3104
	public class ITeleCtrlTriggerConfig
	{
		// Token: 0x06004718 RID: 18200 RVA: 0x000B4689 File Offset: 0x000B2889
		public static ITeleCtrlTriggerConfig Create(ITeleCtrlTriggerConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleCtrlTriggerConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004719 RID: 18201 RVA: 0x000B46A8 File Offset: 0x000B28A8
		public virtual ETeleCtrlTriggerType Type
		{
			get
			{
				return (ETeleCtrlTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x040027DF RID: 10207
		private ITeleCtrlTriggerConfig Instance;
	}
}
