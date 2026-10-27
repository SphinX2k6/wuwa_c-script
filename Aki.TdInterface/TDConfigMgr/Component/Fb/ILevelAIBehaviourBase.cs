using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C97 RID: 3223
	public class ILevelAIBehaviourBase
	{
		// Token: 0x060049B6 RID: 18870 RVA: 0x000B8CCA File Offset: 0x000B6ECA
		[NullableContext(1)]
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

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x000B8CE9 File Offset: 0x000B6EE9
		public virtual ELevelAIBehaviourType Type
		{
			get
			{
				return (ELevelAIBehaviourType)this.Instance.Type;
			}
		}

		// Token: 0x04002A1A RID: 10778
		private ILevelAIBehaviourBase Instance;
	}
}
