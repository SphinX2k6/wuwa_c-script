using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002655 RID: 9813
	public class IInfrActivityRoadProcess : IInfrActivityBuildStageOption
	{
		// Token: 0x0600DC06 RID: 56326 RVA: 0x0020BF26 File Offset: 0x0020A126
		[NullableContext(1)]
		public static IInfrActivityRoadProcess Create(IInfrActivityRoadProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityRoadProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x0600DC07 RID: 56327 RVA: 0x0020BF45 File Offset: 0x0020A145
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				return (EInfrActivityBuildStageType)this.Instance.Type;
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x0600DC08 RID: 56328 RVA: 0x0020BF52 File Offset: 0x0020A152
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007A51 RID: 31313
		private IInfrActivityRoadProcess Instance;
	}
}
