using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D47 RID: 3399
	public class IBattleVehicleFeature : IVehicleFeature
	{
		// Token: 0x06004D82 RID: 19842 RVA: 0x000C0CB2 File Offset: 0x000BEEB2
		[NullableContext(1)]
		public static IBattleVehicleFeature Create(IBattleVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x000C0CD1 File Offset: 0x000BEED1
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x04002C70 RID: 11376
		private IBattleVehicleFeature Instance;
	}
}
