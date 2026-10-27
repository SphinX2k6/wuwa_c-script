using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB5 RID: 6837
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowShooterSkillSkill : IExecClientBattleActionType
	{
		// Token: 0x0600929C RID: 37532 RVA: 0x00154BD8 File Offset: 0x00152DD8
		private IFollowShooterSkillSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowShooterSkillSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowShooterSkillSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowShooterSkillSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x00154C10 File Offset: 0x00152E10
		public static IFollowShooterSkillSkill Create([Nullable(2)] IFollowShooterSkillSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterSkillSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x00154C23 File Offset: 0x00152E23
		public static IFollowShooterSkillSkill CreateFromSetValue([Nullable(2)] IFollowShooterSkillSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowShooterSkillSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x00154C36 File Offset: 0x00152E36
		public new IFollowShooterSkillSkill_SetValue ToSetValue()
		{
			return new IFollowShooterSkillSkill_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x060092A0 RID: 37536 RVA: 0x00154C55 File Offset: 0x00152E55
		// (set) Token: 0x060092A1 RID: 37537 RVA: 0x00154C80 File Offset: 0x00152E80
		public override EExecClientBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x060092A2 RID: 37538 RVA: 0x00154C8E File Offset: 0x00152E8E
		// (set) Token: 0x060092A3 RID: 37539 RVA: 0x00154CB9 File Offset: 0x00152EB9
		public virtual int SkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillId;
			}
			set
			{
				this.GetOrCreatePoco().SkillId = value;
			}
		}

		// Token: 0x04005A3F RID: 23103
		[Nullable(2)]
		protected new IFollowShooterSkillSkill FbInstance;

		// Token: 0x04005A40 RID: 23104
		[Nullable(2)]
		protected new IFollowShooterSkillSkill_SetValue PocoInterface;
	}
}
