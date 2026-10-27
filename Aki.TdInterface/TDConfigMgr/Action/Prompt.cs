using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200212B RID: 8491
	[NullableContext(1)]
	[Nullable(0)]
	public class Prompt : ActionParams
	{
		// Token: 0x0600BB0E RID: 47886 RVA: 0x001B02B8 File Offset: 0x001AE4B8
		private Prompt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Prompt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Prompt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Prompt_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x001B02F0 File Offset: 0x001AE4F0
		public static Prompt Create([Nullable(2)] Prompt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Prompt
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x001B0303 File Offset: 0x001AE503
		public static Prompt CreateFromSetValue([Nullable(2)] Prompt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Prompt
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x001B0316 File Offset: 0x001AE516
		public Prompt_SetValue ToSetValue()
		{
			return new Prompt_SetValue
			{
				GeneralTextId = this.GeneralTextId
			};
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600BB12 RID: 47890 RVA: 0x001B0329 File Offset: 0x001AE529
		// (set) Token: 0x0600BB13 RID: 47891 RVA: 0x001B0354 File Offset: 0x001AE554
		public virtual int GeneralTextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GeneralTextId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GeneralTextId;
			}
			set
			{
				this.GetOrCreatePoco().GeneralTextId = value;
			}
		}

		// Token: 0x04006FEB RID: 28651
		[Nullable(2)]
		protected new Prompt FbInstance;

		// Token: 0x04006FEC RID: 28652
		[Nullable(2)]
		protected Prompt_SetValue PocoInterface;
	}
}
