using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002347 RID: 9031
	public class NpcLeisureInteract : ActionParams
	{
		// Token: 0x0600C4AA RID: 50346 RVA: 0x001C326C File Offset: 0x001C146C
		private NpcLeisureInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NpcLeisureInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NpcLeisureInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NpcLeisureInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600C4AB RID: 50347 RVA: 0x001C32A4 File Offset: 0x001C14A4
		public static NpcLeisureInteract Create([Nullable(2)] NpcLeisureInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NpcLeisureInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x001C32B7 File Offset: 0x001C14B7
		public static NpcLeisureInteract CreateFromSetValue([Nullable(2)] NpcLeisureInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NpcLeisureInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x001C32CA File Offset: 0x001C14CA
		public NpcLeisureInteract_SetValue ToSetValue()
		{
			return new NpcLeisureInteract_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600C4AE RID: 50350 RVA: 0x001C32DD File Offset: 0x001C14DD
		// (set) Token: 0x0600C4AF RID: 50351 RVA: 0x001C3304 File Offset: 0x001C1504
		public virtual INpcLeisureInteractType Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				NpcLeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x04007513 RID: 29971
		[Nullable(2)]
		protected new NpcLeisureInteract FbInstance;

		// Token: 0x04007514 RID: 29972
		[Nullable(2)]
		protected NpcLeisureInteract_SetValue PocoInterface;
	}
}
