using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB4 RID: 7092
	public class IExecClientMonsterNpcInteract : ActionParams
	{
		// Token: 0x060096A6 RID: 38566 RVA: 0x0015E8CC File Offset: 0x0015CACC
		private IExecClientMonsterNpcInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExecClientMonsterNpcInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExecClientMonsterNpcInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExecClientMonsterNpcInteract_SetValue());
			}
			return result;
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x0015E904 File Offset: 0x0015CB04
		public static IExecClientMonsterNpcInteract Create([Nullable(2)] IExecClientMonsterNpcInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecClientMonsterNpcInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x0015E917 File Offset: 0x0015CB17
		public static IExecClientMonsterNpcInteract CreateFromSetValue([Nullable(2)] IExecClientMonsterNpcInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExecClientMonsterNpcInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x0015E92A File Offset: 0x0015CB2A
		public IExecClientMonsterNpcInteract_SetValue ToSetValue()
		{
			return new IExecClientMonsterNpcInteract_SetValue
			{
				MonsterNpcEntityId = this.MonsterNpcEntityId,
				Config = this.Config
			};
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x060096AA RID: 38570 RVA: 0x0015E949 File Offset: 0x0015CB49
		// (set) Token: 0x060096AB RID: 38571 RVA: 0x0015E974 File Offset: 0x0015CB74
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

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x0015E984 File Offset: 0x0015CB84
		// (set) Token: 0x060096AD RID: 38573 RVA: 0x0015E9E5 File Offset: 0x0015CBE5
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
					IExecClientMonsterNpcInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005D0B RID: 23819
		[Nullable(2)]
		protected new IExecClientMonsterNpcInteract FbInstance;

		// Token: 0x04005D0C RID: 23820
		[Nullable(2)]
		protected IExecClientMonsterNpcInteract_SetValue PocoInterface;

		// Token: 0x04005D0D RID: 23821
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x04005D0E RID: 23822
		private bool _ConfigInited;
	}
}
