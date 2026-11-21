using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200039B RID: 923
	public class IExploreSkillLonelyDollPollutant : IExploreSkillInteractType
	{
		// Token: 0x06001221 RID: 4641 RVA: 0x0003D0FC File Offset: 0x0003B2FC
		private IExploreSkillLonelyDollPollutant_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillLonelyDollPollutant 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillLonelyDollPollutant_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillLonelyDollPollutant_SetValue());
			}
			return result;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0003D134 File Offset: 0x0003B334
		public static IExploreSkillLonelyDollPollutant Create([Nullable(2)] IExploreSkillLonelyDollPollutant instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillLonelyDollPollutant
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0003D147 File Offset: 0x0003B347
		public static IExploreSkillLonelyDollPollutant CreateFromSetValue([Nullable(2)] IExploreSkillLonelyDollPollutant_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillLonelyDollPollutant
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0003D15A File Offset: 0x0003B35A
		public new IExploreSkillLonelyDollPollutant_SetValue ToSetValue()
		{
			return new IExploreSkillLonelyDollPollutant_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0003D16D File Offset: 0x0003B36D
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x0003D198 File Offset: 0x0003B398
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F07 RID: 3847
		[Nullable(2)]
		protected new IExploreSkillLonelyDollPollutant FbInstance;

		// Token: 0x04000F08 RID: 3848
		[Nullable(2)]
		protected new IExploreSkillLonelyDollPollutant_SetValue PocoInterface;
	}
}
