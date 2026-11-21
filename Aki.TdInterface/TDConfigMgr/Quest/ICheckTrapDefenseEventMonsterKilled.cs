using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200101E RID: 4126
	public class ICheckTrapDefenseEventMonsterKilled : ICheckTrapDefenseEventBase
	{
		// Token: 0x06005A58 RID: 23128 RVA: 0x000DC2DC File Offset: 0x000DA4DC
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

		// Token: 0x06005A59 RID: 23129 RVA: 0x000DC314 File Offset: 0x000DA514
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

		// Token: 0x06005A5A RID: 23130 RVA: 0x000DC327 File Offset: 0x000DA527
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

		// Token: 0x06005A5B RID: 23131 RVA: 0x000DC33A File Offset: 0x000DA53A
		public new ICheckTrapDefenseEventMonsterKilled_SetValue ToSetValue()
		{
			return new ICheckTrapDefenseEventMonsterKilled_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x000DC359 File Offset: 0x000DA559
		// (set) Token: 0x06005A5D RID: 23133 RVA: 0x000DC384 File Offset: 0x000DA584
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

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06005A5E RID: 23134 RVA: 0x000DC392 File Offset: 0x000DA592
		// (set) Token: 0x06005A5F RID: 23135 RVA: 0x000DC3BD File Offset: 0x000DA5BD
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

		// Token: 0x04003669 RID: 13929
		[Nullable(2)]
		protected new ICheckTrapDefenseEventMonsterKilled FbInstance;

		// Token: 0x0400366A RID: 13930
		[Nullable(2)]
		protected new ICheckTrapDefenseEventMonsterKilled_SetValue PocoInterface;
	}
}
