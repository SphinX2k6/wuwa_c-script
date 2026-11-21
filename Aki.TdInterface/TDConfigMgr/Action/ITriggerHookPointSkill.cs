using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002247 RID: 8775
	public class ITriggerHookPointSkill : IExecClientBattleActionType
	{
		// Token: 0x0600BF3A RID: 48954 RVA: 0x001B956C File Offset: 0x001B776C
		private ITriggerHookPointSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerHookPointSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerHookPointSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerHookPointSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x001B95A4 File Offset: 0x001B77A4
		public static ITriggerHookPointSkill Create([Nullable(2)] ITriggerHookPointSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerHookPointSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x001B95B7 File Offset: 0x001B77B7
		public static ITriggerHookPointSkill CreateFromSetValue([Nullable(2)] ITriggerHookPointSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerHookPointSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x001B95CA File Offset: 0x001B77CA
		public new ITriggerHookPointSkill_SetValue ToSetValue()
		{
			return new ITriggerHookPointSkill_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId,
				HookEntityId = this.HookEntityId,
				SpecTriggerType = this.SpecTriggerType
			};
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600BF3E RID: 48958 RVA: 0x001B9601 File Offset: 0x001B7801
		// (set) Token: 0x0600BF3F RID: 48959 RVA: 0x001B962C File Offset: 0x001B782C
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

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0600BF40 RID: 48960 RVA: 0x001B963C File Offset: 0x001B783C
		// (set) Token: 0x0600BF41 RID: 48961 RVA: 0x001B9676 File Offset: 0x001B7876
		public virtual int? AssistCharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AssistCharacterId;
				}
				ITriggerHookPointSkill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AssistCharacterId;
			}
			set
			{
				this.GetOrCreatePoco().AssistCharacterId = value;
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x001B9684 File Offset: 0x001B7884
		// (set) Token: 0x0600BF43 RID: 48963 RVA: 0x001B96AF File Offset: 0x001B78AF
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

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600BF44 RID: 48964 RVA: 0x001B96C0 File Offset: 0x001B78C0
		// (set) Token: 0x0600BF45 RID: 48965 RVA: 0x001B96FA File Offset: 0x001B78FA
		public virtual EHookTriggerType? SpecTriggerType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpecTriggerType;
				}
				ITriggerHookPointSkill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpecTriggerType;
			}
			set
			{
				this.GetOrCreatePoco().SpecTriggerType = value;
			}
		}

		// Token: 0x04007299 RID: 29337
		[Nullable(2)]
		protected new ITriggerHookPointSkill FbInstance;

		// Token: 0x0400729A RID: 29338
		[Nullable(2)]
		protected new ITriggerHookPointSkill_SetValue PocoInterface;
	}
}
