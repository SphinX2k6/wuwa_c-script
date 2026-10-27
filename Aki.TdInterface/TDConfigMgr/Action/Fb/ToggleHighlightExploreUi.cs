using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002974 RID: 10612
	public class ToggleHighlightExploreUi : ActionParams
	{
		// Token: 0x0600EB25 RID: 60197 RVA: 0x0022687C File Offset: 0x00224A7C
		[NullableContext(1)]
		public static ToggleHighlightExploreUi Create(IToggleHighlightExploreUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleHighlightExploreUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x0022689B File Offset: 0x00224A9B
		public virtual EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x0600EB27 RID: 60199 RVA: 0x002268A8 File Offset: 0x00224AA8
		public virtual EHighlightType? HighlightType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EHighlightType?((EHighlightType)this.Instance.HighlightType);
			}
		}

		// Token: 0x0400818C RID: 33164
		private IToggleHighlightExploreUi Instance;
	}
}
