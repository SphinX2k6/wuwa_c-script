using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CDA RID: 7386
	public class IInfrActivityInfrastructureStage : IInfrActivityBuildStageOption
	{
		// Token: 0x06009CC8 RID: 40136 RVA: 0x001693C4 File Offset: 0x001675C4
		private IInfrActivityInfrastructureStage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrActivityInfrastructureStage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrActivityInfrastructureStage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrActivityInfrastructureStage_SetValue());
			}
			return result;
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x001693FC File Offset: 0x001675FC
		public static IInfrActivityInfrastructureStage Create([Nullable(2)] IInfrActivityInfrastructureStage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityInfrastructureStage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x0016940F File Offset: 0x0016760F
		public static IInfrActivityInfrastructureStage CreateFromSetValue([Nullable(2)] IInfrActivityInfrastructureStage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrActivityInfrastructureStage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CCB RID: 40139 RVA: 0x00169422 File Offset: 0x00167622
		public new IInfrActivityInfrastructureStage_SetValue ToSetValue()
		{
			return new IInfrActivityInfrastructureStage_SetValue
			{
				Type = this.Type,
				Stage = this.Stage
			};
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x06009CCC RID: 40140 RVA: 0x00169441 File Offset: 0x00167641
		// (set) Token: 0x06009CCD RID: 40141 RVA: 0x0016946C File Offset: 0x0016766C
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x06009CCE RID: 40142 RVA: 0x0016947A File Offset: 0x0016767A
		// (set) Token: 0x06009CCF RID: 40143 RVA: 0x001694A5 File Offset: 0x001676A5
		public virtual int Stage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Stage;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Stage;
			}
			set
			{
				this.GetOrCreatePoco().Stage = value;
			}
		}

		// Token: 0x04005FCB RID: 24523
		[Nullable(2)]
		protected new IInfrActivityInfrastructureStage FbInstance;

		// Token: 0x04005FCC RID: 24524
		[Nullable(2)]
		protected new IInfrActivityInfrastructureStage_SetValue PocoInterface;
	}
}
