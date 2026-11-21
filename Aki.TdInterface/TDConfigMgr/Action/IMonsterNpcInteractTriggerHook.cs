using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE9 RID: 7657
	public class IMonsterNpcInteractTriggerHook : IMonsterNpcInteractConfigBase
	{
		// Token: 0x0600A28D RID: 41613 RVA: 0x00173E60 File Offset: 0x00172060
		private IMonsterNpcInteractTriggerHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractTriggerHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractTriggerHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractTriggerHook_SetValue());
			}
			return result;
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x00173E98 File Offset: 0x00172098
		public static IMonsterNpcInteractTriggerHook Create([Nullable(2)] IMonsterNpcInteractTriggerHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractTriggerHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x00173EAB File Offset: 0x001720AB
		public static IMonsterNpcInteractTriggerHook CreateFromSetValue([Nullable(2)] IMonsterNpcInteractTriggerHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractTriggerHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x00173EBE File Offset: 0x001720BE
		public new IMonsterNpcInteractTriggerHook_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractTriggerHook_SetValue
			{
				Type = this.Type,
				HookEntityId = this.HookEntityId
			};
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A291 RID: 41617 RVA: 0x00173EDD File Offset: 0x001720DD
		// (set) Token: 0x0600A292 RID: 41618 RVA: 0x00173F08 File Offset: 0x00172108
		public override EMonsterNpcInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractType.TriggerHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A293 RID: 41619 RVA: 0x00173F16 File Offset: 0x00172116
		// (set) Token: 0x0600A294 RID: 41620 RVA: 0x00173F41 File Offset: 0x00172141
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

		// Token: 0x04006288 RID: 25224
		[Nullable(2)]
		protected new IMonsterNpcInteractTriggerHook FbInstance;

		// Token: 0x04006289 RID: 25225
		[Nullable(2)]
		protected new IMonsterNpcInteractTriggerHook_SetValue PocoInterface;
	}
}
