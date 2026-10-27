using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F9C RID: 8092
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportToLatestResetPointDirectly : ITeleportToLatestResetPointType
	{
		// Token: 0x0600B1EE RID: 45550 RVA: 0x0019EDE8 File Offset: 0x0019CFE8
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

		// Token: 0x0600B1EF RID: 45551 RVA: 0x0019EE20 File Offset: 0x0019D020
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

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x0019EE33 File Offset: 0x0019D033
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

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x0019EE46 File Offset: 0x0019D046
		public new ITeleportToLatestResetPointDirectly_SetValue ToSetValue()
		{
			return new ITeleportToLatestResetPointDirectly_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600B1F2 RID: 45554 RVA: 0x0019EE59 File Offset: 0x0019D059
		// (set) Token: 0x0600B1F3 RID: 45555 RVA: 0x0019EE84 File Offset: 0x0019D084
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

		// Token: 0x04006B80 RID: 27520
		[Nullable(2)]
		protected new ITeleportToLatestResetPointDirectly FbInstance;

		// Token: 0x04006B81 RID: 27521
		[Nullable(2)]
		protected new ITeleportToLatestResetPointDirectly_SetValue PocoInterface;
	}
}
