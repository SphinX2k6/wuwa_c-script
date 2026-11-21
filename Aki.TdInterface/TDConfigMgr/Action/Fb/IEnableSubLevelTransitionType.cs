using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002986 RID: 10630
	public class IEnableSubLevelTransitionType
	{
		// Token: 0x0600EBC6 RID: 60358 RVA: 0x0022B9A9 File Offset: 0x00229BA9
		public static IEnableSubLevelTransitionType Create(IEnableSubLevelTransitionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x0600EBC7 RID: 60359 RVA: 0x0022B9C8 File Offset: 0x00229BC8
		public virtual EEnableSubLevelTransitionType Type
		{
			get
			{
				return (EEnableSubLevelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x040081D8 RID: 33240
		private IEnableSubLevelTransitionType Instance;
	}
}
