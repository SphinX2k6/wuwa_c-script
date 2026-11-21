using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E51 RID: 3665
	public class IGroupAiEcologyGameplayAbp
	{
		// Token: 0x060052EF RID: 21231 RVA: 0x000CCE2F File Offset: 0x000CB02F
		public static IGroupAiEcologyGameplayAbp Create(IGroupAiEcologyGameplayAbp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiEcologyGameplayAbp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x000CCE4E File Offset: 0x000CB04E
		public virtual EGroupAiEcologyGameplayType GameplayType
		{
			get
			{
				return (EGroupAiEcologyGameplayType)this.Instance.GameplayType;
			}
		}

		// Token: 0x04002F5C RID: 12124
		private IGroupAiEcologyGameplayAbp Instance;
	}
}
