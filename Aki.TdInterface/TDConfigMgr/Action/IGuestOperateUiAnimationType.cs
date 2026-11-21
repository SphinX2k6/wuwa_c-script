using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8C RID: 7308
	public class IGuestOperateUiAnimationType
	{
		// Token: 0x06009B48 RID: 39752 RVA: 0x00166D44 File Offset: 0x00164F44
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

		// Token: 0x06009B49 RID: 39753 RVA: 0x00166D7C File Offset: 0x00164F7C
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

		// Token: 0x06009B4A RID: 39754 RVA: 0x00166D8F File Offset: 0x00164F8F
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

		// Token: 0x06009B4B RID: 39755 RVA: 0x00166DA2 File Offset: 0x00164FA2
		public IGuestOperateUiAnimationType_SetValue ToSetValue()
		{
			return new IGuestOperateUiAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06009B4C RID: 39756 RVA: 0x00166DB5 File Offset: 0x00164FB5
		// (set) Token: 0x06009B4D RID: 39757 RVA: 0x00166DE0 File Offset: 0x00164FE0
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

		// Token: 0x04005F30 RID: 24368
		[Nullable(2)]
		protected IGuestOperateUiAnimationType FbInstance;

		// Token: 0x04005F31 RID: 24369
		[Nullable(2)]
		protected IGuestOperateUiAnimationType_SetValue PocoInterface;
	}
}
