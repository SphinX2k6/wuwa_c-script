using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002124 RID: 8484
	public class ISummonEntityType
	{
		// Token: 0x0600B420 RID: 46112 RVA: 0x00193D38 File Offset: 0x00191F38
		private ISummonEntityType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISummonEntityType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISummonEntityType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISummonEntityType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x00193D70 File Offset: 0x00191F70
		public static ISummonEntityType Create([Nullable(2)] ISummonEntityType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonEntityType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x00193D83 File Offset: 0x00191F83
		public static ISummonEntityType CreateFromSetValue([Nullable(2)] ISummonEntityType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISummonEntityType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x00193D96 File Offset: 0x00191F96
		public ISummonEntityType_SetValue ToSetValue()
		{
			return new ISummonEntityType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600B424 RID: 46116 RVA: 0x00193DA9 File Offset: 0x00191FA9
		// (set) Token: 0x0600B425 RID: 46117 RVA: 0x00193DD4 File Offset: 0x00191FD4
		public virtual ESummonEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESummonEntityType.Vehicle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006AAE RID: 27310
		[Nullable(2)]
		protected ISummonEntityType FbInstance;

		// Token: 0x04006AAF RID: 27311
		[Nullable(2)]
		protected ISummonEntityType_SetValue PocoInterface;
	}
}
