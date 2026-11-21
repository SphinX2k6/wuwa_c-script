using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015F4 RID: 5620
	public class AdjustPlayerCamera : ActionParams
	{
		// Token: 0x06007EEF RID: 32495 RVA: 0x0012EFA4 File Offset: 0x0012D1A4
		private AdjustPlayerCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AdjustPlayerCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AdjustPlayerCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AdjustPlayerCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x0012EFDC File Offset: 0x0012D1DC
		public static AdjustPlayerCamera Create([Nullable(2)] AdjustPlayerCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustPlayerCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x0012EFEF File Offset: 0x0012D1EF
		public static AdjustPlayerCamera CreateFromSetValue([Nullable(2)] AdjustPlayerCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AdjustPlayerCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x0012F002 File Offset: 0x0012D202
		public AdjustPlayerCamera_SetValue ToSetValue()
		{
			return new AdjustPlayerCamera_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x0012F015 File Offset: 0x0012D215
		// (set) Token: 0x06007EF4 RID: 32500 RVA: 0x0012F03C File Offset: 0x0012D23C
		public virtual IAdjustPlayerCameraType Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				AdjustPlayerCamera_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x04004975 RID: 18805
		[Nullable(2)]
		protected new AdjustPlayerCamera FbInstance;

		// Token: 0x04004976 RID: 18806
		[Nullable(2)]
		protected AdjustPlayerCamera_SetValue PocoInterface;
	}
}
