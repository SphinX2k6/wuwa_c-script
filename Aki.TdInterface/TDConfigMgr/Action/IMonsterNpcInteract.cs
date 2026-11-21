using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE5 RID: 7653
	public class IMonsterNpcInteract : IExecClientBattleActionType
	{
		// Token: 0x0600A279 RID: 41593 RVA: 0x00173C20 File Offset: 0x00171E20
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

		// Token: 0x0600A27A RID: 41594 RVA: 0x00173C58 File Offset: 0x00171E58
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

		// Token: 0x0600A27B RID: 41595 RVA: 0x00173C6B File Offset: 0x00171E6B
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

		// Token: 0x0600A27C RID: 41596 RVA: 0x00173C7E File Offset: 0x00171E7E
		public new IMonsterNpcInteract_SetValue ToSetValue()
		{
			return new IMonsterNpcInteract_SetValue
			{
				Type = this.Type,
				MonsterNpcEntityId = this.MonsterNpcEntityId,
				Config = this.Config
			};
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A27D RID: 41597 RVA: 0x00173CA9 File Offset: 0x00171EA9
		// (set) Token: 0x0600A27E RID: 41598 RVA: 0x00173CD4 File Offset: 0x00171ED4
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

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A27F RID: 41599 RVA: 0x00173CE2 File Offset: 0x00171EE2
		// (set) Token: 0x0600A280 RID: 41600 RVA: 0x00173D0D File Offset: 0x00171F0D
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

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A281 RID: 41601 RVA: 0x00173D1C File Offset: 0x00171F1C
		// (set) Token: 0x0600A282 RID: 41602 RVA: 0x00173D7D File Offset: 0x00171F7D
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

		// Token: 0x0400627E RID: 25214
		[Nullable(2)]
		protected new IMonsterNpcInteract FbInstance;

		// Token: 0x0400627F RID: 25215
		[Nullable(2)]
		protected new IMonsterNpcInteract_SetValue PocoInterface;

		// Token: 0x04006280 RID: 25216
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x04006281 RID: 25217
		private bool _ConfigInited;
	}
}
