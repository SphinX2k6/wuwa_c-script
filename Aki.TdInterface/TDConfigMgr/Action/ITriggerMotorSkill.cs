using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002002 RID: 8194
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerMotorSkill : IExecClientBattleActionType
	{
		// Token: 0x0600B430 RID: 46128 RVA: 0x001A3154 File Offset: 0x001A1354
		private ITriggerMotorSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerMotorSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerMotorSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerMotorSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x001A318C File Offset: 0x001A138C
		public static ITriggerMotorSkill Create([Nullable(2)] ITriggerMotorSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerMotorSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x001A319F File Offset: 0x001A139F
		public static ITriggerMotorSkill CreateFromSetValue([Nullable(2)] ITriggerMotorSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerMotorSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x001A31B2 File Offset: 0x001A13B2
		public new ITriggerMotorSkill_SetValue ToSetValue()
		{
			return new ITriggerMotorSkill_SetValue
			{
				Type = this.Type,
				MotorSkillId = this.MotorSkillId
			};
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600B434 RID: 46132 RVA: 0x001A31D1 File Offset: 0x001A13D1
		// (set) Token: 0x0600B435 RID: 46133 RVA: 0x001A31FC File Offset: 0x001A13FC
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

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600B436 RID: 46134 RVA: 0x001A320A File Offset: 0x001A140A
		// (set) Token: 0x0600B437 RID: 46135 RVA: 0x001A3235 File Offset: 0x001A1435
		public virtual int MotorSkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotorSkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MotorSkillId;
			}
			set
			{
				this.GetOrCreatePoco().MotorSkillId = value;
			}
		}

		// Token: 0x04006C9C RID: 27804
		[Nullable(2)]
		protected new ITriggerMotorSkill FbInstance;

		// Token: 0x04006C9D RID: 27805
		[Nullable(2)]
		protected new ITriggerMotorSkill_SetValue PocoInterface;
	}
}
