using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002217 RID: 8727
	public class IToggleRideFlyingCarUiGameplayConfig
	{
		// Token: 0x0600BE48 RID: 48712 RVA: 0x001B7A14 File Offset: 0x001B5C14
		private IToggleRideFlyingCarUiGameplayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleRideFlyingCarUiGameplayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleRideFlyingCarUiGameplayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleRideFlyingCarUiGameplayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x001B7A4C File Offset: 0x001B5C4C
		public static IToggleRideFlyingCarUiGameplayConfig Create([Nullable(2)] IToggleRideFlyingCarUiGameplayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleRideFlyingCarUiGameplayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x001B7A5F File Offset: 0x001B5C5F
		public static IToggleRideFlyingCarUiGameplayConfig CreateFromSetValue([Nullable(2)] IToggleRideFlyingCarUiGameplayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleRideFlyingCarUiGameplayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x001B7A72 File Offset: 0x001B5C72
		public IToggleRideFlyingCarUiGameplayConfig_SetValue ToSetValue()
		{
			return new IToggleRideFlyingCarUiGameplayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600BE4C RID: 48716 RVA: 0x001B7A85 File Offset: 0x001B5C85
		// (set) Token: 0x0600BE4D RID: 48717 RVA: 0x001B7AB0 File Offset: 0x001B5CB0
		public virtual EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleRideFlyingCarUiGameplayType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007224 RID: 29220
		[Nullable(2)]
		protected IToggleRideFlyingCarUiGameplayConfig FbInstance;

		// Token: 0x04007225 RID: 29221
		[Nullable(2)]
		protected IToggleRideFlyingCarUiGameplayConfig_SetValue PocoInterface;
	}
}
