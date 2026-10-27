using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002000 RID: 8192
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerHookPointSkill : IExecClientBattleActionType
	{
		// Token: 0x0600B424 RID: 46116 RVA: 0x001A3000 File Offset: 0x001A1200
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

		// Token: 0x0600B425 RID: 46117 RVA: 0x001A3038 File Offset: 0x001A1238
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

		// Token: 0x0600B426 RID: 46118 RVA: 0x001A304B File Offset: 0x001A124B
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

		// Token: 0x0600B427 RID: 46119 RVA: 0x001A305E File Offset: 0x001A125E
		public new ITriggerHookPointSkill_SetValue ToSetValue()
		{
			return new ITriggerHookPointSkill_SetValue
			{
				Type = this.Type,
				HookEntityId = this.HookEntityId,
				SpecTriggerType = this.SpecTriggerType
			};
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600B428 RID: 46120 RVA: 0x001A3089 File Offset: 0x001A1289
		// (set) Token: 0x0600B429 RID: 46121 RVA: 0x001A30B4 File Offset: 0x001A12B4
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

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600B42A RID: 46122 RVA: 0x001A30C2 File Offset: 0x001A12C2
		// (set) Token: 0x0600B42B RID: 46123 RVA: 0x001A30ED File Offset: 0x001A12ED
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

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600B42C RID: 46124 RVA: 0x001A30FC File Offset: 0x001A12FC
		// (set) Token: 0x0600B42D RID: 46125 RVA: 0x001A3136 File Offset: 0x001A1336
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

		// Token: 0x04006C97 RID: 27799
		[Nullable(2)]
		protected new ITriggerHookPointSkill FbInstance;

		// Token: 0x04006C98 RID: 27800
		[Nullable(2)]
		protected new ITriggerHookPointSkill_SetValue PocoInterface;
	}
}
