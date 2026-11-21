using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6C RID: 7276
	public class IGamepadShakeConfig
	{
		// Token: 0x06009AB6 RID: 39606 RVA: 0x00165E68 File Offset: 0x00164068
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

		// Token: 0x06009AB7 RID: 39607 RVA: 0x00165EA0 File Offset: 0x001640A0
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

		// Token: 0x06009AB8 RID: 39608 RVA: 0x00165EB3 File Offset: 0x001640B3
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

		// Token: 0x06009AB9 RID: 39609 RVA: 0x00165EC6 File Offset: 0x001640C6
		public IGamepadShakeConfig_SetValue ToSetValue()
		{
			return new IGamepadShakeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x00165ED9 File Offset: 0x001640D9
		// (set) Token: 0x06009ABB RID: 39611 RVA: 0x00165F04 File Offset: 0x00164104
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

		// Token: 0x04005EF3 RID: 24307
		[Nullable(2)]
		protected IGamepadShakeConfig FbInstance;

		// Token: 0x04005EF4 RID: 24308
		[Nullable(2)]
		protected IGamepadShakeConfig_SetValue PocoInterface;
	}
}
