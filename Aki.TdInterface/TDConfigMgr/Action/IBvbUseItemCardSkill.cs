using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001838 RID: 6200
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbUseItemCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x06008509 RID: 34057 RVA: 0x0013C8D0 File Offset: 0x0013AAD0
		[NullableContext(1)]
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

		// Token: 0x0600850A RID: 34058 RVA: 0x0013C908 File Offset: 0x0013AB08
		[NullableContext(1)]
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

		// Token: 0x0600850B RID: 34059 RVA: 0x0013C91B File Offset: 0x0013AB1B
		[NullableContext(1)]
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

		// Token: 0x0600850C RID: 34060 RVA: 0x0013C92E File Offset: 0x0013AB2E
		[NullableContext(1)]
		public new IBvbUseItemCardSkill_SetValue ToSetValue()
		{
			return new IBvbUseItemCardSkill_SetValue
			{
				Type = this.Type,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x0013C94D File Offset: 0x0013AB4D
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x0013C978 File Offset: 0x0013AB78
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

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600850F RID: 34063 RVA: 0x0013C986 File Offset: 0x0013AB86
		// (set) Token: 0x06008510 RID: 34064 RVA: 0x0013C9AD File Offset: 0x0013ABAD
		public virtual List<int> BoardPosIndexList
		{
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
			set
			{
				this.GetOrCreatePoco().BoardPosIndexList = value;
			}
		}

		// Token: 0x04005414 RID: 21524
		protected new IBvbUseItemCardSkill FbInstance;

		// Token: 0x04005415 RID: 21525
		protected new IBvbUseItemCardSkill_SetValue PocoInterface;
	}
}
