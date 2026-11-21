using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A9 RID: 937
	public class IExploreSkillSearchTargetCfg
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x0003DA20 File Offset: 0x0003BC20
		private IExploreSkillSearchTargetCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillSearchTargetCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillSearchTargetCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillSearchTargetCfg_SetValue());
			}
			return result;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0003DA58 File Offset: 0x0003BC58
		public static IExploreSkillSearchTargetCfg Create([Nullable(2)] IExploreSkillSearchTargetCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillSearchTargetCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0003DA6B File Offset: 0x0003BC6B
		public static IExploreSkillSearchTargetCfg CreateFromSetValue([Nullable(2)] IExploreSkillSearchTargetCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillSearchTargetCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0003DA7E File Offset: 0x0003BC7E
		public IExploreSkillSearchTargetCfg_SetValue ToSetValue()
		{
			return new IExploreSkillSearchTargetCfg_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0003DA91 File Offset: 0x0003BC91
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0003DABC File Offset: 0x0003BCBC
		public virtual EExploreSkillSearchTargetCfg Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillSearchTargetCfg.AngleWeight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F2D RID: 3885
		[Nullable(2)]
		protected IExploreSkillSearchTargetCfg FbInstance;

		// Token: 0x04000F2E RID: 3886
		[Nullable(2)]
		protected IExploreSkillSearchTargetCfg_SetValue PocoInterface;
	}
}
