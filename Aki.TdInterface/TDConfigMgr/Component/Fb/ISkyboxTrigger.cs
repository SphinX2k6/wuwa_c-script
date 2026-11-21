using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC8 RID: 3272
	public class ISkyboxTrigger
	{
		// Token: 0x06004AC5 RID: 19141 RVA: 0x000BBEE7 File Offset: 0x000BA0E7
		public static ISkyboxTrigger Create(ISkyboxTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x000BBF06 File Offset: 0x000BA106
		public virtual ETriggerMode Type
		{
			get
			{
				return (ETriggerMode)this.Instance.Type;
			}
		}

		// Token: 0x04002A5D RID: 10845
		private ISkyboxTrigger Instance;
	}
}
