using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002654 RID: 9812
	public class IInfrActivityInfrastructureStage : IInfrActivityBuildStageOption
	{
		// Token: 0x0600DC02 RID: 56322 RVA: 0x0020BEE5 File Offset: 0x0020A0E5
		[NullableContext(1)]
		public static IInfrActivityInfrastructureStage Create(IInfrActivityInfrastructureStage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityInfrastructureStage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x0600DC03 RID: 56323 RVA: 0x0020BF04 File Offset: 0x0020A104
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				return (EInfrActivityBuildStageType)this.Instance.Type;
			}
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x0600DC04 RID: 56324 RVA: 0x0020BF11 File Offset: 0x0020A111
		public virtual int Stage
		{
			get
			{
				return this.Instance.Stage;
			}
		}

		// Token: 0x04007A50 RID: 31312
		private IInfrActivityInfrastructureStage Instance;
	}
}
