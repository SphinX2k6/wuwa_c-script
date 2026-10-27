using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215E RID: 8542
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetEntityPos : ActionParams
	{
		// Token: 0x0600BBF2 RID: 48114 RVA: 0x001B1A20 File Offset: 0x001AFC20
		private ResetEntityPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetEntityPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetEntityPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetEntityPos_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBF3 RID: 48115 RVA: 0x001B1A58 File Offset: 0x001AFC58
		public static ResetEntityPos Create([Nullable(2)] ResetEntityPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetEntityPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBF4 RID: 48116 RVA: 0x001B1A6B File Offset: 0x001AFC6B
		public static ResetEntityPos CreateFromSetValue([Nullable(2)] ResetEntityPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetEntityPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBF5 RID: 48117 RVA: 0x001B1A7E File Offset: 0x001AFC7E
		public ResetEntityPos_SetValue ToSetValue()
		{
			return new ResetEntityPos_SetValue
			{
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600BBF6 RID: 48118 RVA: 0x001B1A91 File Offset: 0x001AFC91
		// (set) Token: 0x0600BBF7 RID: 48119 RVA: 0x001B1ABC File Offset: 0x001AFCBC
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x0400704F RID: 28751
		[Nullable(2)]
		protected new ResetEntityPos FbInstance;

		// Token: 0x04007050 RID: 28752
		[Nullable(2)]
		protected ResetEntityPos_SetValue PocoInterface;
	}
}
