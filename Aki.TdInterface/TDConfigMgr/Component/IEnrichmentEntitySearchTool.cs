using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200034C RID: 844
	public class IEnrichmentEntitySearchTool
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x0003854C File Offset: 0x0003674C
		private IEnrichmentEntitySearchTool_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnrichmentEntitySearchTool 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnrichmentEntitySearchTool_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnrichmentEntitySearchTool_SetValue());
			}
			return result;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00038584 File Offset: 0x00036784
		public static IEnrichmentEntitySearchTool Create([Nullable(2)] IEnrichmentEntitySearchTool instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnrichmentEntitySearchTool
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00038597 File Offset: 0x00036797
		public static IEnrichmentEntitySearchTool CreateFromSetValue([Nullable(2)] IEnrichmentEntitySearchTool_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnrichmentEntitySearchTool
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x000385AA File Offset: 0x000367AA
		public IEnrichmentEntitySearchTool_SetValue ToSetValue()
		{
			return new IEnrichmentEntitySearchTool_SetValue
			{
				TargetType = this.TargetType,
				Radius = this.Radius,
				Height = this.Height
			};
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x000385D5 File Offset: 0x000367D5
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00038600 File Offset: 0x00036800
		public virtual int TargetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetType;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetType;
			}
			set
			{
				this.GetOrCreatePoco().TargetType = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0003860E File Offset: 0x0003680E
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x0003863D File Offset: 0x0003683D
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0003864B File Offset: 0x0003684B
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x0003867A File Offset: 0x0003687A
		public virtual float Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x04000DF4 RID: 3572
		[Nullable(2)]
		protected IEnrichmentEntitySearchTool FbInstance;

		// Token: 0x04000DF5 RID: 3573
		[Nullable(2)]
		protected IEnrichmentEntitySearchTool_SetValue PocoInterface;
	}
}
