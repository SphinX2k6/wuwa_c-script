using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1F RID: 6687
	[NullableContext(1)]
	[Nullable(0)]
	public class IExecClientMonsterNpcInteract : ActionParams
	{
		// Token: 0x06008F3C RID: 36668 RVA: 0x0014E9A0 File Offset: 0x0014CBA0
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

		// Token: 0x06008F3D RID: 36669 RVA: 0x0014E9D8 File Offset: 0x0014CBD8
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

		// Token: 0x06008F3E RID: 36670 RVA: 0x0014E9EB File Offset: 0x0014CBEB
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

		// Token: 0x06008F3F RID: 36671 RVA: 0x0014E9FE File Offset: 0x0014CBFE
		public IExecClientMonsterNpcInteract_SetValue ToSetValue()
		{
			return new IExecClientMonsterNpcInteract_SetValue
			{
				MonsterNpcEntityId = this.MonsterNpcEntityId,
				Config = this.Config
			};
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x06008F40 RID: 36672 RVA: 0x0014EA1D File Offset: 0x0014CC1D
		// (set) Token: 0x06008F41 RID: 36673 RVA: 0x0014EA48 File Offset: 0x0014CC48
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

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x06008F42 RID: 36674 RVA: 0x0014EA58 File Offset: 0x0014CC58
		// (set) Token: 0x06008F43 RID: 36675 RVA: 0x0014EAB9 File Offset: 0x0014CCB9
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

		// Token: 0x040058A6 RID: 22694
		[Nullable(2)]
		protected new IExecClientMonsterNpcInteract FbInstance;

		// Token: 0x040058A7 RID: 22695
		[Nullable(2)]
		protected IExecClientMonsterNpcInteract_SetValue PocoInterface;

		// Token: 0x040058A8 RID: 22696
		private IMonsterNpcInteractTriggerHook _ConfigCache;

		// Token: 0x040058A9 RID: 22697
		private bool _ConfigInited;
	}
}
