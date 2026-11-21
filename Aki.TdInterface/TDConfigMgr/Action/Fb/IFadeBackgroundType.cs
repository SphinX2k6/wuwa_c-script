using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A43 RID: 10819
	public class IFadeBackgroundType
	{
		// Token: 0x0600EEF5 RID: 61173 RVA: 0x002306D7 File Offset: 0x0022E8D7
		public static IFadeBackgroundType Create(IFadeBackgroundType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x0600EEF6 RID: 61174 RVA: 0x002306F6 File Offset: 0x0022E8F6
		public virtual EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04008335 RID: 33589
		private IFadeBackgroundType Instance;
	}
}
