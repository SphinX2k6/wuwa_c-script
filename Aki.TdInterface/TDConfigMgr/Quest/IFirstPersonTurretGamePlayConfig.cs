using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B5 RID: 4277
	public class IFirstPersonTurretGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06005E84 RID: 24196 RVA: 0x000E5160 File Offset: 0x000E3360
		private IFirstPersonTurretGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFirstPersonTurretGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFirstPersonTurretGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFirstPersonTurretGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x000E5198 File Offset: 0x000E3398
		public static IFirstPersonTurretGamePlayConfig Create([Nullable(2)] IFirstPersonTurretGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFirstPersonTurretGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x000E51AB File Offset: 0x000E33AB
		public static IFirstPersonTurretGamePlayConfig CreateFromSetValue([Nullable(2)] IFirstPersonTurretGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFirstPersonTurretGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x000E51BE File Offset: 0x000E33BE
		public new IFirstPersonTurretGamePlayConfig_SetValue ToSetValue()
		{
			return new IFirstPersonTurretGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06005E88 RID: 24200 RVA: 0x000E51D1 File Offset: 0x000E33D1
		// (set) Token: 0x06005E89 RID: 24201 RVA: 0x000E51FC File Offset: 0x000E33FC
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040038C9 RID: 14537
		[Nullable(2)]
		protected new IFirstPersonTurretGamePlayConfig FbInstance;

		// Token: 0x040038CA RID: 14538
		[Nullable(2)]
		protected new IFirstPersonTurretGamePlayConfig_SetValue PocoInterface;
	}
}
