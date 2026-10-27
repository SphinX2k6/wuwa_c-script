using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002242 RID: 8770
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleDragActorPlay : ActionParams
	{
		// Token: 0x0600C07A RID: 49274 RVA: 0x001BA2AC File Offset: 0x001B84AC
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

		// Token: 0x0600C07B RID: 49275 RVA: 0x001BA2E4 File Offset: 0x001B84E4
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

		// Token: 0x0600C07C RID: 49276 RVA: 0x001BA2F7 File Offset: 0x001B84F7
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

		// Token: 0x0600C07D RID: 49277 RVA: 0x001BA30A File Offset: 0x001B850A
		public ToggleDragActorPlay_SetValue ToSetValue()
		{
			return new ToggleDragActorPlay_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600C07E RID: 49278 RVA: 0x001BA31D File Offset: 0x001B851D
		// (set) Token: 0x0600C07F RID: 49279 RVA: 0x001BA344 File Offset: 0x001B8544
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

		// Token: 0x040072C3 RID: 29379
		[Nullable(2)]
		protected new ToggleDragActorPlay FbInstance;

		// Token: 0x040072C4 RID: 29380
		[Nullable(2)]
		protected ToggleDragActorPlay_SetValue PocoInterface;
	}
}
