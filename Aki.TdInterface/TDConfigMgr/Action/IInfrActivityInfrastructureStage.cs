using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2B RID: 6955
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrActivityInfrastructureStage : IInfrActivityBuildStageOption
	{
		// Token: 0x060094DE RID: 38110 RVA: 0x001586E8 File Offset: 0x001568E8
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

		// Token: 0x060094DF RID: 38111 RVA: 0x00158720 File Offset: 0x00156920
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

		// Token: 0x060094E0 RID: 38112 RVA: 0x00158733 File Offset: 0x00156933
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

		// Token: 0x060094E1 RID: 38113 RVA: 0x00158746 File Offset: 0x00156946
		public new IInfrActivityInfrastructureStage_SetValue ToSetValue()
		{
			return new IInfrActivityInfrastructureStage_SetValue
			{
				Type = this.Type,
				Stage = this.Stage
			};
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x060094E2 RID: 38114 RVA: 0x00158765 File Offset: 0x00156965
		// (set) Token: 0x060094E3 RID: 38115 RVA: 0x00158790 File Offset: 0x00156990
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

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x0015879E File Offset: 0x0015699E
		// (set) Token: 0x060094E5 RID: 38117 RVA: 0x001587C9 File Offset: 0x001569C9
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

		// Token: 0x04005B2D RID: 23341
		[Nullable(2)]
		protected new IInfrActivityInfrastructureStage FbInstance;

		// Token: 0x04005B2E RID: 23342
		[Nullable(2)]
		protected new IInfrActivityInfrastructureStage_SetValue PocoInterface;
	}
}
