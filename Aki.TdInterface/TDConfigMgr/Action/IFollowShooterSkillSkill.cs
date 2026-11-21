using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C54 RID: 7252
	public class IFollowShooterSkillSkill : IExecClientBattleActionType
	{
		// Token: 0x06009A34 RID: 39476 RVA: 0x00164FF8 File Offset: 0x001631F8
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

		// Token: 0x06009A35 RID: 39477 RVA: 0x00165030 File Offset: 0x00163230
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

		// Token: 0x06009A36 RID: 39478 RVA: 0x00165043 File Offset: 0x00163243
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

		// Token: 0x06009A37 RID: 39479 RVA: 0x00165056 File Offset: 0x00163256
		public new IFollowShooterSkillSkill_SetValue ToSetValue()
		{
			return new IFollowShooterSkillSkill_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06009A38 RID: 39480 RVA: 0x00165075 File Offset: 0x00163275
		// (set) Token: 0x06009A39 RID: 39481 RVA: 0x001650A0 File Offset: 0x001632A0
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

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x06009A3A RID: 39482 RVA: 0x001650AE File Offset: 0x001632AE
		// (set) Token: 0x06009A3B RID: 39483 RVA: 0x001650D9 File Offset: 0x001632D9
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

		// Token: 0x04005EB8 RID: 24248
		[Nullable(2)]
		protected new IFollowShooterSkillSkill FbInstance;

		// Token: 0x04005EB9 RID: 24249
		[Nullable(2)]
		protected new IFollowShooterSkillSkill_SetValue PocoInterface;
	}
}
