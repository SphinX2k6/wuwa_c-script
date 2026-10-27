using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF8 RID: 3064
	public class ISkyboxTrigger
	{
		// Token: 0x06004662 RID: 18018 RVA: 0x000B1D1B File Offset: 0x000AFF1B
		[NullableContext(1)]
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

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x000B1D3A File Offset: 0x000AFF3A
		public virtual ETriggerMode Type
		{
			get
			{
				return (ETriggerMode)this.Instance.Type;
			}
		}

		// Token: 0x04002811 RID: 10257
		private ISkyboxTrigger Instance;
	}
}
