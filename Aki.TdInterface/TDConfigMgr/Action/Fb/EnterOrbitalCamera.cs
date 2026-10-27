using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D3 RID: 10451
	[NullableContext(1)]
	[Nullable(0)]
	public class EnterOrbitalCamera : ActionParams
	{
		// Token: 0x0600E81D RID: 59421 RVA: 0x00221173 File Offset: 0x0021F373
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

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x0600E81E RID: 59422 RVA: 0x00221192 File Offset: 0x0021F392
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

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x0600E81F RID: 59423 RVA: 0x002211C8 File Offset: 0x0021F3C8
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

		// Token: 0x0400804D RID: 32845
		private IEnterOrbitalCamera Instance;

		// Token: 0x0400804E RID: 32846
		[Nullable(2)]
		private IEnterOrbitalCameraControlByMove _OptionCache;

		// Token: 0x0400804F RID: 32847
		private bool _OptionInited;
	}
}
