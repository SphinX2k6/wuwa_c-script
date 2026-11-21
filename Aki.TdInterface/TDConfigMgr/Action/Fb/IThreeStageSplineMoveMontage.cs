using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E8 RID: 10728
	public class IThreeStageSplineMoveMontage : ISplineMoveMontageType
	{
		// Token: 0x0600ED50 RID: 60752 RVA: 0x0022E412 File Offset: 0x0022C612
		public static IThreeStageSplineMoveMontage Create(IThreeStageSplineMoveMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThreeStageSplineMoveMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x0600ED51 RID: 60753 RVA: 0x0022E431 File Offset: 0x0022C631
		public override ESplineMoveMontageType Type
		{
			get
			{
				return (ESplineMoveMontageType)this.Instance.Type;
			}
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x0022E43E File Offset: 0x0022C63E
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x0400829C RID: 33436
		private IThreeStageSplineMoveMontage Instance;
	}
}
