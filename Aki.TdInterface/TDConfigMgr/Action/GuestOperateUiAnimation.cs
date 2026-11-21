using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018BB RID: 6331
	public class GuestOperateUiAnimation : ActionParams
	{
		// Token: 0x060084C5 RID: 33989 RVA: 0x0013CCAC File Offset: 0x0013AEAC
		private GuestOperateUiAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GuestOperateUiAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GuestOperateUiAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GuestOperateUiAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x0013CCE4 File Offset: 0x0013AEE4
		public static GuestOperateUiAnimation Create([Nullable(2)] GuestOperateUiAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GuestOperateUiAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x0013CCF7 File Offset: 0x0013AEF7
		public static GuestOperateUiAnimation CreateFromSetValue([Nullable(2)] GuestOperateUiAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GuestOperateUiAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x0013CD0A File Offset: 0x0013AF0A
		public GuestOperateUiAnimation_SetValue ToSetValue()
		{
			return new GuestOperateUiAnimation_SetValue
			{
				UiAnimationConfig = this.UiAnimationConfig
			};
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x060084C9 RID: 33993 RVA: 0x0013CD1D File Offset: 0x0013AF1D
		// (set) Token: 0x060084CA RID: 33994 RVA: 0x0013CD44 File Offset: 0x0013AF44
		public virtual IGuestOperateUiAnimationType UiAnimationConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiAnimationConfig;
				}
				GuestOperateUiAnimation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiAnimationConfig;
			}
			set
			{
				this.GetOrCreatePoco().UiAnimationConfig = value;
			}
		}

		// Token: 0x04005474 RID: 21620
		[Nullable(2)]
		protected new GuestOperateUiAnimation FbInstance;

		// Token: 0x04005475 RID: 21621
		[Nullable(2)]
		protected GuestOperateUiAnimation_SetValue PocoInterface;
	}
}
