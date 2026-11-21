using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AD RID: 9389
	public class ToggleDragActorPlay : ActionParams
	{
		// Token: 0x0600CC38 RID: 52280 RVA: 0x001D1978 File Offset: 0x001CFB78
		private ToggleDragActorPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleDragActorPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleDragActorPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleDragActorPlay_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x001D19B0 File Offset: 0x001CFBB0
		public static ToggleDragActorPlay Create([Nullable(2)] ToggleDragActorPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleDragActorPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x001D19C3 File Offset: 0x001CFBC3
		public static ToggleDragActorPlay CreateFromSetValue([Nullable(2)] ToggleDragActorPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleDragActorPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x001D19D6 File Offset: 0x001CFBD6
		public ToggleDragActorPlay_SetValue ToSetValue()
		{
			return new ToggleDragActorPlay_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600CC3C RID: 52284 RVA: 0x001D19E9 File Offset: 0x001CFBE9
		// (set) Token: 0x0600CC3D RID: 52285 RVA: 0x001D1A10 File Offset: 0x001CFC10
		public virtual IToggleDragActorPlayType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ToggleDragActorPlay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400790D RID: 30989
		[Nullable(2)]
		protected new ToggleDragActorPlay FbInstance;

		// Token: 0x0400790E RID: 30990
		[Nullable(2)]
		protected ToggleDragActorPlay_SetValue PocoInterface;
	}
}
