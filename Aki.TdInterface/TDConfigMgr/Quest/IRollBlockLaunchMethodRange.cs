using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124A RID: 4682
	public class IRollBlockLaunchMethodRange : IRollBlockStartupMethodBase
	{
		// Token: 0x060068DB RID: 26843 RVA: 0x000FADE4 File Offset: 0x000F8FE4
		private IRollBlockLaunchMethodRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRollBlockLaunchMethodRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRollBlockLaunchMethodRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRollBlockLaunchMethodRange_SetValue());
			}
			return result;
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x000FAE1C File Offset: 0x000F901C
		public static IRollBlockLaunchMethodRange Create([Nullable(2)] IRollBlockLaunchMethodRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x000FAE2F File Offset: 0x000F902F
		public static IRollBlockLaunchMethodRange CreateFromSetValue([Nullable(2)] IRollBlockLaunchMethodRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRollBlockLaunchMethodRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x000FAE42 File Offset: 0x000F9042
		public new IRollBlockLaunchMethodRange_SetValue ToSetValue()
		{
			return new IRollBlockLaunchMethodRange_SetValue
			{
				Type = this.Type,
				TargetId = this.TargetId
			};
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x060068DF RID: 26847 RVA: 0x000FAE61 File Offset: 0x000F9061
		// (set) Token: 0x060068E0 RID: 26848 RVA: 0x000FAE8C File Offset: 0x000F908C
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

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x060068E1 RID: 26849 RVA: 0x000FAE9A File Offset: 0x000F909A
		// (set) Token: 0x060068E2 RID: 26850 RVA: 0x000FAEC5 File Offset: 0x000F90C5
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

		// Token: 0x04003E99 RID: 16025
		[Nullable(2)]
		protected new IRollBlockLaunchMethodRange FbInstance;

		// Token: 0x04003E9A RID: 16026
		[Nullable(2)]
		protected new IRollBlockLaunchMethodRange_SetValue PocoInterface;
	}
}
