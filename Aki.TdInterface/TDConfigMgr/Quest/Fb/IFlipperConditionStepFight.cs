using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013FC RID: 5116
	public class IFlipperConditionStepFight : IFlipperConditionStepBase
	{
		// Token: 0x06007464 RID: 29796 RVA: 0x00116764 File Offset: 0x00114964
		[NullableContext(1)]
		public static IFlipperConditionStepFight Create(IFlipperConditionStepFight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperConditionStepFight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06007465 RID: 29797 RVA: 0x00116783 File Offset: 0x00114983
		public override EFlipperConditionStep Type
		{
			get
			{
				return (EFlipperConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x0400435A RID: 17242
		private IFlipperConditionStepFight Instance;
	}
}
