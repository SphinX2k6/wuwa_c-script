using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CD RID: 6093
	public class EnterOrbitalCamera : ActionParams
	{
		// Token: 0x060083B1 RID: 33713 RVA: 0x0013AEB4 File Offset: 0x001390B4
		private EnterOrbitalCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnterOrbitalCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnterOrbitalCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnterOrbitalCamera_SetValue());
			}
			return result;
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x0013AEEC File Offset: 0x001390EC
		public static EnterOrbitalCamera Create([Nullable(2)] EnterOrbitalCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterOrbitalCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0013AEFF File Offset: 0x001390FF
		public static EnterOrbitalCamera CreateFromSetValue([Nullable(2)] EnterOrbitalCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnterOrbitalCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0013AF12 File Offset: 0x00139112
		public EnterOrbitalCamera_SetValue ToSetValue()
		{
			return new EnterOrbitalCamera_SetValue
			{
				Option = this.Option,
				IsDisableControlCamera = this.IsDisableControlCamera
			};
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x060083B5 RID: 33717 RVA: 0x0013AF34 File Offset: 0x00139134
		// (set) Token: 0x060083B6 RID: 33718 RVA: 0x0013AF95 File Offset: 0x00139195
		public virtual IEnterOrbitalCameraControlByMove Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IEnterOrbitalCameraControlByMove.Create(this.FbInstance.Option);
				}
				else
				{
					EnterOrbitalCamera_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x060083B7 RID: 33719 RVA: 0x0013AFAC File Offset: 0x001391AC
		// (set) Token: 0x060083B8 RID: 33720 RVA: 0x0013AFE6 File Offset: 0x001391E6
		public virtual bool? IsDisableControlCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableControlCamera;
				}
				EnterOrbitalCamera_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableControlCamera;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableControlCamera = value;
			}
		}

		// Token: 0x040050AE RID: 20654
		[Nullable(2)]
		protected new EnterOrbitalCamera FbInstance;

		// Token: 0x040050AF RID: 20655
		[Nullable(2)]
		protected EnterOrbitalCamera_SetValue PocoInterface;

		// Token: 0x040050B0 RID: 20656
		private IEnterOrbitalCameraControlByMove _OptionCache;

		// Token: 0x040050B1 RID: 20657
		private bool _OptionInited;
	}
}
