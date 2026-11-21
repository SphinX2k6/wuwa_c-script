using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200034E RID: 846
	public class IEnterScreenWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06001033 RID: 4147 RVA: 0x00038698 File Offset: 0x00036898
		private IEnterScreenWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterScreenWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterScreenWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterScreenWeight_SetValue());
			}
			return result;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000386D0 File Offset: 0x000368D0
		public static IEnterScreenWeight Create([Nullable(2)] IEnterScreenWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterScreenWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000386E3 File Offset: 0x000368E3
		public static IEnterScreenWeight CreateFromSetValue([Nullable(2)] IEnterScreenWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterScreenWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000386F6 File Offset: 0x000368F6
		public new IEnterScreenWeight_SetValue ToSetValue()
		{
			return new IEnterScreenWeight_SetValue
			{
				Type = this.Type,
				Weight = this.Weight
			};
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00038715 File Offset: 0x00036915
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x00038740 File Offset: 0x00036940
		public override EExploreSkillSearchTargetCfg Type
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

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0003874E File Offset: 0x0003694E
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x00038779 File Offset: 0x00036979
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x04000DF9 RID: 3577
		[Nullable(2)]
		protected new IEnterScreenWeight FbInstance;

		// Token: 0x04000DFA RID: 3578
		[Nullable(2)]
		protected new IEnterScreenWeight_SetValue PocoInterface;
	}
}
