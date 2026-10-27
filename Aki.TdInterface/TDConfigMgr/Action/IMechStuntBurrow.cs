using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCE RID: 7118
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntBurrow : IMechStuntConfigType
	{
		// Token: 0x06009889 RID: 39049 RVA: 0x0015F92C File Offset: 0x0015DB2C
		private IMechStuntBurrow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntBurrow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntBurrow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntBurrow_SetValue());
			}
			return result;
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x0015F964 File Offset: 0x0015DB64
		public static IMechStuntBurrow Create([Nullable(2)] IMechStuntBurrow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntBurrow
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x0015F977 File Offset: 0x0015DB77
		public static IMechStuntBurrow CreateFromSetValue([Nullable(2)] IMechStuntBurrow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntBurrow
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x0015F98A File Offset: 0x0015DB8A
		public new IMechStuntBurrow_SetValue ToSetValue()
		{
			return new IMechStuntBurrow_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600988D RID: 39053 RVA: 0x0015F99D File Offset: 0x0015DB9D
		// (set) Token: 0x0600988E RID: 39054 RVA: 0x0015F9C8 File Offset: 0x0015DBC8
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

		// Token: 0x04005D07 RID: 23815
		[Nullable(2)]
		protected new IMechStuntBurrow FbInstance;

		// Token: 0x04005D08 RID: 23816
		[Nullable(2)]
		protected new IMechStuntBurrow_SetValue PocoInterface;
	}
}
