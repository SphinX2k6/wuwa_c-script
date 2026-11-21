using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BD RID: 9149
	public class ResetEntity : ActionParams
	{
		// Token: 0x0600C778 RID: 51064 RVA: 0x001C8B1C File Offset: 0x001C6D1C
		private ResetEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x001C8B54 File Offset: 0x001C6D54
		public static ResetEntity Create([Nullable(2)] ResetEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x001C8B67 File Offset: 0x001C6D67
		public static ResetEntity CreateFromSetValue([Nullable(2)] ResetEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x001C8B7A File Offset: 0x001C6D7A
		public ResetEntity_SetValue ToSetValue()
		{
			return new ResetEntity_SetValue
			{
				ResetEntityConfig = this.ResetEntityConfig
			};
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0600C77C RID: 51068 RVA: 0x001C8B8D File Offset: 0x001C6D8D
		// (set) Token: 0x0600C77D RID: 51069 RVA: 0x001C8BB4 File Offset: 0x001C6DB4
		public virtual IResetEntityConfig ResetEntityConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetEntityConfig;
				}
				ResetEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetEntityConfig;
			}
			set
			{
				this.GetOrCreatePoco().ResetEntityConfig = value;
			}
		}

		// Token: 0x04007681 RID: 30337
		[Nullable(2)]
		protected new ResetEntity FbInstance;

		// Token: 0x04007682 RID: 30338
		[Nullable(2)]
		protected ResetEntity_SetValue PocoInterface;
	}
}
