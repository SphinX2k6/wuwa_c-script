using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200265A RID: 9818
	public class IQuestBranchConfig
	{
		// Token: 0x0600DC1A RID: 56346 RVA: 0x0020C0BD File Offset: 0x0020A2BD
		[NullableContext(1)]
		public static IQuestBranchConfig Create(IQuestBranchConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestBranchConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x0600DC1B RID: 56347 RVA: 0x0020C0DC File Offset: 0x0020A2DC
		public virtual bool? EnableAnimation
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableAnimation);
			}
		}

		// Token: 0x04007A58 RID: 31320
		private IQuestBranchConfig Instance;
	}
}
