using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021DF RID: 8671
	public class ITeleportToLatestResetPointDirectly : ITeleportToLatestResetPointType
	{
		// Token: 0x0600BCF2 RID: 48370 RVA: 0x001B5198 File Offset: 0x001B3398
		private ITeleportToLatestResetPointDirectly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportToLatestResetPointDirectly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportToLatestResetPointDirectly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportToLatestResetPointDirectly_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x001B51D0 File Offset: 0x001B33D0
		public static ITeleportToLatestResetPointDirectly Create([Nullable(2)] ITeleportToLatestResetPointDirectly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointDirectly
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x001B51E3 File Offset: 0x001B33E3
		public static ITeleportToLatestResetPointDirectly CreateFromSetValue([Nullable(2)] ITeleportToLatestResetPointDirectly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointDirectly
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x001B51F6 File Offset: 0x001B33F6
		public new ITeleportToLatestResetPointDirectly_SetValue ToSetValue()
		{
			return new ITeleportToLatestResetPointDirectly_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600BCF6 RID: 48374 RVA: 0x001B5209 File Offset: 0x001B3409
		// (set) Token: 0x0600BCF7 RID: 48375 RVA: 0x001B5234 File Offset: 0x001B3434
		public override ETeleportToLatestResetPointType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportToLatestResetPointType.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400717B RID: 29051
		[Nullable(2)]
		protected new ITeleportToLatestResetPointDirectly FbInstance;

		// Token: 0x0400717C RID: 29052
		[Nullable(2)]
		protected new ITeleportToLatestResetPointDirectly_SetValue PocoInterface;
	}
}
