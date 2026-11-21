using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBB RID: 8123
	public class IResetEntityConfig
	{
		// Token: 0x0600ACA9 RID: 44201 RVA: 0x00186354 File Offset: 0x00184554
		private IResetEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x0018638C File Offset: 0x0018458C
		public static IResetEntityConfig Create([Nullable(2)] IResetEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x0018639F File Offset: 0x0018459F
		public static IResetEntityConfig CreateFromSetValue([Nullable(2)] IResetEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x001863B2 File Offset: 0x001845B2
		public IResetEntityConfig_SetValue ToSetValue()
		{
			return new IResetEntityConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x001863C5 File Offset: 0x001845C5
		// (set) Token: 0x0600ACAE RID: 44206 RVA: 0x001863F0 File Offset: 0x001845F0
		public virtual EResetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetEntityType.TeleControl;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400672D RID: 26413
		[Nullable(2)]
		protected IResetEntityConfig FbInstance;

		// Token: 0x0400672E RID: 26414
		[Nullable(2)]
		protected IResetEntityConfig_SetValue PocoInterface;
	}
}
