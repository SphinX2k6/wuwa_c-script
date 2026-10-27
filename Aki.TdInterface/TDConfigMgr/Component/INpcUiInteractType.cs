using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200059A RID: 1434
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractType
	{
		// Token: 0x06001E08 RID: 7688 RVA: 0x00055388 File Offset: 0x00053588
		private INpcUiInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x000553C0 File Offset: 0x000535C0
		public static INpcUiInteractType Create([Nullable(2)] INpcUiInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x000553D3 File Offset: 0x000535D3
		public static INpcUiInteractType CreateFromSetValue([Nullable(2)] INpcUiInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x000553E6 File Offset: 0x000535E6
		public INpcUiInteractType_SetValue ToSetValue()
		{
			return new INpcUiInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x000553F9 File Offset: 0x000535F9
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00055424 File Offset: 0x00053624
		public virtual ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400156E RID: 5486
		[Nullable(2)]
		protected INpcUiInteractType FbInstance;

		// Token: 0x0400156F RID: 5487
		[Nullable(2)]
		protected INpcUiInteractType_SetValue PocoInterface;
	}
}
