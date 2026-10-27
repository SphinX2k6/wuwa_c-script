using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C2 RID: 9922
	public class IEnableSubLevelTransitionType
	{
		// Token: 0x0600DDEA RID: 56810 RVA: 0x0020F169 File Offset: 0x0020D369
		[NullableContext(1)]
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

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x0020F188 File Offset: 0x0020D388
		public virtual EEnableSubLevelTransitionType Type
		{
			get
			{
				return (EEnableSubLevelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x04007B38 RID: 31544
		private IEnableSubLevelTransitionType Instance;
	}
}
