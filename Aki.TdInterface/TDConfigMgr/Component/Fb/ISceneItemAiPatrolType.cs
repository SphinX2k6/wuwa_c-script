using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D74 RID: 3444
	public class ISceneItemAiPatrolType
	{
		// Token: 0x06004E61 RID: 20065 RVA: 0x000C282B File Offset: 0x000C0A2B
		[NullableContext(1)]
		public static ISceneItemAiPatrolType Create(ISceneItemAiPatrolType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06004E62 RID: 20066 RVA: 0x000C284A File Offset: 0x000C0A4A
		public virtual ESceneItemAiPatrolType Type
		{
			get
			{
				return (ESceneItemAiPatrolType)this.Instance.Type;
			}
		}

		// Token: 0x04002CFD RID: 11517
		private ISceneItemAiPatrolType Instance;
	}
}
