using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE0 RID: 7392
	public class IInfrastructureItemDeliveryRoadBuild : IInfrastructureItemDeliveryType
	{
		// Token: 0x06009CE6 RID: 40166 RVA: 0x001696C4 File Offset: 0x001678C4
		private IInfrastructureItemDeliveryRoadBuild_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrastructureItemDeliveryRoadBuild 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrastructureItemDeliveryRoadBuild_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrastructureItemDeliveryRoadBuild_SetValue());
			}
			return result;
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x001696FC File Offset: 0x001678FC
		public static IInfrastructureItemDeliveryRoadBuild Create([Nullable(2)] IInfrastructureItemDeliveryRoadBuild instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryRoadBuild
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x0016970F File Offset: 0x0016790F
		public static IInfrastructureItemDeliveryRoadBuild CreateFromSetValue([Nullable(2)] IInfrastructureItemDeliveryRoadBuild_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrastructureItemDeliveryRoadBuild
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x00169722 File Offset: 0x00167922
		public new IInfrastructureItemDeliveryRoadBuild_SetValue ToSetValue()
		{
			return new IInfrastructureItemDeliveryRoadBuild_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x00169741 File Offset: 0x00167941
		// (set) Token: 0x06009CEB RID: 40171 RVA: 0x0016976C File Offset: 0x0016796C
		public override EInfrastructureItemDeliveryType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrastructureItemDeliveryType.Observatory;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x0016977A File Offset: 0x0016797A
		// (set) Token: 0x06009CED RID: 40173 RVA: 0x001697A5 File Offset: 0x001679A5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005FD7 RID: 24535
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryRoadBuild FbInstance;

		// Token: 0x04005FD8 RID: 24536
		[Nullable(2)]
		protected new IInfrastructureItemDeliveryRoadBuild_SetValue PocoInterface;
	}
}
