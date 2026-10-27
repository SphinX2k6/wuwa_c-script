using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D5A RID: 7514
	[NullableContext(1)]
	[Nullable(0)]
	public class IProjectionMachinePhotoFilter
	{
		// Token: 0x0600A12D RID: 41261 RVA: 0x0016F538 File Offset: 0x0016D738
		private IProjectionMachinePhotoFilter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProjectionMachinePhotoFilter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProjectionMachinePhotoFilter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProjectionMachinePhotoFilter_SetValue());
			}
			return result;
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x0016F570 File Offset: 0x0016D770
		public static IProjectionMachinePhotoFilter Create([Nullable(2)] IProjectionMachinePhotoFilter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectionMachinePhotoFilter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x0016F583 File Offset: 0x0016D783
		public static IProjectionMachinePhotoFilter CreateFromSetValue([Nullable(2)] IProjectionMachinePhotoFilter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProjectionMachinePhotoFilter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x0016F596 File Offset: 0x0016D796
		public IProjectionMachinePhotoFilter_SetValue ToSetValue()
		{
			return new IProjectionMachinePhotoFilter_SetValue
			{
				DefaultParam1 = this.DefaultParam1,
				DefaultParam2 = this.DefaultParam2,
				TargetParam1 = this.TargetParam1,
				TargetParam2 = this.TargetParam2
			};
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A131 RID: 41265 RVA: 0x0016F5CD File Offset: 0x0016D7CD
		// (set) Token: 0x0600A132 RID: 41266 RVA: 0x0016F5FC File Offset: 0x0016D7FC
		public virtual float DefaultParam1
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultParam1;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DefaultParam1;
			}
			set
			{
				this.GetOrCreatePoco().DefaultParam1 = value;
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600A133 RID: 41267 RVA: 0x0016F60A File Offset: 0x0016D80A
		// (set) Token: 0x0600A134 RID: 41268 RVA: 0x0016F639 File Offset: 0x0016D839
		public virtual float DefaultParam2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultParam2;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DefaultParam2;
			}
			set
			{
				this.GetOrCreatePoco().DefaultParam2 = value;
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600A135 RID: 41269 RVA: 0x0016F647 File Offset: 0x0016D847
		// (set) Token: 0x0600A136 RID: 41270 RVA: 0x0016F676 File Offset: 0x0016D876
		public virtual float TargetParam1
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetParam1;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TargetParam1;
			}
			set
			{
				this.GetOrCreatePoco().TargetParam1 = value;
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600A137 RID: 41271 RVA: 0x0016F684 File Offset: 0x0016D884
		// (set) Token: 0x0600A138 RID: 41272 RVA: 0x0016F6B3 File Offset: 0x0016D8B3
		public virtual float TargetParam2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetParam2;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TargetParam2;
			}
			set
			{
				this.GetOrCreatePoco().TargetParam2 = value;
			}
		}

		// Token: 0x04006109 RID: 24841
		[Nullable(2)]
		protected IProjectionMachinePhotoFilter FbInstance;

		// Token: 0x0400610A RID: 24842
		[Nullable(2)]
		protected IProjectionMachinePhotoFilter_SetValue PocoInterface;
	}
}
