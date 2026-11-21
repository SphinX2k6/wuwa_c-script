using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A72 RID: 10866
	public class IScreenType
	{
		// Token: 0x0600EFDB RID: 61403 RVA: 0x002327C1 File Offset: 0x002309C1
		public static IScreenType Create(IScreenType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScreenType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x0600EFDC RID: 61404 RVA: 0x002327E0 File Offset: 0x002309E0
		public virtual EScreenType Type
		{
			get
			{
				return (EScreenType)this.Instance.Type;
			}
		}

		// Token: 0x040083E2 RID: 33762
		private IScreenType Instance;
	}
}
