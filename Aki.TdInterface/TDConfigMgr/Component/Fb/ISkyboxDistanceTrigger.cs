using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC9 RID: 3273
	public class ISkyboxDistanceTrigger : ISkyboxTrigger
	{
		// Token: 0x06004AC8 RID: 19144 RVA: 0x000BBF1B File Offset: 0x000BA11B
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

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x000BBF3A File Offset: 0x000BA13A
		public override ETriggerMode Type
		{
			get
			{
				return (ETriggerMode)this.Instance.Type;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x000BBF47 File Offset: 0x000BA147
		public virtual float Distance
		{
			get
			{
				return this.Instance.Distance;
			}
		}

		// Token: 0x04002A5E RID: 10846
		private ISkyboxDistanceTrigger Instance;
	}
}
