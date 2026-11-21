using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002913 RID: 10515
	public class IPhotographCameraTransformBase
	{
		// Token: 0x0600E9CA RID: 59850 RVA: 0x0022851E File Offset: 0x0022671E
		public static IPhotographCameraTransformBase Create(IPhotographCameraTransformBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographCameraTransformBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x0600E9CB RID: 59851 RVA: 0x0022853D File Offset: 0x0022673D
		public virtual EPhotographCameraTransform Type
		{
			get
			{
				return (EPhotographCameraTransform)this.Instance.Type;
			}
		}

		// Token: 0x040080E1 RID: 32993
		private IPhotographCameraTransformBase Instance;
	}
}
