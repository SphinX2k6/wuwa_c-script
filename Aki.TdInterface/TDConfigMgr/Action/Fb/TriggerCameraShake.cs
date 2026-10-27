using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002916 RID: 10518
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerCameraShake : ActionParams
	{
		// Token: 0x0600E975 RID: 59765 RVA: 0x00223994 File Offset: 0x00221B94
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

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x0600E976 RID: 59766 RVA: 0x002239B3 File Offset: 0x00221BB3
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

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x0600E977 RID: 59767 RVA: 0x002239E2 File Offset: 0x00221BE2
		public virtual string CameraShakeBp
		{
			get
			{
				return this.Instance.CameraShakeBp;
			}
		}

		// Token: 0x040080DA RID: 32986
		private ITriggerCameraShake Instance;

		// Token: 0x040080DB RID: 32987
		private ICameraShakeConfig _CameraShakeConfigCache;

		// Token: 0x040080DC RID: 32988
		private bool _CameraShakeConfigInited;
	}
}
