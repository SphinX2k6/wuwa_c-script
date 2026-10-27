using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000305 RID: 773
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnrichmentEntitySearchTool
	{
		// Token: 0x06000EF7 RID: 3831 RVA: 0x00035618 File Offset: 0x00033818
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

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00035650 File Offset: 0x00033850
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

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00035663 File Offset: 0x00033863
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

		// Token: 0x06000EFA RID: 3834 RVA: 0x00035676 File Offset: 0x00033876
		public IEnrichmentEntitySearchTool_SetValue ToSetValue()
		{
			return new IEnrichmentEntitySearchTool_SetValue
			{
				TargetType = this.TargetType,
				Radius = this.Radius,
				Height = this.Height
			};
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000356A1 File Offset: 0x000338A1
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000356CC File Offset: 0x000338CC
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000356DA File Offset: 0x000338DA
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00035709 File Offset: 0x00033909
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00035717 File Offset: 0x00033917
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00035746 File Offset: 0x00033946
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

		// Token: 0x04000D0A RID: 3338
		[Nullable(2)]
		protected IEnrichmentEntitySearchTool FbInstance;

		// Token: 0x04000D0B RID: 3339
		[Nullable(2)]
		protected IEnrichmentEntitySearchTool_SetValue PocoInterface;
	}
}
