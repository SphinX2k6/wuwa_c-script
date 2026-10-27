using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B78 RID: 2936
	public class IImmediateStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x060043A4 RID: 17316 RVA: 0x000AC54B File Offset: 0x000AA74B
		[NullableContext(1)]
		public static IImmediateStartCondition Create(IImmediateStartCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IImmediateStartCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x000AC56A File Offset: 0x000AA76A
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				return (ESpawnMonsterStartCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002629 RID: 9769
		private IImmediateStartCondition Instance;
	}
}
