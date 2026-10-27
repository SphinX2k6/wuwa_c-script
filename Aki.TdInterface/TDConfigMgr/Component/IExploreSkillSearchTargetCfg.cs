using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000360 RID: 864
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillSearchTargetCfg
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x0003A73C File Offset: 0x0003893C
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

		// Token: 0x06001128 RID: 4392 RVA: 0x0003A774 File Offset: 0x00038974
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

		// Token: 0x06001129 RID: 4393 RVA: 0x0003A787 File Offset: 0x00038987
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

		// Token: 0x0600112A RID: 4394 RVA: 0x0003A79A File Offset: 0x0003899A
		public IExploreSkillSearchTargetCfg_SetValue ToSetValue()
		{
			return new IExploreSkillSearchTargetCfg_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0003A7AD File Offset: 0x000389AD
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0003A7D8 File Offset: 0x000389D8
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

		// Token: 0x04000E36 RID: 3638
		[Nullable(2)]
		protected IExploreSkillSearchTargetCfg FbInstance;

		// Token: 0x04000E37 RID: 3639
		[Nullable(2)]
		protected IExploreSkillSearchTargetCfg_SetValue PocoInterface;
	}
}
