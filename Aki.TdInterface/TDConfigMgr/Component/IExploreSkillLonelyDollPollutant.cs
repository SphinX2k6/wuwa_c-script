using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000352 RID: 850
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillLonelyDollPollutant : IExploreSkillInteractType
	{
		// Token: 0x060010DD RID: 4317 RVA: 0x00039E18 File Offset: 0x00038018
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

		// Token: 0x060010DE RID: 4318 RVA: 0x00039E50 File Offset: 0x00038050
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

		// Token: 0x060010DF RID: 4319 RVA: 0x00039E63 File Offset: 0x00038063
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

		// Token: 0x060010E0 RID: 4320 RVA: 0x00039E76 File Offset: 0x00038076
		public new IExploreSkillLonelyDollPollutant_SetValue ToSetValue()
		{
			return new IExploreSkillLonelyDollPollutant_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00039E89 File Offset: 0x00038089
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00039EB4 File Offset: 0x000380B4
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

		// Token: 0x04000E10 RID: 3600
		[Nullable(2)]
		protected new IExploreSkillLonelyDollPollutant FbInstance;

		// Token: 0x04000E11 RID: 3601
		[Nullable(2)]
		protected new IExploreSkillLonelyDollPollutant_SetValue PocoInterface;
	}
}
