using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BF RID: 9151
	public class ResetEntityPos : ActionParams
	{
		// Token: 0x0600C780 RID: 51072 RVA: 0x001C8BD4 File Offset: 0x001C6DD4
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

		// Token: 0x0600C781 RID: 51073 RVA: 0x001C8C0C File Offset: 0x001C6E0C
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

		// Token: 0x0600C782 RID: 51074 RVA: 0x001C8C1F File Offset: 0x001C6E1F
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

		// Token: 0x0600C783 RID: 51075 RVA: 0x001C8C32 File Offset: 0x001C6E32
		public ResetEntityPos_SetValue ToSetValue()
		{
			return new ResetEntityPos_SetValue
			{
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0600C784 RID: 51076 RVA: 0x001C8C45 File Offset: 0x001C6E45
		// (set) Token: 0x0600C785 RID: 51077 RVA: 0x001C8C70 File Offset: 0x001C6E70
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

		// Token: 0x04007684 RID: 30340
		[Nullable(2)]
		protected new ResetEntityPos FbInstance;

		// Token: 0x04007685 RID: 30341
		[Nullable(2)]
		protected ResetEntityPos_SetValue PocoInterface;
	}
}
