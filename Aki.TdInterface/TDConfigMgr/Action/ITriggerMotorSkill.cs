using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002249 RID: 8777
	public class ITriggerMotorSkill : IExecClientBattleActionType
	{
		// Token: 0x0600BF48 RID: 48968 RVA: 0x001B9718 File Offset: 0x001B7918
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

		// Token: 0x0600BF49 RID: 48969 RVA: 0x001B9750 File Offset: 0x001B7950
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

		// Token: 0x0600BF4A RID: 48970 RVA: 0x001B9763 File Offset: 0x001B7963
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

		// Token: 0x0600BF4B RID: 48971 RVA: 0x001B9776 File Offset: 0x001B7976
		public new ITriggerMotorSkill_SetValue ToSetValue()
		{
			return new ITriggerMotorSkill_SetValue
			{
				Type = this.Type,
				MotorSkillId = this.MotorSkillId
			};
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x001B9795 File Offset: 0x001B7995
		// (set) Token: 0x0600BF4D RID: 48973 RVA: 0x001B97C0 File Offset: 0x001B79C0
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

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600BF4E RID: 48974 RVA: 0x001B97CE File Offset: 0x001B79CE
		// (set) Token: 0x0600BF4F RID: 48975 RVA: 0x001B97F9 File Offset: 0x001B79F9
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

		// Token: 0x0400729F RID: 29343
		[Nullable(2)]
		protected new ITriggerMotorSkill FbInstance;

		// Token: 0x040072A0 RID: 29344
		[Nullable(2)]
		protected new ITriggerMotorSkill_SetValue PocoInterface;
	}
}
