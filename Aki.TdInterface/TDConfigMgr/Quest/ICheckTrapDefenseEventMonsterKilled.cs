using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F08 RID: 3848
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckTrapDefenseEventMonsterKilled : ICheckTrapDefenseEventBase
	{
		// Token: 0x060054DC RID: 21724 RVA: 0x000D0134 File Offset: 0x000CE334
		private ICheckTrapDefenseEventMonsterKilled_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckTrapDefenseEventMonsterKilled 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckTrapDefenseEventMonsterKilled_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckTrapDefenseEventMonsterKilled_SetValue());
			}
			return result;
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x000D016C File Offset: 0x000CE36C
		public static ICheckTrapDefenseEventMonsterKilled Create([Nullable(2)] ICheckTrapDefenseEventMonsterKilled instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventMonsterKilled
			{
				FbInstance = instance
			};
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x000D017F File Offset: 0x000CE37F
		public static ICheckTrapDefenseEventMonsterKilled CreateFromSetValue([Nullable(2)] ICheckTrapDefenseEventMonsterKilled_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventMonsterKilled
			{
				PocoInterface = value
			};
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x000D0192 File Offset: 0x000CE392
		public new ICheckTrapDefenseEventMonsterKilled_SetValue ToSetValue()
		{
			return new ICheckTrapDefenseEventMonsterKilled_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x000D01B1 File Offset: 0x000CE3B1
		// (set) Token: 0x060054E1 RID: 21729 RVA: 0x000D01DC File Offset: 0x000CE3DC
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x000D01EA File Offset: 0x000CE3EA
		// (set) Token: 0x060054E3 RID: 21731 RVA: 0x000D0215 File Offset: 0x000CE415
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x0400335C RID: 13148
		[Nullable(2)]
		protected new ICheckTrapDefenseEventMonsterKilled FbInstance;

		// Token: 0x0400335D RID: 13149
		[Nullable(2)]
		protected new ICheckTrapDefenseEventMonsterKilled_SetValue PocoInterface;
	}
}
