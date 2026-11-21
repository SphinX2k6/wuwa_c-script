using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F6B RID: 8043
	public class IProjectionMachinePhotoFilter
	{
		// Token: 0x0600AB19 RID: 43801 RVA: 0x0018395C File Offset: 0x00181B5C
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

		// Token: 0x0600AB1A RID: 43802 RVA: 0x00183994 File Offset: 0x00181B94
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

		// Token: 0x0600AB1B RID: 43803 RVA: 0x001839A7 File Offset: 0x00181BA7
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

		// Token: 0x0600AB1C RID: 43804 RVA: 0x001839BA File Offset: 0x00181BBA
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

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600AB1D RID: 43805 RVA: 0x001839F1 File Offset: 0x00181BF1
		// (set) Token: 0x0600AB1E RID: 43806 RVA: 0x00183A20 File Offset: 0x00181C20
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

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600AB1F RID: 43807 RVA: 0x00183A2E File Offset: 0x00181C2E
		// (set) Token: 0x0600AB20 RID: 43808 RVA: 0x00183A5D File Offset: 0x00181C5D
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

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600AB21 RID: 43809 RVA: 0x00183A6B File Offset: 0x00181C6B
		// (set) Token: 0x0600AB22 RID: 43810 RVA: 0x00183A9A File Offset: 0x00181C9A
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

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600AB23 RID: 43811 RVA: 0x00183AA8 File Offset: 0x00181CA8
		// (set) Token: 0x0600AB24 RID: 43812 RVA: 0x00183AD7 File Offset: 0x00181CD7
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

		// Token: 0x04006685 RID: 26245
		[Nullable(2)]
		protected IProjectionMachinePhotoFilter FbInstance;

		// Token: 0x04006686 RID: 26246
		[Nullable(2)]
		protected IProjectionMachinePhotoFilter_SetValue PocoInterface;
	}
}
