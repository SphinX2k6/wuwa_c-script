using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165D RID: 5725
	[NullableContext(1)]
	[Nullable(0)]
	public class EnterOrbitalCamera : ActionParams
	{
		// Token: 0x06007CD3 RID: 31955 RVA: 0x0012BE08 File Offset: 0x0012A008
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

		// Token: 0x06007CD4 RID: 31956 RVA: 0x0012BE40 File Offset: 0x0012A040
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

		// Token: 0x06007CD5 RID: 31957 RVA: 0x0012BE53 File Offset: 0x0012A053
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

		// Token: 0x06007CD6 RID: 31958 RVA: 0x0012BE66 File Offset: 0x0012A066
		public EnterOrbitalCamera_SetValue ToSetValue()
		{
			return new EnterOrbitalCamera_SetValue
			{
				Option = this.Option,
				IsDisableControlCamera = this.IsDisableControlCamera
			};
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x06007CD7 RID: 31959 RVA: 0x0012BE88 File Offset: 0x0012A088
		// (set) Token: 0x06007CD8 RID: 31960 RVA: 0x0012BEE9 File Offset: 0x0012A0E9
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

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x0012BF00 File Offset: 0x0012A100
		// (set) Token: 0x06007CDA RID: 31962 RVA: 0x0012BF3A File Offset: 0x0012A13A
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

		// Token: 0x04004CB3 RID: 19635
		[Nullable(2)]
		protected new EnterOrbitalCamera FbInstance;

		// Token: 0x04004CB4 RID: 19636
		[Nullable(2)]
		protected EnterOrbitalCamera_SetValue PocoInterface;

		// Token: 0x04004CB5 RID: 19637
		private IEnterOrbitalCameraControlByMove _OptionCache;

		// Token: 0x04004CB6 RID: 19638
		private bool _OptionInited;
	}
}
