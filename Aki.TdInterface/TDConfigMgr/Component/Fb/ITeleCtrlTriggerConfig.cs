using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B52 RID: 2898
	public class ITeleCtrlTriggerConfig
	{
		// Token: 0x060042BF RID: 17087 RVA: 0x000AA5C5 File Offset: 0x000A87C5
		[NullableContext(1)]
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060042C0 RID: 17088 RVA: 0x000AA5E4 File Offset: 0x000A87E4
		public virtual ETeleCtrlTriggerType Type
		{
			get
			{
				return (ETeleCtrlTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04002597 RID: 9623
		private ITeleCtrlTriggerConfig Instance;
	}
}
