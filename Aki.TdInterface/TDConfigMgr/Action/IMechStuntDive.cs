using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD4 RID: 7124
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntDive : IMechStuntConfigType
	{
		// Token: 0x060098A1 RID: 39073 RVA: 0x0015FB60 File Offset: 0x0015DD60
		private IMechStuntDive_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntDive 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntDive_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntDive_SetValue());
			}
			return result;
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x0015FB98 File Offset: 0x0015DD98
		public static IMechStuntDive Create([Nullable(2)] IMechStuntDive instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntDive
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x0015FBAB File Offset: 0x0015DDAB
		public static IMechStuntDive CreateFromSetValue([Nullable(2)] IMechStuntDive_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntDive
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x0015FBBE File Offset: 0x0015DDBE
		public new IMechStuntDive_SetValue ToSetValue()
		{
			return new IMechStuntDive_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x060098A5 RID: 39077 RVA: 0x0015FBD1 File Offset: 0x0015DDD1
		// (set) Token: 0x060098A6 RID: 39078 RVA: 0x0015FBFC File Offset: 0x0015DDFC
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D10 RID: 23824
		[Nullable(2)]
		protected new IMechStuntDive FbInstance;

		// Token: 0x04005D11 RID: 23825
		[Nullable(2)]
		protected new IMechStuntDive_SetValue PocoInterface;
	}
}
