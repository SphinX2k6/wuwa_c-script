using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C82 RID: 7298
	[NullableContext(1)]
	[Nullable(0)]
	public class Interact : ActionParams
	{
		// Token: 0x06009C89 RID: 40073 RVA: 0x00166F74 File Offset: 0x00165174
		private Interact_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Interact 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Interact_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Interact_SetValue());
			}
			return result;
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x00166FAC File Offset: 0x001651AC
		public static Interact Create([Nullable(2)] Interact instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Interact
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x00166FBF File Offset: 0x001651BF
		public static Interact CreateFromSetValue([Nullable(2)] Interact_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Interact
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x00166FD2 File Offset: 0x001651D2
		public Interact_SetValue ToSetValue()
		{
			return new Interact_SetValue
			{
				Who = this.Who,
				Param = this.Param
			};
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06009C8D RID: 40077 RVA: 0x00166FF1 File Offset: 0x001651F1
		// (set) Token: 0x06009C8E RID: 40078 RVA: 0x0016701C File Offset: 0x0016521C
		public virtual int Who
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Who;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Who;
			}
			set
			{
				this.GetOrCreatePoco().Who = value;
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x0016702A File Offset: 0x0016522A
		// (set) Token: 0x06009C90 RID: 40080 RVA: 0x00167055 File Offset: 0x00165255
		public virtual string Param
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Param;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Param;
			}
			set
			{
				this.GetOrCreatePoco().Param = value;
			}
		}

		// Token: 0x04005EE7 RID: 24295
		[Nullable(2)]
		protected new Interact FbInstance;

		// Token: 0x04005EE8 RID: 24296
		[Nullable(2)]
		protected Interact_SetValue PocoInterface;
	}
}
