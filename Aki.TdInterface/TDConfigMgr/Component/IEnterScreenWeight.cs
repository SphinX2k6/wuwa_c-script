using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000307 RID: 775
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterScreenWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06000F03 RID: 3843 RVA: 0x00035764 File Offset: 0x00033964
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

		// Token: 0x06000F04 RID: 3844 RVA: 0x0003579C File Offset: 0x0003399C
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

		// Token: 0x06000F05 RID: 3845 RVA: 0x000357AF File Offset: 0x000339AF
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

		// Token: 0x06000F06 RID: 3846 RVA: 0x000357C2 File Offset: 0x000339C2
		public new IEnterScreenWeight_SetValue ToSetValue()
		{
			return new IEnterScreenWeight_SetValue
			{
				Type = this.Type,
				Weight = this.Weight
			};
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x000357E1 File Offset: 0x000339E1
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0003580C File Offset: 0x00033A0C
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0003581A File Offset: 0x00033A1A
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00035845 File Offset: 0x00033A45
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

		// Token: 0x04000D0F RID: 3343
		[Nullable(2)]
		protected new IEnterScreenWeight FbInstance;

		// Token: 0x04000D10 RID: 3344
		[Nullable(2)]
		protected new IEnterScreenWeight_SetValue PocoInterface;
	}
}
