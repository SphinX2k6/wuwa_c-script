using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B5 RID: 9397
	public class ToggleRideFlyingCarUiGameplay : ActionParams
	{
		// Token: 0x0600CC5C RID: 52316 RVA: 0x001D1CFC File Offset: 0x001CFEFC
		private ToggleRideFlyingCarUiGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleRideFlyingCarUiGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleRideFlyingCarUiGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleRideFlyingCarUiGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x001D1D34 File Offset: 0x001CFF34
		public static ToggleRideFlyingCarUiGameplay Create([Nullable(2)] ToggleRideFlyingCarUiGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleRideFlyingCarUiGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC5E RID: 52318 RVA: 0x001D1D47 File Offset: 0x001CFF47
		public static ToggleRideFlyingCarUiGameplay CreateFromSetValue([Nullable(2)] ToggleRideFlyingCarUiGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleRideFlyingCarUiGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC5F RID: 52319 RVA: 0x001D1D5A File Offset: 0x001CFF5A
		public ToggleRideFlyingCarUiGameplay_SetValue ToSetValue()
		{
			return new ToggleRideFlyingCarUiGameplay_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x001D1D6D File Offset: 0x001CFF6D
		// (set) Token: 0x0600CC61 RID: 52321 RVA: 0x001D1D94 File Offset: 0x001CFF94
		public virtual IToggleRideFlyingCarUiGameplayConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ToggleRideFlyingCarUiGameplay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400791B RID: 31003
		[Nullable(2)]
		protected new ToggleRideFlyingCarUiGameplay FbInstance;

		// Token: 0x0400791C RID: 31004
		[Nullable(2)]
		protected ToggleRideFlyingCarUiGameplay_SetValue PocoInterface;
	}
}
