using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA8 RID: 11176
	public class EnterOrbitalCamera : ActionParams
	{
		// Token: 0x0600F64C RID: 63052 RVA: 0x0023E0F3 File Offset: 0x0023C2F3
		public static EnterOrbitalCamera Create(IEnterOrbitalCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterOrbitalCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x0600F64D RID: 63053 RVA: 0x0023E112 File Offset: 0x0023C312
		public virtual IEnterOrbitalCameraControlByMove Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IEnterOrbitalCameraControlByMove.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x0600F64E RID: 63054 RVA: 0x0023E148 File Offset: 0x0023C348
		public virtual bool? IsDisableControlCamera
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableControlCamera);
			}
		}

		// Token: 0x0400870C RID: 34572
		private IEnterOrbitalCamera Instance;

		// Token: 0x0400870D RID: 34573
		[Nullable(2)]
		private IEnterOrbitalCameraControlByMove _OptionCache;

		// Token: 0x0400870E RID: 34574
		private bool _OptionInited;
	}
}
