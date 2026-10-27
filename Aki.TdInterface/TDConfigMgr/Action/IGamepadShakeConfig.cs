using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC5 RID: 6853
	[NullableContext(1)]
	[Nullable(0)]
	public class IGamepadShakeConfig
	{
		// Token: 0x060092F8 RID: 37624 RVA: 0x00155648 File Offset: 0x00153848
		private IGamepadShakeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGamepadShakeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGamepadShakeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGamepadShakeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x00155680 File Offset: 0x00153880
		public static IGamepadShakeConfig Create([Nullable(2)] IGamepadShakeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x00155693 File Offset: 0x00153893
		public static IGamepadShakeConfig CreateFromSetValue([Nullable(2)] IGamepadShakeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGamepadShakeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x001556A6 File Offset: 0x001538A6
		public IGamepadShakeConfig_SetValue ToSetValue()
		{
			return new IGamepadShakeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x001556B9 File Offset: 0x001538B9
		// (set) Token: 0x060092FD RID: 37629 RVA: 0x001556E4 File Offset: 0x001538E4
		public virtual EGamepadShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGamepadShakeType.Onetime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A69 RID: 23145
		[Nullable(2)]
		protected IGamepadShakeConfig FbInstance;

		// Token: 0x04005A6A RID: 23146
		[Nullable(2)]
		protected IGamepadShakeConfig_SetValue PocoInterface;
	}
}
