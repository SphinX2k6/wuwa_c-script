using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020E6 RID: 8422
	[NullableContext(1)]
	[Nullable(0)]
	public class NpcLeisureInteract : ActionParams
	{
		// Token: 0x0600B91E RID: 47390 RVA: 0x001AC10C File Offset: 0x001AA30C
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

		// Token: 0x0600B91F RID: 47391 RVA: 0x001AC144 File Offset: 0x001AA344
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

		// Token: 0x0600B920 RID: 47392 RVA: 0x001AC157 File Offset: 0x001AA357
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

		// Token: 0x0600B921 RID: 47393 RVA: 0x001AC16A File Offset: 0x001AA36A
		public NpcLeisureInteract_SetValue ToSetValue()
		{
			return new NpcLeisureInteract_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600B922 RID: 47394 RVA: 0x001AC17D File Offset: 0x001AA37D
		// (set) Token: 0x0600B923 RID: 47395 RVA: 0x001AC1A4 File Offset: 0x001AA3A4
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

		// Token: 0x04006EDF RID: 28383
		[Nullable(2)]
		protected new NpcLeisureInteract FbInstance;

		// Token: 0x04006EE0 RID: 28384
		[Nullable(2)]
		protected NpcLeisureInteract_SetValue PocoInterface;
	}
}
