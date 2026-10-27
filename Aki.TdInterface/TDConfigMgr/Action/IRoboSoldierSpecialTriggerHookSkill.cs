using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC2 RID: 7618
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoboSoldierSpecialTriggerHookSkill : IExecClientBattleActionType
	{
		// Token: 0x0600A329 RID: 41769 RVA: 0x00172A34 File Offset: 0x00170C34
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

		// Token: 0x0600A32A RID: 41770 RVA: 0x00172A6C File Offset: 0x00170C6C
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

		// Token: 0x0600A32B RID: 41771 RVA: 0x00172A7F File Offset: 0x00170C7F
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

		// Token: 0x0600A32C RID: 41772 RVA: 0x00172A92 File Offset: 0x00170C92
		public new IRoboSoldierSpecialTriggerHookSkill_SetValue ToSetValue()
		{
			return new IRoboSoldierSpecialTriggerHookSkill_SetValue
			{
				Type = this.Type,
				HookEntityId = this.HookEntityId
			};
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x00172AB1 File Offset: 0x00170CB1
		// (set) Token: 0x0600A32E RID: 41774 RVA: 0x00172ADC File Offset: 0x00170CDC
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

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x00172AEA File Offset: 0x00170CEA
		// (set) Token: 0x0600A330 RID: 41776 RVA: 0x00172B15 File Offset: 0x00170D15
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

		// Token: 0x040061DF RID: 25055
		[Nullable(2)]
		protected new IRoboSoldierSpecialTriggerHookSkill FbInstance;

		// Token: 0x040061E0 RID: 25056
		[Nullable(2)]
		protected new IRoboSoldierSpecialTriggerHookSkill_SetValue PocoInterface;
	}
}
