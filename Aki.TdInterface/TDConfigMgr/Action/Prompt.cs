using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238C RID: 9100
	public class Prompt : ActionParams
	{
		// Token: 0x0600C69C RID: 50844 RVA: 0x001C746C File Offset: 0x001C566C
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

		// Token: 0x0600C69D RID: 50845 RVA: 0x001C74A4 File Offset: 0x001C56A4
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

		// Token: 0x0600C69E RID: 50846 RVA: 0x001C74B7 File Offset: 0x001C56B7
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

		// Token: 0x0600C69F RID: 50847 RVA: 0x001C74CA File Offset: 0x001C56CA
		public Prompt_SetValue ToSetValue()
		{
			return new Prompt_SetValue
			{
				GeneralTextId = this.GeneralTextId
			};
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600C6A0 RID: 50848 RVA: 0x001C74DD File Offset: 0x001C56DD
		// (set) Token: 0x0600C6A1 RID: 50849 RVA: 0x001C7508 File Offset: 0x001C5708
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

		// Token: 0x04007620 RID: 30240
		[Nullable(2)]
		protected new Prompt FbInstance;

		// Token: 0x04007621 RID: 30241
		[Nullable(2)]
		protected Prompt_SetValue PocoInterface;
	}
}
