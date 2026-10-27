using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF6 RID: 7158
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteract : IExecClientBattleActionType
	{
		// Token: 0x06009949 RID: 39241 RVA: 0x00160CD4 File Offset: 0x0015EED4
		private IMonsterNpcInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600994A RID: 39242 RVA: 0x00160D0C File Offset: 0x0015EF0C
		public static IMonsterNpcInteract Create([Nullable(2)] IMonsterNpcInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x00160D1F File Offset: 0x0015EF1F
		public static IMonsterNpcInteract CreateFromSetValue([Nullable(2)] IMonsterNpcInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x00160D32 File Offset: 0x0015EF32
		public new IMonsterNpcInteract_SetValue ToSetValue()
		{
			return new IMonsterNpcInteract_SetValue
			{
				Type = this.Type,
				MonsterNpcEntityId = this.MonsterNpcEntityId,
				Config = this.Config
			};
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600994D RID: 39245 RVA: 0x00160D5D File Offset: 0x0015EF5D
		// (set) Token: 0x0600994E RID: 39246 RVA: 0x00160D88 File Offset: 0x0015EF88
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

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600994F RID: 39247 RVA: 0x00160D96 File Offset: 0x0015EF96
		// (set) Token: 0x06009950 RID: 39248 RVA: 0x00160DC1 File Offset: 0x0015EFC1
		public virtual int MonsterNpcEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterNpcEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MonsterNpcEntityId;
			}
			set
			{
				this.GetOrCreatePoco().MonsterNpcEntityId = value;
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x06009951 RID: 39249 RVA: 0x00160DD0 File Offset: 0x0015EFD0
		// (set) Token: 0x06009952 RID: 39250 RVA: 0x00160E31 File Offset: 0x0015F031
		public virtual IMonsterNpcInteractTriggerHook Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IMonsterNpcInteractTriggerHook.Create(this.FbInstance.Config);
				}
				else
				{
					IMonsterNpcInteract_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04005D57 RID: 23895
		[Nullable(2)]
		protected new IMonsterNpcInteract FbInstance;

		// Token: 0x04005D58 RID: 23896
		[Nullable(2)]
		protected new IMonsterNpcInteract_SetValue PocoInterface;

		// Token: 0x04005D59 RID: 23897
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x04005D5A RID: 23898
		private bool _ConfigInited;
	}
}
