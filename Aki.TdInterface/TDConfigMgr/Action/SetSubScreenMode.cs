using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002449 RID: 9289
	public class SetSubScreenMode : ActionParams
	{
		// Token: 0x0600CA3B RID: 51771 RVA: 0x001CDF68 File Offset: 0x001CC168
		private SetSubScreenMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSubScreenMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSubScreenMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSubScreenMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x001CDFA0 File Offset: 0x001CC1A0
		public static SetSubScreenMode Create([Nullable(2)] SetSubScreenMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSubScreenMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x001CDFB3 File Offset: 0x001CC1B3
		public static SetSubScreenMode CreateFromSetValue([Nullable(2)] SetSubScreenMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSubScreenMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x001CDFC6 File Offset: 0x001CC1C6
		public SetSubScreenMode_SetValue ToSetValue()
		{
			return new SetSubScreenMode_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600CA3F RID: 51775 RVA: 0x001CDFD9 File Offset: 0x001CC1D9
		// (set) Token: 0x0600CA40 RID: 51776 RVA: 0x001CE000 File Offset: 0x001CC200
		public virtual ISubScreenModeConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				SetSubScreenMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040077F7 RID: 30711
		[Nullable(2)]
		protected new SetSubScreenMode FbInstance;

		// Token: 0x040077F8 RID: 30712
		[Nullable(2)]
		protected SetSubScreenMode_SetValue PocoInterface;
	}
}
