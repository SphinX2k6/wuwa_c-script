using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E70 RID: 3696
	public class ISceneItemAiPatrolType
	{
		// Token: 0x06005386 RID: 21382 RVA: 0x000CE07B File Offset: 0x000CC27B
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

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x000CE09A File Offset: 0x000CC29A
		public virtual ESceneItemAiPatrolType Type
		{
			get
			{
				return (ESceneItemAiPatrolType)this.Instance.Type;
			}
		}

		// Token: 0x04002FC3 RID: 12227
		private ISceneItemAiPatrolType Instance;
	}
}
