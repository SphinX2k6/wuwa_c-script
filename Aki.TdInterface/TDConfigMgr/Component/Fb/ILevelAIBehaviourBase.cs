using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D79 RID: 3449
	public class ILevelAIBehaviourBase
	{
		// Token: 0x06004E64 RID: 20068 RVA: 0x000C36DA File Offset: 0x000C18DA
		public static ILevelAIBehaviourBase Create(ILevelAIBehaviourBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAIBehaviourBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x000C36F9 File Offset: 0x000C18F9
		public virtual ELevelAIBehaviourType Type
		{
			get
			{
				return (ELevelAIBehaviourType)this.Instance.Type;
			}
		}

		// Token: 0x04002C94 RID: 11412
		private ILevelAIBehaviourBase Instance;
	}
}
