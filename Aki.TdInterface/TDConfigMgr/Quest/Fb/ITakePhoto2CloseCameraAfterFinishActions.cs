using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200150E RID: 5390
	public class ITakePhoto2CloseCameraAfterFinishActions : ITakePhoto2SuccessCameraBehaviorBase
	{
		// Token: 0x06007A07 RID: 31239 RVA: 0x001235F8 File Offset: 0x001217F8
		public static ITakePhoto2CloseCameraAfterFinishActions Create(ITakePhoto2CloseCameraAfterFinishActions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2CloseCameraAfterFinishActions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x00123617 File Offset: 0x00121817
		public override ETakePhoto2SuccessCameraBehavior Type
		{
			get
			{
				return (ETakePhoto2SuccessCameraBehavior)this.Instance.Type;
			}
		}

		// Token: 0x04004642 RID: 17986
		private ITakePhoto2CloseCameraAfterFinishActions Instance;
	}
}
