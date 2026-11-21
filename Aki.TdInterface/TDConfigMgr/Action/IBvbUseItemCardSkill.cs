using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C3 RID: 6595
	public class IBvbUseItemCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x06008C2F RID: 35887 RVA: 0x0014C0C4 File Offset: 0x0014A2C4
		private IBvbUseItemCardSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbUseItemCardSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbUseItemCardSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbUseItemCardSkill_SetValue());
			}
			return result;
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x0014C0FC File Offset: 0x0014A2FC
		public static IBvbUseItemCardSkill Create([Nullable(2)] IBvbUseItemCardSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbUseItemCardSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x0014C10F File Offset: 0x0014A30F
		public static IBvbUseItemCardSkill CreateFromSetValue([Nullable(2)] IBvbUseItemCardSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbUseItemCardSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C32 RID: 35890 RVA: 0x0014C122 File Offset: 0x0014A322
		public new IBvbUseItemCardSkill_SetValue ToSetValue()
		{
			return new IBvbUseItemCardSkill_SetValue
			{
				Type = this.Type,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06008C33 RID: 35891 RVA: 0x0014C141 File Offset: 0x0014A341
		// (set) Token: 0x06008C34 RID: 35892 RVA: 0x0014C16C File Offset: 0x0014A36C
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x0014C17A File Offset: 0x0014A37A
		// (set) Token: 0x06008C36 RID: 35894 RVA: 0x0014C1A1 File Offset: 0x0014A3A1
		[Nullable(2)]
		public virtual List<int> BoardPosIndexList
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndexList;
				}
				IBvbUseItemCardSkill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BoardPosIndexList;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BoardPosIndexList = value;
			}
		}

		// Token: 0x04005860 RID: 22624
		[Nullable(2)]
		protected new IBvbUseItemCardSkill FbInstance;

		// Token: 0x04005861 RID: 22625
		[Nullable(2)]
		protected new IBvbUseItemCardSkill_SetValue PocoInterface;
	}
}
