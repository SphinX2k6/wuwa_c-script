using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD9 RID: 8153
	public class IRoboSoldierSpecialTriggerHookSkill : IExecClientBattleActionType
	{
		// Token: 0x0600AD33 RID: 44339 RVA: 0x0018715C File Offset: 0x0018535C
		private IRoboSoldierSpecialTriggerHookSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoboSoldierSpecialTriggerHookSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoboSoldierSpecialTriggerHookSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoboSoldierSpecialTriggerHookSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x00187194 File Offset: 0x00185394
		public static IRoboSoldierSpecialTriggerHookSkill Create([Nullable(2)] IRoboSoldierSpecialTriggerHookSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoboSoldierSpecialTriggerHookSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x001871A7 File Offset: 0x001853A7
		public static IRoboSoldierSpecialTriggerHookSkill CreateFromSetValue([Nullable(2)] IRoboSoldierSpecialTriggerHookSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoboSoldierSpecialTriggerHookSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x001871BA File Offset: 0x001853BA
		public new IRoboSoldierSpecialTriggerHookSkill_SetValue ToSetValue()
		{
			return new IRoboSoldierSpecialTriggerHookSkill_SetValue
			{
				Type = this.Type,
				HookEntityId = this.HookEntityId
			};
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x001871D9 File Offset: 0x001853D9
		// (set) Token: 0x0600AD38 RID: 44344 RVA: 0x00187204 File Offset: 0x00185404
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

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x00187212 File Offset: 0x00185412
		// (set) Token: 0x0600AD3A RID: 44346 RVA: 0x0018723D File Offset: 0x0018543D
		public virtual int HookEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HookEntityId;
			}
			set
			{
				this.GetOrCreatePoco().HookEntityId = value;
			}
		}

		// Token: 0x04006767 RID: 26471
		[Nullable(2)]
		protected new IRoboSoldierSpecialTriggerHookSkill FbInstance;

		// Token: 0x04006768 RID: 26472
		[Nullable(2)]
		protected new IRoboSoldierSpecialTriggerHookSkill_SetValue PocoInterface;
	}
}
