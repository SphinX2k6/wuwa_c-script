using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C46 RID: 3142
	public class IImmediateStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x060047FD RID: 18429 RVA: 0x000B660F File Offset: 0x000B480F
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

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x060047FE RID: 18430 RVA: 0x000B662E File Offset: 0x000B482E
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				return (ESpawnMonsterStartCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002871 RID: 10353
		private IImmediateStartCondition Instance;
	}
}
