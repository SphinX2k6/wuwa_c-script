using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001248 RID: 4680
	public class IRollBlockLaunchMethodInteract : IRollBlockStartupMethodBase
	{
		// Token: 0x060068D1 RID: 26833 RVA: 0x000FACE4 File Offset: 0x000F8EE4
		private IRollBlockLaunchMethodInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRollBlockLaunchMethodInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRollBlockLaunchMethodInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRollBlockLaunchMethodInteract_SetValue());
			}
			return result;
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x000FAD1C File Offset: 0x000F8F1C
		public static IRollBlockLaunchMethodInteract Create([Nullable(2)] IRollBlockLaunchMethodInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x000FAD2F File Offset: 0x000F8F2F
		public static IRollBlockLaunchMethodInteract CreateFromSetValue([Nullable(2)] IRollBlockLaunchMethodInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x000FAD42 File Offset: 0x000F8F42
		public new IRollBlockLaunchMethodInteract_SetValue ToSetValue()
		{
			return new IRollBlockLaunchMethodInteract_SetValue
			{
				Type = this.Type,
				TargetId = this.TargetId
			};
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x060068D5 RID: 26837 RVA: 0x000FAD61 File Offset: 0x000F8F61
		// (set) Token: 0x060068D6 RID: 26838 RVA: 0x000FAD8C File Offset: 0x000F8F8C
		public override ERollBlockLaunchMethod Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x060068D7 RID: 26839 RVA: 0x000FAD9A File Offset: 0x000F8F9A
		// (set) Token: 0x060068D8 RID: 26840 RVA: 0x000FADC5 File Offset: 0x000F8FC5
		public virtual int TargetId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetId;
			}
			set
			{
				this.GetOrCreatePoco().TargetId = value;
			}
		}

		// Token: 0x04003E95 RID: 16021
		[Nullable(2)]
		protected new IRollBlockLaunchMethodInteract FbInstance;

		// Token: 0x04003E96 RID: 16022
		[Nullable(2)]
		protected new IRollBlockLaunchMethodInteract_SetValue PocoInterface;
	}
}
