using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F5 RID: 2037
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoBowTrap : IWuWaGoEntityBase
	{
		// Token: 0x06002C41 RID: 11329 RVA: 0x000730D4 File Offset: 0x000712D4
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

		// Token: 0x06002C42 RID: 11330 RVA: 0x0007310C File Offset: 0x0007130C
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

		// Token: 0x06002C43 RID: 11331 RVA: 0x0007311F File Offset: 0x0007131F
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

		// Token: 0x06002C44 RID: 11332 RVA: 0x00073132 File Offset: 0x00071332
		public new IWuWaGoBowTrap_SetValue ToSetValue()
		{
			return new IWuWaGoBowTrap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00073145 File Offset: 0x00071345
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x00073170 File Offset: 0x00071370
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

		// Token: 0x04001D54 RID: 7508
		[Nullable(2)]
		protected new IWuWaGoBowTrap FbInstance;

		// Token: 0x04001D55 RID: 7509
		[Nullable(2)]
		protected new IWuWaGoBowTrap_SetValue PocoInterface;
	}
}
