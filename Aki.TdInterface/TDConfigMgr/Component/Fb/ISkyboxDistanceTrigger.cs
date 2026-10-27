using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF9 RID: 3065
	public class ISkyboxDistanceTrigger : ISkyboxTrigger
	{
		// Token: 0x06004665 RID: 18021 RVA: 0x000B1D4F File Offset: 0x000AFF4F
		[NullableContext(1)]
		public static ISkyboxDistanceTrigger Create(ISkyboxDistanceTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxDistanceTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x000B1D6E File Offset: 0x000AFF6E
		public override ETriggerMode Type
		{
			get
			{
				return (ETriggerMode)this.Instance.Type;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x000B1D7B File Offset: 0x000AFF7B
		public virtual float Distance
		{
			get
			{
				return this.Instance.Distance;
			}
		}

		// Token: 0x04002812 RID: 10258
		private ISkyboxDistanceTrigger Instance;
	}
}
