using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F8B RID: 3979
	[NullableContext(1)]
	[Nullable(0)]
	public class IFirstPersonTurretGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x060058B2 RID: 22706 RVA: 0x000D8738 File Offset: 0x000D6938
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

		// Token: 0x060058B3 RID: 22707 RVA: 0x000D8770 File Offset: 0x000D6970
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

		// Token: 0x060058B4 RID: 22708 RVA: 0x000D8783 File Offset: 0x000D6983
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

		// Token: 0x060058B5 RID: 22709 RVA: 0x000D8796 File Offset: 0x000D6996
		public new IFirstPersonTurretGamePlayConfig_SetValue ToSetValue()
		{
			return new IFirstPersonTurretGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x000D87A9 File Offset: 0x000D69A9
		// (set) Token: 0x060058B7 RID: 22711 RVA: 0x000D87D4 File Offset: 0x000D69D4
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

		// Token: 0x04003599 RID: 13721
		[Nullable(2)]
		protected new IFirstPersonTurretGamePlayConfig FbInstance;

		// Token: 0x0400359A RID: 13722
		[Nullable(2)]
		protected new IFirstPersonTurretGamePlayConfig_SetValue PocoInterface;
	}
}
