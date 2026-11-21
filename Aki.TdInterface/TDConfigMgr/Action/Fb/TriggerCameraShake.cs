using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF2 RID: 11250
	public class TriggerCameraShake : ActionParams
	{
		// Token: 0x0600F7C7 RID: 63431 RVA: 0x00240CEC File Offset: 0x0023EEEC
		public static TriggerCameraShake Create(ITriggerCameraShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerCameraShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x0600F7C8 RID: 63432 RVA: 0x00240D0B File Offset: 0x0023EF0B
		public virtual ICameraShakeConfig CameraShakeConfig
		{
			get
			{
				if (this._CameraShakeConfigInited)
				{
					return this._CameraShakeConfigCache;
				}
				this._CameraShakeConfigInited = true;
				this._CameraShakeConfigCache = ActionReadHelper.ReadTriggerCameraShake_CameraShakeConfig(this.Instance);
				return this._CameraShakeConfigCache;
			}
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x0600F7C9 RID: 63433 RVA: 0x00240D3A File Offset: 0x0023EF3A
		public virtual string CameraShakeBp
		{
			get
			{
				return this.Instance.CameraShakeBp;
			}
		}

		// Token: 0x040087A8 RID: 34728
		private ITriggerCameraShake Instance;

		// Token: 0x040087A9 RID: 34729
		private ICameraShakeConfig _CameraShakeConfigCache;

		// Token: 0x040087AA RID: 34730
		private bool _CameraShakeConfigInited;
	}
}
