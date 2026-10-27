using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200111A RID: 4378
	[NullableContext(1)]
	[Nullable(0)]
	public class IRollBlockLaunchMethodInteract : IRollBlockStartupMethodBase
	{
		// Token: 0x060062D6 RID: 25302 RVA: 0x000EDB70 File Offset: 0x000EBD70
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

		// Token: 0x060062D7 RID: 25303 RVA: 0x000EDBA8 File Offset: 0x000EBDA8
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

		// Token: 0x060062D8 RID: 25304 RVA: 0x000EDBBB File Offset: 0x000EBDBB
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

		// Token: 0x060062D9 RID: 25305 RVA: 0x000EDBCE File Offset: 0x000EBDCE
		public new IRollBlockLaunchMethodInteract_SetValue ToSetValue()
		{
			return new IRollBlockLaunchMethodInteract_SetValue
			{
				Type = this.Type,
				TargetId = this.TargetId
			};
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x000EDBED File Offset: 0x000EBDED
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x000EDC18 File Offset: 0x000EBE18
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

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x060062DC RID: 25308 RVA: 0x000EDC26 File Offset: 0x000EBE26
		// (set) Token: 0x060062DD RID: 25309 RVA: 0x000EDC51 File Offset: 0x000EBE51
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

		// Token: 0x04003B47 RID: 15175
		[Nullable(2)]
		protected new IRollBlockLaunchMethodInteract FbInstance;

		// Token: 0x04003B48 RID: 15176
		[Nullable(2)]
		protected new IRollBlockLaunchMethodInteract_SetValue PocoInterface;
	}
}
