using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC5 RID: 7877
	public class IPainCoveringHead : ILeisureInteractType
	{
		// Token: 0x0600A7A7 RID: 42919 RVA: 0x0017D4E4 File Offset: 0x0017B6E4
		private IPainCoveringHead_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPainCoveringHead 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPainCoveringHead_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPainCoveringHead_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x0017D51C File Offset: 0x0017B71C
		public static IPainCoveringHead Create([Nullable(2)] IPainCoveringHead instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPainCoveringHead
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x0017D52F File Offset: 0x0017B72F
		public static IPainCoveringHead CreateFromSetValue([Nullable(2)] IPainCoveringHead_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPainCoveringHead
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x0017D542 File Offset: 0x0017B742
		public new IPainCoveringHead_SetValue ToSetValue()
		{
			return new IPainCoveringHead_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x0017D555 File Offset: 0x0017B755
		// (set) Token: 0x0600A7AC RID: 42924 RVA: 0x0017D580 File Offset: 0x0017B780
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064E9 RID: 25833
		[Nullable(2)]
		protected new IPainCoveringHead FbInstance;

		// Token: 0x040064EA RID: 25834
		[Nullable(2)]
		protected new IPainCoveringHead_SetValue PocoInterface;
	}
}
