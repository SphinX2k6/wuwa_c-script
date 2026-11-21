using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2E RID: 3118
	public class IBuildingBlockFoundation : IItemFoundationType
	{
		// Token: 0x0600476B RID: 18283 RVA: 0x000B51DD File Offset: 0x000B33DD
		public static IBuildingBlockFoundation Create(IBuildingBlockFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuildingBlockFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x000B51FC File Offset: 0x000B33FC
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x04002823 RID: 10275
		private IBuildingBlockFoundation Instance;
	}
}
