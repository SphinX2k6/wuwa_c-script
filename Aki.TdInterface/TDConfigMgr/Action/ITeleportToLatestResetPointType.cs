using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F9E RID: 8094
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportToLatestResetPointType
	{
		// Token: 0x0600B1F6 RID: 45558 RVA: 0x0019EEA4 File Offset: 0x0019D0A4
		private ITeleportToLatestResetPointType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportToLatestResetPointType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportToLatestResetPointType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportToLatestResetPointType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x0019EEDC File Offset: 0x0019D0DC
		public static ITeleportToLatestResetPointType Create([Nullable(2)] ITeleportToLatestResetPointType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x0019EEEF File Offset: 0x0019D0EF
		public static ITeleportToLatestResetPointType CreateFromSetValue([Nullable(2)] ITeleportToLatestResetPointType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportToLatestResetPointType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x0019EF02 File Offset: 0x0019D102
		public ITeleportToLatestResetPointType_SetValue ToSetValue()
		{
			return new ITeleportToLatestResetPointType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600B1FA RID: 45562 RVA: 0x0019EF15 File Offset: 0x0019D115
		// (set) Token: 0x0600B1FB RID: 45563 RVA: 0x0019EF40 File Offset: 0x0019D140
		public virtual ETeleportToLatestResetPointType Type
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

		// Token: 0x04006B83 RID: 27523
		[Nullable(2)]
		protected ITeleportToLatestResetPointType FbInstance;

		// Token: 0x04006B84 RID: 27524
		[Nullable(2)]
		protected ITeleportToLatestResetPointType_SetValue PocoInterface;
	}
}
