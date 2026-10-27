using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D57 RID: 3415
	public class IGroupAiEcologyGameplayAbp
	{
		// Token: 0x06004DD3 RID: 19923 RVA: 0x000C16EB File Offset: 0x000BF8EB
		[NullableContext(1)]
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

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x000C170A File Offset: 0x000BF90A
		public virtual EGroupAiEcologyGameplayType GameplayType
		{
			get
			{
				return (EGroupAiEcologyGameplayType)this.Instance.GameplayType;
			}
		}

		// Token: 0x04002C9C RID: 11420
		private IGroupAiEcologyGameplayAbp Instance;
	}
}
