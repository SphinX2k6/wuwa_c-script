using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1D RID: 3101
	public class IThrowCfg
	{
		// Token: 0x0600470D RID: 18189 RVA: 0x000B458A File Offset: 0x000B278A
		public static IThrowCfg Create(IThrowCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x000B45A9 File Offset: 0x000B27A9
		public virtual IThrowMotion MotionConfig
		{
			get
			{
				if (this._MotionConfigInited)
				{
					return this._MotionConfigCache;
				}
				this._MotionConfigInited = true;
				this._MotionConfigCache = ComponentReadHelper.ReadIThrowCfg_MotionConfig(this.Instance);
				return this._MotionConfigCache;
			}
		}

		// Token: 0x040027D8 RID: 10200
		private IThrowCfg Instance;

		// Token: 0x040027D9 RID: 10201
		private IThrowMotion _MotionConfigCache;

		// Token: 0x040027DA RID: 10202
		private bool _MotionConfigInited;
	}
}
