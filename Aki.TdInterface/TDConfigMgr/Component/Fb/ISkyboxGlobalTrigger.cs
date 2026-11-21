using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCA RID: 3274
	public class ISkyboxGlobalTrigger : ISkyboxTrigger
	{
		// Token: 0x06004ACC RID: 19148 RVA: 0x000BBF5C File Offset: 0x000BA15C
		public static ISkyboxGlobalTrigger Create(ISkyboxGlobalTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxGlobalTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x000BBF7B File Offset: 0x000BA17B
		public override ETriggerMode Type
		{
			get
			{
				return (ETriggerMode)this.Instance.Type;
			}
		}

		// Token: 0x04002A5F RID: 10847
		private ISkyboxGlobalTrigger Instance;
	}
}
