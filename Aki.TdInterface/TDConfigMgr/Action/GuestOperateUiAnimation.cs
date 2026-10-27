using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200173C RID: 5948
	[NullableContext(1)]
	[Nullable(0)]
	public class GuestOperateUiAnimation : ActionParams
	{
		// Token: 0x06007DDD RID: 32221 RVA: 0x0012DB04 File Offset: 0x0012BD04
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

		// Token: 0x06007DDE RID: 32222 RVA: 0x0012DB3C File Offset: 0x0012BD3C
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

		// Token: 0x06007DDF RID: 32223 RVA: 0x0012DB4F File Offset: 0x0012BD4F
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

		// Token: 0x06007DE0 RID: 32224 RVA: 0x0012DB62 File Offset: 0x0012BD62
		public GuestOperateUiAnimation_SetValue ToSetValue()
		{
			return new GuestOperateUiAnimation_SetValue
			{
				UiAnimationConfig = this.UiAnimationConfig
			};
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06007DE1 RID: 32225 RVA: 0x0012DB75 File Offset: 0x0012BD75
		// (set) Token: 0x06007DE2 RID: 32226 RVA: 0x0012DB9C File Offset: 0x0012BD9C
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

		// Token: 0x04005041 RID: 20545
		[Nullable(2)]
		protected new GuestOperateUiAnimation FbInstance;

		// Token: 0x04005042 RID: 20546
		[Nullable(2)]
		protected GuestOperateUiAnimation_SetValue PocoInterface;
	}
}
