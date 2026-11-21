using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001510 RID: 5392
	public class ITakePhoto2BeforeYourEyesMode : ITakePhoto2ModeBase
	{
		// Token: 0x06007A0D RID: 31245 RVA: 0x00123660 File Offset: 0x00121860
		public static ITakePhoto2BeforeYourEyesMode Create(ITakePhoto2BeforeYourEyesMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2BeforeYourEyesMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x06007A0E RID: 31246 RVA: 0x0012367F File Offset: 0x0012187F
		public override ETakePhoto2Mode Type
		{
			get
			{
				return (ETakePhoto2Mode)this.Instance.Type;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x06007A0F RID: 31247 RVA: 0x0012368C File Offset: 0x0012188C
		public virtual ITakePhoto2SuccessCameraBehaviorBase SuccessCameraBehavior
		{
			get
			{
				if (this._SuccessCameraBehaviorInited)
				{
					return this._SuccessCameraBehaviorCache;
				}
				this._SuccessCameraBehaviorInited = true;
				this._SuccessCameraBehaviorCache = QuestReadHelper.ReadITakePhoto2BeforeYourEyesMode_SuccessCameraBehavior(this.Instance);
				return this._SuccessCameraBehaviorCache;
			}
		}

		// Token: 0x04004644 RID: 17988
		private ITakePhoto2BeforeYourEyesMode Instance;

		// Token: 0x04004645 RID: 17989
		private ITakePhoto2SuccessCameraBehaviorBase _SuccessCameraBehaviorCache;

		// Token: 0x04004646 RID: 17990
		private bool _SuccessCameraBehaviorInited;
	}
}
