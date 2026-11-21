using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A46 RID: 10822
	public class IFadeBackgroundUiPrefabType
	{
		// Token: 0x0600EF04 RID: 61188 RVA: 0x0023085D File Offset: 0x0022EA5D
		public static IFadeBackgroundUiPrefabType Create(IFadeBackgroundUiPrefabType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefabType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x0600EF05 RID: 61189 RVA: 0x0023087C File Offset: 0x0022EA7C
		public virtual EFadeBackgroundUiPrefabType Type
		{
			get
			{
				return (EFadeBackgroundUiPrefabType)this.Instance.Type;
			}
		}

		// Token: 0x04008340 RID: 33600
		private IFadeBackgroundUiPrefabType Instance;
	}
}
