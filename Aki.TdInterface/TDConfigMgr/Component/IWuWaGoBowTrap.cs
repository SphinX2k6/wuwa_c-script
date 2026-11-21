using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000898 RID: 2200
	public class IWuWaGoBowTrap : IWuWaGoEntityBase
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x0007A438 File Offset: 0x00078638
		private IWuWaGoBowTrap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoBowTrap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoBowTrap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoBowTrap_SetValue());
			}
			return result;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x0007A470 File Offset: 0x00078670
		public static IWuWaGoBowTrap Create([Nullable(2)] IWuWaGoBowTrap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoBowTrap
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x0007A483 File Offset: 0x00078683
		public static IWuWaGoBowTrap CreateFromSetValue([Nullable(2)] IWuWaGoBowTrap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoBowTrap
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x0007A496 File Offset: 0x00078696
		public new IWuWaGoBowTrap_SetValue ToSetValue()
		{
			return new IWuWaGoBowTrap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x0007A4A9 File Offset: 0x000786A9
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x0007A4D4 File Offset: 0x000786D4
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001F60 RID: 8032
		[Nullable(2)]
		protected new IWuWaGoBowTrap FbInstance;

		// Token: 0x04001F61 RID: 8033
		[Nullable(2)]
		protected new IWuWaGoBowTrap_SetValue PocoInterface;
	}
}
