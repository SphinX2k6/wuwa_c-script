using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E87 RID: 7815
	public class Interact : ActionParams
	{
		// Token: 0x0600A623 RID: 42531 RVA: 0x0017A968 File Offset: 0x00178B68
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

		// Token: 0x0600A624 RID: 42532 RVA: 0x0017A9A0 File Offset: 0x00178BA0
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

		// Token: 0x0600A625 RID: 42533 RVA: 0x0017A9B3 File Offset: 0x00178BB3
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

		// Token: 0x0600A626 RID: 42534 RVA: 0x0017A9C6 File Offset: 0x00178BC6
		public Interact_SetValue ToSetValue()
		{
			return new Interact_SetValue
			{
				Who = this.Who,
				Param = this.Param
			};
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x0017A9E5 File Offset: 0x00178BE5
		// (set) Token: 0x0600A628 RID: 42536 RVA: 0x0017AA10 File Offset: 0x00178C10
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

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600A629 RID: 42537 RVA: 0x0017AA1E File Offset: 0x00178C1E
		// (set) Token: 0x0600A62A RID: 42538 RVA: 0x0017AA49 File Offset: 0x00178C49
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

		// Token: 0x0400643A RID: 25658
		[Nullable(2)]
		protected new Interact FbInstance;

		// Token: 0x0400643B RID: 25659
		[Nullable(2)]
		protected Interact_SetValue PocoInterface;
	}
}
