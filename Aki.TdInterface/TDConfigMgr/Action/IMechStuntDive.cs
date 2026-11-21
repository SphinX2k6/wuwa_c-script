using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DBD RID: 7613
	public class IMechStuntDive : IMechStuntConfigType
	{
		// Token: 0x0600A1AF RID: 41391 RVA: 0x00172720 File Offset: 0x00170920
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

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x00172758 File Offset: 0x00170958
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

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x0017276B File Offset: 0x0017096B
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

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x0017277E File Offset: 0x0017097E
		public new IMechStuntDive_SetValue ToSetValue()
		{
			return new IMechStuntDive_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A1B3 RID: 41395 RVA: 0x00172791 File Offset: 0x00170991
		// (set) Token: 0x0600A1B4 RID: 41396 RVA: 0x001727BC File Offset: 0x001709BC
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

		// Token: 0x04006229 RID: 25129
		[Nullable(2)]
		protected new IMechStuntDive FbInstance;

		// Token: 0x0400622A RID: 25130
		[Nullable(2)]
		protected new IMechStuntDive_SetValue PocoInterface;
	}
}
