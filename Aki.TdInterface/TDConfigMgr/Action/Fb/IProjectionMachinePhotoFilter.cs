using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B15 RID: 11029
	public class IProjectionMachinePhotoFilter
	{
		// Token: 0x0600F29F RID: 62111 RVA: 0x00236F42 File Offset: 0x00235142
		public static IProjectionMachinePhotoFilter Create(IProjectionMachinePhotoFilter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectionMachinePhotoFilter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x00236F61 File Offset: 0x00235161
		public virtual float DefaultParam1
		{
			get
			{
				return this.Instance.DefaultParam1;
			}
		}

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x0600F2A1 RID: 62113 RVA: 0x00236F6E File Offset: 0x0023516E
		public virtual float DefaultParam2
		{
			get
			{
				return this.Instance.DefaultParam2;
			}
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x0600F2A2 RID: 62114 RVA: 0x00236F7B File Offset: 0x0023517B
		public virtual float TargetParam1
		{
			get
			{
				return this.Instance.TargetParam1;
			}
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x0600F2A3 RID: 62115 RVA: 0x00236F88 File Offset: 0x00235188
		public virtual float TargetParam2
		{
			get
			{
				return this.Instance.TargetParam2;
			}
		}

		// Token: 0x04008527 RID: 34087
		private IProjectionMachinePhotoFilter Instance;
	}
}
