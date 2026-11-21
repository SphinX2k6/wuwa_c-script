using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200150D RID: 5389
	public class ITakePhoto2KeepCameraOpen : ITakePhoto2SuccessCameraBehaviorBase
	{
		// Token: 0x06007A04 RID: 31236 RVA: 0x001235C4 File Offset: 0x001217C4
		public static ITakePhoto2KeepCameraOpen Create(ITakePhoto2KeepCameraOpen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2KeepCameraOpen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06007A05 RID: 31237 RVA: 0x001235E3 File Offset: 0x001217E3
		public override ETakePhoto2SuccessCameraBehavior Type
		{
			get
			{
				return (ETakePhoto2SuccessCameraBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04004641 RID: 17985
		private ITakePhoto2KeepCameraOpen Instance;
	}
}
