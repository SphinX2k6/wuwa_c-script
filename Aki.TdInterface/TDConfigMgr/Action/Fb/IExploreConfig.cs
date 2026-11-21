using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BCF RID: 11215
	public class IExploreConfig
	{
		// Token: 0x0600F72D RID: 63277 RVA: 0x0023FCE9 File Offset: 0x0023DEE9
		public static IExploreConfig Create(IExploreConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x0600F72E RID: 63278 RVA: 0x0023FD08 File Offset: 0x0023DF08
		public virtual EExploreStateType Type
		{
			get
			{
				return (EExploreStateType)this.Instance.Type;
			}
		}

		// Token: 0x04008759 RID: 34649
		private IExploreConfig Instance;
	}
}
