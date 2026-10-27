using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE5 RID: 6885
	[NullableContext(1)]
	[Nullable(0)]
	public class IGuestOperateUiAnimationType
	{
		// Token: 0x0600938A RID: 37770 RVA: 0x00156524 File Offset: 0x00154724
		private IGuestOperateUiAnimationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGuestOperateUiAnimationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGuestOperateUiAnimationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGuestOperateUiAnimationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x0015655C File Offset: 0x0015475C
		public static IGuestOperateUiAnimationType Create([Nullable(2)] IGuestOperateUiAnimationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGuestOperateUiAnimationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x0015656F File Offset: 0x0015476F
		public static IGuestOperateUiAnimationType CreateFromSetValue([Nullable(2)] IGuestOperateUiAnimationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGuestOperateUiAnimationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x00156582 File Offset: 0x00154782
		public IGuestOperateUiAnimationType_SetValue ToSetValue()
		{
			return new IGuestOperateUiAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x00156595 File Offset: 0x00154795
		// (set) Token: 0x0600938F RID: 37775 RVA: 0x001565C0 File Offset: 0x001547C0
		public virtual EGuestOperateUiAnimation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGuestOperateUiAnimation.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AA6 RID: 23206
		[Nullable(2)]
		protected IGuestOperateUiAnimationType FbInstance;

		// Token: 0x04005AA7 RID: 23207
		[Nullable(2)]
		protected IGuestOperateUiAnimationType_SetValue PocoInterface;
	}
}
