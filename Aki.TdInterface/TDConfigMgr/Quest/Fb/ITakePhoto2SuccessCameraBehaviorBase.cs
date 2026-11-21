using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200150C RID: 5388
	public class ITakePhoto2SuccessCameraBehaviorBase
	{
		// Token: 0x06007A01 RID: 31233 RVA: 0x00123590 File Offset: 0x00121790
		public static ITakePhoto2SuccessCameraBehaviorBase Create(ITakePhoto2SuccessCameraBehaviorBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2SuccessCameraBehaviorBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x001235AF File Offset: 0x001217AF
		public virtual ETakePhoto2SuccessCameraBehavior Type
		{
			get
			{
				return (ETakePhoto2SuccessCameraBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04004640 RID: 17984
		private ITakePhoto2SuccessCameraBehaviorBase Instance;
	}
}
